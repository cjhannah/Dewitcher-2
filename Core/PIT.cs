using System;
using dewitcher.Extensions;
namespace dewitcher.Core
{
    public static class PIT
    {
        public static void Mode0(uint frequency)
        {
            dewitcher.Core.IDT.Remap();
            dewitcher.Core.IRQ.ClearMask(0);
            dewitcher.Core.IRQ.ClearMask(15);
            uint divisor = 1193180 / frequency;
            IO.CDDI.outb(0x43, 0x30);
            IO.CDDI.outb(0x40, (byte)(divisor & 0xFF));
            IO.CDDI.outb(0x40, (byte)((divisor >> 8) & 0xFF));
        }
        public static void Mode2(uint frequency)
        {
            dewitcher.Core.IDT.Remap();
            dewitcher.Core.IRQ.ClearMask(0);
            dewitcher.Core.IRQ.ClearMask(15);
            uint divisor = 1193180 / frequency;
            IO.CDDI.outb(0x43, 0x36);
            IO.CDDI.outb(0x40, (byte)(divisor & 0xFF));
            IO.CDDI.outb(0x40, (byte)((divisor >> 8) & 0xFF));
        }
        public static void Beep(uint frequency)
        {
            uint divisor = 1193180 / frequency;
            IO.CDDI.outb(0x43, 0xB6);
            IO.CDDI.outb(0x42, (byte)(divisor & 0xFF));
            IO.CDDI.outb(0x42, (byte)((divisor >> 8) & 0xFF));
        }
        internal static bool called = false;
        public static void SleepMilliseconds(uint milliseconds)
        {
            if (milliseconds <= 50)
            {
                called = false;
                Core.PIT.Mode0(milliseconds.MsToHz());
                while (!called) { }
                called = false;
            }
            else
            {
                uint mod = milliseconds % 100;
                uint ms = milliseconds - mod;
                for (int i = 0; i < ms; i += 50)
                {
                    called = false;
                    Core.PIT.Mode0(20);
                    while (!called) { }
                }
                called = false;
                ms = mod % 2;
                for (int i = 0; i < ms; i += 2)
                {
                    called = false;
                    Core.PIT.Mode0(500);
                    while (!called) { }
                }
                called = false;
            }
        }
    }
}
