// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	public enum EConnectionPriority : int
	{
		k_EConnectionPriorityLow = 0,
		k_EConnectionPriorityMedium = 1,
		k_EConnectionPriorityHigh = 2,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(601)]
	public struct CSClientApprove_t
	{
		public const int k_iCallback = 601;
		public SteamID_t m_SteamID;
		public UInt32 m_uContentID;
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	[CallbackIdentity(602)]
	public struct CSClientDeny_t
	{
		public const int k_iCallback = 602;
		public SteamID_t m_SteamID;
		public UInt32 m_uContentID;
		public EDenyReason m_eDenyReason;
	};
	
}