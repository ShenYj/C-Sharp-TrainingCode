using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _窗体传值
{
    public partial class Form2 : Form
    {
        public delegate void DHandler(string txt);
        public DHandler GetHandle;

        private static Form2 _instanceType;

        public static Form2 Shared()
        {
            if (_instanceType == null)
            {
                _instanceType = new Form2();
            }
            return _instanceType;
        }

        private Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GetHandle(textBox1.Text);
            this.Close();
        }
    }
}
