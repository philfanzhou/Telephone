using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public BindingSource CurrBindSrc { get; set; }
        public DataReader CurrDateRead { get; set; }

        public CurrentData()
        {
            CurrBindSrc = new BindingSource();
            CurrDateRead = new DataReader();
        }


    }
}
