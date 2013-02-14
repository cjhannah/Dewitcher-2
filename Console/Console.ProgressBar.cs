using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dewitcher
{
    public static partial class Console
    {
        public class ProgressBar
        {
            private bool flicker = true;
            private int value = 0;
            public int Value
            {
                get { return value; }
                set
                {
                    if (value >= 0 && value <= 100)
                    {
                        this.value = value;
                    }
                }
            }
            /// <summary>
            /// Initialize a new ProgressBar
            /// </summary>
            /// <param name="startValue">Value</param>
            /// <param name="Flicker">true = Very cool effect =)</param>
            public ProgressBar(int startValue, bool Flicker = false)
            {
                this.Value = startValue;
                this.flicker = Flicker;
                this.Refresh();
            }
            public void Increment()
            {
                this.Value++;
                this.Refresh();
            }
            public void Decrement()
            {
                this.Value--;
                this.Refresh();
            }
            /// <summary>
            /// INFO: MaxValue is 100 and MinValue is 0.
            /// </summary>
            /// <param name="value"></param>
            public void Draw()
            {
                int ct = Console.CursorTop;
                int cl = Console.CursorLeft;
                Console.WriteLine();
                string buffer = "[                                                  ] ";
                Console.Write(buffer);
                Console.CursorLeft = cl + 1;
                if (flicker)
                {
                    for (int i = 0; i < this.value / 2; i++)
                    {
                        if (this.value / 2 <= 50) Console.Write("=");
                    }
                }
                else
                {
                    string __buffer = "";
                    for (int i = 0; i < this.value / 2; i++)
                    {
                        if (this.value / 2 <= 50) __buffer += "=";
                    }
                    Console.Write(__buffer);
                }
                Console.CursorLeft = cl + 54;
                Console.Write(this.value.ToString() + "%");
                Console.CursorTop = ct;
                Console.CursorLeft = cl;
            }
            private void Refresh()
            {
                this.Draw();
            }
        }
    }
}
