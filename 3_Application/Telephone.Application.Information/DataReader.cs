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

        //获取所有服务名称
        public IEnumerable<string> GetCollectionServices()
        {
            var client = ClientFactory.CreateCollectionStatusClient(serverAddress);
            return client.GetAllServiceName();
        }

        //获取指定服务状态
        public string GetServiceStatus(string serviceName)
        {
            var client = ClientFactory.CreateCollectionStatusClient(serverAddress);
            return client.GetStatus(serviceName);
        }

        //获取股票实时数据
        public IEnumerable<IStockRealTime> GetStockRealTimeData(IEnumerable<string> stockCodes)
        {
            var client = ClientFactory.CreateRealTimeClient(serverAddress);
            return client.GetLatest(stockCodes).Cast<IStockRealTime>();
        }

        //获取分时数据
        public IEnumerable<IStockIntraday> GetIntradayData(string stockCode, DateTime startDate, DateTime endDate)
        {
            var client = ClientFactory.CreateIntradayClient(serverAddress);
            return client.GetData(stockCode, startDate, endDate).Cast<IStockIntraday>();
        }

        //获取K线1分钟数据
        public IEnumerable<IStockKLine> GetKLineBy1Minute(string stockCode, DateTime startDate, DateTime endDate)
        {
            var client = ClientFactory.CreateKLineClient(serverAddress);
            return client.GetBy1Minute(stockCode, startDate, endDate).Cast<IStockKLine>();
        }
    }
}
