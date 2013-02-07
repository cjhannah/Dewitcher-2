using System;
using System.Collections.Generic;
using Console = dewitcher.Console;

namespace dewitcher.Core
{
    public static class Bluescreen
    {
        /// <summary>
        /// Initiates a Bluescreen.
        /// </summary>
        /// <param name="error">Error title or exception name</param>
        /// <param name="description">Error description</param>
        /// <param name="critical">Critical error?</param>
        public static void Init(
            string error = "Something went wrong!",
            string description = "Unknown exception",
            bool critical = false)
        {
            DrawOOPS();
            if (description.Length + 33 < Console.WindowHeight)
            {
                Console.CursorTop = 2; Console.CursorLeft = 33;
                ConsoleColor errcolor = ConsoleColor.White;
                if (critical) errcolor = ConsoleColor.Red;
                Console.WriteLineEx(error, errcolor, ConsoleColor.Blue);
                Console.CursorTop = 4; Console.CursorLeft = 70;
                Console.WriteLineEx(description, ConsoleColor.White, ConsoleColor.Blue);
            }
            else
            {
                Console.CursorTop = 12; Console.CursorLeft = 2;
                ConsoleColor errcolor = ConsoleColor.White;
                if (critical) errcolor = ConsoleColor.Red;
                Console.WriteLineEx(error, errcolor, ConsoleColor.Blue);
                Console.CursorTop = 14; Console.CursorLeft = 2;
                Console.WriteLineEx(description, ConsoleColor.White, ConsoleColor.Blue);
            }
            if (!critical)
            {
                Console.CursorTop = Console.WindowHeight - 1;
                Console.WriteLineEx("Press the [Enter]-key to resume", ConsoleColor.White, ConsoleColor.Blue);
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.CursorTop = Console.WindowHeight - 2;
                Console.WriteLineEx("Press the [Enter]-key to shutdown", ConsoleColor.White, ConsoleColor.Blue);
                Console.WriteLineEx("If it doesn't work, press the RESET-button on your computer.", ConsoleColor.White, ConsoleColor.Blue);
                Console.ReadLine();
                ACPI.Shutdown();
            }
        }
        public static void Init(Exception ex, bool critical = false)
        {
            DrawOOPS();
            if (ex.Message.Length + 33 < Console.WindowHeight)
            {
                Console.CursorTop = 2; Console.CursorLeft = 33;
                ConsoleColor errcolor = ConsoleColor.White;
                if (critical) errcolor = ConsoleColor.Red;
                Console.WriteLineEx(ex.Source, errcolor, ConsoleColor.Blue);
                Console.CursorTop = 4; Console.CursorLeft = 70;
                Console.WriteLineEx(ex.Message, ConsoleColor.White, ConsoleColor.Blue);
            }
            else
            {
                Console.CursorTop = 12; Console.CursorLeft = 2;
                ConsoleColor errcolor = ConsoleColor.White;
                if (critical) errcolor = ConsoleColor.Red;
                Console.WriteLineEx(ex.Source, errcolor, ConsoleColor.Blue);
                Console.CursorTop = 14; Console.CursorLeft = 2;
                Console.WriteLineEx(ex.Message, ConsoleColor.White, ConsoleColor.Blue);
            }
            if (!critical)
            {
                Console.CursorTop = Console.WindowHeight - 1;
                Console.WriteLineEx("Press the [Enter]-key to resume", ConsoleColor.White, ConsoleColor.Blue);
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.CursorTop = Console.WindowHeight - 2;
                Console.WriteLineEx("Press the [Enter]-key to shutdown", ConsoleColor.White, ConsoleColor.Blue);
                Console.WriteLineEx("If it doesn't work, press the RESET-button on your computer.", ConsoleColor.White, ConsoleColor.Blue);
                Console.ReadLine();
                ACPI.Shutdown();
            }
        }
        private static void DrawOOPS()
        {
            Console.Fill(ConsoleColor.Blue);
            string[] arrOOPS = new string[] {
                "======  ======  =====  =====  =",
                "=    =  =    =  =   =  =      =",
                "=    =  =    =  =====  =====  =",
                "=    =  =    =  =          =   ",
                "======  ======  =      =====  ="};
            Console.CursorTop = 2;
            foreach (string str in arrOOPS)
            {
                Console.CursorLeft = 2;
                Console.WriteLineEx(str, ConsoleColor.White, ConsoleColor.Blue);
            }
        }
        /// <summary>
        /// Kernel Panic
        /// </summary>
        public static void Panic()
        {
            Console.Clear();
            Console.Fill(ConsoleColor.Red);
            Console.CursorTop = 2;
            Console.WriteLineEx("KERNEL PANIC", ConsoleColor.White, ConsoleColor.Red, true);
            Console.WriteLine("\n");
            string message = "CRITICAL KERNEL EXCEPTION\nPLEASE CONTACT YOUR SOFTWARE MANUFACTURER";
            Console.WriteLineEx(message, ConsoleColor.White, ConsoleColor.Red, true);
            // Enter an infinite loop
            while (true)
            {

            }
        }
    }
}
