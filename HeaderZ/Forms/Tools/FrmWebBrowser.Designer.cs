namespace Web_Gunners.Forms.Tools
{
    partial class FrmWebBrowser
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lnklBL_Close = new System.Windows.Forms.LinkLabel();
            this.GoBtn = new System.Windows.Forms.Button();
            this.txbxUrl = new System.Windows.Forms.TextBox();
            this.panelContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelContainer.Controls.Add(this.panel3);
            this.panelContainer.Controls.Add(this.panel2);
            this.panelContainer.Location = new System.Drawing.Point(3, 3);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(918, 515);
            this.panelContainer.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel3.Controls.Add(this.webBrowser1);
            this.panel3.Location = new System.Drawing.Point(4, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 478);
            this.panel3.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(911, 478);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel2.Controls.Add(this.lnklBL_Close);
            this.panel2.Controls.Add(this.GoBtn);
            this.panel2.Controls.Add(this.txbxUrl);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 26);
            this.panel2.TabIndex = 0;
            // 
            // lnklBL_Close
            // 
            this.lnklBL_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklBL_Close.AutoSize = true;
            this.lnklBL_Close.LinkColor = System.Drawing.Color.Red;
            this.lnklBL_Close.Location = new System.Drawing.Point(897, 4);
            this.lnklBL_Close.Name = "lnklBL_Close";
            this.lnklBL_Close.Size = new System.Drawing.Size(14, 13);
            this.lnklBL_Close.TabIndex = 16;
            this.lnklBL_Close.TabStop = true;
            this.lnklBL_Close.Text = "X";
            this.lnklBL_Close.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklBL_Close_LinkClicked);
            // 
            // GoBtn
            // 
            this.GoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoBtn.Enabled = false;
            this.GoBtn.ForeColor = System.Drawing.Color.White;
            this.GoBtn.Location = new System.Drawing.Point(826, 0);
            this.GoBtn.Name = "GoBtn";
            this.GoBtn.Size = new System.Drawing.Size(66, 23);
            this.GoBtn.TabIndex = 1;
            this.GoBtn.Text = ">>";
            this.GoBtn.UseVisualStyleBackColor = false;
            this.GoBtn.Click += new System.EventHandler(this.GoBtn_Click);
            // 
            // txbxUrl
            // 
            this.txbxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.txbxUrl.Location = new System.Drawing.Point(6, 4);
            this.txbxUrl.Name = "txbxUrl";
            this.txbxUrl.Size = new System.Drawing.Size(814, 18);
            this.txbxUrl.TabIndex = 0;
            this.txbxUrl.TextChanged += new System.EventHandler(this.txbxUrl_TextChanged);
            // 
            // FrmWebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.panelContainer);
            this.Name = "FrmWebBrowser";
            this.Text = "WebBrowser";
            this.panelContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbxUrl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.LinkLabel lnklBL_Close;
    }
}