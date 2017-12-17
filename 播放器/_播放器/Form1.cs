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

namespace _播放器
{
    public partial class Form1 : Form
    {
        // 存储音频文件的全路径
        private List<string> audioPaths = new List<string>();
        private bool flag = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (audioList.Items.Count == 0)
            {
                MessageBox.Show("请先导入歌曲");
                return;
            }

            if (audioList.SelectedIndex == -1)
            {
                audioList.SelectedIndex = 0;
            }
            string fileURL = audioPaths[audioList.SelectedIndex];
            axWMP.URL = fileURL;
            axWMP.Ctlcontrols.play();

            btnPlayOrPause.Text = "暂停";
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.pause();
            btnPlayOrPause.Text = "播放";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 取消自动播放
            axWMP.settings.autoStart = false;
            // 设置歌曲URL
            //axWMP.URL = @"C:\Users\Ryan Shen\Music\赵方婧 - 尽头.mp3";
            // 默认选中
            btnPlay.Enabled = false;
            btnPlayOrPause.Enabled = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.stop();
            btnPlayOrPause.Text = "播放";
        }

        private void btnPlayOrPause_Click(object sender, EventArgs e)
        {

            if (audioList.Items.Count == 0)
            {
                MessageBox.Show("请先导入歌曲");
                return;
            }

            if (audioList.SelectedIndex == -1)
            {
                audioList.SelectedIndex = 0;
            }

            if (btnPlayOrPause.Text == "播放")
            {
                if (flag == true)
                {
                    string fileURL = audioPaths[audioList.SelectedIndex];
                    axWMP.URL = fileURL;
                }
                axWMP.Ctlcontrols.play();
                btnPlayOrPause.Text = "暂停";
            }
            else
            {
                axWMP.Ctlcontrols.pause();
                btnPlayOrPause.Text = "播放";
                flag = false;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "音频文件|*.wav|MP3文件|*.mp3|所有文件|*.*";
            open.Multiselect = true;
            open.ShowDialog();

            string[] paths = open.FileNames;
            for (int i = 0; i < paths.Length; i++)
            {
                if (audioPaths.Contains(paths[i]))
                {
                    continue;
                }
                btnPlay.Enabled = true;
                btnPlayOrPause.Enabled = true;
                audioPaths.Add(paths[i]);
                audioList.Items.Add(Path.GetFileName(paths[i]));
            }
        }

        private void audioList_DoubleClick(object sender, EventArgs e)
        {
            if (audioList.Items.Count == 0)
            {
                MessageBox.Show("请先选择音频文件");
                return;
            }

            if (audioList.SelectedIndex >= 0)
            {
                string selectedMusic = audioPaths[audioList.SelectedIndex];
                axWMP.URL = selectedMusic;
                axWMP.Ctlcontrols.play();
                btnPlayOrPause.Text = "暂停";
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int index = audioList.SelectedIndex;

            // 清除所有选中的索引
            audioList.SelectedIndices.Clear();

            index++;
            if (index > audioPaths.Count - 1)
            {
                index = 0;
            }
            string path = audioPaths[index];
            axWMP.URL = path;
            axWMP.Ctlcontrols.play();
            btnPlayOrPause.Text = "暂停";

            audioList.SelectedIndex = index;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int index = audioList.SelectedIndex;

            // 清除所有选中的索引
            audioList.SelectedIndices.Clear();

            index--;
            if (index < 0)
            {
                index = audioPaths.Count - 1;
            }
            string path = audioPaths[index];
            axWMP.URL = path;
            axWMP.Ctlcontrols.play();
            btnPlayOrPause.Text = "暂停";

            audioList.SelectedIndex = index;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int count = audioList.SelectedItems.Count;

            for (int i = 0; i < count; i++)
            {
                audioPaths.RemoveAt(audioList.SelectedIndex);
                audioList.Items.RemoveAt(audioList.SelectedIndex);
            }

            if (audioList.Items.Count <= 0)
            {
                // 默认选中
                btnPlay.Enabled = false;
                btnPlayOrPause.Enabled = false;
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = audioList.SelectedItems.Count;

            for (int i = 0; i < count; i++)
            {
                audioPaths.RemoveAt(audioList.SelectedIndex);
                audioList.Items.RemoveAt(audioList.SelectedIndex);
            }

            if (audioList.Items.Count <= 0)
            {
                // 默认选中
                btnPlay.Enabled = false;
                btnPlayOrPause.Enabled = false;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {

                double d1 = double.Parse(axWMP.currentMedia.duration.ToString());
                double d2 = double.Parse(axWMP.Ctlcontrols.currentPosition.ToString()) + 1;
                if ((int)d1 == (int)d2)
                {
                    btnNext_Click(btnNext, null);
                }
                lblInformation.Text = axWMP.currentMedia.duration.ToString() + "\r\n" + axWMP.currentMedia.durationString + "\r\n" + axWMP.Ctlcontrols.currentPosition.ToString() + "\r\n" + axWMP.Ctlcontrols.currentPositionString;
            }
        }
    }
}
