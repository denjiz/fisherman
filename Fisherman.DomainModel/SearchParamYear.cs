using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public class SearchParamYear : SearchParam
    {
        private int _value;

        public SearchParamYear(int inYear)
        {
            _value = inYear;
        }

        protected override bool RecordHasNeededValue(FishingRecord record)
        {
            if (record.DateTimeInterval.Start.Year == _value)
            {
                return true;
            }
            if (record.DateTimeInterval.End.Year == _value)
            {
                return true;
            }

            return false;
        }
    }
}
