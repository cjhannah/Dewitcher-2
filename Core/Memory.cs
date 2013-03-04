﻿using System;
using System.Collections.Generic;

namespace dewitcher.Core
{
    public static unsafe class Memory
    {
        public static void MemAlloc(uint length)
        {
            Cosmos.Core.Heap.MemAlloc(length);
        }
        public static unsafe void MemRemove(byte start, uint offset, uint length)
        {
            byte* ptr = (byte*)start;
            for (uint i = offset; i < offset + length; i++ )
            {
                ptr[i] = 0;
            }
        }
        public static unsafe void MemCopy(byte source, byte destination, uint offset, uint length)
        {
            byte* src = (byte*)source;
            byte* dst = (byte*)destination;
            for (uint i = offset; i < offset + length; i++)
            {
                dst[i] = src[i];
            }
        }
        public static unsafe void MemMove(byte source, byte destination, uint offset, uint length)
        {
            byte* src = (byte*)source;
            byte* dst = (byte*)destination;
            for (uint i = offset; i < offset + length; i++)
            {
                dst[i] = src[i];
                src[i] = 0;
            }
        }
        public static unsafe bool MemCompare(byte source1, byte source2, uint offset, uint length)
        {
            byte* ptr1 = (byte*)source1;
            byte* ptr2 = (byte*)source2;
            for (uint i = offset; i < offset + length; i++)
            {
                if (ptr1[i] != ptr2[i]) return false;
            }
            return true;
        }
    }
}
