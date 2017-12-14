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
                ShowMsg("授权成功");
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
            string content = tbSend.Text;
            byte[] buffer = Encoding.Default.GetBytes(content);

            try
            {
                int result = socketSend.Send(buffer, 0, buffer.Length, SocketFlags.None);
                if (result == buffer.Length)
                {
                    Console.WriteLine("发送成功");
                    tbSend.Clear();
                }
            }
            catch (Exception)
            {
            }
            
        }
    }
}
