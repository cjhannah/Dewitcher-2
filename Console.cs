using System;
using System.Collections.Generic;
// Grunt was here!
namespace dewitcher
{
    
    /// <summary>
    /// A Console class that contains so much cool features for OS developing ;)
    /// </summary>
    public unsafe static partial class Console
    {
        class VideoBuffer
        {
            public byte[] data;
            public int X, Y;
        }
        private static Stack<VideoBuffer> videoBuffers = new Stack<VideoBuffer>();
        /// <summary>
        /// Pushes what is in video RAM onto a stack
        /// </summary>
        public static void PushContents()
        {
            VideoBuffer vb = new VideoBuffer();
            byte* VideoRam = (byte*)0xB8000;
            vb.data = new byte[4250];
            for (int i = 0; i < 4250; i++)
            {
                byte b = VideoRam[i];
                vb.data[i] = b;
            }
            vb.X = CursorLeft;
            vb.Y = CursorTop;
            videoBuffers.Push(vb);
        }
        public static void PopContents()
        {
            VideoBuffer vb = videoBuffers.Pop();
            byte* VideoRam = (byte*)0xB8000;
  
            for (int i = 0; i < 4250; i++)
            {
                VideoRam[i] = vb.data[i];
            
            }
            CursorLeft = vb.X;
            CursorTop = vb.Y;
        }
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
        /// KeyAvailable Property
        /// </summary>
        public static bool KeyAvailable { get { return System.Console.KeyAvailable; } }
        /// <summary>
        /// Write Method
        /// </summary>
        /// <param name="text">The text to write</param>
        /// <param name="color">The color of the text</param>
        /// <param name="xcenter">Horizontal centered?</param>
        /// <param name="ycenter">Vertical centered?</param>
        public static void Write(string text = "", ConsoleColor color = ConsoleColor.White, bool xcenter = false, bool ycenter = false)
        {
            ConsoleColor originalColor = ForegroundColor;
            ForegroundColor = color;
            int X = CursorLeft + indent;
            if (xcenter) CursorLeft = ((WindowWidth / 2) - (text.Length / 2));
            int Y = CursorTop;
            if (ycenter) CursorTop = ((WindowHeight / 2) - 1);
            System.Console.Write(text);
            if (xcenter) CursorLeft = X;
            if (ycenter) CursorTop = Y;
            ForegroundColor = originalColor;
        }
        /// <summary>
        /// Write Method
        /// </summary>
        /// <param name="text">The text to write</param>
        /// <param name="color">The color of the text</param>
        /// <param name="backcolor">The background color of the text</param>
        /// <param name="xcenter">Horizontal centered?</param>
        /// <param name="ycenter">Vertical centered?</param>
        public static void WriteEx(string text = "", ConsoleColor color = ConsoleColor.White, ConsoleColor backcolor = ConsoleColor.Black, bool xcenter = false, bool ycenter = false)
        {
            ConsoleColor originalColor = ForegroundColor;
            ConsoleColor originalColor2 = BackgroundColor;
            ForegroundColor = color;
            BackgroundColor = backcolor;
            int X = CursorLeft + indent;
            if (xcenter) CursorLeft = ((WindowWidth / 2) - (text.Length / 2));
            int Y = CursorTop;
            if (ycenter) CursorTop = ((WindowHeight / 2) - 1);
            System.Console.Write(text);
            if (xcenter) CursorLeft = X;
            if (ycenter) CursorTop = Y;
            ForegroundColor = originalColor;
            BackgroundColor = originalColor2;
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
            ConsoleColor originalColor = ForegroundColor;
            ForegroundColor = color;
            int X = CursorLeft + indent;
            if (xcenter) CursorLeft = ((WindowWidth / 2) - (text.Length / 2));
            int Y = CursorTop;
            if (ycenter) CursorTop = ((WindowHeight / 2) - 1);
            System.Console.WriteLine(text);
            if (xcenter) CursorLeft = X;
            if (ycenter) CursorTop = Y;
            ForegroundColor = originalColor;
        }
        /// <summary>
        /// WriteLine Method
        /// </summary>
        /// <param name="text">The text to write</param>
        /// <param name="color">The color of the text</param>
        /// <param name="backcolor">The background color of the text</param>
        /// <param name="xcenter">Horizontal centered?</param>
        /// <param name="ycenter">Vertical centered?</param>
        public static void WriteLineEx(string text = "", ConsoleColor color = ConsoleColor.White, ConsoleColor backcolor = ConsoleColor.Black, bool xcenter = false, bool ycenter = false)
        {
            ConsoleColor originalColor = ForegroundColor;
            ConsoleColor originalColor2 = BackgroundColor;
            ForegroundColor = color;
            BackgroundColor = backcolor;
            int X = CursorLeft + indent;
            if (xcenter) CursorLeft = ((WindowWidth / 2) - (text.Length / 2));
            int Y = CursorTop;
            if (ycenter) CursorTop = ((WindowHeight / 2) - 1);
            System.Console.WriteLine(text);
            if (xcenter) CursorLeft = X;
            if (ycenter) CursorTop = Y;
            ForegroundColor = originalColor;
            BackgroundColor = originalColor2;
        }
        public static void Fill(ConsoleColor color)
        {
            Console.Clear();
            ConsoleColor backup = Console.BackgroundColor;
            Console.BackgroundColor = color;
            for (int ih = 0; ih < Cosmos.Hardware.Global.TextScreen.Rows; ++ih)
            {
                Console.CursorTop = ih;
                for (int iw = 0; iw < Cosmos.Hardware.Global.TextScreen.Cols; ++iw)
                {
                    Console.CursorLeft = iw;
                    Console.BackgroundColor = color;
                    Console.Write(" ");
                }
            }
            Console.BackgroundColor = backup;
        }
        /// <summary>
        /// Clear Method
        /// </summary>
        public static void Clear() { System.Console.Clear(); }
        /// <summary>
        /// Extended Clear Method
        /// </summary>
        /// <param name="BackgroundColor"></param>
        public static void ClearExtended(ConsoleColor BackgroundColor)
        {
            Fill(BackgroundColor);
        }
        /// <summary>
        /// Wipes the first two lines and writes a text (e.g. "YourOSName") at the horizontal center of the screen
        /// </summary>
        /// <param name="text">The text to write</param>
        /// <param name="color">The color of the text</param>
        public static void DrawLogoBar(string text, ConsoleColor color)
        {
            int curTop = CursorTop;
            int curLeft = CursorLeft;
            for (int i = 0; i < 2; i++)
            {
                CursorTop = i;
                for (int ix = 0; ix < WindowWidth; ix++) Write(" ");
            }
            CursorTop = 0;
            WriteLine(text, color, true);
            if (curTop >= 2) CursorTop = curTop;
            else CursorTop = 2;
            CursorLeft = curLeft;
        }
        /// <summary>
        /// Inserts a line break
        /// </summary>
        public static void NewLine() { WriteLine(); }
        /// <summary>
        /// System.Console.Read()-Implementation
        /// </summary>
        /// <returns></returns>
        public static int Read() { return System.Console.Read(); }
        /// <summary>
        /// System.Console.ReadKey()-Implementation
        /// </summary>
        /// <returns></returns>
        public static ConsoleKeyInfo ReadKey() { return System.Console.ReadKey(); }
        /// <summary>
        /// System.Console.ReadLine()-Implementation
        /// </summary>
        /// <returns></returns>
        public static string ReadLine() { return System.Console.ReadLine(); }
        /// <summary>
        /// Sets a custom indent
        /// </summary>
        /// <param name="_indent"></param>
        public static void SetIndent(int _indent)
        {
            indent = _indent;
        }
    }
}
