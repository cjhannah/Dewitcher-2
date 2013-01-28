using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dewitcher
{
    /// <summary>
    /// That's the Kenneth class, you see =P
    /// </summary>
    public static class Kenneth
    {
        /// <summary>
        /// Burn the witchcode | ProgressBar demonstration
        /// </summary>
        public static void Burn()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("       TM");
            Console.WriteLine("Kenneth   is burning your witchcode...");
            Console.WriteLine("\n");
            Console.CursorTop = 5;
            Console.WriteLine("Step 1...");
            Console.ProgressBar pb = new Console.ProgressBar(0, false);
            do { pb.Increment(); RTC.SleepTicks(1000000); } while (pb.Value < 100);
            Console.CursorTop = 5;
            Console.WriteLine("Step 2...");
            pb = new Console.ProgressBar(0, false);
            do { pb.Increment(); RTC.SleepTicks(1000000); } while (pb.Value < 100);
            Console.CursorTop = 5;
            Console.WriteLine("Finalizing...");
            pb = new Console.ProgressBar(0, false);
            do { pb.Increment(); RTC.SleepTicks(1000000); } while (pb.Value < 100);
            Console.CursorTop = 5;
            Console.WriteLine("Done! 917384618467296694136487 Errors");
            Console.WriteLine("\n\n\n\nKenneth burned your witchcode.\nThat's a problem because dewitcher is a whole bunch of witchcode.\n\nSorry :/\n\n\nPress [Enter] to restore the witchcode");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
