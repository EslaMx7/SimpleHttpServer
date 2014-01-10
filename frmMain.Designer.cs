namespace SimpleServers
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpHttp = new System.Windows.Forms.GroupBox();
            this.txtHttpLog = new System.Windows.Forms.TextBox();
            this.btnStartHttpServ = new System.Windows.Forms.Button();
            this.txtHttpPort = new System.Windows.Forms.NumericUpDown();
            this.lblHPort = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lnkSite = new System.Windows.Forms.LinkLabel();
            this.gpHttp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHttpPort)).BeginInit();
            this.SuspendLayout();
            // 
            // gpHttp
            // 
            this.gpHttp.Controls.Add(this.checkBox1);
            this.gpHttp.Controls.Add(this.txtHttpLog);
            this.gpHttp.Controls.Add(this.btnStartHttpServ);
            this.gpHttp.Controls.Add(this.txtHttpPort);
            this.gpHttp.Controls.Add(this.lblHPort);
            this.gpHttp.Location = new System.Drawing.Point(19, 30);
            this.gpHttp.Name = "gpHttp";
            this.gpHttp.Size = new System.Drawing.Size(393, 386);
            this.gpHttp.TabIndex = 0;
            this.gpHttp.TabStop = false;
            this.gpHttp.Text = "HTTP Server";
            // 
            // txtHttpLog
            // 
            this.txtHttpLog.Location = new System.Drawing.Point(7, 111);
            this.txtHttpLog.Multiline = true;
            this.txtHttpLog.Name = "txtHttpLog";
            this.txtHttpLog.ReadOnly = true;
            this.txtHttpLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHttpLog.Size = new System.Drawing.Size(374, 269);
            this.txtHttpLog.TabIndex = 3;
            // 
            // btnStartHttpServ
            // 
            this.btnStartHttpServ.Location = new System.Drawing.Point(278, 30);
            this.btnStartHttpServ.Name = "btnStartHttpServ";
            this.btnStartHttpServ.Size = new System.Drawing.Size(103, 23);
            this.btnStartHttpServ.TabIndex = 2;
            this.btnStartHttpServ.Text = "Start Server";
            this.btnStartHttpServ.UseVisualStyleBackColor = true;
            this.btnStartHttpServ.Click += new System.EventHandler(this.btnStartHttpServ_Click);
            // 
            // txtHttpPort
            // 
            this.txtHttpPort.Location = new System.Drawing.Point(92, 33);
            this.txtHttpPort.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.txtHttpPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHttpPort.Name = "txtHttpPort";
            this.txtHttpPort.Size = new System.Drawing.Size(64, 20);
            this.txtHttpPort.TabIndex = 1;
            this.txtHttpPort.Value = new decimal(new int[] {
            81,
            0,
            0,
            0});
            // 
            // lblHPort
            // 
            this.lblHPort.AutoSize = true;
            this.lblHPort.Location = new System.Drawing.Point(7, 35);
            this.lblHPort.Name = "lblHPort";
            this.lblHPort.Size = new System.Drawing.Size(79, 13);
            this.lblHPort.TabIndex = 0;
            this.lblHPort.Text = "Listening Port :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(179, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Enable PHP";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lnkSite
            // 
            this.lnkSite.AutoSize = true;
            this.lnkSite.Location = new System.Drawing.Point(336, 419);
            this.lnkSite.Name = "lnkSite";
            this.lnkSite.Size = new System.Drawing.Size(76, 13);
            this.lnkSite.TabIndex = 1;
            this.lnkSite.TabStop = true;
            this.lnkSite.Text = "© eslamx.com";
            this.lnkSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSite_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 436);
            this.Controls.Add(this.lnkSite);
            this.Controls.Add(this.gpHttp);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Servers v1 | by : Eslam Hamouda";
            this.gpHttp.ResumeLayout(false);
            this.gpHttp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHttpPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpHttp;
        private System.Windows.Forms.Button btnStartHttpServ;
        private System.Windows.Forms.NumericUpDown txtHttpPort;
        private System.Windows.Forms.Label lblHPort;
        private System.Windows.Forms.TextBox txtHttpLog;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel lnkSite;
    }
}

