using System;
using System.Collections.Generic;

namespace dewitcher
{
    public static class DateTime
    {
        public static class Now
        {
            /// <summary>
            /// Returns the hour
            /// </summary>
            public static byte Hour { get { return Cosmos.Hardware.RTC.Hour; } }
            /// <summary>
            /// Returns the hour as string in format hh
            /// </summary>
            public static string HourString { get { return Cosmos.Hardware.RTC.Hour.TryAppend(); } }

            /// <summary>
            /// Returns the minute
            /// </summary>
            public static byte Minute { get { return Cosmos.Hardware.RTC.Minute; } }
            /// <summary>
            /// Returns the minute as string in format mm
            /// </summary>
            public static string MinuteString { get { return Cosmos.Hardware.RTC.Minute.TryAppend(); } }

            /// <summary>
            /// Returns the second
            /// </summary>
            public static byte Second { get { return Cosmos.Hardware.RTC.Second; } }
            /// /// <summary>
            /// Returns the second as string in format ss
            /// </summary>
            public static string SecondString { get { return Cosmos.Hardware.RTC.Second.TryAppend(); } }

            /// <summary>
            /// Returns the century
            /// </summary>
            public static byte Century { get { return (byte)(Cosmos.Hardware.RTC.Century); } }
            /// <summary>
            /// Returns the century as string in format xx ( x = any number )
            /// </summary>
            public static string CenturyString { get { return ((byte)(Cosmos.Hardware.RTC.Century)).TryAppend(); } }

            /// <summary>
            /// Returns the year (e.g. 2012)
            /// </summary>
            public static int Year { get { return int.Parse(((Century).ToString() + Cosmos.Hardware.RTC.Year.ToString())); } }
            /// <summary>
            /// Returns the year as string in format xxxx ( x = any number )
            /// </summary>
            public static string YearString { get { return (CenturyString + Cosmos.Hardware.RTC.Year.TryAppend()); } }

            /// <summary>
            /// Returns the day of the month
            /// </summary>
            public static byte DayOfTheMonth { get { return Cosmos.Hardware.RTC.DayOfTheMonth; } }

            /// <summary>
            /// Returns the day of the week
            /// </summary>
            public static byte DayOfTheWeek { get { return Cosmos.Hardware.RTC.DayOfTheWeek; } }

            /// <summary>
            /// Returns the month
            /// </summary>
            public static byte Month { get { return Cosmos.Hardware.RTC.Month; } }
            /// <summary>
            /// Returns the month in format xx ( x = any number )
            /// </summary>
            public static string MonthString { get { return Cosmos.Hardware.RTC.Month.TryAppend(); } }

            /// <summary>
            /// DateFormat
            /// </summary>
            public enum DateFormat : byte { YYYY_MM_DD, DD_MM_YYYY, YYYY_DD_MM }
            /// <summary>
            /// Returns the date in the specified date format
            /// </summary>
            /// <param name="format">Date Format</param>
            /// <returns>the date in the specified date format</returns>
            public static string GetDate(DateFormat format)
            {
                if (format == DateFormat.DD_MM_YYYY)
                    return (DayOfTheMonth.ToString() + "." + Month.ToString() + "." + Year.ToString());
                else if (format == DateFormat.YYYY_MM_DD)
                    return (YearString + "." + MonthString + "." + DayOfTheMonth.ToString());
                else if (format == DateFormat.YYYY_DD_MM)
                    return (Year.ToString() + "." + DayOfTheMonth.ToString() + "." + MonthString);
                else
                    return "Failure";
            }

            /// <summary>
            /// TimeFormat
            /// </summary>
            public enum TimeFormat : byte { hh_mm, hh_mm_ss, mm_ss }
            /// <summary>
            /// Returns the time in the specified time format
            /// </summary>
            /// <param name="format">Time Format</param>
            /// <returns>the time in the specified time format</returns>
            public static string GetTime(TimeFormat format)
            {
                if (format == TimeFormat.hh_mm)
                    return (HourString + ":" + MinuteString);
                else if (format == TimeFormat.hh_mm_ss)
                    return (HourString + ":" + MinuteString + ":" + SecondString);
                else if (format == TimeFormat.mm_ss)
                    return (MinuteString + ":" + SecondString);
                else
                    return "Failure";
            }
        }
        /// <summary>
        /// Function that tries to set the numbers length to 2
        /// </summary>
        /// <param name="value">byte</param>
        /// <returns>new value as string</returns>
        public static string TryAppend(this byte value)
        {
            string val = value.ToString();
            if (val.Length < 2)
                return ("0" + val);
            else
                return val;
        }
    }
}
