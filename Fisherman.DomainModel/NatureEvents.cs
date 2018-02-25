using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fisherman.DomainModel
{
    [Serializable()]
    public class NatureEvents
    {
        private Winds _wind;
        private MoonPhases _moonPhase;
        private Tides _tide;

        public NatureEvents(Winds inWind, MoonPhases inMoonPhase, Tides inTide)
        {
            Wind = inWind;
            MoonPhase = inMoonPhase;
            Tide = inTide;
        }

        public Winds Wind
        {
            get { return _wind; }
            set { _wind = value; }
        }

        public MoonPhases MoonPhase
        {
            get { return _moonPhase; }
            set { _moonPhase = value; }
        }

        public Tides Tide
        {
            get { return _tide; }
            set { _tide = value; }
        }
    }
}
