using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public class ParamYear : SearchParameter
    {
        private int _value;

        public ParamYear(int inYear)
        {
            _value = inYear;
        }

        protected override bool RecordHasNeededValue(FishingRecord record)
        {
            if (record.dateTimeStart.Year == _value)
            {
                return true;
            }
            if (record.dateTimeEnd.Year == _value)
            {
                return true;
            }

            return false;
        }
    }
}
