using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _单例
{
    public partial class Form2 : Form
    {
        // 创建一个单例
        public static Form2 _formSingle = null;
        public static Form2 Shared()
        {
            if (_formSingle == null)
            {
                _formSingle = new Form2();
            }
            return _formSingle;
        }

        private Form2()
        {
            InitializeComponent();
        }
    }
}
