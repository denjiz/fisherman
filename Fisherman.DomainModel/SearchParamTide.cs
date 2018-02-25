using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public class SearchParamTide : SearchParam
    {
        private Tides _value;

        public SearchParamTide(Tides inTide)
        {
            _value = inTide;
        }

        protected override bool RecordHasNeededValue(FishingRecord record)
        {
            if (record.NatureContex.Tide == _value)
            {
                return true;
            }

            return false;
        }
    }
}
