using System;
using System.Collections.Generic;
using Fisherman.DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fisherman.Tests
{
    [TestClass]
    public class Statistics_Test
    {
        private List<FishingRecord> records;

        public Statistics_Test()
        {
            records = new List<FishingRecord>();
            records.Add(EntityGenerator.GetFishingRecord1());
            records.Add(EntityGenerator.GetFishingRecord2());
        }

        [TestMethod]
        public void Test_GetTotalCatchMass()
        {
            double expected = 21.5;
            double result = Statistics.GetTotalCatchMass(records);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_GetTotalCatchProfit()
        {
            double expected = 820.0;
            double result = Statistics.GetTotalCatchProfit(records);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Test_GetTotalMassPerFish()
        {
            double expected = 4.5;
            Dictionary<string, double> result = Statistics.GetTotalMassPerFish(records);

            Assert.AreEqual(expected, result["brancin"]);
        }

        [TestMethod]
        public void Test_GetTotalProfitPerFish()
        {
            double expected = 500.0;
            Dictionary<string, double> result = Statistics.GetTotalProfitPerFish(records);

            Assert.AreEqual(expected, result["tuna"]);
        }

        [TestMethod]
        public void Test_GetTotalTimeInHours()
        {
            double expected = 8.0;
            double result = Statistics.GetTotalTimeInHours(records);

            Assert.AreEqual(expected, result);
        }
    }
}
