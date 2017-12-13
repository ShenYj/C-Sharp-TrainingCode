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

namespace _记事本应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> FullFilePathsList = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void 隐藏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            // 打开对话框
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "选择要打开的目录";
            openDialog.ShowDialog();
            string path = Path.GetFileName(openDialog.FileName);
            try
            {
                if (!listBox1.Items.Contains(path))
                {
                    listBox1.Items.Add(path);
                    FullFilePathsList.Add(openDialog.FileName);
                    try
                    {
                        using (FileStream readFileStream = new FileStream(openDialog.FileName, FileMode.OpenOrCreate, FileAccess.Read))
                        {
                            int length = 0;
                            while (true)
                            {
                                byte[] buffer = new byte[1024 * 1024];
                                length = readFileStream.Read(buffer, 0, buffer.Length);
                                if (length == 0) break;
                                string content = Encoding.Default.GetString(buffer, 0, length);
                                textBox1.Text += content;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("打开文件失败" + exp.ToString());
            }

        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "请选择要保存的路径";
            saveDialog.Filter = "文本文件|*.txt";

            saveDialog.ShowDialog();

            string savePath = saveDialog.FileName;

            try
            {
                using (FileStream writeStream = new FileStream(savePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                    writeStream.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("保存失败" + exp.ToString());
            }

        }

        private void 自动换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( 自动换行ToolStripMenuItem.Text == "√自动换行" )
            {
                textBox1.WordWrap = false;
                自动换行ToolStripMenuItem.Text = "自动换行";
            }
            else
            {
                textBox1.WordWrap = true;
                自动换行ToolStripMenuItem.Text = "√自动换行";
            }
        }

        private void ToolStripMenuItemFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDiaLog = new FontDialog();
            fontDiaLog.ShowDialog();
            textBox1.Font = fontDiaLog.Font;
        }

        private void ToolStripMenuItemColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            textBox1.ForeColor = colorDialog.Color;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string fileFullPath = FullFilePathsList[index];
            textBox1.Clear();
            try
            {
                using (FileStream readStream = new FileStream(fileFullPath, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    int length = 0;
                    byte[] buffer = new byte[1024 * 1024];
                    while (true)
                    {
                        length = readStream.Read(buffer, 0, buffer.Length);
                        if (length == 0) break;
                        string content = Encoding.Default.GetString(buffer);
                        textBox1.Text += content;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("打开失败" + exp.ToString());
            }

        }
    }
}
