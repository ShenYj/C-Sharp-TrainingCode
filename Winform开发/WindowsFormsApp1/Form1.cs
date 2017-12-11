using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你哟~~~");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            int x = this.ClientSize.Width - button2.Width;
            int y = this.ClientSize.Height - button2.Height - label1.Height;

            Random random = new Random();
            int newX = random.Next(0, x + 1);
            int newY = random.Next(0, y + 1);

            button2.Location = new Point(newX, newY);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }
    }
}
