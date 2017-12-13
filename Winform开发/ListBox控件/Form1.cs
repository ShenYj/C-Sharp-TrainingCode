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
using System.Media;


namespace ListBox控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> fileFullPathList = new List<string>();
        private SoundPlayer player = new SoundPlayer();

        private void Form1_Load(object sender, EventArgs e)
        {
            //string directory = @"C:\Users\Ryan Shen\Desktop\亲情奉献-全套精品.Net基础班视频教程-video\亲情奉献全套精品.Net基础视频教程之1-学前入门\（第一天）\video";
            //string[] docs = Directory.GetFiles(directory, "*.avi");
            string[] docs = Directory.GetFiles(@"D:\05-音乐\2015-8-11", "*.mp3");
            for (int i = 0; i < docs.Length; i++)
            {
                string fileName = Path.GetFileName(docs[i]);
                if (!lb1.Items.Contains(fileName))
                {
                    lb1.Items.Add(fileName);
                    fileFullPathList.Add(docs[i]);
                }
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string fileFullPath = fileFullPathList[lb1.SelectedIndex];
            player.SoundLocation = fileFullPath;
            player.Play();
        }
    }
}
