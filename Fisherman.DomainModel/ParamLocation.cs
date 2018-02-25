using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public class ParamLocation : SearchParameter
    {
        private string _value;

        public ParamLocation(string inLocation)
        {
            _value = inLocation;
        }

        protected override bool RecordHasNeededValue(FishingRecord record)
        {
            if (record.location == _value)
            {
                return true;
            }

            return false;
        }
    }
}
