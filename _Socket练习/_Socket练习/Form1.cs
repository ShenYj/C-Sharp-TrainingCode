using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Socket练习
{

    /// <summary>
    /// 服务端Socket
    /// </summary>
    public partial class Form1 : Form
    {
        // 线程
        private Thread thread;
        // 负责通信的Socket
        private Dictionary<string, Socket> socketDicts = new Dictionary<string, Socket>();
        private Socket socketWatch;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            try
            {
                // 在服务端创建一个负责监听IP地址跟端口号的Socket
                socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Any;//IPAddress.Parse(tbIp.Text);
                                             // 创建端口号对象 192.168.0.112
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(tbPort.Text));
                // 监听
                socketWatch.Bind(point);
                ShowMsg("监听成功");
                socketWatch.Listen(10);

                thread = new Thread(WaitToConnectSocket);
                thread.IsBackground = true;
                thread.Start(socketWatch);
            }
            catch
            {
            }
        }

        private void WaitToConnectSocket(Object obj)
        {
            if (obj is Socket)
            {
                try
                {
                    Socket socketWatch = obj as Socket;
                    while (true)
                    {
                        // 等待客户端的连接， 并创建一个负责通信的Socket
                        Socket socketSend = socketWatch.Accept();

                        // 缓存Socket
                        this.socketDicts.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                        // 添加到ComboBox中
                        comboBox1.Items.Add(socketSend.RemoteEndPoint.ToString());

                        ShowMsg(socketSend.RemoteEndPoint + ":连接成功");
                        // 创建一个线程去接收数据
                        Thread receivedMsgThread = new Thread(ReceivedMessage);
                        receivedMsgThread.IsBackground = true;
                        receivedMsgThread.Start(socketSend);
                    }
                }
                catch 
                {
                }
            }
        }
        /// <summary>
        /// 服务端不断的接收客户端发送来的数据
        /// </summary>
        /// <param name="obj"></param>
        private void ReceivedMessage(Object obj)
        {
            Socket socketSend = obj as Socket;
            while (true)
            {
                try
                {
                    // 客户端连接成功后， 服务器接收客户端发来的消息
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int length = socketSend.Receive(buffer);
                    if (length == 0) break;
                    // 将接收到的数据转成字符串
                    string content = Encoding.Default.GetString(buffer, 0, length);
                    ShowMsg(socketSend.RemoteEndPoint + ":" + content);
                }
                catch 
                {
                    
                }
            }
        }

        private void ShowMsg(string msg)
        {
            textBox1.AppendText(msg + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            socketWatch.Close();
            thread.Abort();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Default.GetBytes(tbSend.Text);
            if (buffer.Length > 0)
            {
                try
                {
                    Socket socket = this.socketDicts[comboBox1.SelectedItem.ToString()];
                    int length = socket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                    if (length == buffer.Length)
                    {
                        tbSend.Clear();
                        Console.WriteLine("发送成功");
                    }
                }
                catch (Exception)
                {
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (socketWatch != null)
            {
                socketWatch.Close();
                socketWatch.Dispose();
            }
            
        }
    }
}
