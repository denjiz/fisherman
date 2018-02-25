using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.DomainModel;

namespace Fisherman.DomainModel
{
    [Serializable()]
    public class Location
    {
        private string _name;
        private Coordinates _coordinates;
        private double _depth;
        private string _comment;

        public Location(string inName, Coordinates inCoor, double inDepth, string inComment)
        {
            Name = inName;
            Coordinates = inCoor;
            Depth = inDepth;
            Comment = inComment;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Coordinates Coordinates
        {
            get { return _coordinates; }
            set { _coordinates = value; }
        }

        public double Depth
        {
            get { return _depth; }
            set { _depth = value; }
        }

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        internal bool IsEqualTo(Location location)
        {
            return Name == location.Name | Coordinates.IsEqualTo(location.Coordinates);
        }
    }
}
