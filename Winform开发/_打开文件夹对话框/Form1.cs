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

namespace _打开文件夹对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 点击弹出对话框
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "请选择您要打开的文件";
            fileDialog.Multiselect = true;
            //fileDialog.InitialDirectory = Dictionary(@"C:\Users\Ryan Shen\Desktop");
            fileDialog.Filter = "文本文件|*.txt|媒体文件|*.wmv|图片文件|.jpg";
            fileDialog.ShowDialog();

            // 获取文件路径
            string[] fileNames = fileDialog.FileNames;

            for (int i = 0; i < fileNames.Length; i++)
            {
                using (FileStream readStream = new FileStream(fileNames[i], FileMode.OpenOrCreate, FileAccess.Read))
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int length = readStream.Read(buffer, 0, buffer.Length);
                    textBox1.Text = Encoding.Default.GetString(buffer, 0, length);
                }
            }


            try
            {
                for (int i = 0; i < fileNames.Length; i++)
                {
                    using (FileStream readStream = new FileStream(fileNames[i], FileMode.OpenOrCreate, FileAccess.Read))
                    {
                        byte[] buffer = new byte[1024 * 1024];
                        int length = readStream.Read(buffer, 0, buffer.Length);
                        textBox1.Text = Encoding.Default.GetString(buffer, 0, length);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("获取文件路径失败");
                throw;
            }

            
        }
    }
}
