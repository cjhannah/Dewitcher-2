using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dewitcher
{
    public static partial class Console
    {
        public static void RollUp(uint mspause)
        {
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 80; j++)
                {
                    Console.Write(" ");
                }
                Core.PIT.SleepMilliseconds(mspause);
            }
            Console.Clear();
        }
    }
}
