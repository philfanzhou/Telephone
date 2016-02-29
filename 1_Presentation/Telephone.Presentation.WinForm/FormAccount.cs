using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quantum.Domain.Trading;

namespace Telephone.Presentation.WinForm
{
    public partial class FormAccount : Form
    {
        private IAccount _account;

        public FormAccount(IAccount account)
        {
            InitializeComponent();

            _account = account;
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            ShowMessage("");
            ShowAccountInfo(_account);
        }

        private void FormAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            // SaveData
            if (AccountExist(_account))
                Broker.SaveAccountData(_account);
        }

        private void ShowMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                tsslMessages.Visible = false;
            }

            tsslMessages.Text = message;
            tsslMessages.Visible = true;
        }

        private bool AccountExist(IAccount account)
        {
            if (account == null)
            {
                return false;
            }
            return true;
        }

        private void ShowAccountInfo(IAccount account)
        {
            if (account == null)
                return;

            this.Text = string.Format("账户：{0} ID：{1}", account.Name, account.Id);
            this.lbPrincipal.Text = string.Format("本金：{0}", account.Principal.ToString());// 本金            
            this.lbBalance.Text = string.Format("余额：{0}", account.Balance.ToString());// 余额
            this.lbTotalAssets.Text = string.Format("总资产：{0}", account.TotalAssets.ToString());// 总资产 - 与实时行情相关
            this.lbMarketValue.Text = string.Format("总市值：{0}", account.MarketValue.ToString());// 持仓市值 - 与实时行情相关
        }

        private void DisplayHoldingsRecord(string stockCode = null)
        {
            string funName = string.IsNullOrEmpty(stockCode) ? "所有持仓记录查询" : "指定股票持仓记录查询";

            dataGridView.DataSource = null;
            if (!AccountExist(_account))
            {
                ShowMessage(funName + "：操作账户不存在");
                return;
            }
            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    this.Invoke(new EventHandler(delegate
                    {
                        if (string.IsNullOrEmpty(stockCode))
                        {
                            dataGridView.DataSource = CurrentData.GetDataSource(_account.GetAllHoldingsRecord());
                        }
                        else
                        {
                            var holdingsRecord = _account.GetHoldingsRecord(stockCode);
                            dataGridView.DataSource = CurrentData.GetDataSource(new IHoldingsRecord[] { holdingsRecord });
                        }
                        ShowMessage(funName + "：成功");
                    }));
                }));
            }
            catch (Exception ex)
            {
                ShowMessage(funName + "：失败 " + ex.InnerException.Message);
            }
        }

        private void tsmBuy_Click(object sender, EventArgs e)
        {
            string funName = "买入";
            if (!AccountExist(_account))
            {
                ShowMessage(funName + "：操作账户不存在");
                return;
            }

            FormTrading frmTrading = new FormTrading(funName, _account);
            if (DialogResult.OK == frmTrading.ShowDialog(this))
            {
                ShowAccountInfo(_account);
                ShowMessage(funName + "：操作成功");
            }
        }

        private void tsmSell_Click(object sender, EventArgs e)
        {
            string funName = "卖出";
            if (!AccountExist(_account))
            {
                ShowMessage(funName + "：操作账户不存在");
                return;
            }

            FormTrading frmTrading = new FormTrading(funName, _account);
            if (DialogResult.OK == frmTrading.ShowDialog(this))
            {
                ShowAccountInfo(_account);
                ShowMessage(funName + "：操作成功");
            }
        }

        private void tsmHoldings_Click(object sender, EventArgs e)
        {
            DisplayHoldingsRecord();
        }

        private void tsmTradingRecord_Click(object sender, EventArgs e)
        {
            string funName = "所有交易记录查询";

            dataGridView.DataSource = null;
            if (!AccountExist(_account))
            {
                ShowMessage(funName + "：操作账户不存在");
                return;
            }
            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = _account.GetAllTradingRecord();
                        ShowMessage(funName + "：成功");
                    }));
                }));
            }
            catch (Exception ex)
            {
                ShowMessage(funName + "：失败 " + ex.InnerException.Message);
            }
        }

        private void tsmHoldingsAll_Click(object sender, EventArgs e)
        {
            DisplayHoldingsRecord();
        }

        private void tsmHoldingsSpecified_Click(object sender, EventArgs e)
        {
            FormQuery frmQuery = new FormQuery(1);
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            DisplayHoldingsRecord(frmQuery.StockCode);
        }

        private void tsmTransferIn_Click(object sender, EventArgs e)
        {
            string funName = "银行转券商";
            if (AccountExist(_account))
            {
                FormTransfer frmTransfer = new FormTransfer();
                frmTransfer.Type = funName;
                if (DialogResult.OK == frmTransfer.ShowDialog(this))
                {
                    _account.TransferIn(frmTransfer.Money);
                    ShowAccountInfo(_account);
                }
            }
        }

        private void tsmTransferOut_Click(object sender, EventArgs e)
        {
            string funName = "券商转银行";
            if (AccountExist(_account))
            {
                FormTransfer frmTransfer = new FormTransfer();
                frmTransfer.Type = funName;
                if (DialogResult.OK == frmTransfer.ShowDialog(this))
                {
                    _account.TransferOut(frmTransfer.Money);
                    ShowAccountInfo(_account);
                }
            }
        }
    }
}
