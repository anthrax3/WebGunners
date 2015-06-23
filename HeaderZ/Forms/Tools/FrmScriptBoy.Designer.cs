namespace Web_Gunners.Forms.Tools
{
    partial class FrmScriptBoy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadCurrent = new System.Windows.Forms.Button();
            this.labelNotf = new System.Windows.Forms.Label();
            this.labelInLinkScript = new System.Windows.Forms.Label();
            this.labelAllscripts = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtxbx_document = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtxbx_document_new = new System.Windows.Forms.RichTextBox();
            this.txbxSearchpatern = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbFile = new System.Windows.Forms.RadioButton();
            this.RbURL = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMatches = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblMatches);
            this.panel1.Controls.Add(this.btnLoadCurrent);
            this.panel1.Controls.Add(this.labelNotf);
            this.panel1.Controls.Add(this.labelInLinkScript);
            this.panel1.Controls.Add(this.labelAllscripts);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.txbxSearchpatern);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 511);
            this.panel1.TabIndex = 0;
            // 
            // btnLoadCurrent
            // 
            this.btnLoadCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoadCurrent.Location = new System.Drawing.Point(715, 462);
            this.btnLoadCurrent.Name = "btnLoadCurrent";
            this.btnLoadCurrent.Size = new System.Drawing.Size(138, 23);
            this.btnLoadCurrent.TabIndex = 27;
            this.btnLoadCurrent.Text = "Load Current";
            this.btnLoadCurrent.UseVisualStyleBackColor = false;
            this.btnLoadCurrent.Click += new System.EventHandler(this.btnLoadCurrent_Click);
            // 
            // labelNotf
            // 
            this.labelNotf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNotf.AutoSize = true;
            this.labelNotf.Location = new System.Drawing.Point(328, 491);
            this.labelNotf.Name = "labelNotf";
            this.labelNotf.Size = new System.Drawing.Size(16, 13);
            this.labelNotf.TabIndex = 26;
            this.labelNotf.Text = "...";
            // 
            // labelInLinkScript
            // 
            this.labelInLinkScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInLinkScript.AutoSize = true;
            this.labelInLinkScript.Location = new System.Drawing.Point(94, 491);
            this.labelInLinkScript.Name = "labelInLinkScript";
            this.labelInLinkScript.Size = new System.Drawing.Size(67, 13);
            this.labelInLinkScript.TabIndex = 25;
            this.labelInLinkScript.Text = "In Link script";
            this.labelInLinkScript.TextChanged += new System.EventHandler(this.labelInLinkScript_TextChanged);
            // 
            // labelAllscripts
            // 
            this.labelAllscripts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelAllscripts.AutoSize = true;
            this.labelAllscripts.Location = new System.Drawing.Point(27, 491);
            this.labelAllscripts.Name = "labelAllscripts";
            this.labelAllscripts.Size = new System.Drawing.Size(51, 13);
            this.labelAllscripts.TabIndex = 25;
            this.labelAllscripts.Text = "All scripts";
            this.labelAllscripts.TextChanged += new System.EventHandler(this.labelInLinkScript_TextChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel2.Location = new System.Drawing.Point(640, 468);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(45, 13);
            this.linkLabel2.TabIndex = 24;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Copy All";
            this.linkLabel2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(10, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 384);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(827, 358);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtxbx_document);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(819, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Original Document";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxbx_document
            // 
            this.rtxbx_document.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxbx_document.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtxbx_document.Location = new System.Drawing.Point(-2, -1);
            this.rtxbx_document.Name = "rtxbx_document";
            this.rtxbx_document.Size = new System.Drawing.Size(821, 333);
            this.rtxbx_document.TabIndex = 1;
            this.rtxbx_document.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtxbx_document_new);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(819, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "New Document";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtxbx_document_new
            // 
            this.rtxbx_document_new.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxbx_document_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtxbx_document_new.Location = new System.Drawing.Point(-2, -1);
            this.rtxbx_document_new.Name = "rtxbx_document_new";
            this.rtxbx_document_new.Size = new System.Drawing.Size(818, 330);
            this.rtxbx_document_new.TabIndex = 1;
            this.rtxbx_document_new.Text = "";
            // 
            // txbxSearchpatern
            // 
            this.txbxSearchpatern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbxSearchpatern.Location = new System.Drawing.Point(23, 461);
            this.txbxSearchpatern.Name = "txbxSearchpatern";
            this.txbxSearchpatern.Size = new System.Drawing.Size(341, 20);
            this.txbxSearchpatern.TabIndex = 2;
            this.txbxSearchpatern.TextChanged += new System.EventHandler(this.txbxSearchpatern_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.RbFile);
            this.groupBox1.Controls.Add(this.RbURL);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(10, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // RbFile
            // 
            this.RbFile.AutoSize = true;
            this.RbFile.Location = new System.Drawing.Point(6, 42);
            this.RbFile.Name = "RbFile";
            this.RbFile.Size = new System.Drawing.Size(41, 17);
            this.RbFile.TabIndex = 3;
            this.RbFile.TabStop = true;
            this.RbFile.Text = "File";
            this.RbFile.UseVisualStyleBackColor = true;
            // 
            // RbURL
            // 
            this.RbURL.AutoSize = true;
            this.RbURL.Location = new System.Drawing.Point(6, 19);
            this.RbURL.Name = "RbURL";
            this.RbURL.Size = new System.Drawing.Size(47, 17);
            this.RbURL.TabIndex = 3;
            this.RbURL.TabStop = true;
            this.RbURL.Text = "URL";
            this.RbURL.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Location = new System.Drawing.Point(755, 16);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 43);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Load Original";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.textBox1.Location = new System.Drawing.Point(59, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(677, 18);
            this.textBox1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMatches
            // 
            this.lblMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMatches.AutoSize = true;
            this.lblMatches.Location = new System.Drawing.Point(370, 467);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(16, 13);
            this.lblMatches.TabIndex = 28;
            this.lblMatches.Text = "...";
            // 
            // FrmScriptBoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(871, 521);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmScriptBoy";
            this.Text = "Gunners Beta 1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtxbx_document;
        private System.Windows.Forms.RichTextBox rtxbx_document_new;
        private System.Windows.Forms.TextBox txbxSearchpatern;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelAllscripts;
        private System.Windows.Forms.Label labelInLinkScript;
        private System.Windows.Forms.RadioButton RbURL;
        private System.Windows.Forms.RadioButton RbFile;
        private System.Windows.Forms.Label labelNotf;
        private System.Windows.Forms.Button btnLoadCurrent;
        private System.Windows.Forms.Label lblMatches;
    }
}