using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dewitcher.IO
{
    public unsafe class MemoryStream : Stream
    {
        private bool eof;
        public bool EOF { get { return eof; } }
        private byte* data;
        private uint length;
        public MemoryStream(byte* dat)
        {
            eof = false;
            length = sizeof(uint);
            data = dat;
        }
        public MemoryStream(byte[] dat)
        {
            eof = false;
            length = (uint)dat.Length;
            fixed (byte* ptr = dat)
            {
                data = ptr;
            }
        }
        protected override byte ReadByte(uint p)
        {
            if (p > length)
                eof = true;
            return data[p];
        }
        protected override void WriteByte(uint p, byte b)
        {
            if (p > length)
                eof = true;
            data[p] = b;
        }
    }
}
