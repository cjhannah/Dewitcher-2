using System;

namespace dewitcher
{
    public static class Threading
    {
        public static class MainThread
        {
            /// <summary>
            /// NOT RECOMMENDED! Waits for a given amount of ticks. It extremely depends on the CPU speed.
            /// </summary>
            /// <param name="ticks">Amount</param>
            public static void SleepTicks(int ticks)
            {
                for (int i = 0; i < ticks; i++) { ;} return;
            }
            /// <summary>
            /// RECOMMENDED! Waits for a given amount of seconds.
            /// </summary>
            /// <param name="seconds">Amount</param>
            public static void SleepSeconds(int seconds)
            {
                int start = Cosmos.Hardware.RTC.Second; int stop;
                if (start + seconds > 59) stop = 0;
                else stop = start + seconds;
                while (Cosmos.Hardware.RTC.Second != stop) { ;} return;
            }
        }
    }
}
