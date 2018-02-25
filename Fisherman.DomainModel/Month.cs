using System;
using System.Collections.Generic;
using System.Text;

namespace Fisherman.DomainModel
{
    public class Month : StatisticsParameter
    {
        private Months _name;

        public Month(Months inName)
        {
            _name = inName;
        }

        #region StatisticsParameter Members

        public void GetRecordsWithValue(List<FishingRecord> records, object value)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
