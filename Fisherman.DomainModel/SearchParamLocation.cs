using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public class SearchParamLocation : SearchParam
    {
        private string _value;

        public SearchParamLocation(string inLocation)
        {
            _value = inLocation;
        }

        protected override bool RecordHasNeededValue(FishingRecord record)
        {
            if (record.Location.Name == _value)
            {
                return true;
            }

            return false;
        }
    }
}
