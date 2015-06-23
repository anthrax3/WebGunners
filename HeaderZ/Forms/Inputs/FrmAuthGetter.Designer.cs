namespace Web_Gunners.Forms.Inputs
{
    partial class FrmAuthGetter
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
            this.GpxMain = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbxMethod = new System.Windows.Forms.ComboBox();
            this.txbxPass = new System.Windows.Forms.TextBox();
            this.txbxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.GpxMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.GpxMain);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 202);
            this.panel1.TabIndex = 2;
            // 
            // GpxMain
            // 
            this.GpxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpxMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GpxMain.Controls.Add(this.label5);
            this.GpxMain.Controls.Add(this.label4);
            this.GpxMain.Controls.Add(this.label3);
            this.GpxMain.Controls.Add(this.btnCancel);
            this.GpxMain.Controls.Add(this.btnOK);
            this.GpxMain.Controls.Add(this.cmbxMethod);
            this.GpxMain.Controls.Add(this.txbxPass);
            this.GpxMain.Controls.Add(this.txbxUsername);
            this.GpxMain.Controls.Add(this.label2);
            this.GpxMain.Controls.Add(this.label1);
            this.GpxMain.ForeColor = System.Drawing.Color.White;
            this.GpxMain.Location = new System.Drawing.Point(5, 3);
            this.GpxMain.Name = "GpxMain";
            this.GpxMain.Size = new System.Drawing.Size(346, 193);
            this.GpxMain.TabIndex = 0;
            this.GpxMain.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "username";
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(67, 155);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(212, 155);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbxMethod
            // 
            this.cmbxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMethod.FormattingEnabled = true;
            this.cmbxMethod.Items.AddRange(new object[] {
            "Basic",
            "Digset"});
            this.cmbxMethod.Location = new System.Drawing.Point(67, 119);
            this.cmbxMethod.Name = "cmbxMethod";
            this.cmbxMethod.Size = new System.Drawing.Size(87, 21);
            this.cmbxMethod.TabIndex = 2;
            this.cmbxMethod.SelectedIndexChanged += new System.EventHandler(this.cmbxMethod_SelectedIndexChanged);
            // 
            // txbxPass
            // 
            this.txbxPass.Location = new System.Drawing.Point(67, 92);
            this.txbxPass.Name = "txbxPass";
            this.txbxPass.Size = new System.Drawing.Size(265, 20);
            this.txbxPass.TabIndex = 1;
            this.txbxPass.TextChanged += new System.EventHandler(this.txbxPass_TextChanged);
            // 
            // txbxUsername
            // 
            this.txbxUsername.Location = new System.Drawing.Point(67, 66);
            this.txbxUsername.Name = "txbxUsername";
            this.txbxUsername.Size = new System.Drawing.Size(265, 20);
            this.txbxUsername.TabIndex = 1;
            this.txbxUsername.TextChanged += new System.EventHandler(this.txbxUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = " the following form to enter username and password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "If you need authentication to Pass request, use";
            // 
            // FrmAuthGetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(359, 205);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAuthGetter";
            this.Opacity = 0.99D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auth";
            this.Load += new System.EventHandler(this.FrmAuthGetter_Load);
            this.panel1.ResumeLayout(false);
            this.GpxMain.ResumeLayout(false);
            this.GpxMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GpxMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbxMethod;
        private System.Windows.Forms.TextBox txbxPass;
        private System.Windows.Forms.TextBox txbxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}