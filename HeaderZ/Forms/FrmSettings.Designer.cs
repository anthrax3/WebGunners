namespace Web_Gunners
{
    partial class FrmSettings
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
            this.panelmain = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmPort = new System.Windows.Forms.NumericUpDown();
            this.txbxHost = new System.Windows.Forms.TextBox();
            this.chkbxProxy = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkbx_Authorization = new System.Windows.Forms.CheckBox();
            this.lnklblLoadAuth = new System.Windows.Forms.LinkLabel();
            this.rtxbxAuth = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lnklblLoadUserAgent = new System.Windows.Forms.LinkLabel();
            this.Rtxbxuseragent = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtxbxCookie = new System.Windows.Forms.RichTextBox();
            this.checkBoxCookie = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.linkLabelClose = new System.Windows.Forms.LinkLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_in_Tab_Page = new System.Windows.Forms.RadioButton();
            this.checkBox_Isolated_window = new System.Windows.Forms.RadioButton();
            this.tpg_Requests = new System.Windows.Forms.TabPage();
            this.tpgAppearance = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.ColorPanel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.checkBox_UserAgent = new System.Windows.Forms.CheckBox();
            this.panelmain.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPort)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tpg_Requests.SuspendLayout();
            this.tpgAppearance.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmain
            // 
            this.panelmain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelmain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.panelmain.Controls.Add(this.panel5);
            this.panelmain.Controls.Add(this.panel3);
            this.panelmain.Controls.Add(this.panel2);
            this.panelmain.Controls.Add(this.panel1);
            this.panelmain.Location = new System.Drawing.Point(0, 0);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(444, 359);
            this.panelmain.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.nmPort);
            this.panel5.Controls.Add(this.txbxHost);
            this.panel5.Controls.Add(this.chkbxProxy);
            this.panel5.Location = new System.Drawing.Point(12, 291);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(429, 65);
            this.panel5.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Host";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port";
            // 
            // nmPort
            // 
            this.nmPort.Enabled = false;
            this.nmPort.Location = new System.Drawing.Point(351, 30);
            this.nmPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nmPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmPort.Name = "nmPort";
            this.nmPort.Size = new System.Drawing.Size(49, 20);
            this.nmPort.TabIndex = 2;
            this.nmPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nmPort.ValueChanged += new System.EventHandler(this.nmPort_ValueChanged);
            // 
            // txbxHost
            // 
            this.txbxHost.Enabled = false;
            this.txbxHost.Location = new System.Drawing.Point(58, 30);
            this.txbxHost.Name = "txbxHost";
            this.txbxHost.Size = new System.Drawing.Size(246, 20);
            this.txbxHost.TabIndex = 1;
            this.txbxHost.TextChanged += new System.EventHandler(this.txbxHost_TextChanged);
            // 
            // chkbxProxy
            // 
            this.chkbxProxy.AutoSize = true;
            this.chkbxProxy.Location = new System.Drawing.Point(156, 3);
            this.chkbxProxy.Name = "chkbxProxy";
            this.chkbxProxy.Size = new System.Drawing.Size(71, 17);
            this.chkbxProxy.TabIndex = 0;
            this.chkbxProxy.Text = "UseProxy";
            this.chkbxProxy.UseVisualStyleBackColor = true;
            this.chkbxProxy.CheckedChanged += new System.EventHandler(this.chkbxProxy_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkbx_Authorization);
            this.panel3.Controls.Add(this.lnklblLoadAuth);
            this.panel3.Controls.Add(this.rtxbxAuth);
            this.panel3.Location = new System.Drawing.Point(12, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 83);
            this.panel3.TabIndex = 9;
            // 
            // chkbx_Authorization
            // 
            this.chkbx_Authorization.AutoSize = true;
            this.chkbx_Authorization.Location = new System.Drawing.Point(156, 3);
            this.chkbx_Authorization.Name = "chkbx_Authorization";
            this.chkbx_Authorization.Size = new System.Drawing.Size(109, 17);
            this.chkbx_Authorization.TabIndex = 6;
            this.chkbx_Authorization.Text = "Use Authorization";
            this.chkbx_Authorization.UseVisualStyleBackColor = true;
            this.chkbx_Authorization.CheckedChanged += new System.EventHandler(this.chkbx_Authorization_CheckedChanged);
            // 
            // lnklblLoadAuth
            // 
            this.lnklblLoadAuth.AutoSize = true;
            this.lnklblLoadAuth.Enabled = false;
            this.lnklblLoadAuth.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblLoadAuth.Location = new System.Drawing.Point(416, 64);
            this.lnklblLoadAuth.Name = "lnklblLoadAuth";
            this.lnklblLoadAuth.Size = new System.Drawing.Size(13, 13);
            this.lnklblLoadAuth.TabIndex = 8;
            this.lnklblLoadAuth.TabStop = true;
            this.lnklblLoadAuth.Text = "L";
            this.lnklblLoadAuth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLoadAuth_LinkClicked);
            // 
            // rtxbxAuth
            // 
            this.rtxbxAuth.Enabled = false;
            this.rtxbxAuth.Location = new System.Drawing.Point(26, 23);
            this.rtxbxAuth.Name = "rtxbxAuth";
            this.rtxbxAuth.Size = new System.Drawing.Size(384, 54);
            this.rtxbxAuth.TabIndex = 7;
            this.rtxbxAuth.Text = "";
            this.rtxbxAuth.TextChanged += new System.EventHandler(this.rtxbxAuth_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox_UserAgent);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lnklblLoadUserAgent);
            this.panel2.Controls.Add(this.Rtxbxuseragent);
            this.panel2.Location = new System.Drawing.Point(12, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 94);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Agent";
            // 
            // lnklblLoadUserAgent
            // 
            this.lnklblLoadUserAgent.AutoSize = true;
            this.lnklblLoadUserAgent.Enabled = false;
            this.lnklblLoadUserAgent.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblLoadUserAgent.Location = new System.Drawing.Point(416, 76);
            this.lnklblLoadUserAgent.Name = "lnklblLoadUserAgent";
            this.lnklblLoadUserAgent.Size = new System.Drawing.Size(13, 13);
            this.lnklblLoadUserAgent.TabIndex = 2;
            this.lnklblLoadUserAgent.TabStop = true;
            this.lnklblLoadUserAgent.Text = "L";
            this.lnklblLoadUserAgent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLoadUserAgent_LinkClicked);
            this.lnklblLoadUserAgent.Click += new System.EventHandler(this.lnklblLoadUserAgent_Click);
            // 
            // Rtxbxuseragent
            // 
            this.Rtxbxuseragent.Enabled = false;
            this.Rtxbxuseragent.Location = new System.Drawing.Point(17, 22);
            this.Rtxbxuseragent.Name = "Rtxbxuseragent";
            this.Rtxbxuseragent.Size = new System.Drawing.Size(393, 67);
            this.Rtxbxuseragent.TabIndex = 1;
            this.Rtxbxuseragent.Text = "";
            this.Rtxbxuseragent.TextChanged += new System.EventHandler(this.Rtxbxuseragent_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtxbxCookie);
            this.panel1.Controls.Add(this.checkBoxCookie);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 90);
            this.panel1.TabIndex = 1;
            // 
            // rtxbxCookie
            // 
            this.rtxbxCookie.Location = new System.Drawing.Point(17, 21);
            this.rtxbxCookie.Name = "rtxbxCookie";
            this.rtxbxCookie.Size = new System.Drawing.Size(393, 63);
            this.rtxbxCookie.TabIndex = 1;
            this.rtxbxCookie.Text = "";
            this.rtxbxCookie.TextChanged += new System.EventHandler(this.rtxbxCookie_TextChanged);
            // 
            // checkBoxCookie
            // 
            this.checkBoxCookie.AutoSize = true;
            this.checkBoxCookie.Location = new System.Drawing.Point(156, 3);
            this.checkBoxCookie.Name = "checkBoxCookie";
            this.checkBoxCookie.Size = new System.Drawing.Size(81, 17);
            this.checkBoxCookie.TabIndex = 0;
            this.checkBoxCookie.Text = "Use Cookie";
            this.checkBoxCookie.UseVisualStyleBackColor = true;
            this.checkBoxCookie.CheckedChanged += new System.EventHandler(this.checkBoxCookie_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Location = new System.Drawing.Point(181, 397);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // linkLabelClose
            // 
            this.linkLabelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelClose.AutoSize = true;
            this.linkLabelClose.LinkColor = System.Drawing.Color.Red;
            this.linkLabelClose.Location = new System.Drawing.Point(446, 1);
            this.linkLabelClose.Name = "linkLabelClose";
            this.linkLabelClose.Size = new System.Drawing.Size(14, 13);
            this.linkLabelClose.TabIndex = 10;
            this.linkLabelClose.TabStop = true;
            this.linkLabelClose.Text = "X";
            this.linkLabelClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClose_LinkClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tpg_Requests);
            this.tabControl1.Controls.Add(this.tpgAppearance);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(452, 388);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.panel6);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(444, 362);
            this.tabPageGeneral.TabIndex = 2;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(444, 366);
            this.panel6.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.checkBox_in_Tab_Page);
            this.panel8.Controls.Add(this.checkBox_Isolated_window);
            this.panel8.Location = new System.Drawing.Point(6, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(432, 41);
            this.panel8.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "System Proxy Display in";
            // 
            // checkBox_in_Tab_Page
            // 
            this.checkBox_in_Tab_Page.AutoSize = true;
            this.checkBox_in_Tab_Page.Location = new System.Drawing.Point(296, 11);
            this.checkBox_in_Tab_Page.Name = "checkBox_in_Tab_Page";
            this.checkBox_in_Tab_Page.Size = new System.Drawing.Size(71, 17);
            this.checkBox_in_Tab_Page.TabIndex = 1;
            this.checkBox_in_Tab_Page.Text = "Tab page";
            this.checkBox_in_Tab_Page.UseVisualStyleBackColor = true;
            this.checkBox_in_Tab_Page.CheckedChanged += new System.EventHandler(this.checkBox_Isolated_window_CheckedChanged_1);
            // 
            // checkBox_Isolated_window
            // 
            this.checkBox_Isolated_window.AutoSize = true;
            this.checkBox_Isolated_window.Checked = true;
            this.checkBox_Isolated_window.Location = new System.Drawing.Point(153, 11);
            this.checkBox_Isolated_window.Name = "checkBox_Isolated_window";
            this.checkBox_Isolated_window.Size = new System.Drawing.Size(104, 17);
            this.checkBox_Isolated_window.TabIndex = 1;
            this.checkBox_Isolated_window.TabStop = true;
            this.checkBox_Isolated_window.Text = "Isolated Window";
            this.checkBox_Isolated_window.UseVisualStyleBackColor = true;
            this.checkBox_Isolated_window.CheckedChanged += new System.EventHandler(this.checkBox_Isolated_window_CheckedChanged_1);
            // 
            // tpg_Requests
            // 
            this.tpg_Requests.Controls.Add(this.panelmain);
            this.tpg_Requests.Location = new System.Drawing.Point(4, 22);
            this.tpg_Requests.Name = "tpg_Requests";
            this.tpg_Requests.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_Requests.Size = new System.Drawing.Size(444, 362);
            this.tpg_Requests.TabIndex = 0;
            this.tpg_Requests.Text = "Requests";
            this.tpg_Requests.UseVisualStyleBackColor = true;
            // 
            // tpgAppearance
            // 
            this.tpgAppearance.Controls.Add(this.panel9);
            this.tpgAppearance.Location = new System.Drawing.Point(4, 22);
            this.tpgAppearance.Name = "tpgAppearance";
            this.tpgAppearance.Padding = new System.Windows.Forms.Padding(3);
            this.tpgAppearance.Size = new System.Drawing.Size(444, 362);
            this.tpgAppearance.TabIndex = 1;
            this.tpgAppearance.Text = "Appearance";
            this.tpgAppearance.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel9.Controls.Add(this.ColorPanel);
            this.panel9.Controls.Add(this.label6);
            this.panel9.ForeColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(0, -2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(444, 366);
            this.panel9.TabIndex = 2;
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.Color.Yellow;
            this.ColorPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorPanel.ForeColor = System.Drawing.Color.Yellow;
            this.ColorPanel.Location = new System.Drawing.Point(219, 9);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(30, 23);
            this.ColorPanel.TabIndex = 1;
            this.ColorPanel.UseVisualStyleBackColor = false;
            this.ColorPanel.BackColorChanged += new System.EventHandler(this.ColorPanel_BackColorChanged);
            this.ColorPanel.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Search Text";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(444, 362);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Plus";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(0, -2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(444, 366);
            this.panel7.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Location = new System.Drawing.Point(2, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 426);
            this.panel4.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(142, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Settings";
            // 
            // checkBox_UserAgent
            // 
            this.checkBox_UserAgent.AutoSize = true;
            this.checkBox_UserAgent.Location = new System.Drawing.Point(156, 1);
            this.checkBox_UserAgent.Name = "checkBox_UserAgent";
            this.checkBox_UserAgent.Size = new System.Drawing.Size(79, 17);
            this.checkBox_UserAgent.TabIndex = 4;
            this.checkBox_UserAgent.Text = "User Agent";
            this.checkBox_UserAgent.UseVisualStyleBackColor = true;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(460, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.linkLabelClose);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FrmSettings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.panelmain.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPort)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tpg_Requests.ResumeLayout(false);
            this.tpgAppearance.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtxbxCookie;
        private System.Windows.Forms.CheckBox checkBoxCookie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox Rtxbxuseragent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel lnklblLoadUserAgent;
        private System.Windows.Forms.CheckBox chkbx_Authorization;
        private System.Windows.Forms.RichTextBox rtxbxAuth;
        private System.Windows.Forms.LinkLabel lnklblLoadAuth;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel linkLabelClose;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpg_Requests;
        private System.Windows.Forms.TabPage tpgAppearance;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmPort;
        private System.Windows.Forms.TextBox txbxHost;
        private System.Windows.Forms.CheckBox chkbxProxy;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton checkBox_Isolated_window;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton checkBox_in_Tab_Page;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ColorPanel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox checkBox_UserAgent;
    }
}