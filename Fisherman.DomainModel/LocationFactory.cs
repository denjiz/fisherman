using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.DomainModel;

namespace Fisherman.DomainModel
{
    public class LocationFactory
    {
        public static Location CreateLocation(string inName, double inLatitude, double inLongitude, double inDepth,
            string inComment)
        {
            Coordinates coor = new Coordinates(inLatitude, inLongitude);
            
            Location location = new Location(inName, coor, inDepth, inComment);

            return location;
        }
    }
}
