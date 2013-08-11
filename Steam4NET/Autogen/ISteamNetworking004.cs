// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("SteamNetworking004")]
	public interface ISteamNetworking004
	{
		[VTableSlot(0)]
		bool SendP2PPacket(CSteamID steamIDRemote, Byte[] pubData, UInt32 cubData, EP2PSend eP2PSendType, Int32 iVirtualPort);
		[VTableSlot(1)]
		bool IsP2PPacketAvailable(ref UInt32 pcubMsgSize, Int32 iVirtualPort);
		[VTableSlot(2)]
		bool ReadP2PPacket(Byte[] pubDest, UInt32 cubDest, ref UInt32 pcubMsgSize, ref CSteamID psteamIDRemote, Int32 iVirtualPort);
		[VTableSlot(3)]
		bool AcceptP2PSessionWithUser(CSteamID steamIDRemote);
		[VTableSlot(4)]
		bool CloseP2PSessionWithUser(CSteamID steamIDRemote);
		[VTableSlot(5)]
		bool GetP2PSessionState(CSteamID steamIDRemote, ref P2PSessionState_t pConnectionState);
		[VTableSlot(6)]
		UInt32 CreateListenSocket(Int32 nVirtualP2PPort, UInt32 nIP, UInt16 nPort, bool bAllowUseOfPacketRelay);
		[VTableSlot(7)]
		UInt32 CreateP2PConnectionSocket(CSteamID steamIDTarget, Int32 nVirtualPort, Int32 nTimeoutSec, bool bAllowUseOfPacketRelay);
		[VTableSlot(8)]
		UInt32 CreateConnectionSocket(UInt32 nIP, UInt16 nPort, Int32 nTimeoutSec);
		[VTableSlot(9)]
		bool DestroySocket(UInt32 hSocket, bool bNotifyRemoteEnd);
		[VTableSlot(10)]
		bool DestroyListenSocket(UInt32 hSocket, bool bNotifyRemoteEnd);
		[VTableSlot(11)]
		bool SendDataOnSocket(UInt32 hSocket, Byte[] pubData, UInt32 cubData, bool bReliable);
		[VTableSlot(12)]
		bool IsDataAvailableOnSocket(UInt32 hSocket, ref UInt32 pcubMsgSize);
		[VTableSlot(13)]
		bool RetrieveDataFromSocket(UInt32 hSocket, Byte[] pubDest, UInt32 cubDest, ref UInt32 pcubMsgSize);
		[VTableSlot(14)]
		bool IsDataAvailable(UInt32 hListenSocket, ref UInt32 pcubMsgSize, ref UInt32 phSocket);
		[VTableSlot(15)]
		bool RetrieveData(UInt32 hListenSocket, Byte[] pubDest, UInt32 cubDest, ref UInt32 pcubMsgSize, ref UInt32 phSocket);
		[VTableSlot(16)]
		bool GetSocketInfo(UInt32 hSocket, ref CSteamID pSteamIDRemote, ref Int32 peSocketStatus, ref UInt32 punIPRemote, ref UInt16 punPortRemote);
		[VTableSlot(17)]
		bool GetListenSocketInfo(UInt32 hListenSocket, ref UInt32 pnIP, ref UInt16 pnPort);
		[VTableSlot(18)]
		ESNetSocketConnectionType GetSocketConnectionType(UInt32 hSocket);
		[VTableSlot(19)]
		Int32 GetMaxPacketSize(UInt32 hSocket);
	};
}
