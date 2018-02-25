using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.BaseLibrary
{
    public interface IViewStatistics : IView
    {
        void ShowNumberOfRecordsFound(int found, int total);
        string[] AvailableReports { set; }
        void ChangeToStatisticReportView(string report);
    }
}
