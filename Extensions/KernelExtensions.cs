using System;

namespace dewitcher.Extensions
{
    /// <summary>
    /// Useful kernel extensions
    /// </summary>
    public static class KernelExtensions
    {
        public static void Shutdown(this Cosmos.System.Kernel krnl) { ACPI.Shutdown(); }
        public static void SleepTicks(this Cosmos.System.Kernel krnl, int amount) { Threading.MainThread.SleepTicks(amount); }
        public static void SleepSeconds(this Cosmos.System.Kernel krnl, int amount) { Threading.MainThread.SleepSeconds(amount); }
    }
}
