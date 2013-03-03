using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cosmos.IL2CPU.Plugs;
using CPUx86 = Cosmos.Assembler.x86;
using Cosmos.Core;
using IRQContext = Cosmos.Core.INTs.IRQContext;
// Credits for STIEnabler goes to Grunt =)
namespace dewitcher.Core
{
    [Plug(Target = typeof(Cosmos.Core.INTs))]
    public class INTs
    {
        public delegate void IRQ0called();
        public static IRQ0called onCalled = delegate { Core.PIT.called = true; };
        public static void HandleInterrupt_Default(ref IRQContext aContext)
        {
            if (aContext.Interrupt >= 0x20 && aContext.Interrupt <= 0x2F)
            {
                if (aContext.Interrupt >= 0x28)
                {
                    Global.PIC.EoiSlave();
                }
                else
                {
                    Global.PIC.EoiMaster();
                }
            }
        }

        public static void HandleInterrupt_00(ref IRQContext aContext)
        {
            Bluescreen.Init("Divide by zero Exception", "", true); 
        }

        public static void HandleInterrupt_01(ref IRQContext aContext)
        {
            Bluescreen.Init("Debug Exception", "", true); 
        }

        public static void HandleInterrupt_02(ref IRQContext aContext)
        {
            Bluescreen.Init("Non Maskable Interrupt Exception", "", true); 
        }

        public static void HandleInterrupt_03(ref IRQContext aContext)
        {
            Bluescreen.Init("Breakpoint Exception", "", true); 
        }

        public static void HandleInterrupt_04(ref IRQContext aContext)
        {
            Bluescreen.Init("Into Detected Overflow Exception", "", true); 
        }

        public static void HandleInterrupt_05(ref IRQContext aContext)
        {
            Bluescreen.Init("Out of Bounds Exception", "", true); 
        }

        public static void HandleInterrupt_06(ref IRQContext aContext)
        {
            Bluescreen.Init("Invalid Opcode", "", true); 
        }

        public static void HandleInterrupt_07(ref IRQContext aContext)
        {
            Bluescreen.Init("No Coprocessor Exception", "", true); 
        }

        public static void HandleInterrupt_08(ref IRQContext aContext)
        {
            Bluescreen.Init("Double Fault Exception", "", true); 
        }

        public static void HandleInterrupt_09(ref IRQContext aContext)
        {
            Bluescreen.Init("Coprocessor Segment Overrun Exception", "", true); 
        }

        public static void HandleInterrupt_0A(ref IRQContext aContext)
        {
            Bluescreen.Init("Bad TSS Exception", "", true); 
        }

        public static void HandleInterrupt_0B(ref IRQContext aContext)
        {
            Bluescreen.Init("Segment not present", "", true); 
        }

        public static void HandleInterrupt_0C(ref IRQContext aContext)
        {
            Bluescreen.Init("Stack Fault Exception", "", true); 
        }

        public static void HandleInterrupt_0E(ref IRQContext aContext)
        {
            Bluescreen.Init("Page Fault Exception", "", true); 
        }

        public static void HandleInterrupt_0F(ref IRQContext aContext)
        {
            Bluescreen.Init("Unknown Interrupt Exception", "", true); 
        }

        public static void HandleInterrupt_10(ref IRQContext aContext)
        {
            Bluescreen.Init("Coprocessor Fault Exception", "", true); 
        }

        public static void HandleInterrupt_11(ref IRQContext aContext)
        {
            Bluescreen.Init("Alignment Exception", "", true); 
        }

        public static void HandleInterrupt_12(ref IRQContext aContext)
        {
            Bluescreen.Init("Machine Check Exception", "", true); 
        }

        // IRQ0
        public static void HandleInterrupt_20(ref IRQContext aContext)
        {
            Global.PIC.EoiMaster();
            IO.CDDI.outb(0x20, 0x20);
            onCalled();
        }
    }




    public class STIEnabler
    {
        public void Enable()
        {

        }
    }
    [Plug(Target = typeof(STIEnabler))]
    public class Enable : AssemblerMethod
    {
        public override void AssembleNew(object aAssembler, object aMethodInfo)
        {
            new CPUx86.Sti();
        }
    }
}