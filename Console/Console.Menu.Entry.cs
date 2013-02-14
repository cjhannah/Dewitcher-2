using System;

namespace dewitcher
{
    public static partial class Console
    {
        public abstract class Entry
        {
            public string text;
            public abstract void Execute();
        }
    }
}
