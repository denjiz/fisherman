using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.BaseLibrary
{
    public interface IStatisticsView
    {
        void End();

        void ShowNumberOfRecordsFound(int p1, int p2);

        void ShowReport(string report);

        string[] AvailableReports { set; }
    }
}
