using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    [Serializable()]
    public class FishSaleInfo
    {
        private double _mass;
        private double _price;

        public FishSaleInfo(double inSaleMass, double inSalePrice)
        {
            Mass = inSaleMass;
            Price = inSalePrice;
        }

        public double Mass
        {
            get { return _mass; }
            set { _mass = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
