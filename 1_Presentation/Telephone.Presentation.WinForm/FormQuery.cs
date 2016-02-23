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

namespace Telephone.Presentation.WinForm
{
    public partial class FormQuery : Form
    {
        public List<string> StockCodes { get; private set; }
        public string StockCode { get; private set; }
        public DateTime BgnDate { get; private set; }
        public DateTime EndDate { get; private set; }

        private int queryType = 0;

        public FormQuery()
        {
            InitializeComponent();

            queryType = 0;
        }

        public FormQuery(int nType)
        {
            InitializeComponent();

            queryType = nType;
        }

        private void FormQuery_Load(object sender, EventArgs e)
        {
            this.lbAlarm.Text = "";
            txtStockCode.Text = "600036";
            dtpBgnDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;

            if(this.queryType == 1)
            {
                lbBgnDate.Visible = false;
                lbEndDate.Visible = false;
                dtpBgnDate.Visible = false;
                dtpBgnTime.Visible = false;
                dtpEndDate.Visible = false;
                dtpEndTime.Visible = false;
            }
        }

        private void FormQuery_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var matchCodes = Regex.Matches(txtStockCode.Text, @"\d{6}");            
            if(matchCodes == null || matchCodes.Count < 1)
            {
                lbAlarm.Text = "请重新输入股票代码！";
                lbAlarm.Visible = true;
                return;
            }

            if (this.StockCodes == null)
                this.StockCodes = new List<string>();
            this.StockCodes.Clear();
            
            foreach (Match it in matchCodes)
            {
                this.StockCodes.Add(it.Value);
            }

            StockCode = matchCodes[0].Value;
            BgnDate = new DateTime(
                dtpBgnDate.Value.Year, 
                dtpBgnDate.Value.Month, 
                dtpBgnDate.Value.Day, 
                dtpBgnTime.Value.Hour,
                dtpBgnTime.Value.Minute,
                dtpBgnTime.Value.Second);
            EndDate = new DateTime(
                dtpEndDate.Value.Year,
                dtpEndDate.Value.Month,
                dtpEndDate.Value.Day,
                dtpEndTime.Value.Hour,
                dtpEndTime.Value.Minute,
                dtpEndTime.Value.Second);            

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
