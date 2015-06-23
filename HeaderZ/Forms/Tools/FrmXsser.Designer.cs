namespace Web_Gunners.Forms.Tools
{
    partial class FrmXsser
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
            this.checkBoxPOST = new System.Windows.Forms.CheckBox();
            this.checkBoxGet = new System.Windows.Forms.CheckBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox_MassAssgi = new System.Windows.Forms.CheckBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbmediumLevel = new System.Windows.Forms.RadioButton();
            this.rbLowLevel = new System.Windows.Forms.RadioButton();
            this.groupBoxPOST = new System.Windows.Forms.GroupBox();
            this.groupBoxGet = new System.Windows.Forms.GroupBox();
            this.checkedListBox_GET_Pars = new System.Windows.Forms.CheckedListBox();
            this.GpxUrl = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxGet.SuspendLayout();
            this.GpxUrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.checkBoxPOST);
            this.panel1.Controls.Add(this.checkBoxGet);
            this.panel1.Controls.Add(this.groupBoxResult);
            this.panel1.Controls.Add(this.groupBoxPOST);
            this.panel1.Controls.Add(this.groupBoxGet);
            this.panel1.Controls.Add(this.GpxUrl);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 518);
            this.panel1.TabIndex = 0;
            // 
            // checkBoxPOST
            // 
            this.checkBoxPOST.AutoSize = true;
            this.checkBoxPOST.Location = new System.Drawing.Point(422, 189);
            this.checkBoxPOST.Name = "checkBoxPOST";
            this.checkBoxPOST.Size = new System.Drawing.Size(47, 17);
            this.checkBoxPOST.TabIndex = 1;
            this.checkBoxPOST.Text = "Post";
            this.checkBoxPOST.UseVisualStyleBackColor = true;
            this.checkBoxPOST.CheckedChanged += new System.EventHandler(this.checkBoxPOST_CheckedChanged);
            // 
            // checkBoxGet
            // 
            this.checkBoxGet.AutoSize = true;
            this.checkBoxGet.Checked = true;
            this.checkBoxGet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGet.Location = new System.Drawing.Point(422, 54);
            this.checkBoxGet.Name = "checkBoxGet";
            this.checkBoxGet.Size = new System.Drawing.Size(43, 17);
            this.checkBoxGet.TabIndex = 1;
            this.checkBoxGet.Text = "Get";
            this.checkBoxGet.UseVisualStyleBackColor = true;
            this.checkBoxGet.CheckedChanged += new System.EventHandler(this.checkBoxGet_CheckedChanged);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxResult.Controls.Add(this.button1);
            this.groupBoxResult.Controls.Add(this.richTextBox1);
            this.groupBoxResult.Controls.Add(this.checkBox_MassAssgi);
            this.groupBoxResult.Controls.Add(this.btnProceed);
            this.groupBoxResult.Controls.Add(this.radioButton2);
            this.groupBoxResult.Controls.Add(this.rbmediumLevel);
            this.groupBoxResult.Controls.Add(this.rbLowLevel);
            this.groupBoxResult.Location = new System.Drawing.Point(5, 301);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(908, 207);
            this.groupBoxResult.TabIndex = 3;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(162, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(346, 142);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // checkBox_MassAssgi
            // 
            this.checkBox_MassAssgi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_MassAssgi.AutoSize = true;
            this.checkBox_MassAssgi.Location = new System.Drawing.Point(22, 178);
            this.checkBox_MassAssgi.Name = "checkBox_MassAssgi";
            this.checkBox_MassAssgi.Size = new System.Drawing.Size(108, 17);
            this.checkBox_MassAssgi.TabIndex = 2;
            this.checkBox_MassAssgi.Text = "Mass Assignment";
            this.checkBox_MassAssgi.UseVisualStyleBackColor = true;
            this.checkBox_MassAssgi.CheckedChanged += new System.EventHandler(this.checkBox_MassAssgi_CheckedChanged);
            // 
            // btnProceed
            // 
            this.btnProceed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProceed.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnProceed.Location = new System.Drawing.Point(417, 178);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(75, 23);
            this.btnProceed.TabIndex = 1;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(22, 65);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Heigh Level";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbmediumLevel
            // 
            this.rbmediumLevel.AutoSize = true;
            this.rbmediumLevel.Location = new System.Drawing.Point(22, 42);
            this.rbmediumLevel.Name = "rbmediumLevel";
            this.rbmediumLevel.Size = new System.Drawing.Size(62, 17);
            this.rbmediumLevel.TabIndex = 0;
            this.rbmediumLevel.TabStop = true;
            this.rbmediumLevel.Text = "Medium";
            this.rbmediumLevel.UseVisualStyleBackColor = true;
            // 
            // rbLowLevel
            // 
            this.rbLowLevel.AutoSize = true;
            this.rbLowLevel.Location = new System.Drawing.Point(22, 19);
            this.rbLowLevel.Name = "rbLowLevel";
            this.rbLowLevel.Size = new System.Drawing.Size(74, 17);
            this.rbLowLevel.TabIndex = 0;
            this.rbLowLevel.TabStop = true;
            this.rbLowLevel.Text = "Low Level";
            this.rbLowLevel.UseVisualStyleBackColor = true;
            // 
            // groupBoxPOST
            // 
            this.groupBoxPOST.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPOST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxPOST.Location = new System.Drawing.Point(5, 212);
            this.groupBoxPOST.Name = "groupBoxPOST";
            this.groupBoxPOST.Size = new System.Drawing.Size(908, 74);
            this.groupBoxPOST.TabIndex = 2;
            this.groupBoxPOST.TabStop = false;
            this.groupBoxPOST.Text = "POST Details";
            // 
            // groupBoxGet
            // 
            this.groupBoxGet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBoxGet.Controls.Add(this.checkedListBox_GET_Pars);
            this.groupBoxGet.Location = new System.Drawing.Point(5, 74);
            this.groupBoxGet.Name = "groupBoxGet";
            this.groupBoxGet.Size = new System.Drawing.Size(908, 109);
            this.groupBoxGet.TabIndex = 2;
            this.groupBoxGet.TabStop = false;
            this.groupBoxGet.Text = "Get Details";
            // 
            // checkedListBox_GET_Pars
            // 
            this.checkedListBox_GET_Pars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox_GET_Pars.FormattingEnabled = true;
            this.checkedListBox_GET_Pars.Location = new System.Drawing.Point(3, 16);
            this.checkedListBox_GET_Pars.Name = "checkedListBox_GET_Pars";
            this.checkedListBox_GET_Pars.Size = new System.Drawing.Size(902, 90);
            this.checkedListBox_GET_Pars.TabIndex = 1;
            this.checkedListBox_GET_Pars.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_GET_Pars_ItemCheck);
            this.checkedListBox_GET_Pars.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_GET_Pars_SelectedIndexChanged);
            // 
            // GpxUrl
            // 
            this.GpxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpxUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GpxUrl.Controls.Add(this.textBox1);
            this.GpxUrl.Location = new System.Drawing.Point(5, 11);
            this.GpxUrl.Name = "GpxUrl";
            this.GpxUrl.Size = new System.Drawing.Size(908, 40);
            this.GpxUrl.TabIndex = 0;
            this.GpxUrl.TabStop = false;
            this.GpxUrl.Text = "Url";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(887, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "http://localhost/vuln/xss.php?c=1&p=2";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmXsser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmXsser";
            this.Text = "http://localhost/vuln/xss.php?p1=1&p2=2";
            this.Load += new System.EventHandler(this.FrmXsser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxGet.ResumeLayout(false);
            this.GpxUrl.ResumeLayout(false);
            this.GpxUrl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GpxUrl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxPOST;
        private System.Windows.Forms.CheckBox checkBoxGet;
        private System.Windows.Forms.GroupBox groupBoxPOST;
        private System.Windows.Forms.GroupBox groupBoxGet;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.RadioButton rbLowLevel;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbmediumLevel;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.CheckedListBox checkedListBox_GET_Pars;
        private System.Windows.Forms.CheckBox checkBox_MassAssgi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}