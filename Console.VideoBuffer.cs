using System;
using System.Collections.Generic;

namespace dewitcher
{
    public unsafe static partial class Console
    {
        internal class VideoBuffer
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
        /// <summary>
        /// Pops the content of the stack in video RAM
        /// </summary>
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
    }
}