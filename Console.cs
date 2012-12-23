using System;
using System.Collections.Generic;

namespace dewitcher
{
    /// <summary>
    /// A Console class that contains so much cool features for OS developing ;)
    /// </summary>
    public static class Console
    {
        private static int indent = 0;
        /// <summary>
        /// ForegroundColor Property
        /// </summary>
        public static ConsoleColor ForegroundColor { get { return System.Console.ForegroundColor; } set { System.Console.ForegroundColor = value; } }
        /// <summary>
        /// BackgroundColor Property
        /// </summary>
        public static ConsoleColor BackgroundColor { get { return System.Console.BackgroundColor; } set { System.Console.BackgroundColor = value; } }
        /// <summary>
        /// CursorTop Property
        /// </summary>
        public static int CursorTop { get { return System.Console.CursorTop; } set { System.Console.CursorTop = value; } }
        /// <summary>
        /// CursorLeft Property
        /// </summary>
        public static int CursorLeft { get { return System.Console.CursorLeft; } set { System.Console.CursorLeft = value; } }
        /// <summary>
        /// WindowWidth Property
        /// </summary>
        public static int WindowWidth { get { return System.Console.WindowWidth; } set { System.Console.WindowWidth = value; } }
        /// <summary>
        /// WindowHeight Property
        /// </summary>
        public static int WindowHeight { get { return System.Console.WindowHeight; } set { System.Console.WindowHeight = value; } }
        /// <summary>
        /// Write Method
        /// </summary>
        /// <param name="text">The text to write</param>
        /// <param name="color">The color of the text</param>
        /// <param name="xcenter">Horizontal centered?</param>
        /// <param name="ycenter">Vertical centered?</param>
        public static void Write(string text = "", ConsoleColor color = ConsoleColor.White, bool xcenter = false, bool ycenter = false)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            int X = Console.CursorLeft + indent;
            if (xcenter) Console.CursorLeft = ((Console.WindowWidth / 2) - (text.Length / 2));
            int Y = Console.CursorTop;
            if (ycenter) Console.CursorTop = ((Console.WindowHeight / 2) - 1);
            System.Console.Write(text);
            if (xcenter) Console.CursorLeft = X;
            if (ycenter) Console.CursorTop = Y;
            Console.ForegroundColor = originalColor;
        }
        /// <summary>
        /// WriteLine Method
        /// </summary>
        /// <param name="text">The text to write</param>
        /// <param name="color">The color of the text</param>
        /// <param name="xcenter">Horizontal centered?</param>
        /// <param name="ycenter">Vertical centered?</param>
        public static void WriteLine(string text = "", ConsoleColor color = ConsoleColor.White, bool xcenter = false, bool ycenter = false)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            int X = Console.CursorLeft + indent;
            if (xcenter) Console.CursorLeft = ((Console.WindowWidth / 2) - (text.Length / 2));
            int Y = Console.CursorTop;
            if (ycenter) Console.CursorTop = ((Console.WindowHeight / 2) - 1);
            System.Console.WriteLine(text);
            if (xcenter) Console.CursorLeft = X;
            if (ycenter) Console.CursorTop = Y;
            Console.ForegroundColor = originalColor;
        }
        /// <summary>
        /// Clear Method
        /// </summary>
        public static void Clear() { System.Console.Clear(); Console.CursorTop = 2; }
        /// <summary>
        /// Wipes the first two lines and writes a text like (e.g. "YourOS v0.3") at the horizontal center of the screen
        /// </summary>
        /// <param name="text">The text to write</param>
        /// <param name="color">The color of the text</param>
        public static void DrawLogoBar(string text, ConsoleColor color)
        {
            int curTop = Console.CursorTop;
            int curLeft = Console.CursorLeft;
            for (int i = 0; i < 2; i++)
            {
                Console.CursorTop = i;
                for (int ix = 0; ix < Console.WindowWidth; ix++) Console.Write(" ");
            }
            Console.CursorTop = 0;
            Console.WriteLine(text, color, true);
            if (curTop >= 2) Console.CursorTop = curTop;
            else Console.CursorTop = 2;
            Console.CursorLeft = curLeft;
        }
        public static void CrLf() { Console.WriteLine(); }
        public static void WaitForKeypress() { System.Console.ReadKey(); }
        public static void SetIndent(int _indent)
        {
            Console.indent = _indent;
        }
        /// <summary>
        /// Set the Resolution to 1024x768
        /// </summary>
        public static void SetMode1024x768()
        {
            System.Console.Clear();
            System.Console.BufferWidth = 1024;
            System.Console.BufferHeight = 768;
            System.Console.WindowWidth = 1024;
            System.Console.WindowHeight = 768;
            System.Console.Clear();
        }
    }
}
