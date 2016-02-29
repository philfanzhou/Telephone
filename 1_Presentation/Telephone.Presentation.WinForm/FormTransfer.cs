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
    public partial class FormTransfer : Form
    {
        public string Type { get; set; }

        public decimal Money { get; set; }

        public FormTransfer()
        {
            InitializeComponent();
        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            this.Text = Type;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMoney.Text.Trim()))
            {
                lbWarning.Text = "请输入转账金额";
                lbWarning.Visible = true;
                return;
            }

            try
            {
                Money = decimal.Parse(txtMoney.Text.Trim());
            }
            catch(Exception)
            {
                lbWarning.Text = "转账金额输入不正确";
                lbWarning.Visible = true;
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
