using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _记事本插件练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 保存ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "文本|*.txt";
            DialogResult result = save.ShowDialog();

            if (System.Windows.Forms.DialogResult.OK == result)
            {
                string path = save.FileName;
                //File.WriteAllText(path, textBox1.Text);

                try
                {
                    using (FileStream writeFS = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        Byte[] bytes = Encoding.Default.GetBytes(textBox1.Text);
                        writeFS.Write(bytes, 0, bytes.Length);
                    }

                    MessageBox.Show("保存成功");
                }
                catch (Exception exp)
                {
                    MessageBox.Show("保存失败" + exp.Message);
                    throw;
                }
            }
        }

        private void 打开ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "文本|*.txt";
            open.ShowDialog();

            string path = open.FileName;
            if (path.Length == 0) return;

            Byte[] buffer = new Byte[1024 * 1024 * 2];
            int offset = 0;
            using (FileStream readFS = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                while (true)
                {
                    int len = readFS.Read(buffer, 0, buffer.Length);
                    if (len == 0) break;
                    offset += len;

                    string content = Encoding.Default.GetString(buffer, 0, len);
                    textBox1.AppendText(content);
                }
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            DialogResult result = font.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Font = font.Font;
            }  
        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            DialogResult result = color.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.ForeColor = color.Color;
            }
        }
    }
}
