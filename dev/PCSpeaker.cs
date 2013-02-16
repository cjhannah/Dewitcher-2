using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dewitcher.IO;

namespace dewitcher.dev
{
    public class PCSpeaker
    {
        public static void sound_on()
        {
            CDDI.outb(0x61, (byte)(CDDI.inb(0x61) | 3));
        }
        public static void sound_off()
        {
            CDDI.outb(0x61, (byte)(CDDI.inb(0x61) & ~3));
        }
        public static void Beep(uint frequency)
        {
            Core.PIT.Beep(frequency);
            sound_on();
        }
        public static void Beep(uint frequency, uint milliseconds)
        {
            Beep(frequency);
            RTC.SleepMilliseconds(milliseconds);
            sound_off();
        }
        public struct Notes
        {
            public static uint C1 = 33;
            public static uint CS1 = 35;
            public static uint D1 = 37;
            public static uint DS1 = 39;
            public static uint E1 = 41;
            public static uint F1 = 44;
            public static uint FS1 = 46;
            public static uint G1 = 49;
            public static uint GS1 = 52;
            public static uint A1 = 55; // Exactly 55.000
            public static uint AS1 = 58;
            public static uint B1 = 62;

            public static uint C2 = 65;
            public static uint CS2 = 69;
            public static uint D2 = 73;
            public static uint DS2 = 78;
            public static uint E2 = 82;
            public static uint F2 = 87;
            public static uint FS2 = 92;
            public static uint G2 = 98;
            public static uint GS2 = 104;
            public static uint A2 = 110; // Exactly 110.000
            public static uint AS2 = 117;
            public static uint B2 = 123;
        }
    }
}
