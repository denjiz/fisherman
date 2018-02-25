using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;

namespace Fisherman.DomainModel
{
    public class SearchParamMoonPhase : SearchParam
    {
        private MoonPhases _value;

        public SearchParamMoonPhase(MoonPhases inMoonPhase)
        {
            _value = inMoonPhase;
        }

        protected override bool RecordHasNeededValue(FishingRecord record)
        {
            if (record.NatureContex.MoonPhase == _value)
            {
                return true;
            }

            return false;
        }
    }
}
