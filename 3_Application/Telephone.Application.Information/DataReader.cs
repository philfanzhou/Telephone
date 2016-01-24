using Ore.Infrastructure.MarketData;
using Pitman.RESTful.Client;
using System;
using System.Collections.Generic;

namespace Telephone.Application.Information
{
    public class DataReader
    {
        private string serverAddress = "http://quantum1234.cloudapp.net:6688/api";

        //获取所有服务名称
        public IEnumerable<string> GetCollectionServices()
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetAllServiceName();
            }
        }

        //获取指定服务状态
        public string GetServiceStatus(string serviceName)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetServiceStatus(serviceName);
            }
        }

        //获取股票实时数据
        public IEnumerable<IStockRealTime> GetStockRealTimeData(IEnumerable<string> stockCodes)
        {
            //var client = ClientFactory.CreateRealTimeClient(serverAddress);
            //return client.GetLatest(stockCodes).Cast<IStockRealTime>();

            /*调用Sina API进行实现，引用已添加*/
            throw new NotImplementedException();
        }

        //获取分时数据
        public IEnumerable<IStockIntraday> GetIntradayData(string stockCode, DateTime startDate, DateTime endDate)
        {
            /*暂未实现*/
            throw new NotImplementedException();
        }

        //获取K线1分钟数据
        public IEnumerable<IStockKLine> GetKLineBy1Minute(string stockCode, DateTime startDate, DateTime endDate)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetStockKLine(KLineType.Min1, stockCode, startDate, endDate);
            }
        }
    }
}
