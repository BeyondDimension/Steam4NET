// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct SteamSalt
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public Byte[] uchSalt;
	};
	
}
