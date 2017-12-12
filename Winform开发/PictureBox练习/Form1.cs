using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PictureBox练习
{
    public partial class Form1 : Form
    {
        // 获得指定文件夹所有文件的全路径
        private string[] Images = Directory.GetFiles(@"D:\QQ背景墙图片");
        private int Index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 上一张
            Index--;
            if(Index <= 0)
            {
                Index = 0;
                button2.Enabled = false;
            }
            button1.Enabled = true;
            pictureBox1.Image = Image.FromFile(Images[Index]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 下一张
            Index++;
            if (Index >= Images.Length)
            {
                Index = Images.Length - 1;
                button1.Enabled = false;
            }
            button2.Enabled = true;
            pictureBox1.Image = Image.FromFile(Images[Index]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile(@"D:\QQ背景墙图片\001.jpg");
            pictureBox1.Image = Image.FromFile(Images[Index]);
        }
    }
}
