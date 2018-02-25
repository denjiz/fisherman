using System;
using Fisherman.DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fisherman.Tests
{
    [TestClass]
    public class FishingRecordRepository_Test
    {
        private FishingRecord record1, record2;

        public FishingRecordRepository_Test()
        {
            record1 = EntityGenerator.GetFishingRecord1();
            record2 = EntityGenerator.GetFishingRecord2();
        }

        [TestInitialize]
        public void ReInitializeFishingRecordRepository()
        {
            FishingRecordRepository.GetInstance().DeleteAllRecords();
        }

        [TestMethod]
        public void Test_AddFishingRecord()
        {
            FishingRecordRepository repository = FishingRecordRepository.GetInstance();
            repository.AddRecord(record1);

            Assert.AreEqual(1, repository.Count());
        }

        [TestMethod]
        public void Test_GetFishingRecord()
        {
            FishingRecordRepository repository = FishingRecordRepository.GetInstance();
            repository.AddRecord(record1);
            FishingRecord recordGet = repository.GetRecord(0);

            Assert.AreEqual(record1, recordGet);
        }

        [TestMethod]
        public void Test_UpdateFishingRecord()
        {
            FishingRecordRepository repository = FishingRecordRepository.GetInstance();
            repository.AddRecord(record1);
            repository.UpdateRecord(0, record2);
            FishingRecord recordGet = repository.GetRecord(0);
            
            Assert.AreEqual(record1, recordGet);

            string expectedLocation = "Medulin";
            string resultLocation = recordGet.Location.Name;
            Assert.AreEqual(expectedLocation, resultLocation);
        }

        [TestMethod]
        public void Test_DeleteRecord()
        {
            FishingRecordRepository repository = FishingRecordRepository.GetInstance();
            repository.AddRecord(record1);
            repository.DeleteRecord(0);

            Assert.AreEqual(0, repository.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(FishingRecordAlreadyExistsException))]
        public void Test_AddSameFishingRecordTwice()
        {
            FishingRecordRepository repository = FishingRecordRepository.GetInstance();
            repository.AddRecord(record1);
            repository.AddRecord(record1);
        }

        [TestMethod]
        [ExpectedException(typeof(FishingRecordsInCollisionException))]
        public void Test_AddFishingRecordInCollision1()
        {
            FishingRecordRepository repository = FishingRecordRepository.GetInstance();
            repository.AddRecord(record1);
            record2.DateTimeInterval = new DateTimeInterval(new DateTime(2013, 9, 1, 11, 00, 00), new DateTime(2013, 9, 1, 13, 00, 00));
            repository.AddRecord(record2);
        }

        [TestMethod]
        [ExpectedException(typeof(FishingRecordsInCollisionException))]
        public void Test_AddFishingRecordInCollision2()
        {
            FishingRecordRepository repository = FishingRecordRepository.GetInstance();
            repository.AddRecord(record1);
            record2.DateTimeInterval = new DateTimeInterval(new DateTime(2013, 9, 1, 11, 00, 00), new DateTime(2013, 9, 1, 17, 00, 00));
            repository.AddRecord(record2);
        }

        [TestMethod]
        [ExpectedException(typeof(FishingRecordsInCollisionException))]
        public void Test_AddFishingRecordInCollision3()
        {
            FishingRecordRepository repository = FishingRecordRepository.GetInstance();
            repository.AddRecord(record1);
            record2.DateTimeInterval = new DateTimeInterval(new DateTime(2013, 9, 1, 13, 00, 00), new DateTime(2013, 9, 1, 17, 00, 00));
            repository.AddRecord(record2);
        }

        [TestMethod]
        [ExpectedException(typeof(FishingRecordDoesntExistException))]
        public void Test_GetFishingRecordThanDoesntExist()
        {
            FishingRecordRepository repository = FishingRecordRepository.GetInstance();
            repository.GetRecord(0);
        }

        [TestMethod]
        [ExpectedException(typeof(FishingRecordDoesntExistException))]
        public void Test_UpdateFishingRecordThanDoesntExist()
        {
            FishingRecordRepository repository = FishingRecordRepository.GetInstance();
            repository.UpdateRecord(0, record1);
        }

        [TestMethod]
        [ExpectedException(typeof(FishingRecordDoesntExistException))]
        public void Test_DeleteFishingRecordThanDoesntExist()
        {
            FishingRecordRepository repository = FishingRecordRepository.GetInstance();
            repository.DeleteRecord(0);
        }
    }
}
