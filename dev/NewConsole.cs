using System;
using System.Collections.Generic;
using Cosmos.IL2CPU.Plugs;

namespace dewitcher.dev
{
    [Plug(Target=typeof(System.Console))]
    public class Console
    {
        public static void WriteLine(string text)
        {
            System.Console.WriteLine("IT WORKS");
        }
    }
}
