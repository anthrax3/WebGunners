namespace Web_Gunners.Forms.Tools
{
    partial class FrmDigger
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
            this.components = new System.ComponentModel.Container();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbxPatern = new System.Windows.Forms.TextBox();
            this.RtxbxSource = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lnklBL_Close = new System.Windows.Forms.LinkLabel();
            this.GoBtn = new System.Windows.Forms.Button();
            this.txbxUrl = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.panelContainer.Location = new System.Drawing.Point(0, 1);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(923, 518);
            this.panelContainer.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel3.Controls.Add(this.txbxPatern);
            this.panel3.Controls.Add(this.RtxbxSource);
            this.panel3.Location = new System.Drawing.Point(4, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(916, 481);
            this.panel3.TabIndex = 1;
            // 
            // txbxPatern
            // 
            this.txbxPatern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxPatern.Location = new System.Drawing.Point(6, 458);
            this.txbxPatern.Name = "txbxPatern";
            this.txbxPatern.Size = new System.Drawing.Size(904, 20);
            this.txbxPatern.TabIndex = 1;
            this.txbxPatern.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RtxbxSource
            // 
            this.RtxbxSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RtxbxSource.BackColor = System.Drawing.SystemColors.InfoText;
            this.RtxbxSource.ForeColor = System.Drawing.Color.White;
            this.RtxbxSource.Location = new System.Drawing.Point(5, 0);
            this.RtxbxSource.Name = "RtxbxSource";
            this.RtxbxSource.Size = new System.Drawing.Size(905, 452);
            this.RtxbxSource.TabIndex = 0;
            this.RtxbxSource.Text = "";
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
            this.panel2.Size = new System.Drawing.Size(916, 26);
            this.panel2.TabIndex = 0;
            // 
            // lnklBL_Close
            // 
            this.lnklBL_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklBL_Close.AutoSize = true;
            this.lnklBL_Close.LinkColor = System.Drawing.Color.Red;
            this.lnklBL_Close.Location = new System.Drawing.Point(902, 4);
            this.lnklBL_Close.Name = "lnklBL_Close";
            this.lnklBL_Close.Size = new System.Drawing.Size(14, 13);
            this.lnklBL_Close.TabIndex = 16;
            this.lnklBL_Close.TabStop = true;
            this.lnklBL_Close.Text = "X";
            // 
            // GoBtn
            // 
            this.GoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GoBtn.Enabled = false;
            this.GoBtn.ForeColor = System.Drawing.Color.White;
            this.GoBtn.Location = new System.Drawing.Point(831, 0);
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
            this.txbxUrl.Size = new System.Drawing.Size(819, 18);
            this.txbxUrl.TabIndex = 0;
            this.txbxUrl.TextChanged += new System.EventHandler(this.txbxUrl_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmDigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.panelContainer);
            this.Name = "FrmDigger";
            this.Text = "Digger";
            this.panelContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel lnklBL_Close;
        private System.Windows.Forms.Button GoBtn;
        private System.Windows.Forms.TextBox txbxUrl;
        private System.Windows.Forms.RichTextBox RtxbxSource;
        private System.Windows.Forms.TextBox txbxPatern;
        private System.Windows.Forms.Timer timer1;
    }
}