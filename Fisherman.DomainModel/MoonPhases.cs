using System;
using System.Collections.Generic;
using System.Text;

namespace Fisherman.DomainModel
{
    [Serializable()]
    public enum MoonPhases
    {
        newMoon,
        waxingCrescent,
        firstQuarter,
        waxingGibbous,
        fullMoon,
        waningGibbous,
        lastQuarter,
        waningCrescent
    }
}
