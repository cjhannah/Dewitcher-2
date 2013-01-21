using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dewitcher
{
    public static class Bluescreen
    {
        private const string bserr = "Something has gone wrong!";
        private const string bsdesc = "The Kernel throwed an exception.\nThe exception is undefined,\nso I don't know what kind of error it is.\nSorry :(";
        public static void Show(bool critical = false, string error = bserr, string description = bsdesc)
        {
            Console.ClearExtended(ConsoleColor.Blue);
            DrawOOPS();
            if (description.Length + 70 < Console.WindowHeight)
            {
                Console.CursorTop = 2; Console.CursorLeft = 70;
                ConsoleColor errcolor = ConsoleColor.White;
                if (critical) errcolor = ConsoleColor.Red;
                Console.WriteLine(error, errcolor);
                Console.CursorTop = 4; Console.CursorLeft = 70;
                Console.WriteLine(description, ConsoleColor.White);
            }
            else
            {
                Console.CursorTop = 12; Console.CursorLeft = 2;
                ConsoleColor errcolor = ConsoleColor.White;
                if (critical) errcolor = ConsoleColor.Red;
                Console.WriteLine(error, errcolor);
                Console.CursorTop = 14; Console.CursorLeft = 2;
                Console.WriteLine(description, ConsoleColor.White);
            }
            if (!critical)
            {
                Console.CursorTop = Console.WindowHeight - 1;
                Console.WriteLine("Press the [Enter]-key to resume");
            }
            else
            {
                Console.CursorTop = Console.WindowHeight - 2;
                Console.WriteLine("Press the [Enter]-key to shutdown");
                Console.WriteLine("If it doesn't work, press the RESET-button on your computer.");
            }
        }
        private static void DrawOOPS()
        {
            string[] arrOOPS = new string[] {
                "==============  ==============  =============   =============   ==",
                "=            =  =            =  =           ==  =               ==",
                "=            =  =            =  =            =  =               ==",
                "=            =  =            =  =           ==  =               ==",
                "=            =  =            =  =============   =============   ==",
                "=            =  =            =  =                           =   ==",
                "=            =  =            =  =                           =     ",
                "=            =  =            =  =                           =     ",
                "==============  ==============  =               =============   ==" };
            Console.CursorTop = 2;
            Console.CursorLeft = 4;
            foreach (string str in arrOOPS)
            {
                Console.WriteLine(str, ConsoleColor.White);
            }
        }
    }
}
