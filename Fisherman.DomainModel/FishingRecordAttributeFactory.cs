using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public class FishingRecordAttributeFactory
    {
        private List<string> _locations;

        public FishingRecordAttributeFactory()
        {
            _locations = new List<string>();
        }

        public FishingRecordAttribute CreateAttribute(string label, object value)
        {
            switch (label)
            {
                case "Location":
                    string locationName = value as string;
                    _locations.Add(locationName);
                    return new Location(locationName);
                case "Fish catch":
                    return new FishCatch(value as Dictionary<string, double>);
            }

            return null;
        }

        public string GetAttributeLabel(FishingRecordAttribute attribute)
        {
            if (attribute is Location)
            {
                return "Location";
            }
            else if (attribute is FishCatch)
            {
                return "Fish catch";
            }
            else
            {
                return null;
            }
        }

        public List<string> GetLocations()
        {
            return _locations;
        }
    }
}
