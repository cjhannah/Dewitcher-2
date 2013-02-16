using System;
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
    }
}
