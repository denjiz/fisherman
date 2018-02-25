using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    [Serializable()]
    public class FishingRecord
    {
        private DateTime _dateTimeAdded;
        private DateTimeInterval _dateTimeInterval;
        private Location _location;
        private NatureEvents _natureContex;
        private FishCatch _fishCatch;

        public FishingRecord(DateTime inDtAdded, DateTimeInterval inDtInterval, Location inLocation,
            NatureEvents inNatureContext, FishCatch inFishCatch)
        {
            DateTimeAdded = inDtAdded;
            DateTimeInterval = inDtInterval;
            Location = inLocation;
            NatureContex = inNatureContext;
            FishCatch = inFishCatch;
        }

        public DateTime DateTimeAdded
        {
            get { return _dateTimeAdded; }
            set { _dateTimeAdded = value; }
        }

        public DateTimeInterval DateTimeInterval
        {
            get { return _dateTimeInterval; }
            set { _dateTimeInterval = value; }
        }

        public Location Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public NatureEvents NatureContex
        {
            get { return _natureContex; }
            set { _natureContex = value; }
        }

        public FishCatch FishCatch
        {
            get { return _fishCatch; }
            set { _fishCatch = value; }
        }

        internal bool IsInDateTimeCollisionWith(FishingRecord record)
        {
            if (DateTimeInterval.IsInCollisionWith(record.DateTimeInterval))
            {
                return true;
            }

            return false;
        }
    }
}
