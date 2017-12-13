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

namespace _保存文件对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "请选择要保存的路径";
            saveFileDialog.InitialDirectory = @"C:\Users\Ryan Shen\Desktop";
            saveFileDialog.Filter = "文本文件|*.txt";

            saveFileDialog.ShowDialog();

            string path = saveFileDialog.FileName;

            try
            {
                using (FileStream writeStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                    writeStream.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("保存失败");
               // throw;
            }

        }
    }
}
