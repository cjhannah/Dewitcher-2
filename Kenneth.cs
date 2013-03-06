/*
Copyright (c) 2012-2013, dewitcher Team
All rights reserved.

Redistribution and use in source and binary forms, with or without modification,
are permitted provided that the following conditions are met:

* Redistributions of source code must retain the above copyright notice
   this list of conditions and the following disclaimer.

* Redistributions in binary form must reproduce the above copyright notice,
  this list of conditions and the following disclaimer in the documentation
  and/or other materials provided with the distribution.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR
IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR
CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER
IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF
THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/

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
