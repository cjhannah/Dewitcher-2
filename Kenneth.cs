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
        /// Burn the witchcode
        /// </summary>
        public static void Burn()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("       TM");
            Console.WriteLine("Kenneth   is burning your witchcode...");
            Console.WriteLine("\n");
            Console.CursorTop = 5;
            Console.WriteLine("Preparing...");
            Console.ProgressBar pb = new Console.ProgressBar(0, false);
            do { pb.Increment(); RTC.SleepTicks(500000); } while (pb.Value < 100);
            Console.CursorTop = 5;
            Console.WriteLine("Burning witchcode...");
            pb = new Console.ProgressBar(0, false);
            // This script will TOTALLY fuck your memory =P
            unsafe
            {
                int* ptr = (int*)0;
                for (int i = 0; i > -1; i++)
                {
                    pb.Increment();
                    // Fuck memory
                    ptr[i] = (int)~ptr[i];
                }
            }
            Console.ReadLine();
            Core.ACPI.Shutdown();
        }
    }
}
