using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quantum.Domain.Trading;

namespace Telephone.Presentation.WinForm
{
    public partial class FormLogin : Form
    {
        private IAccount _account;
        public IAccount Account
        {
            get { return _account; }
        }

        public FormLogin()
        {
            InitializeComponent();
        }        

        private void LoadAllAccountNames()
        {
            comAccounts.Items.Clear();

            var dicAccounts = ConfigHelper.GetAllAppSettings();
            if (dicAccounts != null)
            {
                foreach (var it in dicAccounts)
                {
                    comAccounts.Items.Add(it.Key);
                }
            }
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            lbWarning.Visible = false;
            LoadAllAccountNames();
        }

        private void FormAccount_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ShowMessage(string message)
        {
            if(string.IsNullOrEmpty(message))
            {
                lbWarning.Visible = false;
            }

            lbWarning.Text = message;
            lbWarning.Visible = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string accountName = comAccounts.Text;
            if (string.IsNullOrEmpty(accountName))
            {
                ShowMessage("请先填写要注册的账户名称");
                return;
            }
            if(comAccounts.Items.Contains(accountName))
            {
                ShowMessage("系统已经存在要注册的账户名称");
                return;
            }

            var account = Broker.CreateAccount(accountName);
            if (account == null)
            {
                ShowMessage("注册账户失败，请重试");
                return;
            }
            comAccounts.Items.Add(accountName);
            SaveAccountConfig(account);
            ShowMessage("账户注册成功");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string accountName = comAccounts.Text;
            if(string.IsNullOrEmpty(accountName))
            {
                ShowMessage("请选择要登录的账户");
                return;
            }

            string accountId = ConfigHelper.GetAppSettingsValue(accountName);
            _account = Broker.LoadAccountData(accountId);
            if (_account == null)
            {
                ShowMessage("系统不存在该账户");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SaveAccountConfig(IAccount account)
        {
            if (account == null)
                return;
            
            ConfigHelper.UpdateAppSettings(account.Name, account.Id);
            Broker.SaveAccountData(account);
        }
    }
}
