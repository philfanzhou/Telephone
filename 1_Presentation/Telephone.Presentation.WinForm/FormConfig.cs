using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone.Presentation.WinForm
{
    public partial class FormConfig : Form
    {
        private string _serverAddress = "http://quantum1234.cloudapp.net:6688/api";
        public string ServerAddress
        {
            get { return _serverAddress; }
        }

        public FormConfig()
        {
            InitializeComponent();
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            var serverAddress = ConfigHelper.GetConnectionStrings("ServerAddress");
            if (!string.IsNullOrEmpty(serverAddress))
                _serverAddress = serverAddress;
            txtSrvAddress.Text = _serverAddress;
        }

        private void FormConfig_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _serverAddress = txtSrvAddress.Text;
            ConfigHelper.UpdateConnectionStrings("ServerAddress", _serverAddress);
            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
