namespace Web_Gunners.Forms.Tools
{
    partial class FrmMRCode
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
            this.panelThird = new System.Windows.Forms.Panel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Rev_Result = new System.Windows.Forms.LinkLabel();
            this.panelSec = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_FromAscii = new System.Windows.Forms.ComboBox();
            this.FromAscii = new System.Windows.Forms.RadioButton();
            this.comboBoxToAscii = new System.Windows.Forms.ComboBox();
            this.checkBox_Use_separatorToAscii = new System.Windows.Forms.CheckBox();
            this.ToAscii = new System.Windows.Forms.RadioButton();
            this.URLDecode = new System.Windows.Forms.RadioButton();
            this.Base64Decode = new System.Windows.Forms.RadioButton();
            this.URLEncode = new System.Windows.Forms.RadioButton();
            this.HTMLDecode = new System.Windows.Forms.RadioButton();
            this.HTMLEncode = new System.Windows.Forms.RadioButton();
            this.Base64Encode = new System.Windows.Forms.RadioButton();
            this.buttonEx = new System.Windows.Forms.Button();
            this.btnProc = new System.Windows.Forms.Button();
            this.panelFrst = new System.Windows.Forms.Panel();
            this.linkLabelLoadFile = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_String = new System.Windows.Forms.RichTextBox();
            this.linkLabelCopToClip = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lnklBL_Close = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panelThird.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelSec.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelFrst.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.panelThird);
            this.panel1.Controls.Add(this.panelSec);
            this.panel1.Controls.Add(this.panelFrst);
            this.panel1.Controls.Add(this.lnklBL_Close);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 513);
            this.panel1.TabIndex = 0;
            // 
            // panelThird
            // 
            this.panelThird.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelThird.Controls.Add(this.linkLabel3);
            this.panelThird.Controls.Add(this.groupBox2);
            this.panelThird.Controls.Add(this.linkLabel2);
            this.panelThird.Controls.Add(this.linkLabel_Rev_Result);
            this.panelThird.Location = new System.Drawing.Point(13, 309);
            this.panelThird.Name = "panelThird";
            this.panelThird.Size = new System.Drawing.Size(887, 199);
            this.panelThird.TabIndex = 19;
            // 
            // linkLabel3
            // 
            this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel3.Location = new System.Drawing.Point(646, 177);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(62, 15);
            this.linkLabel3.TabIndex = 17;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Sae to file";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Save_Clicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.richTextBox_Result);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(0, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 171);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "InPut";
            // 
            // richTextBox_Result
            // 
            this.richTextBox_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Result.Location = new System.Drawing.Point(0, 22);
            this.richTextBox_Result.Name = "richTextBox_Result";
            this.richTextBox_Result.Size = new System.Drawing.Size(884, 179);
            this.richTextBox_Result.TabIndex = 0;
            this.richTextBox_Result.Text = "";
            this.richTextBox_Result.TextChanged += new System.EventHandler(this.richTextBox_Dec_TextChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel2.Location = new System.Drawing.Point(714, 177);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(100, 15);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Copy To Clipboard";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyOutput_LinkClicked);
            // 
            // linkLabel_Rev_Result
            // 
            this.linkLabel_Rev_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_Rev_Result.AutoSize = true;
            this.linkLabel_Rev_Result.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel_Rev_Result.Location = new System.Drawing.Point(833, 176);
            this.linkLabel_Rev_Result.Name = "linkLabel_Rev_Result";
            this.linkLabel_Rev_Result.Size = new System.Drawing.Size(48, 15);
            this.linkLabel_Rev_Result.TabIndex = 3;
            this.linkLabel_Rev_Result.TabStop = true;
            this.linkLabel_Rev_Result.Text = "Reverse";
            this.linkLabel_Rev_Result.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Rev_Result_LinkClicked);
            // 
            // panelSec
            // 
            this.panelSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSec.Controls.Add(this.groupBox3);
            this.panelSec.Location = new System.Drawing.Point(13, 198);
            this.panelSec.Name = "panelSec";
            this.panelSec.Size = new System.Drawing.Size(887, 92);
            this.panelSec.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBox_FromAscii);
            this.groupBox3.Controls.Add(this.FromAscii);
            this.groupBox3.Controls.Add(this.comboBoxToAscii);
            this.groupBox3.Controls.Add(this.checkBox_Use_separatorToAscii);
            this.groupBox3.Controls.Add(this.ToAscii);
            this.groupBox3.Controls.Add(this.URLDecode);
            this.groupBox3.Controls.Add(this.Base64Decode);
            this.groupBox3.Controls.Add(this.URLEncode);
            this.groupBox3.Controls.Add(this.HTMLDecode);
            this.groupBox3.Controls.Add(this.HTMLEncode);
            this.groupBox3.Controls.Add(this.Base64Encode);
            this.groupBox3.Controls.Add(this.buttonEx);
            this.groupBox3.Controls.Add(this.btnProc);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(887, 92);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Separator";
            // 
            // comboBox_FromAscii
            // 
            this.comboBox_FromAscii.Enabled = false;
            this.comboBox_FromAscii.FormattingEnabled = true;
            this.comboBox_FromAscii.Items.AddRange(new object[] {
            "space",
            ",",
            ";",
            ":",
            "+",
            "-",
            "=",
            "/",
            "\\",
            "<",
            ">",
            "?",
            "{",
            "}",
            "!",
            "@",
            "#",
            "$",
            "%"});
            this.comboBox_FromAscii.Location = new System.Drawing.Point(525, 41);
            this.comboBox_FromAscii.Name = "comboBox_FromAscii";
            this.comboBox_FromAscii.Size = new System.Drawing.Size(39, 23);
            this.comboBox_FromAscii.TabIndex = 8;
            // 
            // FromAscii
            // 
            this.FromAscii.AutoSize = true;
            this.FromAscii.Location = new System.Drawing.Point(463, 22);
            this.FromAscii.Name = "FromAscii";
            this.FromAscii.Size = new System.Drawing.Size(77, 19);
            this.FromAscii.TabIndex = 6;
            this.FromAscii.Text = "FromAscii";
            this.FromAscii.UseVisualStyleBackColor = true;
            this.FromAscii.CheckedChanged += new System.EventHandler(this.FromAscii_CheckedChanged);
            // 
            // comboBoxToAscii
            // 
            this.comboBoxToAscii.Enabled = false;
            this.comboBoxToAscii.FormattingEnabled = true;
            this.comboBoxToAscii.Items.AddRange(new object[] {
            "space",
            ",",
            ";",
            ":",
            "+",
            "-",
            "=",
            "/",
            "\\",
            "<",
            ">",
            "?",
            "{",
            "}",
            "!",
            "@",
            "#",
            "$",
            "%"});
            this.comboBoxToAscii.Location = new System.Drawing.Point(396, 42);
            this.comboBoxToAscii.Name = "comboBoxToAscii";
            this.comboBoxToAscii.Size = new System.Drawing.Size(39, 23);
            this.comboBoxToAscii.TabIndex = 5;
            // 
            // checkBox_Use_separatorToAscii
            // 
            this.checkBox_Use_separatorToAscii.AutoSize = true;
            this.checkBox_Use_separatorToAscii.Enabled = false;
            this.checkBox_Use_separatorToAscii.Location = new System.Drawing.Point(318, 46);
            this.checkBox_Use_separatorToAscii.Name = "checkBox_Use_separatorToAscii";
            this.checkBox_Use_separatorToAscii.Size = new System.Drawing.Size(78, 19);
            this.checkBox_Use_separatorToAscii.TabIndex = 4;
            this.checkBox_Use_separatorToAscii.Text = "Separator";
            this.checkBox_Use_separatorToAscii.UseVisualStyleBackColor = true;
            this.checkBox_Use_separatorToAscii.CheckedChanged += new System.EventHandler(this.checkBox_Use_separator_CheckedChanged);
            // 
            // ToAscii
            // 
            this.ToAscii.AutoSize = true;
            this.ToAscii.Location = new System.Drawing.Point(318, 25);
            this.ToAscii.Name = "ToAscii";
            this.ToAscii.Size = new System.Drawing.Size(65, 19);
            this.ToAscii.TabIndex = 3;
            this.ToAscii.Text = "ToAscii";
            this.ToAscii.UseVisualStyleBackColor = true;
            this.ToAscii.CheckedChanged += new System.EventHandler(this.Ascii_CheckedChanged);
            // 
            // URLDecode
            // 
            this.URLDecode.AutoSize = true;
            this.URLDecode.Location = new System.Drawing.Point(6, 47);
            this.URLDecode.Name = "URLDecode";
            this.URLDecode.Size = new System.Drawing.Size(93, 19);
            this.URLDecode.TabIndex = 2;
            this.URLDecode.Text = "URL Dencode";
            this.URLDecode.UseVisualStyleBackColor = true;
            this.URLDecode.CheckedChanged += new System.EventHandler(this.Base64_CheckedChanged);
            // 
            // Base64Decode
            // 
            this.Base64Decode.AutoSize = true;
            this.Base64Decode.Location = new System.Drawing.Point(105, 45);
            this.Base64Decode.Name = "Base64Decode";
            this.Base64Decode.Size = new System.Drawing.Size(104, 19);
            this.Base64Decode.TabIndex = 2;
            this.Base64Decode.Text = "Base64 Decode";
            this.Base64Decode.UseVisualStyleBackColor = true;
            this.Base64Decode.CheckedChanged += new System.EventHandler(this.Base64_CheckedChanged);
            // 
            // URLEncode
            // 
            this.URLEncode.AutoSize = true;
            this.URLEncode.Checked = true;
            this.URLEncode.Location = new System.Drawing.Point(6, 22);
            this.URLEncode.Name = "URLEncode";
            this.URLEncode.Size = new System.Drawing.Size(86, 19);
            this.URLEncode.TabIndex = 2;
            this.URLEncode.TabStop = true;
            this.URLEncode.Text = "URL Encode";
            this.URLEncode.UseVisualStyleBackColor = true;
            this.URLEncode.CheckedChanged += new System.EventHandler(this.Base64_CheckedChanged);
            // 
            // HTMLDecode
            // 
            this.HTMLDecode.AutoSize = true;
            this.HTMLDecode.Location = new System.Drawing.Point(214, 47);
            this.HTMLDecode.Name = "HTMLDecode";
            this.HTMLDecode.Size = new System.Drawing.Size(97, 19);
            this.HTMLDecode.TabIndex = 2;
            this.HTMLDecode.Text = "HTML Decode";
            this.HTMLDecode.UseVisualStyleBackColor = true;
            this.HTMLDecode.CheckedChanged += new System.EventHandler(this.Base64_CheckedChanged);
            // 
            // HTMLEncode
            // 
            this.HTMLEncode.AutoSize = true;
            this.HTMLEncode.Location = new System.Drawing.Point(214, 22);
            this.HTMLEncode.Name = "HTMLEncode";
            this.HTMLEncode.Size = new System.Drawing.Size(96, 19);
            this.HTMLEncode.TabIndex = 2;
            this.HTMLEncode.Text = "HTML Encode";
            this.HTMLEncode.UseVisualStyleBackColor = true;
            this.HTMLEncode.CheckedChanged += new System.EventHandler(this.Base64_CheckedChanged);
            // 
            // Base64Encode
            // 
            this.Base64Encode.AutoSize = true;
            this.Base64Encode.Location = new System.Drawing.Point(105, 22);
            this.Base64Encode.Name = "Base64Encode";
            this.Base64Encode.Size = new System.Drawing.Size(103, 19);
            this.Base64Encode.TabIndex = 2;
            this.Base64Encode.Text = "Base64 Encode";
            this.Base64Encode.UseVisualStyleBackColor = true;
            this.Base64Encode.CheckedChanged += new System.EventHandler(this.Base64_CheckedChanged);
            // 
            // buttonEx
            // 
            this.buttonEx.ForeColor = System.Drawing.Color.Black;
            this.buttonEx.Location = new System.Drawing.Point(606, 43);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(80, 23);
            this.buttonEx.TabIndex = 1;
            this.buttonEx.Text = "Switch";
            this.buttonEx.UseVisualStyleBackColor = true;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // btnProc
            // 
            this.btnProc.Enabled = false;
            this.btnProc.ForeColor = System.Drawing.Color.Black;
            this.btnProc.Location = new System.Drawing.Point(606, 14);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(80, 23);
            this.btnProc.TabIndex = 1;
            this.btnProc.Text = "Go";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // panelFrst
            // 
            this.panelFrst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFrst.Controls.Add(this.linkLabelLoadFile);
            this.panelFrst.Controls.Add(this.groupBox1);
            this.panelFrst.Controls.Add(this.linkLabelCopToClip);
            this.panelFrst.Controls.Add(this.linkLabel1);
            this.panelFrst.Location = new System.Drawing.Point(13, 7);
            this.panelFrst.Name = "panelFrst";
            this.panelFrst.Size = new System.Drawing.Size(887, 185);
            this.panelFrst.TabIndex = 18;
            // 
            // linkLabelLoadFile
            // 
            this.linkLabelLoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelLoadFile.AutoSize = true;
            this.linkLabelLoadFile.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabelLoadFile.Location = new System.Drawing.Point(655, 163);
            this.linkLabelLoadFile.Name = "linkLabelLoadFile";
            this.linkLabelLoadFile.Size = new System.Drawing.Size(53, 15);
            this.linkLabelLoadFile.TabIndex = 17;
            this.linkLabelLoadFile.TabStop = true;
            this.linkLabelLoadFile.Text = "Load file";
            this.linkLabelLoadFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLoadFile_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.richTextBox_String);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 160);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OutPut";
            // 
            // richTextBox_String
            // 
            this.richTextBox_String.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_String.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_String.ForeColor = System.Drawing.Color.Black;
            this.richTextBox_String.Location = new System.Drawing.Point(3, 19);
            this.richTextBox_String.Name = "richTextBox_String";
            this.richTextBox_String.Size = new System.Drawing.Size(881, 138);
            this.richTextBox_String.TabIndex = 0;
            this.richTextBox_String.Text = "";
            this.richTextBox_String.TextChanged += new System.EventHandler(this.richTextBox_Enc_TextChanged);
            // 
            // linkLabelCopToClip
            // 
            this.linkLabelCopToClip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelCopToClip.AutoSize = true;
            this.linkLabelCopToClip.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabelCopToClip.Location = new System.Drawing.Point(714, 163);
            this.linkLabelCopToClip.Name = "linkLabelCopToClip";
            this.linkLabelCopToClip.Size = new System.Drawing.Size(100, 15);
            this.linkLabelCopToClip.TabIndex = 3;
            this.linkLabelCopToClip.TabStop = true;
            this.linkLabelCopToClip.Text = "Copy To Clipboard";
            this.linkLabelCopToClip.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyInput_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(833, 163);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(48, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Reverse";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lnklBL_Close
            // 
            this.lnklBL_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklBL_Close.AutoSize = true;
            this.lnklBL_Close.LinkColor = System.Drawing.Color.Red;
            this.lnklBL_Close.Location = new System.Drawing.Point(900, 3);
            this.lnklBL_Close.Name = "lnklBL_Close";
            this.lnklBL_Close.Size = new System.Drawing.Size(15, 15);
            this.lnklBL_Close.TabIndex = 15;
            this.lnklBL_Close.TabStop = true;
            this.lnklBL_Close.Text = "X";
            this.lnklBL_Close.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklBL_Close_LinkClicked);
            // 
            // FrmMRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMRCode";
            this.Opacity = 0.96D;
            this.ShowIcon = false;
            this.Text = "Base64";
            this.Load += new System.EventHandler(this.FrmMRCode_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelThird.ResumeLayout(false);
            this.panelThird.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panelSec.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelFrst.ResumeLayout(false);
            this.panelFrst.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProc;
        private System.Windows.Forms.RichTextBox richTextBox_Result;
        private System.Windows.Forms.RichTextBox richTextBox_String;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lnklBL_Close;
        private System.Windows.Forms.LinkLabel linkLabel_Rev_Result;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Base64Decode;
        private System.Windows.Forms.RadioButton Base64Encode;
        private System.Windows.Forms.RadioButton URLDecode;
        private System.Windows.Forms.RadioButton URLEncode;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabelCopToClip;
        private System.Windows.Forms.Panel panelSec;
        private System.Windows.Forms.Panel panelFrst;
        private System.Windows.Forms.Panel panelThird;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.LinkLabel linkLabelLoadFile;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.RadioButton ToAscii;
        private System.Windows.Forms.CheckBox checkBox_Use_separatorToAscii;
        private System.Windows.Forms.ComboBox comboBoxToAscii;
        private System.Windows.Forms.RadioButton HTMLDecode;
        private System.Windows.Forms.RadioButton HTMLEncode;
        private System.Windows.Forms.ComboBox comboBox_FromAscii;
        private System.Windows.Forms.RadioButton FromAscii;
        private System.Windows.Forms.Label label1;
    }
}