using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _绘制验证码Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string str = null;
            for (int i = 0; i < 5; i++)
            {
                int rNumber = random.Next(1, 10);
                str += rNumber;
            }

            Bitmap bitmap = new Bitmap(120, 40);
            Graphics graphic = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Brushes.LightGray);

            // 随机字体
            string[] fonts = { "微软雅黑", "宋体", "黑体", "隶书", "仿宋" };
            // 随机颜色
            Color[] colors = { Color.Red, Color.Yellow, Color.Black, Color.Bisque, Color.Aquamarine };
            for (int i = 0; i < str.Length; i++)
            {
                Color ranColor = colors[random.Next(0, 5)];
                Font ranFont = new Font(fonts[random.Next(0, 5)], 15, FontStyle.Bold);
                Point point = new Point(i * 15, 10);
                // 绘制1个字符
                graphic.DrawString(str[i].ToString(), ranFont, new SolidBrush(ranColor), point);
            }

            // 绘制线条遮挡验证码
            for (int i = 0; i < 20; i++)
            {
                Color[] cols = { Color.Blue, Color.Yellow, Color.Gray, Color.Bisque, Color.Aquamarine };
                Pen linePen = new Pen(new SolidBrush(cols[random.Next(0,5)]));
                Point linePoint1 = new Point(random.Next(0, bitmap.Width), random.Next(0, bitmap.Height));
                Point linePoint2 = new Point(random.Next(0, bitmap.Width), random.Next(0, bitmap.Height));
                graphic.DrawLine(linePen, linePoint1, linePoint2);
            }
            // 给图片添加像素颗粒
            for (int i = 0; i < 100; i++)
            {
                Color[] cols = { Color.Black, Color.Red, Color.Gray, Color.RoyalBlue, Color.Aquamarine };
                Point pexPoint = new Point(random.Next(0, bitmap.Width), random.Next(0, bitmap.Height));
                bitmap.SetPixel(pexPoint.X, pexPoint.Y, cols[random.Next(0, 5)]);
            }

            // 将图片镶嵌到PictureBox中
            pictureBox1.Image = bitmap;
        }
    }
}
