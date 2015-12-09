using Ore.Infrastructure.MarketData;
using Pitman.Presentation.RESTfulClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone.Application.Information
{
    public class DataReader
    {
        private string serverAddress = "http://quantum1234.cloudapp.net:6688";

        public IEnumerable<string> GetCollectionServices()
        {
            var client = ClientFactory.CreateCollectionStatusClient(serverAddress);
            return client.GetAllServiceName();
        }

        public IEnumerable<IStockIntraday> GetIntradayData()
        {
            var client = ClientFactory.CreateIntradayClient(serverAddress);
            return client.GetData("600036", DateTime.Now, DateTime.Now).Cast<IStockIntraday>();
        }
    }
}
