using System;
using System.Collections.Generic;

namespace dewitcher
{
    public unsafe static partial class Console
    {
        public unsafe static class VideoRAM
        {
            internal class VideoBuffer
            {
                public string id;
                public byte[] data;
                public int X, Y;
            }
            private static Stack<VideoBuffer> vBufferStack = new Stack<VideoBuffer>();
            private static List<VideoBuffer> vBuffers = new List<VideoBuffer>();
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
                vBufferStack.Push(vb);
            }
            /// <summary>
            /// Pops the content of the stack into Video RAM
            /// </summary>
            public static void PopContents()
            {
                VideoBuffer vb = vBufferStack.Pop();
                byte* VideoRam = (byte*)0xB8000;

                for (int i = 0; i < 4250; i++)
                {
                    VideoRam[i] = vb.data[i];

                }
                CursorLeft = vb.X;
                CursorTop = vb.Y;
            }
            /// <summary>
            /// Saves the Console content
            /// </summary>
            /// <param name="num"></param>
            public static void SetContent(string name)
            {
                bool found = false;
                for (int i = 0; i < vBuffers.Count; i++)
                {
                    if (vBuffers[i].id == name)
                    {
                        found = true;
                        // Delete old content
                        vBuffers[i].X = 0;
                        vBuffers[i].Y = 0;
                        vBuffers[i].id = "";
                        vBuffers[i].data = new byte[] { };
                        // Set new content
                        byte* vram = (byte*)0xB8000;
                        vBuffers[i].data = new byte[4250];
                        for (int _i = 0; i < 4250; i++)
                        {
                            byte b = vram[i];
                            vBuffers[i].data[_i] = b;
                        }
                        vBuffers[i].X = CursorLeft;
                        vBuffers[i].Y = CursorTop;
                        break;
                    }
                }
                if (!found)
                {
                    VideoBuffer vb = new VideoBuffer();
                    byte* vram = (byte*)0xB8000;
                    vb.data = new byte[4250];
                    for (int i = 0; i < 4250; i++)
                    {
                        byte b = vram[i];
                        vb.data[i] = b;
                    }
                    vb.X = CursorLeft;
                    vb.Y = CursorTop;
                    vBuffers.Add(vb);
                }
            }
            /// <summary>
            /// Restores the Console content
            /// </summary>
            /// <param name="name"></param>
            public static void RetContent(string name)
            {
                for (int i = 0; i < vBuffers.Count; i++)
                {
                    if (vBuffers[i].id == name)
                    {
                        // restore content
                        byte* vram = (byte*)0xB8000;
                        for (int _i = 0; i < 4250; i++)
                        {
                            vram[_i] = vBuffers[i].data[_i];
                        }
                        CursorLeft = vBuffers[i].X;
                        CursorTop = vBuffers[i].Y;
                        break;
                    }
                }
            }
        }
    }
}