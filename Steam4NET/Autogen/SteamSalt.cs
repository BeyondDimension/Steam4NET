// This file is automatically generated.
using System;
using System.Runtime.InteropServices;

namespace Steam4NET
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct SteamSalt
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public Byte[] uchSalt;
    };
}