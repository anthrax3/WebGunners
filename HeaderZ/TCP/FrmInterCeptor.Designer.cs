namespace Web_Gunners.Forms.Tools
{
    partial class FrmInterCeptor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInterCeptor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnInterceptResponse = new System.Windows.Forms.Button();
            this.NM_watcher_port = new System.Windows.Forms.NumericUpDown();
            this.btnRejectAll = new System.Windows.Forms.Button();
            this.btnSwitchIntercept = new System.Windows.Forms.Button();
            this.lblNotf = new System.Windows.Forms.Label();
            this.RtxbxBody = new System.Windows.Forms.RichTextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NM_watcher_port)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 499);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(925, 493);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.btnInterceptResponse);
            this.tabPage1.Controls.Add(this.NM_watcher_port);
            this.tabPage1.Controls.Add(this.btnRejectAll);
            this.tabPage1.Controls.Add(this.btnSwitchIntercept);
            this.tabPage1.Controls.Add(this.lblNotf);
            this.tabPage1.Controls.Add(this.RtxbxBody);
            this.tabPage1.Controls.Add(this.btnListen);
            this.tabPage1.Controls.Add(this.btnReject);
            this.tabPage1.Controls.Add(this.btnPass);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(917, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Interceptor";
            // 
            // btnInterceptResponse
            // 
            this.btnInterceptResponse.Location = new System.Drawing.Point(368, 7);
            this.btnInterceptResponse.Name = "btnInterceptResponse";
            this.btnInterceptResponse.Size = new System.Drawing.Size(142, 23);
            this.btnInterceptResponse.TabIndex = 9;
            this.btnInterceptResponse.Text = "Intercept Response";
            this.btnInterceptResponse.UseVisualStyleBackColor = true;
            this.btnInterceptResponse.Click += new System.EventHandler(this.btnInterceptResponse_Click);
            // 
            // NM_watcher_port
            // 
            this.NM_watcher_port.Location = new System.Drawing.Point(777, 7);
            this.NM_watcher_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NM_watcher_port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NM_watcher_port.Name = "NM_watcher_port";
            this.NM_watcher_port.Size = new System.Drawing.Size(53, 20);
            this.NM_watcher_port.TabIndex = 8;
            this.NM_watcher_port.Value = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            // 
            // btnRejectAll
            // 
            this.btnRejectAll.Enabled = false;
            this.btnRejectAll.Location = new System.Drawing.Point(286, 7);
            this.btnRejectAll.Name = "btnRejectAll";
            this.btnRejectAll.Size = new System.Drawing.Size(75, 23);
            this.btnRejectAll.TabIndex = 7;
            this.btnRejectAll.Text = "Reject all";
            this.btnRejectAll.UseVisualStyleBackColor = true;
            this.btnRejectAll.Click += new System.EventHandler(this.btnRejectAll_Click);
            // 
            // btnSwitchIntercept
            // 
            this.btnSwitchIntercept.Enabled = false;
            this.btnSwitchIntercept.Location = new System.Drawing.Point(172, 7);
            this.btnSwitchIntercept.Name = "btnSwitchIntercept";
            this.btnSwitchIntercept.Size = new System.Drawing.Size(107, 23);
            this.btnSwitchIntercept.TabIndex = 6;
            this.btnSwitchIntercept.Text = "Intercept is off";
            this.btnSwitchIntercept.UseVisualStyleBackColor = true;
            this.btnSwitchIntercept.Click += new System.EventHandler(this.btnSwitchIntercept_Click);
            // 
            // lblNotf
            // 
            this.lblNotf.AutoSize = true;
            this.lblNotf.ForeColor = System.Drawing.Color.White;
            this.lblNotf.Location = new System.Drawing.Point(6, 447);
            this.lblNotf.Name = "lblNotf";
            this.lblNotf.Size = new System.Drawing.Size(16, 13);
            this.lblNotf.TabIndex = 5;
            this.lblNotf.Text = "...";
            // 
            // RtxbxBody
            // 
            this.RtxbxBody.Location = new System.Drawing.Point(6, 36);
            this.RtxbxBody.Name = "RtxbxBody";
            this.RtxbxBody.Size = new System.Drawing.Size(905, 408);
            this.RtxbxBody.TabIndex = 3;
            this.RtxbxBody.Text = "";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(836, 6);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 2;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReject
            // 
            this.btnReject.Enabled = false;
            this.btnReject.Location = new System.Drawing.Point(90, 6);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 23);
            this.btnReject.TabIndex = 0;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnPass
            // 
            this.btnPass.Enabled = false;
            this.btnPass.Location = new System.Drawing.Point(9, 6);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(75, 23);
            this.btnPass.TabIndex = 0;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(917, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            // 
            // FrmInterCeptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 505);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInterCeptor";
            this.Text = "Interceptor";
            this.Load += new System.EventHandler(this.FrmInterCeptor_Load_1);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NM_watcher_port)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.RichTextBox RtxbxBody;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Label lblNotf;
        private System.Windows.Forms.Button btnSwitchIntercept;
        private System.Windows.Forms.Button btnRejectAll;
        private System.Windows.Forms.NumericUpDown NM_watcher_port;
        private System.Windows.Forms.Button btnInterceptResponse;
    }
}