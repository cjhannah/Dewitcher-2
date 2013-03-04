using System;
using System.Collections.Generic;
using dewitcher.IO;

namespace dewitcher.Users.SplittyDev
{
    public unsafe class VideoStreamTest : Stream
    {
        private byte* data;
        public VideoStreamTest()
        {
            data = (byte*)0xB8000;
        }
    }
}
