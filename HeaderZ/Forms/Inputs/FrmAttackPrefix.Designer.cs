namespace Web_Gunners.Forms.Inputs
{
    partial class FrmAttackPrefix
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
            this.btnOk = new System.Windows.Forms.Button();
            this.gpx_injection = new System.Windows.Forms.GroupBox();
            this.rtxbx_Injection = new System.Windows.Forms.RichTextBox();
            this.checkBox_Injection = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxbxUserAgent = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.gpx_injection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.gpx_injection);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 246);
            this.panel1.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(113, 212);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gpx_injection
            // 
            this.gpx_injection.Controls.Add(this.rtxbx_Injection);
            this.gpx_injection.Controls.Add(this.checkBox_Injection);
            this.gpx_injection.Location = new System.Drawing.Point(10, 118);
            this.gpx_injection.Name = "gpx_injection";
            this.gpx_injection.Size = new System.Drawing.Size(313, 88);
            this.gpx_injection.TabIndex = 4;
            this.gpx_injection.TabStop = false;
            this.gpx_injection.Text = "Injection";
            // 
            // rtxbx_Injection
            // 
            this.rtxbx_Injection.Enabled = false;
            this.rtxbx_Injection.Location = new System.Drawing.Point(7, 43);
            this.rtxbx_Injection.Name = "rtxbx_Injection";
            this.rtxbx_Injection.Size = new System.Drawing.Size(300, 39);
            this.rtxbx_Injection.TabIndex = 1;
            this.rtxbx_Injection.Text = "";
            this.rtxbx_Injection.TextChanged += new System.EventHandler(this.rtxbx_Injection_TextChanged);
            // 
            // checkBox_Injection
            // 
            this.checkBox_Injection.AutoSize = true;
            this.checkBox_Injection.Location = new System.Drawing.Point(7, 20);
            this.checkBox_Injection.Name = "checkBox_Injection";
            this.checkBox_Injection.Size = new System.Drawing.Size(74, 17);
            this.checkBox_Injection.TabIndex = 0;
            this.checkBox_Injection.Text = "Customize";
            this.checkBox_Injection.UseVisualStyleBackColor = true;
            this.checkBox_Injection.CheckedChanged += new System.EventHandler(this.checkBox_Injection_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(113, 94);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(151, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label2.Location = new System.Drawing.Point(270, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TimeOut";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxbxUserAgent);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Agent";
            // 
            // rtxbxUserAgent
            // 
            this.rtxbxUserAgent.Location = new System.Drawing.Point(7, 18);
            this.rtxbxUserAgent.Name = "rtxbxUserAgent";
            this.rtxbxUserAgent.Size = new System.Drawing.Size(300, 52);
            this.rtxbxUserAgent.TabIndex = 1;
            this.rtxbxUserAgent.Text = "";
            this.rtxbxUserAgent.TextChanged += new System.EventHandler(this.rtxbxUserAgent_TextChanged);
            // 
            // FrmAttackPrefix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 251);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAttackPrefix";
            this.Opacity = 0.96D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Attack Customizer";
            this.Load += new System.EventHandler(this.FrmAttackDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpx_injection.ResumeLayout(false);
            this.gpx_injection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxbxUserAgent;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpx_injection;
        private System.Windows.Forms.CheckBox checkBox_Injection;
        private System.Windows.Forms.RichTextBox rtxbx_Injection;
        private System.Windows.Forms.Button btnOk;
    }
}