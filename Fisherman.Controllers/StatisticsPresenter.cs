using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    public class StatisticsPresenter
    {
        private readonly IStatisticsView _view;
        private readonly PresenterMain _parent;
        private readonly List<FishingRecord> _recordsFound;
        private readonly Dictionary<string, Reporter> _availableReportsDict; 

        public StatisticsPresenter(IStatisticsView inView, PresenterMain inParentPresenter)
        {
            _view = inView;
            _parent = inParentPresenter;

            // show number of records found/total number of records
            List<SearchParameter> searchParams = _parent.GetSearchParameters();
            FishingRecordRepository repository = FishingRecordRepository.GetInstance();
            _recordsFound = SearchService.Find(repository.GetRecords(), searchParams);
            _view.ShowNumberOfRecordsFound(_recordsFound.Count, repository.Count());

            // show available reports
            _availableReportsDict = new Dictionary<string, Reporter>();
            _availableReportsDict.Add("Fish catch", new FishCatchReporter());
            _availableReportsDict.Add("Fish profit", new FishSaleReporter());
            _view.AvailableReports = _availableReportsDict.Keys.ToArray();
        }

        public void CloseRequest()
        {
            _view.End();
        }

        public void ShowStatisticsRequest(string[] requestedReports)
        {
            string reportStr = "";

            foreach (string requestedReport in requestedReports)
            {
                Reporter reporter = _availableReportsDict[requestedReport];
                Report report = reporter.GetStatisticReport(_recordsFound);
                string requestedReportStr = reporter.ReportAsString(report);

                reportStr += " ===== " + requestedReport + ": \n";
                reportStr += requestedReportStr;
                reportStr += "\n\n";
            }

            _view.ShowReport(reportStr);
        }
    }
}
