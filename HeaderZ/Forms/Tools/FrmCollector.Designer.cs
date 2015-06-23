namespace Web_Gunners.Forms.Tools
{
    partial class FrmCollector
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelSendReflector = new System.Windows.Forms.LinkLabel();
            this.linkLabelLoadSource = new System.Windows.Forms.LinkLabel();
            this.linkLabelCopyAll_links = new System.Windows.Forms.LinkLabel();
            this.linkLabelCopySingle_link = new System.Windows.Forms.LinkLabel();
            this.listBoxURLS = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lnklBL_Close = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.btnEval = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBoxForms = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelListBXX = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabelCopySingle_Form = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panelListBXX.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLabelCopySingle_Form);
            this.panel1.Controls.Add(this.panelListBXX);
            this.panel1.Controls.Add(this.linkLabelSendReflector);
            this.panel1.Controls.Add(this.linkLabelLoadSource);
            this.panel1.Controls.Add(this.linkLabelCopyAll_links);
            this.panel1.Controls.Add(this.linkLabelCopySingle_link);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lnklBL_Close);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtReport);
            this.panel1.Controls.Add(this.btnEval);
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 380);
            this.panel1.TabIndex = 0;
            // 
            // linkLabelSendReflector
            // 
            this.linkLabelSendReflector.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabelSendReflector.AutoSize = true;
            this.linkLabelSendReflector.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabelSendReflector.Location = new System.Drawing.Point(230, 363);
            this.linkLabelSendReflector.Name = "linkLabelSendReflector";
            this.linkLabelSendReflector.Size = new System.Drawing.Size(89, 13);
            this.linkLabelSendReflector.TabIndex = 20;
            this.linkLabelSendReflector.TabStop = true;
            this.linkLabelSendReflector.Text = "Send To reflector";
            this.linkLabelSendReflector.Visible = false;
            this.linkLabelSendReflector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSendReflector_LinkClicked);
            // 
            // linkLabelLoadSource
            // 
            this.linkLabelLoadSource.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabelLoadSource.AutoSize = true;
            this.linkLabelLoadSource.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabelLoadSource.Location = new System.Drawing.Point(319, 363);
            this.linkLabelLoadSource.Name = "linkLabelLoadSource";
            this.linkLabelLoadSource.Size = new System.Drawing.Size(67, 13);
            this.linkLabelLoadSource.TabIndex = 20;
            this.linkLabelLoadSource.TabStop = true;
            this.linkLabelLoadSource.Text = "View Source";
            this.linkLabelLoadSource.Visible = false;
            this.linkLabelLoadSource.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLoadSource_LinkClicked);
            // 
            // linkLabelCopyAll_links
            // 
            this.linkLabelCopyAll_links.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabelCopyAll_links.AutoSize = true;
            this.linkLabelCopyAll_links.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabelCopyAll_links.Location = new System.Drawing.Point(32, 360);
            this.linkLabelCopyAll_links.Name = "linkLabelCopyAll_links";
            this.linkLabelCopyAll_links.Size = new System.Drawing.Size(45, 13);
            this.linkLabelCopyAll_links.TabIndex = 20;
            this.linkLabelCopyAll_links.TabStop = true;
            this.linkLabelCopyAll_links.Text = "Copy All";
            this.linkLabelCopyAll_links.Visible = false;
            this.linkLabelCopyAll_links.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCopyAll_LinkClicked);
            // 
            // linkLabelCopySingle_link
            // 
            this.linkLabelCopySingle_link.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabelCopySingle_link.AutoSize = true;
            this.linkLabelCopySingle_link.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabelCopySingle_link.Location = new System.Drawing.Point(94, 360);
            this.linkLabelCopySingle_link.Name = "linkLabelCopySingle_link";
            this.linkLabelCopySingle_link.Size = new System.Drawing.Size(31, 13);
            this.linkLabelCopySingle_link.TabIndex = 20;
            this.linkLabelCopySingle_link.TabStop = true;
            this.linkLabelCopySingle_link.Text = "Copy";
            this.linkLabelCopySingle_link.Visible = false;
            this.linkLabelCopySingle_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCopySingle_LinkClicked);
            // 
            // listBoxURLS
            // 
            this.listBoxURLS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxURLS.FormattingEnabled = true;
            this.listBoxURLS.Location = new System.Drawing.Point(3, 20);
            this.listBoxURLS.Name = "listBoxURLS";
            this.listBoxURLS.Size = new System.Drawing.Size(289, 134);
            this.listBoxURLS.TabIndex = 19;
            this.listBoxURLS.SelectedIndexChanged += new System.EventHandler(this.listBoxURLS_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(309, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Info";
            // 
            // lnklBL_Close
            // 
            this.lnklBL_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklBL_Close.AutoSize = true;
            this.lnklBL_Close.LinkColor = System.Drawing.Color.Red;
            this.lnklBL_Close.Location = new System.Drawing.Point(636, 15);
            this.lnklBL_Close.Name = "lnklBL_Close";
            this.lnklBL_Close.Size = new System.Drawing.Size(14, 13);
            this.lnklBL_Close.TabIndex = 16;
            this.lnklBL_Close.TabStop = true;
            this.lnklBL_Close.Text = "X";
            this.lnklBL_Close.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklBL_Close_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(150, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Collector Gets all Links in a certain page";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Found Links";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Url";
            // 
            // txtReport
            // 
            this.txtReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReport.Location = new System.Drawing.Point(27, 102);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReport.Size = new System.Drawing.Size(587, 93);
            this.txtReport.TabIndex = 4;
            // 
            // btnEval
            // 
            this.btnEval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEval.Location = new System.Drawing.Point(539, 59);
            this.btnEval.Name = "btnEval";
            this.btnEval.Size = new System.Drawing.Size(75, 23);
            this.btnEval.TabIndex = 7;
            this.btnEval.Text = "evaluate";
            this.btnEval.UseVisualStyleBackColor = true;
            this.btnEval.Click += new System.EventHandler(this.btnEval_Click);
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(27, 61);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(506, 20);
            this.txtURL.TabIndex = 6;
            this.txtURL.Text = "http://php.vulnweb.com";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(278, 85);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(653, 12);
            this.progressBar1.TabIndex = 9;
            // 
            // listBoxForms
            // 
            this.listBoxForms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxForms.FormattingEnabled = true;
            this.listBoxForms.Location = new System.Drawing.Point(295, 20);
            this.listBoxForms.Name = "listBoxForms";
            this.listBoxForms.Size = new System.Drawing.Size(289, 134);
            this.listBoxForms.TabIndex = 19;
            this.listBoxForms.SelectedIndexChanged += new System.EventHandler(this.listBoxURLS_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(292, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Found forms";
            // 
            // panelListBXX
            // 
            this.panelListBXX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelListBXX.Controls.Add(this.listBoxURLS);
            this.panelListBXX.Controls.Add(this.listBoxForms);
            this.panelListBXX.Controls.Add(this.label3);
            this.panelListBXX.Controls.Add(this.label5);
            this.panelListBXX.Location = new System.Drawing.Point(27, 201);
            this.panelListBXX.Name = "panelListBXX";
            this.panelListBXX.Size = new System.Drawing.Size(587, 156);
            this.panelListBXX.TabIndex = 21;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel2.Location = new System.Drawing.Point(529, 363);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(45, 13);
            this.linkLabel2.TabIndex = 23;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Copy All";
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabelCopySingle_Form
            // 
            this.linkLabelCopySingle_Form.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabelCopySingle_Form.AutoSize = true;
            this.linkLabelCopySingle_Form.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabelCopySingle_Form.Location = new System.Drawing.Point(580, 363);
            this.linkLabelCopySingle_Form.Name = "linkLabelCopySingle_Form";
            this.linkLabelCopySingle_Form.Size = new System.Drawing.Size(31, 13);
            this.linkLabelCopySingle_Form.TabIndex = 24;
            this.linkLabelCopySingle_Form.TabStop = true;
            this.linkLabelCopySingle_Form.Text = "Copy";
            this.linkLabelCopySingle_Form.Visible = false;
            this.linkLabelCopySingle_Form.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCopySingle_Form_LinkClicked);
            // 
            // FrmCollector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 383);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCollector";
            this.Text = "Collector";
            this.Load += new System.EventHandler(this.FrmAboDoma_Load);
            this.Resize += new System.EventHandler(this.FrmCollector_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelListBXX.ResumeLayout(false);
            this.panelListBXX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.Button btnEval;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnklBL_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxURLS;
        private System.Windows.Forms.LinkLabel linkLabelCopySingle_link;
        private System.Windows.Forms.LinkLabel linkLabelCopyAll_links;
        private System.Windows.Forms.LinkLabel linkLabelSendReflector;
        private System.Windows.Forms.LinkLabel linkLabelLoadSource;
        private System.Windows.Forms.ListBox listBoxForms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelListBXX;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabelCopySingle_Form;
    }
}