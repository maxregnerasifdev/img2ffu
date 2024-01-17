﻿using System.Runtime.InteropServices;

namespace Img2Ffu.Structures.Structs
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ValidationEntry
    {
        public uint dwSectorIndex;
        public uint dwSectorOffset;
        public uint dwByteCount;
    }
}