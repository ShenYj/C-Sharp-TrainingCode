using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace _音乐播放器
{
    public partial class Form1 : Form
    {

        private List<string> FullFilePaths = new List<string>();    // 全路径集合
        private List<string> FileNames = new List<string>();        // 文件名集合
        private SoundPlayer player = new SoundPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "音频文件|*.wav";
            open.ShowDialog();

            string[] paths = open.FileNames;
            try
            {
                for (int i = 0; i < paths.Length; i++)
                {
                    if ( !listBox1.Items.Contains(paths[i]) )
                    {
                        FullFilePaths.Add(paths[i]);
                        string fileName = Path.GetFileName(paths[i]);
                        FileNames.Add(fileName);

                        listBox1.Items.Add(fileName);
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("打开文件失败");
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string fileFullName = FullFilePaths[listBox1.SelectedIndex];
            this.player.SoundLocation = fileFullName;
            this.player.Play();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index--;
            if (index < 0)
            {
                index = FullFilePaths.Count - 1;
            }
            listBox1.SelectedIndex = index;
            player.SoundLocation = FullFilePaths[index];
            player.Play();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index++;
            if (index >= FullFilePaths.Count)
            {
                index = 0;
            }
            listBox1.SelectedIndex = index;
            player.SoundLocation = FullFilePaths[index];
            player.Play();
        }
    }
}
