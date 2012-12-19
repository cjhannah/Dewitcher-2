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
            /// Returns the minute
            /// </summary>
            public static byte Minute { get { return Cosmos.Hardware.RTC.Minute; } }
            /// <summary>
            /// Returns the second
            /// </summary>
            public static byte Second { get { return Cosmos.Hardware.RTC.Second; } }
            /// <summary>
            /// Returns the century
            /// </summary>
            public static byte Century { get { return Cosmos.Hardware.RTC.Century; } }
            /// <summary>
            /// Returns the year (e.g. 2012)
            /// </summary>
            public static int Year { get { return int.Parse(((Century - 1).ToString() + Cosmos.Hardware.RTC.Year.ToString())); } }
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
                    return (Year.ToString() + "." + Month.ToString() + "." + DayOfTheMonth.ToString());
                else if (format == DateFormat.YYYY_DD_MM)
                    return (Year.ToString() + "." + DayOfTheMonth.ToString() + "." + Month.ToString());
                else
                    return "Failure";
            }
        }
    }
}
