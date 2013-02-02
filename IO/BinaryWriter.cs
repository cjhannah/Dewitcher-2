using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dewitcher.IO
{
    public class BinaryWriter
    {
        public Stream BaseStream;
        public BinaryWriter(Stream stream)
        {
            BaseStream = stream;
        }
        public void Write(byte dat)
        {
            BaseStream.Write(dat);
        }
        public void Write(short dat)
        {
            byte[] data = System.BitConverter.GetBytes(dat);
            for (int i = 0; i < data.Length; i++)
                Write(data[i]);
        }
        public void Write(int dat)
        {
            byte[] data = System.BitConverter.GetBytes(dat);
            for (int i = 0; i < data.Length; i++)
                Write(data[i]);
        }
        public void Write(long dat)
        {
            byte[] data = System.BitConverter.GetBytes(dat);
            for (int i = 0; i < data.Length; i++)
                Write(data[i]);
        }
        public void Write(ushort dat)
        {
            byte[] data = System.BitConverter.GetBytes(dat);
            for (int i = 0; i < data.Length; i++)
                Write(data[i]);
        }
        public void Write(uint dat)
        {
            byte[] data = System.BitConverter.GetBytes(dat);
            for (int i = 0; i < data.Length; i++)
                Write(data[i]);
        }
        public void Write(ulong dat)
        {
            byte[] data = System.BitConverter.GetBytes(dat);
            for (int i = 0; i < data.Length; i++)
                Write(data[i]);
        }
        public void Write(bool dat)
        {
            if (dat)
                Write((byte)1);
            else
                Write((byte)0);
        }
        public void Write(byte[] data)
        {
            for (int i = 0; i < data.Length; i++)
                Write(data[i]);
        }
        public void Write(string dat)
        {
            Write((ushort)dat.Length);
            foreach (byte b in dat)
            {
                Write(b);
            }
        }
    }
}
