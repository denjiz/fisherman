using System;
using System.Collections.Generic;
using System.Text;

namespace Fisherman.DomainModel
{
    public interface StatisticsParameter
    {
        string GetStatisticReport(List<FishingRecord> records);
    }
}
