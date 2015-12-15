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
                var lstSrv = CurrentData.Instance.CurrDateRead.GetCollectionServices();
                StringBuilder sb = new StringBuilder("服务状态：");
                foreach (var it in lstSrv)
                {
                    sb.Append(string.Format("{0}[{1}], ", it, CurrentData.Instance.CurrDateRead.GetServiceStatus(it)));
                }
                tsslSrvStatus.Text = sb.ToString(0, sb.Length - 2);

                tsslCurrent.Text = "服务状态查询：成功";
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

        }

        private void tsmCleanup_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
        }

        private void tsmSysStatus_Click(object sender, EventArgs e)
        {
            GetSysStatus();
        }

        private void tsmRealTime_Click(object sender, EventArgs e)
        {
            tsslCurrent.Text = "实时数据查询";
            FormQuery frmQuery = new FormQuery(1);
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            var lstStockCodes = frmQuery.StockCodes;

            try
            {
                dataGridView.DataSource = CurrentData.Instance.CurrBindSrc;
                CurrentData.Instance.CurrBindSrc.DataSource = CurrentData.Instance.CurrDateRead.GetStockRealTimeData(lstStockCodes);

                tsslCurrent.Text = "实时数据查询：成功";
            }
            catch(Exception ex)
            {
                tsslCurrent.Text = "实时数据查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmTimeShare_Click(object sender, EventArgs e)
        {
            tsslCurrent.Text = "分时数据查询";
            FormQuery frmQuery = new FormQuery();
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;

            string stockCode = frmQuery.StockCode;
            DateTime bgnDate = frmQuery.BgnDate;
            DateTime endDate = frmQuery.EndDate;

            try
            {
                dataGridView.DataSource = CurrentData.Instance.CurrBindSrc;
                CurrentData.Instance.CurrBindSrc.DataSource = CurrentData.Instance.CurrDateRead.GetIntradayData(stockCode, bgnDate, endDate);

                tsslCurrent.Text = "分时数据查询：成功";
            }
            catch(Exception ex)
            {
                tsslCurrent.Text = "分时数据查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmKLine_Click(object sender, EventArgs e)
        {
            tsslCurrent.Text = "K线数据查询";
            FormQuery frmQuery = new FormQuery();
            if (DialogResult.OK != frmQuery.ShowDialog())
                return;
            
            string stockCode = frmQuery.StockCode;
            DateTime startDate = frmQuery.BgnDate;
            DateTime endDate = frmQuery.EndDate;

            try
            {
                dataGridView.DataSource = CurrentData.Instance.CurrBindSrc;
                CurrentData.Instance.CurrBindSrc.DataSource = CurrentData.Instance.CurrDateRead.GetKLineBy1Minute(stockCode, startDate, endDate);

                tsslCurrent.Text = "K线数据查询：成功";
            }
            catch(Exception ex)
            {
                tsslCurrent.Text = "K线数据查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmStockStructure_Click(object sender, EventArgs e)
        {
            tsslCurrent.Text = "股本结构信息查询";
            try
            {

                tsslCurrent.Text = "股本结构信息查询:成功";
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "股本结构信息查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmDividendDistribution_Click(object sender, EventArgs e)
        {
            tsslCurrent.Text = "分红分配信息查询";

            try
            {

                tsslCurrent.Text = "分红分配信息查询:成功";
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "分红分配信息查询：失败" + ex.InnerException.Message;
            }
        }

        private void tsmBasicInfo_Click(object sender, EventArgs e)
        {
            tsslCurrent.Text = "基本面信息查询";

            try
            {

                tsslCurrent.Text = "基本面信息查询:成功";
            }
            catch (Exception ex)
            {
                tsslCurrent.Text = "基本面信息查询：失败" + ex.InnerException.Message;
            }
        }

    }
}
