using System;

namespace dewitcher
{
    public static partial class Console
    {
        public partial class Menu
        {
            public class Themepack
            {
                private ConsoleColor[] colors;
                public Themepack(ConsoleColor fill, ConsoleColor box, ConsoleColor text, ConsoleColor highlighted, ConsoleColor arrow)
                {
                    colors = new ConsoleColor[5];
                    colors[0] = fill;
                    colors[1] = box;
                    colors[2] = text;
                    colors[3] = highlighted;
                    colors[4] = arrow;
                }
                public void Apply()
                {
                    Menu.ApplyThemePack(colors);
                }
            }
        }
    }
}
