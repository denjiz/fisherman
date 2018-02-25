using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace Fisherman.DomainModel
{
    public class StatParamFish : StatisticsParameter
    {
        private string _paramName;

        public StatParamFish(string inParamName)
        {
            _paramName = inParamName;
        }

        public string GetStatisticReport(List<FishingRecord> records)
        {
            List<string> report = new List<string>();

            double totalMass = 0;
            Dictionary<string, double> massPerFishDict = new Dictionary<string, double>();
            double totalTimeInHours = 0;

            // collect data
            foreach (FishingRecord record in records)
            {
                // get time spent in hours
                double timeInHours = FishingRecordService.GetTimeInHours(record);
                totalTimeInHours += timeInHours;

                // go through fish catch
                foreach (KeyValuePair<string, double> pair in record.fishCatch)
                {
                    string fish = pair.Key;
                    double mass = pair.Value;

                    // add to total mass
                    totalMass += mass;

                    // add mass to particular fish
                    if (massPerFishDict.ContainsKey(fish))
                    {
                        massPerFishDict[fish] += mass;
                    }
                    else
                    {
                        massPerFishDict.Add(fish, mass);
                    }
                }
            }

            // sort fish by mass descending
            var massPerFish = 
                from fishMassPair in massPerFishDict
                orderby fishMassPair.Value descending
                select fishMassPair;

            // generate report
            report.Add("Total mass: " + totalMass.ToString("0.00") + " kg");
            report.Add("Mass per fish:");
            foreach (KeyValuePair<string, double> pair in massPerFish)
            {
                string fish = pair.Key;
                double mass = pair.Value;
                double percentage = mass/totalMass*100;

                report.Add("\t" + String.Format("{0, -15}", fish) + String.Format("{0, -15}", mass.ToString("0.00") + " kg") + "(" + percentage.ToString("0.00") + "%)");
            }

            report.Add("");

            double massPerHour = totalMass/totalTimeInHours;
            report.Add("Total average mass per hour: " + massPerHour.ToString("0.00") + " kg/h");
            report.Add("Average mass per hour per fish:");
            foreach (KeyValuePair<string, double> pair in massPerFish)
            {
                string fish = pair.Key;
                double mass = pair.Value;
                double averageMassPerHour = mass/totalTimeInHours;

                report.Add("\t" + String.Format("{0, -15}", fish) + averageMassPerHour.ToString("0.00") + " kg/h");
            }

            return string.Join("\n", report.ToArray());
        }
    }
}
