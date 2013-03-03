using System;
using System.Collections.Generic;

namespace dewitcher
{
    public static partial class Console
    {
        public static class Error
        {
            public static void WriteLine(string text)
            {
                Console.WriteLine("[!] ERROR: " + text.ToUpper(), ConsoleColor.Red);
            }
        }
    }
}
