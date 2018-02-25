using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;

namespace Fisherman.DomainModel
{
    public class ParamMoonPhase : SearchParameter
    {
        private MoonPhases _value;

        public ParamMoonPhase(MoonPhases inMoonPhase)
        {
            _value = inMoonPhase;
        }

        protected override bool RecordHasNeededValue(FishingRecord record)
        {
            if (record.moonPhase == _value)
            {
                return true;
            }

            return false;
        }
    }
}
