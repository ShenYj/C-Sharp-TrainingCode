using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _进程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Process currentProcess = Process.GetCurrentProcess();
            //Process[] processes = Process.GetProcesses();

            // 打开指定进程
            //Process.Start("notepad");


            // 打开指定文件
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Users\Ryan Shen\Desktop\123.txt");
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
