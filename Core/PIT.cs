using System;
using System.Collections.Generic;
// PIT code by Grunt
namespace dewitcher.Core
{
    public static class PIT
    {

        // Mode0 AND Mode2 doesn't seem to work.
        // I don't know why..
        // Please take a look at the methods, Grunty or Aurora

        public static void Mode0(uint frequency)
        {
            uint divisor = 1193180 / frequency;
            IO.cDDI.outb(0x43, 0x30);
            byte l = (byte)(divisor & 0xFF);
            byte h = (byte)(divisor >> 8);
            IO.cDDI.outb(0x40, l);
            IO.cDDI.outb(0x40, h);
        }
        public static void Mode2(uint frequency)
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
