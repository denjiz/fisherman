using System;
using System.Collections.Generic;
using System.ComponentModel;
using Fisherman.DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fisherman.Tests
{
    [TestClass]
    public class Search_Test
    {
        private List<FishingRecord> records;
        private List<FishingRecord> recordsFound;
        private List<SearchParam> _params;

        public Search_Test()
        {
            records = new List<FishingRecord>();
            records.Add(EntityGenerator.GetFishingRecord1());
            records.Add(EntityGenerator.GetFishingRecord2());

            recordsFound = new List<FishingRecord>();
            _params = new List<SearchParam>();
        }

        [TestInitialize]
        public void EmptySearchParams()
        {
            _params.Clear();
        }

        [TestMethod]
        public void Test_SearchLocationName()
        {
            _params.Add(new SearchParamLocation("Medulin"));
            recordsFound = Search.Find(records, _params);

            Assert.AreEqual(1, recordsFound.Count);
            Assert.IsTrue(recordsFound.Contains(records[1]));
        }

        [TestMethod]
        public void Test_SearchMonth()
        {
            _params.Add(new SearchParamMonth(9));
            recordsFound = Search.Find(records, _params);

            Assert.AreEqual(2, recordsFound.Count);
            Assert.IsTrue(recordsFound.Contains(records[0]));
            Assert.IsTrue(recordsFound.Contains(records[1]));
        }

        [TestMethod]
        public void Test_SearchMoonPhase()
        {
            _params.Add(new SearchParamMoonPhase(MoonPhases.newMoon));
            recordsFound = Search.Find(records, _params);

            Assert.AreEqual(1, recordsFound.Count);
            Assert.IsTrue(recordsFound.Contains(records[0]));
        }

        [TestMethod]
        public void Test_SearchTide()
        {
            _params.Add(new SearchParamTide(Tides.waterRising));
            recordsFound = Search.Find(records, _params);

            Assert.AreEqual(2, recordsFound.Count);
            Assert.IsTrue(recordsFound.Contains(records[0]));
            Assert.IsTrue(recordsFound.Contains(records[1]));
        }

        [TestMethod]
        public void Test_SearchWind()
        {
            _params.Add(new SearchParamWind(Winds.N));
            recordsFound = Search.Find(records, _params);

            Assert.AreEqual(1, recordsFound.Count);
            Assert.IsTrue(recordsFound.Contains(records[1]));
        }

        [TestMethod]
        public void Test_SearchYear()
        {
            _params.Add(new SearchParamYear(2013));
            recordsFound = Search.Find(records, _params);

            Assert.AreEqual(2, recordsFound.Count);
            Assert.IsTrue(recordsFound.Contains(records[0]));
            Assert.IsTrue(recordsFound.Contains(records[1]));
        }

        [TestMethod]
        public void Test_SearchMultipleParams()
        {
            _params.Add(new SearchParamYear(2013));
            _params.Add(new SearchParamMonth(9));
            _params.Add(new SearchParamLocation("Verudela"));
            recordsFound = Search.Find(records, _params);

            Assert.AreEqual(1, recordsFound.Count);
            Assert.IsTrue(recordsFound.Contains(records[0]));
        }

        [TestMethod]
        public void Test_SearchMultipleParamsNothingFound()
        {
            _params.Add(new SearchParamYear(2013));
            _params.Add(new SearchParamMonth(9));
            _params.Add(new SearchParamLocation("Pula"));
            recordsFound = Search.Find(records, _params);

            Assert.AreEqual(0, recordsFound.Count);
        }
    }
}
