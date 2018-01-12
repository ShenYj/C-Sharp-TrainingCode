using MyNotepad.ExtInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Plug-in");

            // 搜索文件夹下的所有dll文件
            string[] dlls = Directory.GetFiles(path,"*.dll");

            // 循环加载每个dll文件
            foreach (string dllPath in dlls)
            {
                // 动态加载当前dll文件
                Assembly assembly = Assembly.LoadFile(dllPath);
                // 获取当前dll中所有的public类型
                Type[] types = assembly.GetExportedTypes();
                // 循环判断types中的所有类型， 只要实现了IEditor接口的类型

                Type typeIEditor = typeof(IEDitor);
                for (int i = 0; i < types.Length; i++)
                {
                    if (typeIEditor.IsAssignableFrom(types[i]) && !types[i].IsAbstract)
                    {
                        // 那么接下来就需要创建该类型的对象，在接口的开发文档中注明，
                        // 需要开发插件的人员编写一个实现了IEditor接口的类，并且该类必须有一个无参数的构造函数
                        IEDitor editor = (IEDitor)Activator.CreateInstance(types[i]);

                        // 向菜单栏中动态添加一个菜单项
                        ToolStripItem toolItem = format.DropDownItems.Add(editor.InterfaceName);
                        // 为刚刚增加的菜单项注册一个单击事件
                        toolItem.Click += ToolItem_Click;

                    }
                }

            }
        }

        private void ToolItem_Click(object sender, EventArgs e)
        {
            // 运行该插件
            MessageBox.Show("运行插件");
        }
    }
}
