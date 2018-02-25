using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public static class Statistics
    {
        public static double GetTotalCatchMass(List<FishingRecord> records)
        {
            double mass = 0;
            foreach (FishingRecord record in records)
            {
                foreach (string fish in record.FishCatch.GetCaughtFish())
                {
                    mass += record.FishCatch.GetCaughtFishMass(fish);
                }
            }

            return mass;
        }

        public static double GetTotalCatchProfit(List<FishingRecord> records)
        {
            double profit = 0;
            foreach (FishingRecord record in records)
            {
                foreach (string fish in record.FishCatch.GetSoldFish())
                {
                    profit += record.FishCatch.GetSoldFishPrice(fish);
                }
            }

            return profit;
        }

        public static Dictionary<string, double> GetTotalMassPerFish(List<FishingRecord> records)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            foreach (FishingRecord record in records)
            {
                foreach (string fish in record.FishCatch.GetCaughtFish())
                {
                    double mass = record.FishCatch.GetCaughtFishMass(fish);

                    if (!dict.ContainsKey(fish))
                    {
                        dict.Add(fish, mass);
                    }
                    else
                    {
                        dict[fish] += mass;
                    }
                }
            }

            return dict;
        }

        public static Dictionary<string, double> GetTotalProfitPerFish(List<FishingRecord> records)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            foreach (FishingRecord record in records)
            {
                foreach (string fish in record.FishCatch.GetSoldFish())
                {
                    double price = record.FishCatch.GetSoldFishPrice(fish);

                    if (!dict.ContainsKey(fish))
                    {
                        dict.Add(fish, price);
                    }
                    else
                    {
                        dict[fish] += price;
                    }
                }
            }

            return dict;
        }

        public static double GetTotalTimeInHours(List<FishingRecord> records)
        {
            double time = 0;
            foreach (FishingRecord record in records)
            {
                DateTime start = record.DateTimeInterval.Start;
                DateTime end = record.DateTimeInterval.End;

                time += end.Subtract(start).TotalHours;
            }

            return time;
        }
    }
}
