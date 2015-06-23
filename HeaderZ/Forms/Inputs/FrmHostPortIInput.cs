using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Gunners.Forms.Tools
{
    public partial class FrmHostPortIInput : Form
    {
        public RequestDetails HostAndPort = new RequestDetails(80);
        public FrmHostPortIInput()
        {
            InitializeComponent();
        }
        public FrmHostPortIInput(RequestDetails HostAndPort)
        {
            InitializeComponent();
            this.HostAndPort.useHttps = HostAndPort.useHttps;
            this.HostAndPort.port =nmPort.Value= HostAndPort.port;
            this.HostAndPort.host =TxbxHost.Text= HostAndPort.host;
            numericUpDown1.Value = this.HostAndPort.TimeOut = HostAndPort.TimeOut;
      
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           this.DialogResult = System.Windows.Forms.DialogResult.OK; 
           this.HostAndPort.host = TxbxHost.Text;
           this.HostAndPort.port= int.Parse(nmPort.Value.ToString());
           this.HostAndPort.useHttps = this.ChbxHTTPS.Checked;
           this.HostAndPort.TimeOut = int.Parse(this.numericUpDown1.Value.ToString());

            this.Close();
        }

        private void FrmHostPortIInput_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.MinimumSize = this.Size;
        }

        private void TxbxHost_TextChanged(object sender, EventArgs e)
        { 
            TxbxHost.Text = TxbxHost.Text.Trim();
           
            btnOk.Enabled = (TxbxHost.Text != ""  && TxbxHost.Text.isValidHost());
        }

        private void ChbxHTTPS_CheckedChanged(object sender, EventArgs e)
        { 
        }
    }
}
