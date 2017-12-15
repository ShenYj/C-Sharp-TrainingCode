using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void DrawDemo()
        {
            // 创建GDI对象
            Graphics graphic = this.CreateGraphics();
            // 创建画笔对象
            Pen pen = new Pen(Brushes.Red);
            // 创建两个点
            Point p1 = new Point(30, 50);
            Point p2 = new Point(250, 250);
            // 绘制
            graphic.DrawLine(pen, p1, p2);
        }

        // 绘制矩形
        private void DrawDemo1()
        {
            Graphics graphic = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Red);
            Rectangle rec = new Rectangle(new Point(20, 20), new Size(200, 200));
            graphic.DrawRectangle(pen, rec);
        }

        // 绘制扇形
        private void DrwaDemo2()
        {
            Graphics graphic = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Red);
            Rectangle rec = new Rectangle(new Point(20, 20), new Size(200, 200));
            graphic.DrawPie(pen, rec, 30,50);
        }

        // 绘制文本
        private void DrwaDemo3()
        {
            Graphics graphic = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Red);
            graphic.DrawString("sbsd", new Font("宋体", 20, FontStyle.Bold), Brushes.Red, new Point(20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DrawDemo();
            DrwaDemo3();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //DrawDemo();
        }
    }
}
