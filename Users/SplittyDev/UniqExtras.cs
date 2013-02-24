﻿using System;
using System.Collections.Generic;
using Cosmos.IL2CPU.Plugs;
namespace dewitcher.Users.SplittyDev
{
    class UniqExtras
    {
        [Plug(Target = typeof(Byte))]
        public class Byte
        {
            public byte Parse(string toparse)
            {
                bool success = false;
                int tmp = 0;
                try { tmp = int.Parse(toparse); success = true; }
                catch { }
                if (success)
                {
                    return tmp <= (int)byte.MaxValue ? (byte)tmp : (byte)0;
                }
                else return 0;
            }
        }
    }
}