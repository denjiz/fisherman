using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public class ParamFish : SearchParameter, StatisticsParameter
    {
        private string _value;

        public ParamFish(string inFish)
        {
            _value = inFish;
        }

        protected override bool RecordHasNeededValue(FishingRecord record)
        {
            foreach (string fish in record.fishCatch.Keys)
            {
                if (fish == _value)
                {
                    return true;
                    break;
                }
            }

            return false;
        }

        public void GetRecordsWithValue(List<FishingRecord> records, object value)
        {
            throw new NotImplementedException();
        }
    }
}
