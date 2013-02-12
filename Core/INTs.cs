using System;
using System.Runtime.InteropServices;
using Cosmos.IL2CPU.Plugs;
using CPUx86 = Cosmos.Assembler.x86;
// Credits for STIEnabler goes to Grunt =)
namespace dewitcher.Core
{
    [Plug(Target = typeof(Cosmos.Core.INTs))]
    public class INTs
    {
        public static bool called = false;
        public static void HandleInterrupt_Default(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            //aContext.EFlags = Cosmos.Core.INTs.EFlagsEnum.InterruptEnable;
            STIEnabler sti = new STIEnabler();
            sti.Enable();
        }
        public static void HandleInterrupt_00(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            // Should be called by the PIT
            called = true;
            Console.WriteLine("Interrupt called!");
        }
        public static void HandleInterrupt_01(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            
            Bluescreen.Panic();
        }
        public static void HandleInterrupt_02(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            
            Bluescreen.Panic();
        }
        public static void HandleInterrupt_03(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            
            Bluescreen.Panic();
        }
        public static void HandleInterrupt_04(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            
            Bluescreen.Panic();
        }
        public static void HandleInterrupt_05(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            
            Bluescreen.Panic();
        }
        public static void HandleInterrupt_06(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            
            Bluescreen.Panic();
        }
        public static void HandleInterrupt_07(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            
            Bluescreen.Panic();
        }
        public static void HandleInterrupt_08(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            
            Bluescreen.Panic();
        }
        public static void HandleInterrupt_09(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            
            Bluescreen.Panic();
        }
        public static void HandleInterrupt_0A(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            
            Bluescreen.Panic();
        }
        public static void HandleInterrupt_0B(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            
            Bluescreen.Panic();
        }
        public static void HandleInterrupt_0C(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            
            Bluescreen.Panic();
        }
        public static void HandleInterrupt_0D(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            
            Bluescreen.Panic();
        }
        public static void HandleInterrupt_0E(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            
            Bluescreen.Panic();
        }
        public static void HandleInterrupt_0F(ref Cosmos.Core.INTs.IRQContext aContext)
        {
            
            Bluescreen.Panic();
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
            Console.WriteLine("STI ENABLED");
            new CPUx86.Sti();
        }
    }
}