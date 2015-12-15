using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telephone.Application.Information;

namespace Test.Application.Information
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataReader reader = new DataReader();

            var serviceNames = reader.GetCollectionServices();

            var data = reader.GetIntradayData("600036", DateTime.Now, DateTime.Now);
        }
    }
}
