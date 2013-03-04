using System;
using System.Collections.Generic;
// Have to optimize that..
// Grunt: Probally want to make this inherit Stream???? 
// Splitty: I will try it later =)
namespace dewitcher.IO
{
    public unsafe class VideoStream
    {
        private MemoryStream stream;
        public VideoStream()
        {
            stream = new MemoryStream((byte*)0xB8000);
        }
        public byte ReadByte(uint p)
        {
            return stream.ReadByte(p);
        }
        public void WriteByte(uint p, byte b)
        {
            stream.WriteByte(p, b);
        }
    }
}
