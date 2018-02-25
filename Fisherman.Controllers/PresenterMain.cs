using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    public class PresenterMain : Subject, IFishermanObserver
    {
        private readonly IViewMain _view;

        public PresenterMain(IViewMain inView)
        {
            _view = inView;

            // load records
            FishingRecordRepository repository = FishingRecordRepository.GetInstance();
            ShowRecords(repository.GetRecords());

            // init search fields
            SetPossibleSearchValues();

            // attach self to repositories
            repository.Attach(this);
            LocationRepository.GetInstance().Attach(this);
        }

        public void AddFishingRecordRequest()
        {
            _view.ChangeToFishingRecordAddView();
        }

        public void EditFishingRecordRequest(int index)
        {
            _view.ChangeToFishingRecordEditView(index);
        }

        public void DeleteRecordRequest(int inRecordIndex)
        {
            // warn user
            if (_view.WarnUser(CommonPresenterStuff.WarnDeleteMessage("fishing record")))
            {
                FishingRecordRepository repository = FishingRecordRepository.GetInstance();
                repository.DeleteRecord(inRecordIndex);
            }
        }

        public void ShowAllRecordsRequest()
        {
            ShowRecords(FishingRecordRepository.GetInstance().GetRecords());
        }

        public void ShowLocationsRequest()
        {
            _view.ChangeToLocationsView();
        }

        public void SearchRequest()
        {
            List<SearchParam> parameters = GetSearchParameters();

            List<FishingRecord> matches = Search.Find(FishingRecordRepository.GetInstance().GetRecords(), parameters);
            ShowRecords(matches);
        }

        public void CalculateStatisticsRequest()
        {
            _view.ChangeToStatisticsView();
        }

        public void DeselectSearchParamsRequest()
        {
            _view.DeselectSearchParams();
        }

        public void Update(object inObject)
        {
            ShowRecords(FishingRecordRepository.GetInstance().GetRecords());
            SetPossibleSearchValues();
        }

        internal List<SearchParam> GetSearchParameters()
        {
            List<SearchParam> parameters = new List<SearchParam>();

            // get search paramteres and their values
            if (_view.YearSearch != "")
            {
                parameters.Add(new SearchParamYear(Convert.ToInt32(_view.YearSearch)));
            }
            if (_view.MonthSearch != "")
            {
                parameters.Add(new SearchParamMonth(Convert.ToInt32(_view.MonthSearch)));
            }
            if (_view.LocationSearch != "")
            {
                parameters.Add(new SearchParamLocation(_view.LocationSearch));
            }
            if (_view.WindSearch != "")
            {
                parameters.Add(new SearchParamWind(CommonPresenterStuff.GetWindEnum(_view.WindSearch)));
            }
            if (_view.MoonPhaseSearch != "")
            {
                parameters.Add(new SearchParamMoonPhase(CommonPresenterStuff.GetMoonPhaseEnum(_view.MoonPhaseSearch)));
            }
            if (_view.TideSearch != "")
            {
                parameters.Add(new SearchParamTide(CommonPresenterStuff.GetTideEnum(_view.TideSearch)));
            }

            return parameters;
        }

        private void ShowRecords(List<FishingRecord> records)
        {
            _view.DeleteRecords();
            foreach (FishingRecord record in records)
            {
                _view.AddRecord(record.DateTimeAdded);
            }
        }

        private void SetPossibleSearchValues()
        {
            _view.Years = Search.GetYears();
            _view.Months = Search.GetMonths();
            _view.Locations = LocationRepository.GetInstance().GetLocationNames();
            _view.Winds = CommonPresenterStuff.GetWindStrings();
            _view.MoonPhases = CommonPresenterStuff.GetMoonPhaseStrings();
            _view.Tides = CommonPresenterStuff.GetTideStrings();
        }
    }
}
