using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.DomainModel;

namespace Fisherman.Tests
{
    internal class EntityGenerator
    {
        internal static FishingRecord GetFishingRecord1()
        {
            DateTime dtAdded = new DateTime(2014, 1, 10, 12, 34, 45);
            DateTimeInterval dtInterval = new DateTimeInterval(new DateTime(2013, 9, 1, 12, 00, 00), new DateTime(2013, 9, 1, 16, 00, 00));
            Location location = new Location("Verudela", new Coordinates(2,3), 20, "");
            NatureEvents context = new NatureEvents(Winds.NE, MoonPhases.newMoon, Tides.waterRising);
            FishCatch fishCatch = new FishCatch();
            fishCatch.AddCatch("orada", 5.0);
            fishCatch.AddCatch("ribon", 2.0);
            fishCatch.AddSale("orada", 3.0, 200.0);
            fishCatch.AddSale("ribon", 2.0, 120.0);

            return new FishingRecord(dtAdded, dtInterval, location, context, fishCatch);
        }

        internal static FishingRecord GetFishingRecord2()
        {
            DateTime dtAdded = new DateTime(2014, 1, 11, 14, 23, 12);
            DateTimeInterval dtInterval = new DateTimeInterval(new DateTime(2013, 9, 15, 14, 00, 00), new DateTime(2013, 9, 15, 18, 00, 00));
            Location location = new Location("Medulin", new Coordinates(3, 4), 23, "");
            NatureEvents context = new NatureEvents(Winds.N, MoonPhases.fullMoon, Tides.waterRising);
            FishCatch fishCatch = new FishCatch();
            fishCatch.AddCatch("brancin", 4.5);
            fishCatch.AddCatch("tuna", 10.0);
            fishCatch.AddSale("tuna", 10.0, 500.0);

            return new FishingRecord(dtAdded, dtInterval, location, context, fishCatch);
        }

        internal static Location GetLocation1()
        {
            Coordinates coor = new Coordinates(44.85, 13.95);
            return new Location("Medulin", coor, 20.0, "Predvečer često gužva!");
        }

        internal static Location GetLocation2()
        {
            Coordinates coor = new Coordinates(44.9, 13.89);
            return new Location("Verudela", coor, 15.0, "Paziti na tuđe mreže!");
        }
    }
}
