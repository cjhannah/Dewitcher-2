using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dewitcher.IO
{
    public unsafe class MemoryStream : Stream
    {
        private byte* data;
        private uint length;
        public MemoryStream(byte* dat)
        {
            length = sizeof(uint);
            data = dat;
        }
        public MemoryStream(byte[] dat)
        {
            length = (uint)dat.Length;
            fixed (byte* ptr = dat)
            {
                data = ptr;
            }
        }
        protected override byte ReadByte(uint p)
        {
            if (p > length)
                throw new Exception("End of Stream!");
            return data[p];
        }
        protected override void WriteByte(uint p, byte b)
        {
            if (p > length)
                throw new Exception("End of Stream!");
            data[p] = b;
        }
    }
}
