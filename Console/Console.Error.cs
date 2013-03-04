using System;
using System.Collections.Generic;

namespace dewitcher
{
    public static partial class Console
    {
        public static class Error
        {
            public static void Write(string text)
            {
                Console.Write("[!] ERROR: " + text.ToUpper(), ConsoleColor.Red);
            }
            public static void WriteLine(string text)
            {
                Console.WriteLine("[!] ERROR: " + text.ToUpper(), ConsoleColor.Red);
            }
        }
    }
}
