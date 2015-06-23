namespace Web_Gunners.Forms.Tools
{
    partial class JersiProxiFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JersiProxiFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCPS = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.RbNone = new System.Windows.Forms.RadioButton();
            this.rb_Custom = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxIp = new System.Windows.Forms.TextBox();
            this.NmPort = new System.Windows.Forms.NumericUpDown();
            this.btn_close = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmPort)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCPS);
            this.panel1.Controls.Add(this.lblChange);
            this.panel1.Controls.Add(this.RbNone);
            this.panel1.Controls.Add(this.rb_Custom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbxIp);
            this.panel1.Controls.Add(this.NmPort);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 187);
            this.panel1.TabIndex = 0;
            // 
            // lblCPS
            // 
            this.lblCPS.AutoSize = true;
            this.lblCPS.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCPS.Location = new System.Drawing.Point(14, 168);
            this.lblCPS.Name = "lblCPS";
            this.lblCPS.Size = new System.Drawing.Size(35, 13);
            this.lblCPS.TabIndex = 6;
            this.lblCPS.Text = "label3";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Location = new System.Drawing.Point(195, 168);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(35, 13);
            this.lblChange.TabIndex = 5;
            this.lblChange.Text = "label3";
            this.lblChange.TextChanged += new System.EventHandler(this.lblChange_TextChanged);
            // 
            // RbNone
            // 
            this.RbNone.AutoSize = true;
            this.RbNone.ForeColor = System.Drawing.Color.White;
            this.RbNone.Location = new System.Drawing.Point(14, 112);
            this.RbNone.Name = "RbNone";
            this.RbNone.Size = new System.Drawing.Size(67, 17);
            this.RbNone.TabIndex = 4;
            this.RbNone.TabStop = true;
            this.RbNone.Text = "No proxy";
            this.RbNone.UseVisualStyleBackColor = true;
            this.RbNone.CheckedChanged += new System.EventHandler(this.RbNone_CheckedChanged);
            // 
            // rb_Custom
            // 
            this.rb_Custom.AutoSize = true;
            this.rb_Custom.ForeColor = System.Drawing.Color.White;
            this.rb_Custom.Location = new System.Drawing.Point(14, 27);
            this.rb_Custom.Name = "rb_Custom";
            this.rb_Custom.Size = new System.Drawing.Size(60, 17);
            this.rb_Custom.TabIndex = 4;
            this.rb_Custom.TabStop = true;
            this.rb_Custom.Text = "Custom";
            this.rb_Custom.UseVisualStyleBackColor = true;
            this.rb_Custom.CheckedChanged += new System.EventHandler(this.Rb_custom_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host";
            // 
            // txbxIp
            // 
            this.txbxIp.Enabled = false;
            this.txbxIp.Location = new System.Drawing.Point(124, 45);
            this.txbxIp.Name = "txbxIp";
            this.txbxIp.Size = new System.Drawing.Size(120, 20);
            this.txbxIp.TabIndex = 0;
            this.txbxIp.Text = "127.0.0.1";
            this.txbxIp.TextChanged += new System.EventHandler(this.txbxIp_TextChanged);
            // 
            // NmPort
            // 
            this.NmPort.Enabled = false;
            this.NmPort.Location = new System.Drawing.Point(124, 71);
            this.NmPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.NmPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NmPort.Name = "NmPort";
            this.NmPort.Size = new System.Drawing.Size(120, 20);
            this.NmPort.TabIndex = 1;
            this.NmPort.Value = new decimal(new int[] {
            8080,
            0,
            0,
            0});
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(141, 135);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(103, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(14, 135);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(106, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Set";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(14, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "This Changes system proxy ";
            // 
            // JersiProxiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 211);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JersiProxiFrm";
            this.Opacity = 0.88D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jersi Proxy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxIp;
        private System.Windows.Forms.NumericUpDown NmPort;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton RbNone;
        private System.Windows.Forms.RadioButton rb_Custom;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblCPS;
        private System.Windows.Forms.Label label3;
    }
}