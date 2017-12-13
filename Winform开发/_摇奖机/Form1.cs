using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _摇奖机
{
    public partial class Form1 : Form
    {

        private bool flag = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (flag == false)
            {
                flag = true;
                button1.Text = "暂停游戏";
                Thread thread = new Thread(PlayGame);
                thread.IsBackground = true;
                thread.Start();
            }
            else
            {
                flag = false;
                button1.Text = "开始游戏";
            }
        }

        private void PlayGame()
        {
            Random random = new Random();

            while (flag)
            {
                label1.Text = random.Next(0, 10).ToString();
                label2.Text = random.Next(0, 10).ToString();
                label3.Text = random.Next(0, 10).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
