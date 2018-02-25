using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    public class FishingRecordFactory
    {
        public static FishingRecord CreateFishingRecord(DateTime inDtStart, DateTime inDtEnd, string inLocationName,
            Winds inWind, MoonPhases inMoonPhase, Tides inTide, FishCatch inFishCatch)
        {
            DateTime dtAdded = DateTime.Now;
            DateTimeInterval dtInterval = new DateTimeInterval(inDtStart, inDtEnd);
            Location location = LocationRepository.GetInstance().GetLocation(inLocationName);
            NatureEvents nContext = new NatureEvents(inWind, inMoonPhase, inTide);

            FishingRecord record = new FishingRecord(dtAdded, dtInterval, location, nContext, inFishCatch);

            return record;
        }
    }
}
