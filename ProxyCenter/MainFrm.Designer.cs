namespace ProxyCenter
{
    partial class MainFrm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.RtbLog = new System.Windows.Forms.RichTextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.Cb2 = new System.Windows.Forms.CheckBox();
            this.Cb1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LvIp = new System.Windows.Forms.ListView();
            this.c1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnExport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnExport);
            this.groupBox1.Controls.Add(this.BtnStop);
            this.groupBox1.Controls.Add(this.BtnPause);
            this.groupBox1.Controls.Add(this.RtbLog);
            this.groupBox1.Controls.Add(this.BtnStart);
            this.groupBox1.Controls.Add(this.Cb2);
            this.groupBox1.Controls.Add(this.Cb1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 561);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(251, 84);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(78, 23);
            this.BtnStop.TabIndex = 4;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            // 
            // BtnPause
            // 
            this.BtnPause.Location = new System.Drawing.Point(136, 84);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(78, 23);
            this.BtnPause.TabIndex = 3;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = true;
            // 
            // RtbLog
            // 
            this.RtbLog.BackColor = System.Drawing.Color.Black;
            this.RtbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtbLog.ForeColor = System.Drawing.Color.Yellow;
            this.RtbLog.Location = new System.Drawing.Point(21, 137);
            this.RtbLog.Name = "RtbLog";
            this.RtbLog.ReadOnly = true;
            this.RtbLog.Size = new System.Drawing.Size(308, 364);
            this.RtbLog.TabIndex = 2;
            this.RtbLog.Text = "";
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(21, 84);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(78, 23);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Cb2
            // 
            this.Cb2.AutoSize = true;
            this.Cb2.Checked = true;
            this.Cb2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb2.Location = new System.Drawing.Point(202, 35);
            this.Cb2.Name = "Cb2";
            this.Cb2.Size = new System.Drawing.Size(84, 16);
            this.Cb2.TabIndex = 0;
            this.Cb2.Tag = "http://cn-proxy.com/";
            this.Cb2.Text = "中国ip地址";
            this.Cb2.UseVisualStyleBackColor = true;
            // 
            // Cb1
            // 
            this.Cb1.AutoSize = true;
            this.Cb1.Checked = true;
            this.Cb1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb1.Location = new System.Drawing.Point(21, 35);
            this.Cb1.Name = "Cb1";
            this.Cb1.Size = new System.Drawing.Size(108, 16);
            this.Cb1.TabIndex = 0;
            this.Cb1.Tag = "http://www.xici.net.co/";
            this.Cb1.Text = "西刺免费代理IP";
            this.Cb1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LvIp);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(359, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 561);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // LvIp
            // 
            this.LvIp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4});
            this.LvIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvIp.Location = new System.Drawing.Point(3, 17);
            this.LvIp.Name = "LvIp";
            this.LvIp.Size = new System.Drawing.Size(504, 541);
            this.LvIp.TabIndex = 0;
            this.LvIp.UseCompatibleStateImageBehavior = false;
            this.LvIp.View = System.Windows.Forms.View.Details;
            // 
            // c1
            // 
            this.c1.Text = "Ip";
            this.c1.Width = 150;
            // 
            // c2
            // 
            this.c2.Text = "Port";
            this.c2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c3
            // 
            this.c3.Text = "Address";
            this.c3.Width = 200;
            // 
            // c4
            // 
            this.c4.Text = "Status";
            this.c4.Width = 80;
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(21, 507);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(308, 42);
            this.BtnExport.TabIndex = 5;
            this.BtnExport.Text = "Export Enable Ips";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proxy Center";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Cb2;
        private System.Windows.Forms.CheckBox Cb1;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.RichTextBox RtbLog;
        private System.Windows.Forms.ListView LvIp;
        private System.Windows.Forms.ColumnHeader c1;
        private System.Windows.Forms.ColumnHeader c2;
        private System.Windows.Forms.ColumnHeader c3;
        private System.Windows.Forms.ColumnHeader c4;
        private System.Windows.Forms.Button BtnExport;
    }
}

