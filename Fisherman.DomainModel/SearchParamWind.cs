using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public class SearchParamWind : SearchParam
    {
        private Winds _value;

        public SearchParamWind(Winds inWind)
        {
            _value = inWind;
        }

        protected override bool RecordHasNeededValue(FishingRecord record)
        {
            if (record.NatureContex.Wind == _value)
            {
                return true;
            }

            return false;
        }
    }
}
