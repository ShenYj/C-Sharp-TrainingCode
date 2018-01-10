using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _事件1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private int count = 0;

        // 声明一个事件(在声明委托变量前面加一个event，委托变量就变成了事件)
        // 事件不能用=复制，只能用+= 或者 -= 赋值
        
        public event Action TripleClick;

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count >= 3)
            {
                if (TripleClick != null)
                {
                    TripleClick();
                }
                count = 0;
            }
        }
    }
}
