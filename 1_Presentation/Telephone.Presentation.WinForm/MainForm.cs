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
using Telephone.Application.Information;

namespace Telephone.Presentation.WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            tsslCurrent.Text = "";
            tsslSysTime.Text = string.Format("系统时间：{0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void GetSysStatus()
        {
            tsslCurrent.Text = "服务状态查询";
            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    var lstSrv = CurrentData.Instance.DateReader.GetCollectionServices();
                    StringBuilder sb = new StringBuilder("服务状态：");
                    foreach (var it in lstSrv)
                    {
                        sb.Append(string.Format("{0}[{1}], ", it, CurrentData.Instance.DateReader.GetServiceStatus(it)));
                    }
                    this.Invoke(new EventHandler(delegate
                    {
                        tsslSrvStatus.Text = sb.ToString(0, sb.Length - 2);
                        tsslCurrent.Text = "服务状态查询：成功";
                    }));
                    
                }));
            }
            catch(Exception ex)
            {
                tsslCurrent.Text = "服务状态查询：失败" + ex.InnerException.Message;
            }
        }
                
        private void timerSys_Tick(object sender, EventArgs e)
        {
            tsslSysTime.Text = string.Format("系统时间：{0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
        
        private void tsmSetup_Click(object sender, EventArgs e)
        {
            FormConfig frmConfig = new FormConfig();
            if(DialogResult.OK == frmConfig.ShowDialog(this))
            {
                CurrentData.Instance.DateReader.ServerAddress = frmConfig.ServerAddress;
            }
        }

        private void tsmCleanup_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
        }

        private void tsmSysStatus_Click(object sender, EventArgs e)
        {
            GetSysStatus();
        }

        //实时数据查询
        private void tsmRealTime_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "实时数据查询";
            FormQuery frmQuery = new FormQuery(1);
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            var lstStockCodes = frmQuery.StockCodes;

            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {                    
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetStockRealTimeData(lstStockCodes);

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "实时数据查询：成功";
                    }));                    
                }));
            }
            catch(Exception ex)
            {
                tsslCurrent.Text = "实时数据查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmTimeShare_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "分时数据查询";

            MessageBox.Show("暂未实现");

            //FormQuery frmQuery = new FormQuery();
            //if (DialogResult.OK != frmQuery.ShowDialog())
            //    return;

            //string stockCode = frmQuery.StockCode;
            //DateTime bgnDate = frmQuery.BgnDate;
            //DateTime endDate = frmQuery.EndDate;

            //try
            //{
            //    ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            //    {                    
            //        CurrentData.Instance.CurrBindSrc.DataSource = CurrentData.Instance.CurrDateReader.GetIntradayData(stockCode, bgnDate, endDate);
                    
            //        this.Invoke(new EventHandler(delegate
            //        {
            //            dataGridView.DataSource = CurrentData.Instance.CurrBindSrc;
            //            tsslCurrent.Text = "分时数据查询：成功";
            //        }));
            //    }));
            //}
            //catch (Exception ex)
            //{
            //    tsslCurrent.Text = "分时数据查询：失败" + ex.InnerException.Message;
            //}
        }

        #region 基本面数据

        private void tsmStockStructure_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "股本结构信息查询";
            FormQuery frmQuery = new FormQuery(1);
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            var lstStockCodes = frmQuery.StockCodes;
            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetStockStructureData(lstStockCodes.First());

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "股本结构信息查询:成功";
                    }));
                }));                
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "股本结构信息查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmDividendDistribution_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "分红分配信息查询";
            FormQuery frmQuery = new FormQuery(1);
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            var lstStockCodes = frmQuery.StockCodes;
            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetStockBonusData(lstStockCodes.First());

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "分红分配信息查询:成功";
                    }));
                }));                
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "分红分配信息查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmBasicInfo_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "基本面信息查询";
            FormQuery frmQuery = new FormQuery(1);
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            var lstStockCodes = frmQuery.StockCodes;

            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetStockProfileData(lstStockCodes.First());

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "基本面信息查询:成功";
                    }));
                }));                
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "基本面信息查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmAllSecurity_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "所有证券代码信息";

            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetAllSecurityData();

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "所有证券代码信息:成功";
                    }));
                }));                
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "所有证券代码信息：失败" + ex.InnerException.Message;
            }
        }

        private void tsmParticipation_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "机构参与度数据查询";
            FormQuery frmQuery = new FormQuery(1);
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            var lstStockCodes = frmQuery.StockCodes;
            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetParticipationData(lstStockCodes.First());

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "机构参与度数据查询:成功";
                    }));
                }));
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "机构参与度数据查询：失败" + ex.InnerException.Message;
            }
        }

        #endregion

        #region KLine

        private void tsmKLineDay_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "日K线数据查询";
            FormQuery frmQuery = new FormQuery();
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            string stockCode = frmQuery.StockCode;
            DateTime startDate = frmQuery.BgnDate;
            DateTime endDate = frmQuery.EndDate;

            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetKLineDay(stockCode, startDate, endDate);

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "日K线数据查询：成功";
                    }));
                }));
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "日K线数据查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmKLineWeek_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "周K线数据查询";
            FormQuery frmQuery = new FormQuery();
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            string stockCode = frmQuery.StockCode;
            DateTime startDate = frmQuery.BgnDate;
            DateTime endDate = frmQuery.EndDate;

            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetKLineWeek(stockCode, startDate, endDate);

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "周K线数据查询：成功";
                    }));
                }));
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "周K线数据查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmKLineMonth_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "月K线数据查询";
            FormQuery frmQuery = new FormQuery();
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            string stockCode = frmQuery.StockCode;
            DateTime startDate = frmQuery.BgnDate;
            DateTime endDate = frmQuery.EndDate;

            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetKLineMonth(stockCode, startDate, endDate);

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "月K线数据查询：成功";
                    }));
                }));
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "月K线数据查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmKLineQuarter_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "季K线数据查询";
            FormQuery frmQuery = new FormQuery();
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            string stockCode = frmQuery.StockCode;
            DateTime startDate = frmQuery.BgnDate;
            DateTime endDate = frmQuery.EndDate;

            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetKLineQuarter(stockCode, startDate, endDate);

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "季K线数据查询：成功";
                    }));
                }));
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "季K线数据查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmKLineYear_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "年K线数据查询";
            FormQuery frmQuery = new FormQuery();
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            string stockCode = frmQuery.StockCode;
            DateTime startDate = frmQuery.BgnDate;
            DateTime endDate = frmQuery.EndDate;

            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetKLineYear(stockCode, startDate, endDate);

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "年K线数据查询：成功";
                    }));
                }));
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "年K线数据查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmKLineMin1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "1分钟K线数据查询";
            FormQuery frmQuery = new FormQuery();
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            string stockCode = frmQuery.StockCode;
            DateTime startDate = frmQuery.BgnDate;
            DateTime endDate = frmQuery.EndDate;

            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetKLineMin1(stockCode, startDate, endDate);

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "1分钟K线数据查询：成功";
                    }));
                }));
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "1分钟K线数据查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmKLineMin5_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "5分钟K线数据查询";
            FormQuery frmQuery = new FormQuery();
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            string stockCode = frmQuery.StockCode;
            DateTime startDate = frmQuery.BgnDate;
            DateTime endDate = frmQuery.EndDate;

            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetKLineMin5(stockCode, startDate, endDate);

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "5分钟K线数据查询：成功";
                    }));
                }));
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "5分钟K线数据查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmKLineMin15_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "15分钟K线数据查询";
            FormQuery frmQuery = new FormQuery();
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            string stockCode = frmQuery.StockCode;
            DateTime startDate = frmQuery.BgnDate;
            DateTime endDate = frmQuery.EndDate;

            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetKLineMin15(stockCode, startDate, endDate);

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "15分钟K线数据查询：成功";
                    }));
                }));
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "15分钟K线数据查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmKLineMin30_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "30分钟K线数据查询";
            FormQuery frmQuery = new FormQuery();
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            string stockCode = frmQuery.StockCode;
            DateTime startDate = frmQuery.BgnDate;
            DateTime endDate = frmQuery.EndDate;

            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetKLineMin30(stockCode, startDate, endDate);

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "30分钟K线数据查询：成功";
                    }));
                }));
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "30分钟K线数据查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmKLineMin60_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            tsslCurrent.Text = "60分钟K线数据查询";
            FormQuery frmQuery = new FormQuery();
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            string stockCode = frmQuery.StockCode;
            DateTime startDate = frmQuery.BgnDate;
            DateTime endDate = frmQuery.EndDate;

            try
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
                {
                    CurrentData.Instance.BindSources.DataSource = CurrentData.Instance.DateReader.GetKLineMin60(stockCode, startDate, endDate);

                    this.Invoke(new EventHandler(delegate
                    {
                        dataGridView.DataSource = CurrentData.Instance.BindSources;
                        tsslCurrent.Text = "60分钟K线数据查询：成功";
                    }));
                }));
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "60分钟K线数据查询：失败" + ex.InnerException.Message;
            }
        }

        #endregion

        private void tsmLogin_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            if(DialogResult.OK == frmLogin.ShowDialog(this))
            {
                CurrentData.Instance.Account = frmLogin.Account;
                tsslAccount.Text = string.Format("登录账户：{0} [ID:{1}]", 
                    CurrentData.Instance.Account.Name, CurrentData.Instance.Account.Id);
                FormAccount frmAccount = new FormAccount(CurrentData.Instance.Account);
                frmAccount.ShowDialog(this);
            }
        }

        private void 蜡炬图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestChartForm form = new TestChartForm();
            form.ShowDialog();
        }
    }
}
