// This file is automatically generated.
using System.Runtime.InteropServices;

namespace Steam4NET;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct servernetadr_t
{
    public UInt16 m_usConnectionPort;
    public UInt16 m_usQueryPort;
    public UInt32 m_unIP;
};