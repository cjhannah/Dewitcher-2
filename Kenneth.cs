using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dewitcher
{
    /// <summary>
    /// KENNETH
    /// Why so serious?
    /// </summary>
    public static class Kenneth
    {
        /// <summary>
        /// That's not a joke!
        /// </summary>
        public static void CrapLoop()
        {
            Console.Clear();
            while (true) Console.Write("CRAP!", ConsoleColor.DarkRed);
        }
        /// <summary>
        /// Repairs your PC
        /// Srsly
        /// </summary>
        public static unsafe void RepairPC()
        {
            // Haha
            byte* vram = (byte*)0xB8000;
            for (int i = 0; i >= 0; i++)
            {
                vram[i] = (byte)~vram[i];
            }
        }
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
