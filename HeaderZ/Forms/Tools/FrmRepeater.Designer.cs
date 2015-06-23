namespace Web_Gunners.Forms.Tools
{
    partial class FrmRepeater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepeater));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lnklBL_Close = new System.Windows.Forms.LinkLabel();
            this.lblNotf = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChbxColors = new System.Windows.Forms.CheckBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.panelDAD = new System.Windows.Forms.Panel();
            this.gpxResponse = new System.Windows.Forms.GroupBox();
            this.rtxbx_response = new System.Windows.Forms.RichTextBox();
            this.gpxRequest = new System.Windows.Forms.GroupBox();
            this.RtxbxRequest = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txbxPaternRequest_ = new System.Windows.Forms.TextBox();
            this.txbxPaternResponse = new System.Windows.Forms.TextBox();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDAD.SuspendLayout();
            this.gpxResponse.SuspendLayout();
            this.gpxRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContainer.BackColor = System.Drawing.SystemColors.InfoText;
            this.panelContainer.Controls.Add(this.txbxPaternResponse);
            this.panelContainer.Controls.Add(this.txbxPaternRequest_);
            this.panelContainer.Controls.Add(this.linkLabel1);
            this.panelContainer.Controls.Add(this.lnklBL_Close);
            this.panelContainer.Controls.Add(this.lblNotf);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Controls.Add(this.panelDAD);
            this.panelContainer.Controls.Add(this.btnSend);
            this.panelContainer.Location = new System.Drawing.Point(3, 3);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(919, 514);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.SizeChanged += new System.EventHandler(this.panelContainer_SizeChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(869, 492);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 15);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "parser";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.parser_LinkClicked);
            // 
            // lnklBL_Close
            // 
            this.lnklBL_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklBL_Close.AutoSize = true;
            this.lnklBL_Close.LinkColor = System.Drawing.Color.Red;
            this.lnklBL_Close.Location = new System.Drawing.Point(904, 3);
            this.lnklBL_Close.Name = "lnklBL_Close";
            this.lnklBL_Close.Size = new System.Drawing.Size(15, 15);
            this.lnklBL_Close.TabIndex = 15;
            this.lnklBL_Close.TabStop = true;
            this.lnklBL_Close.Text = "X";
            this.lnklBL_Close.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklBL_Close_LinkClicked);
            // 
            // lblNotf
            // 
            this.lblNotf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNotf.AutoSize = true;
            this.lblNotf.Location = new System.Drawing.Point(16, 492);
            this.lblNotf.Name = "lblNotf";
            this.lblNotf.Size = new System.Drawing.Size(16, 15);
            this.lblNotf.TabIndex = 5;
            this.lblNotf.Text = "...";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.ChbxColors);
            this.panel1.Controls.Add(this.lblHost);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(318, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 23);
            this.panel1.TabIndex = 4;
            // 
            // ChbxColors
            // 
            this.ChbxColors.AutoSize = true;
            this.ChbxColors.Location = new System.Drawing.Point(546, 2);
            this.ChbxColors.Name = "ChbxColors";
            this.ChbxColors.Size = new System.Drawing.Size(33, 19);
            this.ChbxColors.TabIndex = 1;
            this.ChbxColors.Text = "E";
            this.ChbxColors.UseVisualStyleBackColor = true;
            this.ChbxColors.CheckedChanged += new System.EventHandler(this.ChbxColors_CheckedChanged);
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(13, 4);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(30, 15);
            this.lblHost.TabIndex = 2;
            this.lblHost.Text = "Host";
            this.lblHost.TextChanged += new System.EventHandler(this.lblHost_TextChanged);
            this.lblHost.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelDAD
            // 
            this.panelDAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDAD.BackColor = System.Drawing.Color.Maroon;
            this.panelDAD.Controls.Add(this.gpxResponse);
            this.panelDAD.Controls.Add(this.gpxRequest);
            this.panelDAD.Location = new System.Drawing.Point(6, 30);
            this.panelDAD.Name = "panelDAD";
            this.panelDAD.Size = new System.Drawing.Size(904, 455);
            this.panelDAD.TabIndex = 3;
            // 
            // gpxResponse
            // 
            this.gpxResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxResponse.BackColor = System.Drawing.Color.LightGray;
            this.gpxResponse.Controls.Add(this.rtxbx_response);
            this.gpxResponse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gpxResponse.Location = new System.Drawing.Point(454, 5);
            this.gpxResponse.Name = "gpxResponse";
            this.gpxResponse.Size = new System.Drawing.Size(446, 447);
            this.gpxResponse.TabIndex = 0;
            this.gpxResponse.TabStop = false;
            this.gpxResponse.Text = "Response";
            this.gpxResponse.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rtxbx_response
            // 
            this.rtxbx_response.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxbx_response.BackColor = System.Drawing.SystemColors.InfoText;
            this.rtxbx_response.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtxbx_response.ForeColor = System.Drawing.Color.White;
            this.rtxbx_response.Location = new System.Drawing.Point(4, 22);
            this.rtxbx_response.Name = "rtxbx_response";
            this.rtxbx_response.Size = new System.Drawing.Size(440, 419);
            this.rtxbx_response.TabIndex = 0;
            this.rtxbx_response.Text = "";
            this.rtxbx_response.TextChanged += new System.EventHandler(this.rtxbx_response_TextChanged);
            // 
            // gpxRequest
            // 
            this.gpxRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpxRequest.BackColor = System.Drawing.Color.LightGray;
            this.gpxRequest.Controls.Add(this.RtxbxRequest);
            this.gpxRequest.Location = new System.Drawing.Point(3, 3);
            this.gpxRequest.Name = "gpxRequest";
            this.gpxRequest.Size = new System.Drawing.Size(430, 447);
            this.gpxRequest.TabIndex = 0;
            this.gpxRequest.TabStop = false;
            this.gpxRequest.Text = "Request";
            // 
            // RtxbxRequest
            // 
            this.RtxbxRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RtxbxRequest.BackColor = System.Drawing.SystemColors.InfoText;
            this.RtxbxRequest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RtxbxRequest.ForeColor = System.Drawing.Color.White;
            this.RtxbxRequest.Location = new System.Drawing.Point(4, 22);
            this.RtxbxRequest.Name = "RtxbxRequest";
            this.RtxbxRequest.Size = new System.Drawing.Size(424, 419);
            this.RtxbxRequest.TabIndex = 0;
            this.RtxbxRequest.Text = resources.GetString("RtxbxRequest.Text");
            this.RtxbxRequest.TextChanged += new System.EventHandler(this.RtxbxRequest_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(16, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = ">";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txbxPaternRequest_
            // 
            this.txbxPaternRequest_.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txbxPaternRequest_.Location = new System.Drawing.Point(6, 486);
            this.txbxPaternRequest_.Name = "txbxPaternRequest_";
            this.txbxPaternRequest_.Size = new System.Drawing.Size(349, 23);
            this.txbxPaternRequest_.TabIndex = 17;
            this.txbxPaternRequest_.TextChanged += new System.EventHandler(this.txbxPaternRequest__TextChanged);
            // 
            // txbxPaternResponse
            // 
            this.txbxPaternResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbxPaternResponse.Location = new System.Drawing.Point(617, 486);
            this.txbxPaternResponse.Name = "txbxPaternResponse";
            this.txbxPaternResponse.Size = new System.Drawing.Size(290, 23);
            this.txbxPaternResponse.TabIndex = 17;
            this.txbxPaternResponse.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FrmRepeater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.panelContainer);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmRepeater";
            this.Opacity = 0.97D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Repeater";
            this.Load += new System.EventHandler(this.FrmRepeater_Load);
            this.SizeChanged += new System.EventHandler(this.FrmRepeater_SizeChanged);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDAD.ResumeLayout(false);
            this.gpxResponse.ResumeLayout(false);
            this.gpxRequest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.GroupBox gpxResponse;
        private System.Windows.Forms.GroupBox gpxRequest;
        private System.Windows.Forms.RichTextBox rtxbx_response;
        private System.Windows.Forms.RichTextBox RtxbxRequest;
        private System.Windows.Forms.CheckBox ChbxColors;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelDAD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNotf;
        private System.Windows.Forms.LinkLabel lnklBL_Close;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txbxPaternResponse;
        private System.Windows.Forms.TextBox txbxPaternRequest_;
    }
}