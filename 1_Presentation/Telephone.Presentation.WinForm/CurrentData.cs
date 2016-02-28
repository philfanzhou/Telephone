using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quantum.Domain.Trading;
using Telephone.Application.Information;

namespace Telephone.Presentation.WinForm
{
    public class CurrentData
    {
        private static CurrentData instance = new CurrentData();
        public static CurrentData Instance
        {
            get { return instance; }
        }

        public BindingSource BindSources { get; set; }
        public DataReader DateReader { get; set; }
        public IAccount Account { get; set; }

        public CurrentData()
        {
            BindSources = new BindingSource();
            DateReader = new DataReader();
        } 

        public static DataTable GetDataSource(IEnumerable<IHoldingsRecord> holdingsRecord)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("股票代码", typeof(string));
            dt.Columns.Add("持仓数量", typeof(int));
            dt.Columns.Add("成本", typeof(double));
            dt.Columns.Add("浮动盈亏", typeof(decimal));
            dt.Columns.Add("盈亏比例", typeof(float));
            dt.Columns.Add("市值", typeof(decimal));
            dt.Columns.Add("冻结数量", typeof(string));
            dt.Columns.Add("可卖数量", typeof(string));

            if (holdingsRecord != null && holdingsRecord.Count() > 0)
            {
                foreach (var it in holdingsRecord)
                {
                    if (it != null)
                    {
                        DataRow dr = dt.NewRow();
                        dr["股票代码"] = it.StockCode;
                        dr["持仓数量"] = it.Quantity;
                        dr["成本"] = it.GetCost();
                        dr["浮动盈亏"] = it.GetFloatingProfitAndLoss();
                        dr["盈亏比例"] = it.GetProportion();
                        dr["市值"] = it.GetMarketValue();
                        dr["冻结数量"] = it.GetFrozenQuantity(DateTime.Now);
                        dr["可卖数量"] = it.GetAvailableQuantity(DateTime.Now);
                        dt.Rows.Add(dr);
                    }
                }            
            }

            return dt;
        }
    }
}
