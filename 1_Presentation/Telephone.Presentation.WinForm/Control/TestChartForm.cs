using Ore.Infrastructure.MarketData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Telephone.Presentation.WinForm.Control;

namespace Telephone.Presentation.WinForm
{
    public partial class TestChartForm : Form
    {
        public TestChartForm()
        {
            InitializeComponent();
        }

        private void TestChartForm_Load(object sender, EventArgs e)
        {
            this.dtpStart.Value = DateTime.Now.AddDays(-30);
        }

        private void btnDayChart_Click(object sender, EventArgs e)
        {
            IEnumerable<IStockKLine> tickers = CurrentData.Instance.CurrDateReader.GetKLineDay(this.txtTicker.Text.Trim(), this.dtpStart.Value, DateTime.Now);
            IEnumerable<IStockKLine> tickersEx = CurrentData.Instance.CurrDateReader.GetKLineDay(this.txtTicker.Text.Trim(), this.dtpStart.Value.AddDays(-30), DateTime.Now);
            CandleChart.SetPicboxChart(this.pbChart, tickers.ToList(), tickersEx.ToList());
        }

        private void btnCapitalChart_Click(object sender, EventArgs e)
        {
            IEnumerable<IParticipation> participations = CurrentData.Instance.CurrDateReader.GetParticipationData(this.txtTicker.Text.Trim());
            List<IParticipation> realParticipations = new List<IParticipation>();
            foreach (IParticipation p in participations)
            {
                DateTime dtStart = this.dtpStart.Value;
                if (p.Time >= dtStart)
                {
                    realParticipations.Add(p);
                }
            }
            CandleChart.SetPicboxChart(this.pbChart, realParticipations);
        }
    }
}
