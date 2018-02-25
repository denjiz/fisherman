using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Fisherman.BaseLibrary
{
    public interface IMainView
    {
        List<string> RecordNames { get; set; }
        void ChangeToAddFishingRecordView();
        void AddRecordNameAtBeginning(string recordName);
        void ShowErrorMessage(string text);
        void ChangeToStatisticsView();
        void ChangeToSearchView();

        string[] Years { set; }
        string[] Months { set; }
        string[] Locations { set; }
        string[] Winds { set; }
        string[] MoonPhases { set; }
        string[] Tides { set; }

        string YearSearch { get; }
        string MonthSearch { get; }
        string LocationSearch { get; }
        string WindSearch { get; }
        string MoonPhaseSearch { get; }
        string TideSearch { get; }

        void DeselectSearchParameters();

        void ChangeToShowFishingRecordView(int index);

        void ChangeToLocationsView();
    }
}
