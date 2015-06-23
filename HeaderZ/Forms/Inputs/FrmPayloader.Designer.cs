namespace Web_Gunners.Forms
{
    partial class FrmPayloader
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
            this.txbx = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.rBENabled = new System.Windows.Forms.RadioButton();
            this.RbDisabled = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txbx);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.rBENabled);
            this.panel1.Controls.Add(this.RbDisabled);
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 194);
            this.panel1.TabIndex = 0;
            // 
            // txbx
            // 
            this.txbx.Enabled = false;
            this.txbx.Location = new System.Drawing.Point(93, 111);
            this.txbx.Name = "txbx";
            this.txbx.Size = new System.Drawing.Size(239, 23);
            this.txbx.TabIndex = 4;
            this.txbx.Text = "http://a7a.net";
            this.txbx.TextChanged += new System.EventHandler(this.txbx_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "URl",
            "Integer",
            "IPv4",
            "Ipv6",
            "Email",
            "String",
            "Mobile",
            "Fax",
            "HTML",
            "JavaScript",
            "Host",
            "Post code"});
            this.comboBox1.Location = new System.Drawing.Point(93, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(257, 154);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Enabled = false;
            this.btnOk.Location = new System.Drawing.Point(93, 154);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // rBENabled
            // 
            this.rBENabled.AutoSize = true;
            this.rBENabled.ForeColor = System.Drawing.Color.White;
            this.rBENabled.Location = new System.Drawing.Point(7, 69);
            this.rBENabled.Name = "rBENabled";
            this.rBENabled.Size = new System.Drawing.Size(65, 19);
            this.rBENabled.TabIndex = 1;
            this.rBENabled.TabStop = true;
            this.rBENabled.Text = "Enabled";
            this.rBENabled.UseVisualStyleBackColor = true;
            this.rBENabled.CheckedChanged += new System.EventHandler(this.rBENabled_CheckedChanged);
            // 
            // RbDisabled
            // 
            this.RbDisabled.AutoSize = true;
            this.RbDisabled.ForeColor = System.Drawing.Color.White;
            this.RbDisabled.Location = new System.Drawing.Point(7, 28);
            this.RbDisabled.Name = "RbDisabled";
            this.RbDisabled.Size = new System.Drawing.Size(69, 19);
            this.RbDisabled.TabIndex = 0;
            this.RbDisabled.TabStop = true;
            this.RbDisabled.Text = "Disabled";
            this.RbDisabled.UseVisualStyleBackColor = true;
            // 
            // FrmPayloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 206);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPayloader";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Payloader";
            this.Load += new System.EventHandler(this.FrmPayloader_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbx;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton rBENabled;
        private System.Windows.Forms.RadioButton RbDisabled;
        private System.Windows.Forms.Button btnCancel;
    }
}