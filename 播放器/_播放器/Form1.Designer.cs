namespace _播放器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlayOrPause = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.audioList = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(1, 0);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(397, 169);
            this.axWMP.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(6, 33);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(87, 33);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(87, 33);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlayOrPause
            // 
            this.btnPlayOrPause.Location = new System.Drawing.Point(6, 32);
            this.btnPlayOrPause.Name = "btnPlayOrPause";
            this.btnPlayOrPause.Size = new System.Drawing.Size(75, 23);
            this.btnPlayOrPause.TabIndex = 4;
            this.btnPlayOrPause.Text = "播放";
            this.btnPlayOrPause.UseVisualStyleBackColor = true;
            this.btnPlayOrPause.Click += new System.EventHandler(this.btnPlayOrPause_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Controls.Add(this.btnPause);
            this.groupBox1.Location = new System.Drawing.Point(16, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "老版本";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPlayOrPause);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Location = new System.Drawing.Point(215, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 56);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新版本";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 20);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 7;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // audioList
            // 
            this.audioList.ContextMenuStrip = this.contextMenuStrip1;
            this.audioList.FormattingEnabled = true;
            this.audioList.ItemHeight = 12;
            this.audioList.Location = new System.Drawing.Point(215, 248);
            this.audioList.Name = "audioList";
            this.audioList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.audioList.Size = new System.Drawing.Size(166, 148);
            this.audioList.TabIndex = 8;
            this.audioList.DoubleClick += new System.EventHandler(this.audioList_DoubleClick);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(6, 49);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "下一曲";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(6, 20);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = "上一曲";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnOpen);
            this.groupBox3.Location = new System.Drawing.Point(16, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(85, 87);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "添加/删除";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLast);
            this.groupBox4.Controls.Add(this.btnNext);
            this.groupBox4.Location = new System.Drawing.Point(103, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(106, 87);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "上一曲/下一曲";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 50);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(16, 342);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(193, 51);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "其他";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(16, 400);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(41, 12);
            this.lblInformation.TabIndex = 15;
            this.lblInformation.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 515);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.audioList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.axWMP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlayOrPause;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ListBox audioList;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Timer timer1;
    }
}

