using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;

namespace Fisherman.DomainModel
{
    public class LocationRepository : Subject
    {
        private static List<Location> _locations;
        private string _locationsDir;
        private static LocationRepository _instance = null;

        public static LocationRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LocationRepository();
            }

            return _instance;
        }

        // constructor
        private LocationRepository()
        {
            // load records from disk
            _locations = new List<Location>();
            _locationsDir = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "locations");
            LoadLocations();
        }

        // destructor
        ~LocationRepository()
        {
            // delete old locations from disk
            string[] locationFiles = GetLocationFiles();
            foreach (var locationFile in locationFiles)
            {
                File.Delete(locationFile);
            }

            // save current records to disk
            foreach (var location in _locations)
            {
                SaveLocation(location);
            }
        }

        private string[] GetLocationFiles()
        {
            // assure that a directory exists to hold the locations
            if (!Directory.Exists(_locationsDir))
            {
                Directory.CreateDirectory(_locationsDir);
            }

            return Directory.GetFiles(_locationsDir, "*.bin");
        }

        private void LoadLocations()
        {
            // get all locations filepaths
            string[] locationFiles = GetLocationFiles();

            // load files into objects
            foreach (var locationFile in locationFiles)
            {
                Location location = Persistor.DeserializeBinary<Location>(locationFile);
                _locations.Add(location);
            }
        }

        private void SaveLocation(Location inLocation)
        {
            // generate location filename
            string fileName = inLocation.Name + ".bin";
            string locationFile = Path.Combine(_locationsDir, fileName);

            // save object to file
            Persistor.SerializeBinary<Location>(inLocation, locationFile);
        }

        private void Initialize()
        {
            _locations = new List<Location>();

            Coordinates coor = new Coordinates(44.85, 13.95);
            _locations.Add(new Location("Medulin", coor, 20.0, "Predvečer često gužva!"));

            coor = new Coordinates(44.9, 13.89);
            _locations.Add(new Location("Verudela", coor, 15.0, "Paziti na tuđe mreže!"));
        }

        public void AddLocation(Location inLocation)
        {
            // check if location with same name or coordinates exists
            foreach (Location location in _locations)
            {
                if (inLocation.IsEqualTo(location))
                {
                    throw new LocationAlreadyExistsException();
                }
            }

            _locations.Add(inLocation);

            NotifyObservers(inLocation);
        }

        public Location GetLocation(int index)
        {
            if (0 <= index & index < _locations.Count)
            {
                return _locations[index];
            }

            throw new LocationDoesntExistException();
        }

        public Location GetLocation(string inName)
        {
            foreach (Location location in _locations)
            {
                if (location.Name == inName)
                {
                    return location;
                }
            }

            throw new LocationDoesntExistException();
        }

        public void UpdateLocation(int index, Location inLocation)
        {
            if (0 <= index & index < _locations.Count)
            {
                for (int i = 0; i < index; i++)
                {
                    if (inLocation.IsEqualTo(_locations[i]))
                    {
                        throw new LocationAlreadyExistsException();
                    }
                }
                for (int i = index+1; i < _locations.Count; i++)
                {
                    if (inLocation.IsEqualTo(_locations[i]))
                    {
                        throw new LocationAlreadyExistsException();
                    }
                }

                Location location = _locations[index];

                location.Name = inLocation.Name;
                location.Coordinates = inLocation.Coordinates;
                location.Depth = inLocation.Depth;
                location.Comment = inLocation.Comment;

                NotifyObservers(location);
            }
            else
            {
                throw new LocationDoesntExistException();
            }
        }

        public void DeleteLocation(int index)
        {
            if (0 <= index & index < _locations.Count)
            {
                Location location = _locations[index];
                foreach (FishingRecord record in FishingRecordRepository.GetInstance().GetRecords())
                {
                    if (location == record.Location)
                    {
                        throw new LocationPartOfFishingRecordException();
                    }
                }

                _locations.RemoveAt(index);

                NotifyObservers(location);
            }
            else
            {
                throw new LocationDoesntExistException();
            }
        }

        public string[] GetLocationNames()
        {
            int n = _locations.Count;
            string[] names = new string[n];
            for (int i = 0; i < n; i++)
            {
                names[i] = _locations[i].Name;
            }

            return names;
        }

        public List<Location> GetLocations()
        {
            return _locations;
        }

        public void DeleteAllLocations()
        {
            _locations.Clear();

            NotifyObservers(null);
        }

        public int Count()
        {
            return _locations.Count();
        }
    }
}
