using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public static class Search
    {
        public static List<FishingRecord> Find(List<FishingRecord> records, List<SearchParam> parameters)
        {
            List<FishingRecord> matches = new List<FishingRecord>(records);
            foreach (SearchParam parameter in parameters)
            {
                matches = parameter.FindRecordsWithValue(matches);
            }

            return matches;
        }

        public static string[] GetFishNames()
        {
            HashSet<string> fishNames = new HashSet<string>(); ;
            foreach (FishingRecord record in FishingRecordRepository.GetInstance().GetRecords())
            {
                foreach (string fishName in record.FishCatch.GetCaughtFish())
                {
                    fishNames.Add(fishName);
                }
            }

            return fishNames.ToArray();
        }

        public static int[] GetYears()
        {
            HashSet<int> years = new HashSet<int>();
            foreach (FishingRecord record in FishingRecordRepository.GetInstance().GetRecords())
            {
                years.Add(record.DateTimeInterval.Start.Year);
                years.Add(record.DateTimeInterval.End.Year);
            }

            return years.ToArray();
        }

        public static int[] GetMonths()
        {
            HashSet<int> months = new HashSet<int>(); ;
            foreach (FishingRecord record in FishingRecordRepository.GetInstance().GetRecords())
            {
                months.Add(record.DateTimeInterval.Start.Month);
                months.Add(record.DateTimeInterval.End.Month);
            }

            return months.ToArray();
        }

        public static List<DateTime> GetDateTimesAdded(List<FishingRecord> records)
        {
            List<DateTime> recordsDates = new List<DateTime>();
            foreach (FishingRecord record in records)
            {
                recordsDates.Add(record.DateTimeAdded);
            }

            return recordsDates;
        }
    }
}
