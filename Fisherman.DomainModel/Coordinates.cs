using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.DomainModel;

namespace Fisherman.DomainModel
{
    [Serializable()]
    public class Coordinates
    {
        private double _latitude;
        private double _longitude;

        public Coordinates(double inLatitude, double inLongitude)
        {
            Latitude = inLatitude;
            Longitude = inLongitude;
        }

        public double Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }

        public double Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }

        internal bool IsEqualTo(Coordinates inCoor)
        {
            if (inCoor.Latitude == Latitude & inCoor.Longitude == Longitude)
            {
                return true;
            }

            return false;
        }
    }
}
