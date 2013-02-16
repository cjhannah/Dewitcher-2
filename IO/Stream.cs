using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dewitcher.IO
{
    public abstract class Stream
    {
        public bool canRead;
        public bool canWrite;
        public uint Position;
        public byte Read()
        {
            if (canRead)
            {
                uint tmp = Position;
                Position++;
                return ReadByte(tmp);
            }
            else
                throw new Exception("Can not read!");
        }
        public void Write(byte b)
        {
            if (canWrite)
            {
                uint tmp = Position;
                Position++;
                WriteByte(tmp, b);
            }
            else
                throw new Exception("Can not Write!");
        }
        public virtual void Flush()
        {
        }
        public void Close()
        {
            Flush();
        }
        internal virtual byte ReadByte(uint p)
        {
            throw new Exception("Read not implemented!");
        }
        internal virtual void WriteByte(uint p, byte b)
        {
            throw new Exception("Write not implemented!");
        }
    }
}
