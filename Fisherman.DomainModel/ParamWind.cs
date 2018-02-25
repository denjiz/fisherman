using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public class ParamWind : SearchParameter
    {
        private Winds _value;

        public ParamWind(Winds inWind)
        {
            _value = inWind;
        }

        protected override bool RecordHasNeededValue(FishingRecord record)
        {
            if (record.wind == _value)
            {
                return true;
            }

            return false;
        }
    }
}
