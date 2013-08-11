// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("SteamMatchMaking003")]
	public interface ISteamMatchmaking003
	{
		[VTableSlot(0)]
		Int32 GetFavoriteGameCount();
		[VTableSlot(1)]
		bool GetFavoriteGame(Int32 iGame, ref UInt32 pnAppID, ref UInt32 pnIP, ref UInt16 pnConnPort, ref UInt16 pnQueryPort, ref UInt32 punFlags, ref UInt32 pRTime32LastPlayedOnServer);
		[VTableSlot(2)]
		Int32 AddFavoriteGame(UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags, UInt32 rTime32LastPlayedOnServer);
		[VTableSlot(3)]
		bool RemoveFavoriteGame(UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags);
		[VTableSlot(4)]
		UInt64 RequestLobbyList();
		[VTableSlot(5)]
		void AddRequestLobbyListFilter(string pchKeyToMatch, string pchValueToMatch);
		[VTableSlot(6)]
		void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, Int32 nValueToMatch, Int32 nComparisonType);
		[VTableSlot(7)]
		void AddRequestLobbyListSlotsAvailableFilter();
		[VTableSlot(8)]
		CSteamID GetLobbyByIndex(Int32 iLobby);
		[VTableSlot(9)]
		void CreateLobby(bool bPrivate);
		[VTableSlot(10)]
		void JoinLobby(CSteamID steamIDLobby);
		[VTableSlot(11)]
		void LeaveLobby(CSteamID steamIDLobby);
		[VTableSlot(12)]
		bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee);
		[VTableSlot(13)]
		Int32 GetNumLobbyMembers(CSteamID steamIDLobby);
		[VTableSlot(14)]
		CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, Int32 iMember);
		[VTableSlot(15)]
		string GetLobbyData(CSteamID steamIDLobby, string pchKey);
		[VTableSlot(16)]
		bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue);
		[VTableSlot(17)]
		string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey);
		[VTableSlot(18)]
		void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue);
		[VTableSlot(19)]
		bool SendLobbyChatMsg(CSteamID steamIDLobby, Byte[] pvMsgBody, Int32 cubMsgBody);
		[VTableSlot(20)]
		Int32 GetLobbyChatEntry(CSteamID steamIDLobby, Int32 iChatID, ref CSteamID pSteamIDUser, Byte[] pvData, Int32 cubData, ref EChatEntryType peChatEntryType);
		[VTableSlot(21)]
		bool RequestLobbyData(CSteamID steamIDLobby);
		[VTableSlot(22)]
		void SetLobbyGameServer(CSteamID steamIDLobby, UInt32 unGameServerIP, UInt16 unGameServerPort, CSteamID steamIDGameServer);
		[VTableSlot(23)]
		bool GetLobbyGameServer(CSteamID steamIDLobby, ref UInt32 punGameServerIP, ref UInt16 punGameServerPort, ref CSteamID psteamIDGameServer);
		[VTableSlot(24)]
		bool SetLobbyMemberLimit(CSteamID steamIDLobby, Int32 cMaxMembers);
		[VTableSlot(25)]
		Int32 GetLobbyMemberLimit(CSteamID steamIDLobby);
		[VTableSlot(26)]
		void SetLobbyVoiceEnabled(CSteamID steamIDLobby, bool bEnabled);
		[VTableSlot(27)]
		bool RequestFriendsLobbies();
	};
}
