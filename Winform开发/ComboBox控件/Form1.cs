using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0 && !comboBox1.Items.Contains(textBox1.Text.Length))
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                MessageBox.Show("添加成功");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            for (int i = currentYear; i >= 1949; i--)
            {
                cboYear.Items.Add(i + "年");
            }
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMonth.Items.Count > 0) return;
            for (int i = 1; i <= 12; i++)
            {
                cboMonth.Items.Add(i + "月");
            }
        }

        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDays.Items.Clear();
            cboDays.ResetText();
            int currentMonthDays = 0;
            string currentYear = cboYear.SelectedItem.ToString().Split(new char[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0];
            string currentMonth = cboMonth.SelectedItem.ToString().Split(new char[] { '月'},  StringSplitOptions.RemoveEmptyEntries)[0];
            int year = int.Parse(currentYear);
            int month = int.Parse(currentMonth);

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    currentMonthDays = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    currentMonthDays = 30;
                    break;
                default:
                    if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                    {
                        currentMonthDays = 29;
                    }
                    else
                    {
                        currentMonthDays = 28;
                    }
                    break;
            }

            for (int i = 1; i <= currentMonthDays; i++)
            {
                cboDays.Items.Add(i + "日");
            }
        }
    }
}
