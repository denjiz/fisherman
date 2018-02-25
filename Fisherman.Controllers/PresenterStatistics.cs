using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    public class PresenterStatistics
    {
        private readonly IViewStatistics _view;
        private readonly List<FishingRecord> _recordsFound;

        public PresenterStatistics(IViewStatistics inView, PresenterMain inParentPresenter)
        {
            _view = inView;

            // show number of records found/total number of records
            List<SearchParam> searchParams = inParentPresenter.GetSearchParameters();
            FishingRecordRepository repository = FishingRecordRepository.GetInstance();
            _recordsFound = Search.Find(repository.GetRecords(), searchParams);
            _view.ShowNumberOfRecordsFound(_recordsFound.Count, repository.Count());

            // show available reports
            List<string> availableReports = new List<string>();
            availableReports.Add("Fish catch");
            availableReports.Add("Fish profit");
            _view.AvailableReports = availableReports.ToArray();
        }

        public void ShowStatisticsRequest(string[] requestedReports)
        {
            List<string> reportPage = new List<string>();
            foreach (string requestedReport in requestedReports)
            {
                reportPage.Add(" ===== " + requestedReport);
                reportPage.AddRange(GenerateReport(requestedReport));
                reportPage.Add("");
            }

            _view.ChangeToStatisticReportView(String.Join(Environment.NewLine, reportPage.ToArray()));
        }

        public void CloseRequest()
        {
            _view.End();
        }

        private List<string> GenerateReport(string requestedReport)
        {
            switch (requestedReport)
            {
                case "Fish catch":
                    return GenerateFishCatchReport();
                case "Fish profit":
                    return GenerateFishSaleReport();
                default:
                    return new List<string>();
            }
        }

        private List<string> GenerateFishCatchReport()
        {
            // get needed data
            double totalMass = Statistics.GetTotalCatchMass(_recordsFound);
            Dictionary<string, double> massPerFishDict = Statistics.GetTotalMassPerFish(_recordsFound);
            double totalTimeInHours = Statistics.GetTotalTimeInHours(_recordsFound);

            // generate report
            return GenerateFishReport(totalMass, massPerFishDict, totalTimeInHours, "mass", "kg");
        }

        private List<string> GenerateFishSaleReport()
        {
            // get needed data
            double totalProfit = Statistics.GetTotalCatchProfit(_recordsFound);
            Dictionary<string, double> profitPerFishDict = Statistics.GetTotalProfitPerFish(_recordsFound);
            double totalTimeInHours = Statistics.GetTotalTimeInHours(_recordsFound);

            // generate report
            return GenerateFishReport(totalProfit, profitPerFishDict, totalTimeInHours, "profit", "kn");
        }

        private List<string> GenerateFishReport(double totalValue, Dictionary<string, double> valuePerItemDict, double totalTimeInHours, string valueName, string valueUnitName)
        {
            List<String> report = new List<string>();

            string valueNameCap = CommonPresenterStuff.CapitalizeFirstLetter(valueName);

            // sort items by value descending
            var valuePerItem =
                from fishMassPair in valuePerItemDict
                orderby fishMassPair.Value descending
                select fishMassPair;

            // generate report
            report.Add("Total " + valueName + ": " + totalValue.ToString("0.00") + " " + valueUnitName);
            report.Add(valueNameCap + " per fish:");
            foreach (KeyValuePair<string, double> pair in valuePerItem)
            {
                string item = pair.Key;
                double value = pair.Value;
                double percentage = value / totalValue * 100;

                report.Add("\t" + String.Format("{0, -15}", item) + String.Format("{0, -15}", value.ToString("0.00") + " " + valueUnitName) + "(" + percentage.ToString("0.00") + "%)");
            }

            report.Add("");

            double valuePerHour = totalValue / totalTimeInHours;
            report.Add("Total average " + valueName + " per hour: " + valuePerHour.ToString("0.00") + " " + valueUnitName + "/h");
            report.Add("Average " + valueName + " per hour per fish:");
            foreach (KeyValuePair<string, double> pair in valuePerItem)
            {
                string item = pair.Key;
                double value = pair.Value;
                double averageValuePerHour = value / totalTimeInHours;

                report.Add("\t" + String.Format("{0, -15}", item) + averageValuePerHour.ToString("0.00") + " " + valueUnitName + "/h");
            }

            return report;
        }
    }
}
