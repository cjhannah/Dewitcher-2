using Cosmos.Hardware;
using Cosmos.System.Network;
using Console = System.Console;
using System;

namespace dewitcher
{
    public abstract class Kernel : Cosmos.System.Kernel
    {
        public virtual void BeforeShutdown()
        {
        }
    }
}
