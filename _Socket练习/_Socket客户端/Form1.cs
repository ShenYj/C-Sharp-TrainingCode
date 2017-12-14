using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Socket客户端
{
    public partial class Form1 : Form
    {

        private Thread thread;
        private Socket socketSend;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // 创建负责通信的Socket
                socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(tbIP.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(tbPort.Text));
                // 获得要连接的远程服务器应用ip和端口号
                socketSend.Connect(point);
                ShowMsg("连接成功");

                // 开启新线程接收服务端发送的消息
                thread = new Thread(ReceivedMessage);
                thread.IsBackground = true;
                thread.Start();
            }
            catch 
            {

            }
        }

        private void ShowMsg(string msg)
        {
            tbReceived.AppendText(msg + "\r\n");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Default.GetBytes(tbSend.Text);
            List<byte> bufferList = new List<byte>();
            bufferList.Add(0);
            bufferList.AddRange(buffer);
            byte[] bytes = bufferList.ToArray();

            try
            {
                int result = socketSend.Send(bytes, 0, bytes.Length, SocketFlags.None);
                if (result == bytes.Length)
                {
                    Console.WriteLine("发送成功");
                    tbSend.Clear();
                }
            }
            catch (Exception)
            {
            }
            
        }
        /// <summary>
        /// 客户端接收服务端的消息
        /// </summary>
        /// <param name="obj"></param>
        private void ReceivedMessage()
        {
            while (true)
            {
                try
                {
                    // 客户端连接成功后， 服务器接收客户端发来的消息
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    int length = socketSend.Receive(buffer);
                    if (length == 0) break;
                    // 将接收到的数据转成字符串

                    if (buffer[0] == 0)
                    {
                        // 文字信息
                        string content = Encoding.Default.GetString(buffer, 1, length - 1);
                        ShowMsg(socketSend.RemoteEndPoint + ":" + content);
                    }
                    else if (buffer[0] == 1)
                    {
                        // txt文本文件
                        SaveFileDialog savefileDialog = new SaveFileDialog();
                        savefileDialog.Title = "请选择要保存的路径";
                        savefileDialog.Filter = "文件|*.txt";
                        savefileDialog.ShowDialog(this);

                        string path = savefileDialog.FileName;
                        if (path != null)
                        {
                            using (FileStream writeFileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                            {
                                writeFileStream.Write(buffer, 1, buffer.Length - 1);
                                MessageBox.Show("保存成功");
                            }
                        }
                        {

                        }
                    }
                    else if (buffer[0] == 2)
                    {
                        Point current = this.Location;
                        // 震动
                        for (int i = 0; i < 500; i++)
                        {
                            this.Location = new Point(current.X + 20, current.Y + 20);
                            this.Location = current;
                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
        }
    }
}
