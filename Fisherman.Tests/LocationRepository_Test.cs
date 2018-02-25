using System;
using Fisherman.DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fisherman.Tests
{
    [TestClass]
    public class LocationRepository_Test
    {
        private Location location1, location2;

        [TestInitialize]
        public void ReInitializeLocationRepository()
        {
            LocationRepository.GetInstance().DeleteAllLocations();
            location1 = EntityGenerator.GetLocation1();
            location2 = EntityGenerator.GetLocation2();
        }

        [TestMethod]
        public void Test_AddLocation()
        {
            LocationRepository repository = LocationRepository.GetInstance();
            repository.AddLocation(location1);

            Assert.AreEqual(1, repository.Count());
        }

        [TestMethod]
        public void Test_GetLocation()
        {
            LocationRepository repository = LocationRepository.GetInstance();
            repository.AddLocation(location1);
            Location locationGet = repository.GetLocation(0);

            Assert.AreEqual(location1, locationGet);
        }

        [TestMethod]
        public void Test_GetLocationByName()
        {
            LocationRepository repository = LocationRepository.GetInstance();
            repository.AddLocation(location1);
            Location locationGet = repository.GetLocation("Medulin");

            Assert.AreEqual(location1, locationGet);
        }

        [TestMethod]
        public void Test_UpdateLocation()
        {
            LocationRepository repository = LocationRepository.GetInstance();
            repository.AddLocation(location1);
            repository.UpdateLocation(0, location2);
            Location locationGet = repository.GetLocation(0);

            Assert.AreEqual(location1, locationGet);
            Assert.AreEqual(15, locationGet.Depth);
        }

        [TestMethod]
        public void Test_DeleteLocation()
        {
            LocationRepository repository = LocationRepository.GetInstance();
            repository.AddLocation(location1);
            repository.DeleteLocation(0);

            Assert.AreEqual(0, repository.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(LocationAlreadyExistsException))]
        public void Test_AddSameLocationTwice()
        {
            LocationRepository repository = LocationRepository.GetInstance();
            repository.AddLocation(location1);
            repository.AddLocation(location1);
        }

        [TestMethod]
        [ExpectedException(typeof(LocationDoesntExistException))]
        public void Test_GetLocationThanDoesntExist()
        {
            LocationRepository repository = LocationRepository.GetInstance();
            repository.GetLocation(0);
        }

        [TestMethod]
        [ExpectedException(typeof(LocationDoesntExistException))]
        public void Test_GetLocationByNameDoesntExist()
        {
            LocationRepository repository = LocationRepository.GetInstance();
            repository.AddLocation(location1);
            Location locationGet = repository.GetLocation("Pula");

            Assert.AreEqual(location1, locationGet);
        }

        [TestMethod]
        [ExpectedException(typeof(LocationDoesntExistException))]
        public void Test_UpdateLocationThanDoesntExist()
        {
            LocationRepository repository = LocationRepository.GetInstance();
            repository.UpdateLocation(0, location1);
        }

        [TestMethod]
        [ExpectedException(typeof(LocationAlreadyExistsException))]
        public void Test_UpdateLocationAlreadyExists()
        {
            LocationRepository repository = LocationRepository.GetInstance();
            repository.AddLocation(location1);
            repository.AddLocation(location2);

            location2.Name = "Medulin";
            repository.UpdateLocation(0, location2);
        }

        [TestMethod]
        [ExpectedException(typeof(LocationDoesntExistException))]
        public void Test_DeleteLocationThanDoesntExist()
        {
            LocationRepository repository = LocationRepository.GetInstance();
            repository.DeleteLocation(0);
        }

        [TestMethod]
        [ExpectedException(typeof(LocationPartOfFishingRecordException))]
        public void Test_DeleteLocationThanIsPartOfAFishingRecord()
        {
            LocationRepository locRepository = LocationRepository.GetInstance();
            locRepository.AddLocation(location1);

            FishingRecordRepository recRepository = FishingRecordRepository.GetInstance();
            recRepository.DeleteAllRecords();
            FishingRecord record = EntityGenerator.GetFishingRecord1();
            record.Location = location1;
            recRepository.AddRecord(record);

            locRepository.DeleteLocation(0);
        }
    }
}
