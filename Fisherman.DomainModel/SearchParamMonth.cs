using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public class SearchParamMonth : SearchParam
    {
        private int _value;

        public SearchParamMonth(int inMonth)
        {
            _value = inMonth;
        }

        protected override bool RecordHasNeededValue(FishingRecord record)
        {
            if (record.DateTimeInterval.Start.Month == _value)
            {
                return true;
            }
            if (record.DateTimeInterval.End.Month == _value)
            {
                return true;
            }

            return false;
        }
    }
}
