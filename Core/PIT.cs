using System;
using System.Collections.Generic;
// PIT code by Grunt
namespace dewitcher.Core
{
    public static class PIT
    {
        public static void Init(uint frequency)
        {
            uint divisor = 1193180 / frequency;
            IO.cDDI.outb(0x43, 0x36);
            byte l = (byte)(divisor & 0xFF);
            byte h = (byte)((divisor >> 8) & 0xFF);
            IO.cDDI.outb(0x40, l);
            IO.cDDI.outb(0x40, h);
        }
    }
}
