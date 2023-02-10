// This file is automatically generated.
using System.Runtime.InteropServices;

namespace Steam4NET;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct TSteamAppDependencyInfo
{
    public UInt32 AppId;
    public UInt32 IsRequired;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
    public string szMountName;
};