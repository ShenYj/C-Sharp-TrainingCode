namespace _Socket客户端
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
            this.tbIP = new System.Windows.Forms.TextBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbReceived = new System.Windows.Forms.TextBox();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbSend = new System.Windows.Forms.Label();
            this.lbReceived = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(102, 27);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(93, 21);
            this.tbIP.TabIndex = 0;
            this.tbIP.Text = "192.168.11.230";
            this.tbIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(13, 30);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(89, 12);
            this.lbIP.TabIndex = 1;
            this.lbIP.Text = "服务端IP地址：";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(202, 30);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(47, 12);
            this.lbPort.TabIndex = 2;
            this.lbPort.Text = "端口号:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(255, 27);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(44, 21);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "50000";
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(322, 25);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbReceived
            // 
            this.tbReceived.Location = new System.Drawing.Point(12, 74);
            this.tbReceived.Multiline = true;
            this.tbReceived.Name = "tbReceived";
            this.tbReceived.Size = new System.Drawing.Size(384, 74);
            this.tbReceived.TabIndex = 5;
            // 
            // tbSend
            // 
            this.tbSend.Location = new System.Drawing.Point(12, 177);
            this.tbSend.Multiline = true;
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(381, 44);
            this.tbSend.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(322, 227);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbSend
            // 
            this.lbSend.AutoSize = true;
            this.lbSend.Location = new System.Drawing.Point(12, 162);
            this.lbSend.Name = "lbSend";
            this.lbSend.Size = new System.Drawing.Size(71, 12);
            this.lbSend.TabIndex = 8;
            this.lbSend.Text = "发送的消息:";
            // 
            // lbReceived
            // 
            this.lbReceived.AutoSize = true;
            this.lbReceived.Location = new System.Drawing.Point(10, 59);
            this.lbReceived.Name = "lbReceived";
            this.lbReceived.Size = new System.Drawing.Size(71, 12);
            this.lbReceived.TabIndex = 9;
            this.lbReceived.Text = "收到的消息:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 262);
            this.Controls.Add(this.lbReceived);
            this.Controls.Add(this.lbSend);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.tbReceived);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.tbIP);
            this.MaximumSize = new System.Drawing.Size(431, 300);
            this.MinimumSize = new System.Drawing.Size(431, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbReceived;
        private System.Windows.Forms.TextBox tbSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbSend;
        private System.Windows.Forms.Label lbReceived;
    }
}

