using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quantum.Domain.Trading;

namespace Telephone.Presentation.WinForm
{
    public partial class FormTrading : Form
    {
        private string _type = string.Empty;
        private IAccount _account;

        public string StockCode { get; set; }        

        public FormTrading(string type, IAccount account)
        {
            InitializeComponent();

            _type = type;
            _account = account;
        }

        private void InitializeInformation()
        {
            txtStockCode.Text = StockCode;

            lbPrice.Text = string.Format("{0}价格：", _type);
            lbMaxQuantity.Text = string.Format("最大可{0}：", _type);
            lbQuantity.Text = string.Format("{0}数量：", _type);
        }

        private void ShowMessage(string message = null)
        {
            if (string.IsNullOrEmpty(message))
            {
                lbWarning.Visible = false;
            }

            lbWarning.Text = message;
            lbWarning.Visible = true;
        }

        private void UpdateBuyPrice(double buy1Price, double buy2Price, double buy3Price, double buy4Price, double buy5Price)
        {
            lbBuy1.Text = string.Format("买一：{0}", (buy1Price <= 0 ? "" : buy1Price.ToString("0.00")));
            lbBuy2.Text = string.Format("买二：{0}", (buy2Price <= 0 ? "" : buy2Price.ToString("0.00")));
            lbBuy3.Text = string.Format("买三：{0}", (buy3Price <= 0 ? "" : buy3Price.ToString("0.00")));
            lbBuy4.Text = string.Format("买四：{0}", (buy4Price <= 0 ? "" : buy4Price.ToString("0.00")));
            lbBuy5.Text = string.Format("买五：{0}", (buy5Price <= 0 ? "" : buy5Price.ToString("0.00")));
        }

        private void UpdateSellPrice(double sell1Price, double sell2Price, double sell3Price, double sell4Price, double sell5Price)
        {
            lbSell1.Text = string.Format("卖一：{0}", (sell1Price <= 0 ? "" : sell1Price.ToString("0.00")));
            lbSell2.Text = string.Format("卖二：{0}", (sell2Price <= 0 ? "" : sell2Price.ToString("0.00")));
            lbSell3.Text = string.Format("卖三：{0}", (sell3Price <= 0 ? "" : sell3Price.ToString("0.00")));
            lbSell4.Text = string.Format("卖四：{0}", (sell4Price <= 0 ? "" : sell4Price.ToString("0.00")));
            lbSell5.Text = string.Format("卖五：{0}", (sell5Price <= 0 ? "" : sell5Price.ToString("0.00")));
        }
        
        private void FormTrading_Load(object sender, EventArgs e)
        {
            ShowMessage();
            InitializeInformation();
        }

        private void FormTrading_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStockCode.Text = "";
            numPrice.Value = 0;
            txtMaxQuantity.Text = "0";
            numQuantity.Value = 0;
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            string stockCode = Regex.Match(txtStockCode.Text.Trim(), @"\d{6}").Value;
            if (string.IsNullOrEmpty(stockCode))
            {
                ShowMessage("证券代码不合法");
                return;
            }
            if (_account == null)
            {
                ShowMessage("操作账户不存在");
                return;
            }
            
            if (_type.Equals("买入"))
            {
                if(!_account.Buy(DateTime.Now, stockCode, (double)numPrice.Value, (int)numQuantity.Value))
                {
                    ShowMessage("买入交易失败");
                    return;
                }
            }
            else if (_type.Equals("卖出"))
            {
                if (!_account.Sell(DateTime.Now, stockCode, (double)numPrice.Value, (int)numQuantity.Value))
                {
                    ShowMessage("卖出交易失败");
                    return;
                }
            }
            Broker.SaveAccountData(_account);

            DialogResult = DialogResult.OK;
        }

        private void txtStockCode_TextChanged(object sender, EventArgs e)
        {
            string stockCode = Regex.Match(txtStockCode.Text.Trim(), @"\d{6}").Value;
            if (string.IsNullOrEmpty(stockCode))
            {
                UpdateBuyPrice(0,0,0,0,0);
                UpdateSellPrice(0, 0, 0, 0, 0);
                return;
            }

            var lstStockRealTime = CurrentData.Instance.DateReader.GetStockRealTimeData(new string[] { stockCode }).ToList();
            if (lstStockRealTime != null && lstStockRealTime.Count > 0)
            {
                var stockRealTime = lstStockRealTime.First();
                if (stockRealTime != null)
                {
                    UpdateBuyPrice(stockRealTime.Buy1Price,
                                        stockRealTime.Buy2Price,
                                        stockRealTime.Buy3Price,
                                        stockRealTime.Buy4Price,
                                        stockRealTime.Buy5Price);

                    UpdateSellPrice(stockRealTime.Sell1Price,
                                        stockRealTime.Sell2Price,
                                        stockRealTime.Sell3Price,
                                        stockRealTime.Sell4Price,
                                        stockRealTime.Sell5Price);
                }

                if (_type.Equals("买入"))
                {
                    numPrice.Value = (decimal)stockRealTime.Buy1Price;                  
                }
                else if (_type.Equals("卖出"))
                {
                    numPrice.Value = (decimal)stockRealTime.Sell1Price;
                }
            }
        }

        private void txtMaxQuantity_TextChanged(object sender, EventArgs e)
        {
            string maxQuantity = Regex.Match(txtMaxQuantity.Text.Trim(), @"\d+").Value;
            if (string.IsNullOrEmpty(maxQuantity))
                return;

            try
            {
                numQuantity.Maximum = decimal.Parse(txtMaxQuantity.Text.Trim());
            }
            catch(Exception ex)
            {
                numQuantity.Maximum = 100000000;
                ShowMessage("数值转换错误：" + ex.Message);
            }
        }

        private void numPrice_ValueChanged(object sender, EventArgs e)
        {
            string stockCode = Regex.Match(txtStockCode.Text.Trim(), @"\d{6}").Value;
            if (string.IsNullOrEmpty(stockCode))
            {
                return;
            }

            if (_type.Equals("买入"))
            {
                if (_account != null)
                {
                    txtMaxQuantity.Text = _account.AvailableQuantityToBuy(stockCode, (double)numPrice.Value).ToString();
                }
            }
            else if (_type.Equals("卖出"))
            {
                if (_account != null)
                {
                    var holdingsRecord = _account.GetHoldingsRecord(stockCode);
                    if (holdingsRecord != null)
                        txtMaxQuantity.Text = holdingsRecord.GetAvailableQuantity(DateTime.Now).ToString();
                    else
                        txtMaxQuantity.Text = "0";
                }
            }            
        }

        private void lbPrice_Click(object sender, EventArgs e)
        {
            var price = sender as Label;
            if (price == null)
                return;

            string strPrice = price.Text.Trim().Substring(price.Text.Trim().IndexOf('：') + 1);
            try
            {
                numPrice.Value = decimal.Parse(strPrice);
            }
            catch(Exception ex)
            {
                ShowMessage("数值转换错误：" + ex.Message);
            }
        }
    }
}
