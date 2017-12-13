namespace 练习
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.bStone = new System.Windows.Forms.Button();
            this.bScissors = new System.Windows.Forms.Button();
            this.bCloth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "玩家出：";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(75, 31);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(11, 12);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "电脑出：";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(221, 32);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(11, 12);
            this.lblComputer.TabIndex = 3;
            this.lblComputer.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "获胜者：";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(131, 69);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(11, 12);
            this.lblWinner.TabIndex = 5;
            this.lblWinner.Text = "-";
            // 
            // bStone
            // 
            this.bStone.Location = new System.Drawing.Point(35, 106);
            this.bStone.Name = "bStone";
            this.bStone.Size = new System.Drawing.Size(75, 23);
            this.bStone.TabIndex = 6;
            this.bStone.Text = "石头";
            this.bStone.UseVisualStyleBackColor = true;
            this.bStone.Click += new System.EventHandler(this.button1_Click);
            // 
            // bScissors
            // 
            this.bScissors.Location = new System.Drawing.Point(116, 106);
            this.bScissors.Name = "bScissors";
            this.bScissors.Size = new System.Drawing.Size(75, 23);
            this.bScissors.TabIndex = 7;
            this.bScissors.Text = "剪刀";
            this.bScissors.UseVisualStyleBackColor = true;
            this.bScissors.Click += new System.EventHandler(this.bScissors_Click);
            // 
            // bCloth
            // 
            this.bCloth.Location = new System.Drawing.Point(197, 106);
            this.bCloth.Name = "bCloth";
            this.bCloth.Size = new System.Drawing.Size(75, 23);
            this.bCloth.TabIndex = 8;
            this.bCloth.Text = "布";
            this.bCloth.UseVisualStyleBackColor = true;
            this.bCloth.Click += new System.EventHandler(this.bCloth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 162);
            this.Controls.Add(this.bCloth);
            this.Controls.Add(this.bScissors);
            this.Controls.Add(this.bStone);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button bStone;
        private System.Windows.Forms.Button bScissors;
        private System.Windows.Forms.Button bCloth;
    }
}

