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
            private static Stack<VideoBuffer> vbufferStack = new Stack<VideoBuffer>();
            private static List<VideoBuffer> vbufferList = new List<VideoBuffer>();
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
                vbufferStack.Push(vb);
            }
            /// <summary>
            /// Pops the content of the stack into Video RAM
            /// </summary>
            public static void PopContents()
            {
                VideoBuffer vb = vbufferStack.Pop();
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
                for (int i = 0; i < vbufferList.Count; i++)
                {
                    if (vbufferList[i].id == name)
                    {
                        found = true;
                        // Set new content
                        byte* vram = (byte*)0xB8000;
                        vbufferList[i].data = new byte[4250];
                        for (int j = 0; j < 4250; j++)
                        {
                            byte b = vram[j];
                            vbufferList[i].data[j] = b;
                        }
                        vbufferList[i].X = CursorLeft;
                        vbufferList[i].Y = CursorTop;
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
                    vbufferList.Add(vb);
                }
            }
            /// <summary>
            /// Restores the Console content
            /// </summary>
            /// <param name="name"></param>
            public static void RetContent(string name)
            {
                for (int i = 0; i < vbufferList.Count; i++)
                {
                    if (vbufferList[i].id == name)
                    {
                        // restore content
                        byte* vram = (byte*)0xB8000;
                        for (int j = 0; j < 4250; j++)
                        {
                            vram[j] = vbufferList[i].data[j];
                        }
                        CursorLeft = vbufferList[i].X;
                        CursorTop = vbufferList[i].Y;
                        break;
                    }
                }
            }
        }
    }
}