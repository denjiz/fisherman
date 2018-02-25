using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public class ParamTide : SearchParameter
    {
        private Tides _value;

        public ParamTide(Tides inTide)
        {
            _value = inTide;
        }

        protected override bool RecordHasNeededValue(FishingRecord record)
        {
            if (record.tide == _value)
            {
                return true;
            }

            return false;
        }
    }
}
