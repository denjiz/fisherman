using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public abstract class SearchParam
    {
        public List<FishingRecord> FindRecordsWithValue(List<FishingRecord> records)
        {
            List<FishingRecord> foundRecords = new List<FishingRecord>();
            foreach (FishingRecord record in records)
            {
                if (RecordHasNeededValue(record))
                {
                    foundRecords.Add(record);
                }
            }

            return foundRecords;
        }

        protected abstract bool RecordHasNeededValue(FishingRecord record);
    }
}
