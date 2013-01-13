using System;

namespace dewitcher.Extensions
{
    /// <summary>
    /// Useful kernel extensions
    /// </summary>
    public static class KernelExtensions
    {
        public static void Shutdown(this Cosmos.System.Kernel krnl) { ACPI.Shutdown(); }
        public static void SleepTicks(this Cosmos.System.Kernel krnl, int amount) { RTC.Sleep.SleepTicks(amount); }
        public static void SleepSeconds(this Cosmos.System.Kernel krnl, int amount) { RTC.Sleep.SleepSeconds(amount); }
        public static uint GetMemory(this Cosmos.System.Kernel krnl) { return Cosmos.Core.CPU.GetAmountOfRAM() + 1; }
    }
}
