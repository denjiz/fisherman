using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    class CommonFunctionalities
    {
        internal static double GetDoubleFromString(string inValueStr, string valueName)
        {
            double value;

            if (inValueStr.Contains(","))
            {
                throw new Exception("Decimal comma is not allowed!\nUse decimal point instead.");
            }

            try
            {
                value = Convert.ToDouble(inValueStr);
            }
            catch (Exception)
            {
                throw new Exception("Invalid " + valueName + "!\nExamples: \"4\"  \"6.12\"  \"45.54327\"");
            }

            return value;
        }

        internal static string[] GetWindStrings()
        {
            return Enum.GetNames(typeof (Winds));
        }

        internal static string[] GetMoonPhaseStrings()
        {
            return Enum.GetNames(typeof(MoonPhases));
        }

        internal static string[] GetTideStrings()
        {
            return Enum.GetNames(typeof(Tides));
        }

        internal static Winds GetWindEnum(string wind)
        {
            return (Winds)Enum.Parse(typeof(Winds), wind, true);
        }

        internal static MoonPhases GetMoonPhaseEnum(string moonPhase)
        {
            return (MoonPhases)Enum.Parse(typeof(MoonPhases), moonPhase, true);
        }

        internal static Tides GetTideEnum(string tide)
        {
            return (Tides) Enum.Parse(typeof (Tides), tide, true);
        }
    }
}
