namespace Web_Gunners
{
    partial class FrmAttacks
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
            this.RTXBXResponse = new System.Windows.Forms.RichTextBox();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelRequest = new System.Windows.Forms.Panel();
            this.rtxbxRequest = new System.Windows.Forms.RichTextBox();
            this.panelResponse = new System.Windows.Forms.Panel();
            this.txbxSearchReQuest = new System.Windows.Forms.TextBox();
            this.txbxSearchResponse = new System.Windows.Forms.TextBox();
            this.label_notf = new System.Windows.Forms.Label();
            this.lnklblUrl = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDocSource = new System.Windows.Forms.Label();
            this.panelParser = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_Requests = new System.Windows.Forms.GroupBox();
            this.panelGredContainer = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lnklBL_Close = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lnklbl_SEndeToRepeater = new System.Windows.Forms.LinkLabel();
            this.lnklblExport = new System.Windows.Forms.LinkLabel();
            this.panelCenter.SuspendLayout();
            this.panelRequest.SuspendLayout();
            this.panelResponse.SuspendLayout();
            this.panelParser.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Requests.SuspendLayout();
            this.panelGredContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RTXBXResponse
            // 
            this.RTXBXResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTXBXResponse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTXBXResponse.Location = new System.Drawing.Point(3, 22);
            this.RTXBXResponse.Name = "RTXBXResponse";
            this.RTXBXResponse.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RTXBXResponse.Size = new System.Drawing.Size(464, 239);
            this.RTXBXResponse.TabIndex = 0;
            this.RTXBXResponse.Text = "";
            // 
            // panelCenter
            // 
            this.panelCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelCenter.Controls.Add(this.lnklblExport);
            this.panelCenter.Controls.Add(this.lnklbl_SEndeToRepeater);
            this.panelCenter.Controls.Add(this.panelRequest);
            this.panelCenter.Controls.Add(this.panelResponse);
            this.panelCenter.Controls.Add(this.label_notf);
            this.panelCenter.Controls.Add(this.lnklblUrl);
            this.panelCenter.ForeColor = System.Drawing.Color.White;
            this.panelCenter.Location = new System.Drawing.Point(3, 144);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(953, 312);
            this.panelCenter.TabIndex = 1;
            // 
            // panelRequest
            // 
            this.panelRequest.Controls.Add(this.rtxbxRequest);
            this.panelRequest.Controls.Add(this.txbxSearchReQuest);
            this.panelRequest.Controls.Add(this.label2);
            this.panelRequest.Location = new System.Drawing.Point(3, 22);
            this.panelRequest.Name = "panelRequest";
            this.panelRequest.Size = new System.Drawing.Size(470, 287);
            this.panelRequest.TabIndex = 14;
            // 
            // rtxbxRequest
            // 
            this.rtxbxRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxbxRequest.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbxRequest.ForeColor = System.Drawing.Color.Black;
            this.rtxbxRequest.Location = new System.Drawing.Point(3, 25);
            this.rtxbxRequest.Name = "rtxbxRequest";
            this.rtxbxRequest.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxbxRequest.Size = new System.Drawing.Size(464, 236);
            this.rtxbxRequest.TabIndex = 6;
            this.rtxbxRequest.Text = "";
            this.rtxbxRequest.TextChanged += new System.EventHandler(this.rtxbxRequest_TextChanged);
            // 
            // panelResponse
            // 
            this.panelResponse.Controls.Add(this.RTXBXResponse);
            this.panelResponse.Controls.Add(this.txbxSearchResponse);
            this.panelResponse.Controls.Add(this.lblDocSource);
            this.panelResponse.Location = new System.Drawing.Point(477, 22);
            this.panelResponse.Name = "panelResponse";
            this.panelResponse.Size = new System.Drawing.Size(470, 290);
            this.panelResponse.TabIndex = 13;
            // 
            // txbxSearchReQuest
            // 
            this.txbxSearchReQuest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxSearchReQuest.Location = new System.Drawing.Point(3, 264);
            this.txbxSearchReQuest.Name = "txbxSearchReQuest";
            this.txbxSearchReQuest.Size = new System.Drawing.Size(464, 20);
            this.txbxSearchReQuest.TabIndex = 12;
            this.txbxSearchReQuest.TextChanged += new System.EventHandler(this.txbxSearchReQuest_TextChanged);
            // 
            // txbxSearchResponse
            // 
            this.txbxSearchResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxSearchResponse.Location = new System.Drawing.Point(3, 264);
            this.txbxSearchResponse.Name = "txbxSearchResponse";
            this.txbxSearchResponse.Size = new System.Drawing.Size(461, 20);
            this.txbxSearchResponse.TabIndex = 11;
            this.txbxSearchResponse.TextChanged += new System.EventHandler(this.txbxSearchResponse_TextChanged);
            // 
            // label_notf
            // 
            this.label_notf.AutoSize = true;
            this.label_notf.Location = new System.Drawing.Point(9, 549);
            this.label_notf.Name = "label_notf";
            this.label_notf.Size = new System.Drawing.Size(35, 13);
            this.label_notf.TabIndex = 10;
            this.label_notf.Text = "label3";
            // 
            // lnklblUrl
            // 
            this.lnklblUrl.AutoSize = true;
            this.lnklblUrl.LinkColor = System.Drawing.Color.White;
            this.lnklblUrl.Location = new System.Drawing.Point(329, 3);
            this.lnklblUrl.Name = "lnklblUrl";
            this.lnklblUrl.Size = new System.Drawing.Size(16, 13);
            this.lnklblUrl.TabIndex = 8;
            this.lnklblUrl.TabStop = true;
            this.lnklblUrl.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Request";
            // 
            // lblDocSource
            // 
            this.lblDocSource.AutoSize = true;
            this.lblDocSource.ForeColor = System.Drawing.Color.White;
            this.lblDocSource.Location = new System.Drawing.Point(3, 3);
            this.lblDocSource.Name = "lblDocSource";
            this.lblDocSource.Size = new System.Drawing.Size(55, 13);
            this.lblDocSource.TabIndex = 2;
            this.lblDocSource.Text = "Response";
            // 
            // panelParser
            // 
            this.panelParser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.panelParser.Controls.Add(this.webBrowser1);
            this.panelParser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParser.Location = new System.Drawing.Point(3, 16);
            this.panelParser.Name = "panelParser";
            this.panelParser.Size = new System.Drawing.Size(938, 81);
            this.panelParser.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(-1, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(939, 81);
            this.webBrowser1.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.SystemColors.InfoText;
            this.panelContainer.Controls.Add(this.groupBox1);
            this.panelContainer.Controls.Add(this.groupBox_Requests);
            this.panelContainer.Controls.Add(this.panelCenter);
            this.panelContainer.Location = new System.Drawing.Point(1, 1);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(953, 566);
            this.panelContainer.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panelParser);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parser";
            // 
            // groupBox_Requests
            // 
            this.groupBox_Requests.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Requests.Controls.Add(this.panelGredContainer);
            this.groupBox_Requests.Controls.Add(this.lnklBL_Close);
            this.groupBox_Requests.ForeColor = System.Drawing.Color.White;
            this.groupBox_Requests.Location = new System.Drawing.Point(3, 0);
            this.groupBox_Requests.Name = "groupBox_Requests";
            this.groupBox_Requests.Size = new System.Drawing.Size(944, 138);
            this.groupBox_Requests.TabIndex = 2;
            this.groupBox_Requests.TabStop = false;
            this.groupBox_Requests.Text = "Attacks";
            this.groupBox_Requests.SizeChanged += new System.EventHandler(this.groupBox_Requests_SizeChanged);
            this.groupBox_Requests.VisibleChanged += new System.EventHandler(this.groupBox_Requests_VisibleChanged);
            // 
            // panelGredContainer
            // 
            this.panelGredContainer.Controls.Add(this.dataGridView1);
            this.panelGredContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGredContainer.ForeColor = System.Drawing.Color.Black;
            this.panelGredContainer.Location = new System.Drawing.Point(3, 16);
            this.panelGredContainer.Name = "panelGredContainer";
            this.panelGredContainer.Size = new System.Drawing.Size(938, 119);
            this.panelGredContainer.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 61;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(938, 119);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // lnklBL_Close
            // 
            this.lnklBL_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklBL_Close.AutoSize = true;
            this.lnklBL_Close.LinkColor = System.Drawing.Color.Red;
            this.lnklBL_Close.Location = new System.Drawing.Point(933, 0);
            this.lnklBL_Close.Name = "lnklBL_Close";
            this.lnklBL_Close.Size = new System.Drawing.Size(14, 13);
            this.lnklBL_Close.TabIndex = 15;
            this.lnklBL_Close.TabStop = true;
            this.lnklBL_Close.Text = "X";
            this.lnklBL_Close.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklBL_Close_LinkClicked);
            // 
            // lnklbl_SEndeToRepeater
            // 
            this.lnklbl_SEndeToRepeater.AutoSize = true;
            this.lnklbl_SEndeToRepeater.LinkColor = System.Drawing.Color.Yellow;
            this.lnklbl_SEndeToRepeater.Location = new System.Drawing.Point(846, 3);
            this.lnklbl_SEndeToRepeater.Name = "lnklbl_SEndeToRepeater";
            this.lnklbl_SEndeToRepeater.Size = new System.Drawing.Size(95, 13);
            this.lnklbl_SEndeToRepeater.TabIndex = 15;
            this.lnklbl_SEndeToRepeater.TabStop = true;
            this.lnklbl_SEndeToRepeater.Text = "Send To Repeater";
            this.lnklbl_SEndeToRepeater.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnklblExport
            // 
            this.lnklblExport.AutoSize = true;
            this.lnklblExport.LinkColor = System.Drawing.Color.Yellow;
            this.lnklblExport.Location = new System.Drawing.Point(779, 3);
            this.lnklblExport.Name = "lnklblExport";
            this.lnklblExport.Size = new System.Drawing.Size(61, 13);
            this.lnklblExport.TabIndex = 15;
            this.lnklblExport.TabStop = true;
            this.lnklblExport.Text = "Export Html";
            this.lnklblExport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // FrmAttacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(959, 572);
            this.Controls.Add(this.panelContainer);
            this.MaximizeBox = false;
            this.Name = "FrmAttacks";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.Text = "Attack Details";
            this.Load += new System.EventHandler(this.DocumentDisplayer_Load);
            this.SizeChanged += new System.EventHandler(this.FrmAttacks_SizeChanged);
            this.panelCenter.ResumeLayout(false);
            this.panelCenter.PerformLayout();
            this.panelRequest.ResumeLayout(false);
            this.panelRequest.PerformLayout();
            this.panelResponse.ResumeLayout(false);
            this.panelResponse.PerformLayout();
            this.panelParser.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_Requests.ResumeLayout(false);
            this.groupBox_Requests.PerformLayout();
            this.panelGredContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTXBXResponse;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.Panel panelParser;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lblDocSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxbxRequest;
        private System.Windows.Forms.LinkLabel lnklblUrl;
        private System.Windows.Forms.Label label_notf;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.GroupBox groupBox_Requests;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel lnklBL_Close;
        private System.Windows.Forms.Panel panelGredContainer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txbxSearchReQuest;
        private System.Windows.Forms.TextBox txbxSearchResponse;
        private System.Windows.Forms.Panel panelResponse;
        private System.Windows.Forms.Panel panelRequest;
        private System.Windows.Forms.LinkLabel lnklbl_SEndeToRepeater;
        private System.Windows.Forms.LinkLabel lnklblExport;
    }
}