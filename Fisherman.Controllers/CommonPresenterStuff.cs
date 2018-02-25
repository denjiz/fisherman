using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fisherman.DomainModel;

namespace Fisherman.Presenters
{
    internal class CommonPresenterStuff
    {
        internal static void ValidateFieldNotEmpty(string inValueStr, string inValueName)
        {
            if (inValueStr == "")
            {
                throw new Exception(CapitalizeFirstLetter(inValueName) + " can't be empty!");
            }
        }

        internal static double ValidateDoubleString(string inValueStr, string inValueName)
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
                throw new Exception("Invalid " + inValueName + "!\nExamples: \"4\"  \"6.12\"  \"45.54327\"");
            }

            return value;
        }

        internal static void ValidateDoubleGreaterThan(double inValue, double v, string inValueName)
        {
            if (!(inValue > v))
            {
                throw new Exception(CapitalizeFirstLetter(inValueName) + " must be greater than " + v + "!");
            }
        }

        internal static void ValidateDoubleInRange(double inValue, double v1, double v2, string inValueName)
        {
            if (inValue < v1 | inValue > v2)
            {
                throw new Exception(CapitalizeFirstLetter(inValueName) + " must be a value between " + v1 + " and " + v2 + "!");
            }
        }

        internal static void ValidateDateEarlierThanNow(DateTime inDt, string inValueName)
        {
            if (inDt.CompareTo(DateTime.Now) >= 0)
            {
                throw new Exception(CapitalizeFirstLetter(inValueName) + " must be earlier than now!");
            }
        }

        internal static void ValidateCronologicalDates(DateTime inDt1, DateTime inDt2, string inValueName1, string inValueName2)
        {
            if (inDt2.CompareTo(inDt1) <= 0)
            {
                throw new Exception(CapitalizeFirstLetter(inValueName2) + " must be later than " + inValueName1 + "!");
            }
        }

        internal static string WarnFieldEmptyMessage(string text)
        {
            return CapitalizeFirstLetter(text) + " is empty.\nAre you sure you want to continue?";
        }

        internal static string WarnDeleteMessage(string text)
        {
            return CapitalizeFirstLetter(text) + " will be deleted permanently.\nAre you sure you want to continue?";
        }

        internal static string ErrorMessage()
        {
            return "Something went wrong!\nUnable to perform operation.";
        }

        internal static string CapitalizeFirstLetter(string inValueName)
        {
            return inValueName[0].ToString().ToUpper() + inValueName.Substring(1);
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

        public static Winds GetWindEnum(string wind)
        {
            return (Winds)Enum.Parse(typeof(Winds), wind, true);
        }

        public static MoonPhases GetMoonPhaseEnum(string moonPhase)
        {
            return (MoonPhases)Enum.Parse(typeof(MoonPhases), moonPhase, true);
        }

        public static Tides GetTideEnum(string tide)
        {
            return (Tides) Enum.Parse(typeof (Tides), tide, true);
        }
    }
}
