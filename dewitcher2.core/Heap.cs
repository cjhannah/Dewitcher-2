using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dewitcher2.Core
{
    public class Heap
    {
        public static void MemAlloc(uint length)
        {
            Cosmos.Core.Heap.MemAlloc(length);
        }
    }
    public class GetRAM
    {
        public static uint GetAmountOfRAM = Cosmos.Core.CPU.GetAmountOfRAM();
    }
}
