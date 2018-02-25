using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;
using System.IO;
using Fisherman.BaseLibrary;

namespace Fisherman.DomainModel
{
    public class FishingRecordRepository : Subject
    {
        private List<FishingRecord> _records;
        private string _recordsDir;
        private static FishingRecordRepository _instance = null;

        public static FishingRecordRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FishingRecordRepository();
            }

            return _instance;
        }

        // constructor
        private FishingRecordRepository()
        {
            // load records from disk
            _records = new List<FishingRecord>();
            _recordsDir = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "records");
            LoadRecords();
        }

        // destructor
        ~FishingRecordRepository()
        {
            // delete old records from disk
            string[] recordFiles = GetRecordFiles();
            foreach (var recordFile in recordFiles)
            {
                File.Delete(recordFile);
            }

            // save current records to disk
            foreach (var record in _records)
            {
                SaveRecord(record);
            }
        }

        private string[] GetRecordFiles()
        {
            // assure that a directory exists to hold the records
            if (!Directory.Exists(_recordsDir))
            {
                Directory.CreateDirectory(_recordsDir);
            }

            return Directory.GetFiles(_recordsDir, "*.bin");
        }

        private void LoadRecords()
        {
            // get all records filepaths
            string[] recordFiles = GetRecordFiles();

            // load files into objects
            foreach (var recordFile in recordFiles)
            {
                FishingRecord record = Persistor.DeserializeBinary<FishingRecord>(recordFile);
                _records.Add(record);
            }
        }

        private void SaveRecord(FishingRecord inRecord)
        {
            // generate record filename
            string fileName = inRecord.DateTimeAdded.ToString("yyyy-MM-dd--HH-mm-ss") + ".bin";
            string recordFile = Path.Combine(_recordsDir, fileName);

            // save object to file
            Persistor.SerializeBinary<FishingRecord>(inRecord, recordFile);
        }

        private void Initialize()
        {
            LocationRepository repository = LocationRepository.GetInstance();
            FishingRecord record;

            _records = new List<FishingRecord>();
            DateTime dtAdded = new DateTime(2014, 1, 10, 12, 34, 45);
            DateTimeInterval dtInterval = new DateTimeInterval(new DateTime(2013, 9, 1, 12, 00, 00), new DateTime(2013, 9, 1, 16, 00, 00));
            Location location = repository.GetLocation("Medulin");
            NatureEvents context = new NatureEvents(Winds.NE, MoonPhases.newMoon, Tides.waterRising);
            FishCatch fishCatch = new FishCatch();
            fishCatch.AddCatch("orada", 5.0);
            fishCatch.AddCatch("ribon", 2.0);
            fishCatch.AddSale("orada", 3.0, 200.0);
            fishCatch.AddSale("ribon", 2.0, 200.0);
            record = new FishingRecord(dtAdded, dtInterval, location, context, fishCatch);
            _records.Add(record);

            dtAdded = new DateTime(2014, 1, 11, 14, 23, 12);
            dtInterval = new DateTimeInterval(new DateTime(2013, 9, 15, 14, 00, 00), new DateTime(2013, 9, 15, 18, 00, 00));
            location = repository.GetLocation("Medulin");
            context = new NatureEvents(Winds.N, MoonPhases.fullMoon, Tides.waterRising);
            fishCatch = new FishCatch();
            fishCatch.AddCatch("brancin", 4.5);
            fishCatch.AddCatch("tuna", 10.0);
            fishCatch.AddSale("tuna", 10.0, 500.0);
            record = new FishingRecord(dtAdded, dtInterval, location, context, fishCatch);
            _records.Add(record);

            dtAdded = new DateTime(2014, 1, 12, 16, 34, 23);
            dtInterval = new DateTimeInterval(new DateTime(2014, 1, 1, 16, 00, 00), new DateTime(2014, 1, 1, 20, 00, 00));
            location = repository.GetLocation("Verudela");
            context = new NatureEvents(Winds.S, MoonPhases.waxingCrescent, Tides.waterFalling);
            fishCatch = new FishCatch();
            fishCatch.AddCatch("list", 2.0);
            fishCatch.AddSale("list", 2.0, 130);
            record = new FishingRecord(dtAdded, dtInterval, location, context, fishCatch);
            _records.Add(record);
        }

        public void AddRecord(FishingRecord inRecord)
        {
            // check if record already exists
            foreach (FishingRecord record in _records)
            {
                if (inRecord.DateTimeAdded.CompareTo(record.DateTimeAdded) == 0)
                {
                    throw new FishingRecordAlreadyExistsException();
                }
            }

            // check for collision in fishing time
            foreach (FishingRecord record in _records)
            {
                if (inRecord.IsInDateTimeCollisionWith(record))
                {
                    throw new FishingRecordsInCollisionException();
                }
            }

            _records.Add(inRecord);

            NotifyObservers(inRecord);
        }

        public FishingRecord GetRecord(int index)
        {
            if (0 <= index & index < _records.Count())
            {
                return _records[index];
            }
            
            throw new FishingRecordDoesntExistException();
        }

        public void UpdateRecord(int index, FishingRecord inRecord)
        {
            if (0 <= index & index < _records.Count())
            {
                // check for collision in fishing time
                for (int i = 0; i < index; i++)
                {
                    if (inRecord.IsInDateTimeCollisionWith(_records[i]))
                    {
                        throw new FishingRecordsInCollisionException();
                    }
                }
                for (int i = index+1; i < _records.Count; i++)
                {
                    if (inRecord.IsInDateTimeCollisionWith(_records[i]))
                    {
                        throw new FishingRecordsInCollisionException();
                    }
                }

                FishingRecord record = _records[index];

                record.DateTimeInterval = inRecord.DateTimeInterval;
                record.Location = inRecord.Location;
                record.NatureContex = inRecord.NatureContex;
                record.FishCatch = inRecord.FishCatch;

                NotifyObservers(record);
            }
            else
            {
                throw new FishingRecordDoesntExistException();
            }
        }

        public void DeleteRecord(int index)
        {
            if (0 <= index & index < _records.Count())
            {
                FishingRecord record = _records[index];
                _records.Remove(record);

                NotifyObservers(record);
            }
            else
            {
                throw new FishingRecordDoesntExistException();
            }
        }

        public List<FishingRecord> GetRecords()
        {
            return _records;
        }

        public void DeleteAllRecords()
        {
            _records.Clear();

            NotifyObservers(null);
        }

        public int Count()
        {
            return _records.Count;
        }
    }
}
