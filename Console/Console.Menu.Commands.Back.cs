using System;
using System.Collections.Generic;

namespace dewitcher
{
    public static partial class Console
    {
        internal class Back : Entry
        {
            public Back() { this.text = "Back to Main Menu"; }
            public override void Execute()
            {
                Menu.menu = 3;
            }
        }
    }
}
