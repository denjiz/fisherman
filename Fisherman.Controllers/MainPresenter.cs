using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.BaseLibrary;
using Fisherman.DomainModel;
using Fisherman.Services;

namespace Fisherman.Presenters
{
    public class MainPresenter
    {
        private readonly FishingRecordRepository _repository = FishingRecordRepository.GetInstance();
        private readonly IMainView _view;
        private const string _noRecordsError =
            "There are no fishing records in the system!";

        public MainPresenter(IMainView inView)
        {
            _view = inView;

            ShowRecords(_repository.GetRecords());
            SetPossibleSearchValues();
        }

        private void ShowRecords(List<FishingRecord> records)
        {
            List<string> recordNames = new List<string>();
            foreach (DateTime dateTimeAdded in RepositoryService.GetRecordDates(records))
            {
                recordNames.Add(CreateNameFromDate(dateTimeAdded));
            }
            recordNames.Reverse();
            _view.RecordNames = recordNames;
        }

        private void SetPossibleSearchValues()
        {
            _view.Years = RepositoryService.GetYears();
            _view.Months = RepositoryService.GetMonths();
            _view.Locations = RepositoryService.GetLocations();
            _view.Winds = EnumProcessor.GetDTOwinds();
            _view.MoonPhases = EnumProcessor.GetDTOmoonPhases();
            _view.Tides = EnumProcessor.GetDTOtides();
        }

        public void AddFishingRecordRequest()
        {
            _view.ChangeToAddFishingRecordView();
        }

        internal void AddRecordName(DateTime dateTimeAdded)
        {
            _view.AddRecordNameAtBeginning(CreateNameFromDate(dateTimeAdded));

            SetPossibleSearchValues();
        }

        private string CreateNameFromDate(DateTime dateTime)
        {
            return dateTime.ToString("yyyy.MM.dd  HH:mm:ss");
        }

        public void CalculateStatisticsRequest()
        {
            _view.ChangeToStatisticsView();
        }

        internal List<SearchParameter> GetSearchParameters()
        {
            List<SearchParameter> parameters = new List<SearchParameter>();

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
                parameters.Add(new SearchParamParamWind(EnumProcessor.GetWindFromDTO(_view.WindSearch)));
            }
            if (_view.MoonPhaseSearch != "")
            {
                parameters.Add(new SearchParamMoonPhase(EnumProcessor.GetMoonPhaseFromDTO(_view.MoonPhaseSearch)));
            }
            if (_view.TideSearch != "")
            {
                parameters.Add(new SearchParamTide(EnumProcessor.GetTideFromDTO(_view.TideSearch)));
            }

            return parameters;
        }

        public void SearchRequest()
        {
            List<SearchParameter> parameters = GetSearchParameters();

            List<FishingRecord> matches = SearchService.Find(_repository.GetRecords(), parameters);
            ShowRecords(matches);
        }

        public string YearSearch { get { return _view.YearSearch; } }

        public string MonthSearch { get { return _view.MonthSearch; } }

        public string LocationSearch { get { return _view.LocationSearch; } }

        public string WindSearch { get { return _view.WindSearch; } }

        public string MoonPhaseSearch{get { return _view.MoonPhaseSearch; } }

        public string TideSearch { get { return _view.TideSearch; } }

        public void ShowFishingRecordsRequest(int index)
        {
            _view.ChangeToShowFishingRecordView(index);
        }

        public void ShowLocationsRequest()
        {
            _view.ChangeToLocationsView();
        }
    }
}
