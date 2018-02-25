using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public class ParamMonth : SearchParameter
    {
        private int _value;

        public ParamMonth(int inMonth)
        {
            _value = inMonth;
        }

        protected override bool RecordHasNeededValue(FishingRecord record)
        {
            if (record.dateTimeStart.Month == _value)
            {
                return true;
            }
            if (record.dateTimeEnd.Month == _value)
            {
                return true;
            }

            return false;
        }
    }
}
