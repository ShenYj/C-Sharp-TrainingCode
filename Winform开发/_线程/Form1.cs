using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 取消跨线程的访问
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private Thread thread;

        private void button1_Click(object sender, EventArgs e)
        {
            thread = new Thread(Test);
            // 默认为前台线程， 设置为后台线程后，当程序关闭，后台线程也会自动关闭
            thread.IsBackground = true;
            thread.Start();
        }

        private void Test()
        {
            for (int i = 0; i < 99999; i++)
            {
                //Console.WriteLine(i);
                // .Net下默认不允许跨线程访问
                textBox1.Text = i.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 如果关闭程序时，进程仍然存在，可能会在回收资源时Crash，手动关闭掉此进程
            if (thread != null) thread.Abort();
            // 线程被Abort后，就无法再次Start
        }
    }
}
