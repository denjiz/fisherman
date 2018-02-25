using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Fisherman.BaseLibrary
{
    public interface IViewMain : IView
    {
        void AddRecord(DateTime dateTime);
        void DeleteRecords();

        int[] Years { set; }
        int[] Months { set; }
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
        void DeselectSearchParams();

        void ChangeToFishingRecordAddView();
        void ChangeToFishingRecordEditView(int index);
        void ChangeToLocationsView();
        void ChangeToStatisticsView();
    }
}
