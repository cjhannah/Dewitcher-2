using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dewitcher.dev.Filesystem.WitchFS
{
    public static class WitchTimestamp
    {
        // Calculate timestamp
        public static string GetCurrentTimestamp()
        {
            // strings
            string Y = ((int)RTC.Now.Year).ToString();
            Y = (string)(Y[2].ToString() + Y[3].ToString());
            string M = RTC.Now.Month.ToString();
            string d = RTC.Now.DayOfTheYear.ToString();
            string h = RTC.Now.Hour.ToString();
            string m = RTC.Now.Minute.ToString();
            string s = RTC.Now.Second.ToString();

            // seed
            float seed = ((float)(int.Parse(s))) / 100f;

            // calculate and return
            int tmp = int.Parse(Y + M + d + h + m + s);
            int final = tmp >> (int)seed;
            return final.ToString();
        }
        public static string GetTimestamp(int Year, int Month, int DayOfYear, int Hour, int Minute, int Second, int Seed)
        {
            // strings
            string Y = Year.ToString();
            Y = (string)(Y[2].ToString() + Y[3].ToString());
            string M = Month.ToString();
            string d = DayOfYear.ToString();
            string h = Hour.ToString();
            string m = Minute.ToString();
            string s = Second.ToString();

            // seed
            float seed = ((float)Second) / 100f;

            // calculate and return
            int tmp = int.Parse(Y + M + d + h + m + s);
            int final = tmp >> (int)seed;
            return final.ToString();
        }
    }
}
