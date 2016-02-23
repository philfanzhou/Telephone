using Ore.Infrastructure.MarketData;
using Pitman.RESTful.Client;
using System;
using System.Collections.Generic;
using Ore.Infrastructure.MarketData.DataSource.Sina;
using System.Linq;

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

        #region 基本面数据

        public IEnumerable<ISecurity> GetAllSecurityData()
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetAllSecurity();
            }
        }

        public IEnumerable<IParticipation> GetParticipationData(string stockCode)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetParticipation(stockCode);
            }
        }

        public IEnumerable<IStockBonus> GetStockBonusData(string stockCode)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetStockBonus(stockCode);
            }
        }

        public IEnumerable<IStockKLine> GetStockKLineData(KLineType type, string stockCode, DateTime startTime, DateTime endTime)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetStockKLine(type, stockCode, startTime, endTime);
            }
        }

        public IStockProfile GetStockProfileData(string stockCode)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetStockProfile(stockCode);
            }
        }

        public IEnumerable<IStockStructure> GetStockStructureData(string stockCode)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetStockStructure(stockCode);
            }
        }

        #endregion
        
        #region KLine
        
        public IEnumerable<IStockKLine> GetKLineDay(string stockCode, DateTime startDate, DateTime endDate)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetStockKLine(KLineType.Day, stockCode, startDate, endDate);
            }
        }
        
        public IEnumerable<IStockKLine> GetKLineWeek(string stockCode, DateTime startDate, DateTime endDate)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetStockKLine(KLineType.Week, stockCode, startDate, endDate);
            }
        }
        
        public IEnumerable<IStockKLine> GetKLineMonth(string stockCode, DateTime startDate, DateTime endDate)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetStockKLine(KLineType.Month, stockCode, startDate, endDate);
            }
        }
        
        public IEnumerable<IStockKLine> GetKLineQuarter(string stockCode, DateTime startDate, DateTime endDate)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetStockKLine(KLineType.Quarter, stockCode, startDate, endDate);
            }
        }
        
        public IEnumerable<IStockKLine> GetKLineYear(string stockCode, DateTime startDate, DateTime endDate)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetStockKLine(KLineType.Year, stockCode, startDate, endDate);
            }
        }
        
        public IEnumerable<IStockKLine> GetKLineMin1(string stockCode, DateTime startDate, DateTime endDate)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetStockKLine(KLineType.Min1, stockCode, startDate, endDate);
            }
        }
        
        public IEnumerable<IStockKLine> GetKLineMin5(string stockCode, DateTime startDate, DateTime endDate)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetStockKLine(KLineType.Min5, stockCode, startDate, endDate);
            }
        }
        
        public IEnumerable<IStockKLine> GetKLineMin15(string stockCode, DateTime startDate, DateTime endDate)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetStockKLine(KLineType.Min15, stockCode, startDate, endDate);
            }
        }
        
        public IEnumerable<IStockKLine> GetKLineMin30(string stockCode, DateTime startDate, DateTime endDate)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetStockKLine(KLineType.Min30, stockCode, startDate, endDate);
            }
        }
        
        public IEnumerable<IStockKLine> GetKLineMin60(string stockCode, DateTime startDate, DateTime endDate)
        {
            using (var client = new ClientApi(serverAddress))
            {
                return client.GetStockKLine(KLineType.Min60, stockCode, startDate, endDate);
            }
        }

        #endregion

        //获取股票实时数据
        public IEnumerable<IStockRealTime> GetStockRealTimeData(IEnumerable<string> stockCodes)
        {
            //var client = ClientFactory.CreateRealTimeClient(serverAddress);
            //return client.GetLatest(stockCodes).Cast<IStockRealTime>();

            List<IStockRealTime> lstStockRealTime = new List<IStockRealTime>();

            /*调用Sina API进行实现，引用已添加*/
            StockRealTimeApi reader = new StockRealTimeApi();
            if (stockCodes.Count() > 1)
            {
                var datas = reader.GetData(stockCodes);
                foreach(var it in datas)
                {
                    lstStockRealTime.Add(it.Value);
                }
            }
            else
            {
                var data = reader.GetData(stockCodes.First());
                lstStockRealTime.Add(data);
            }
            return lstStockRealTime;
        }

        ////获取分时数据
        //public IEnumerable<IStockIntraday> GetIntradayData(string stockCode, DateTime startDate, DateTime endDate)
        //{
        //    /*暂未实现*/
        //    throw new NotImplementedException();
        //}
    }
}
