// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("SteamFriends010")]
	public interface ISteamFriends010
	{
		[VTableSlot(0)]
		string GetPersonaName();
		[VTableSlot(1)]
		void SetPersonaName(string pchPersonaName);
		[VTableSlot(2)]
		EPersonaState GetPersonaState();
		[VTableSlot(3)]
		Int32 GetFriendCount(Int32 iFriendFlags);
		[VTableSlot(4)]
		CSteamID GetFriendByIndex(Int32 iFriend, Int32 iFriendFlags);
		[VTableSlot(5)]
		EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend);
		[VTableSlot(6)]
		EPersonaState GetFriendPersonaState(CSteamID steamIDFriend);
		[VTableSlot(7)]
		string GetFriendPersonaName(CSteamID steamIDFriend);
		[VTableSlot(8)]
		bool GetFriendGamePlayed(CSteamID steamIDFriend, ref FriendGameInfo_t pFriendGameInfo);
		[VTableSlot(9)]
		string GetFriendPersonaNameHistory(CSteamID steamIDFriend, Int32 iPersonaName);
		[VTableSlot(10)]
		bool HasFriend(CSteamID steamIDFriend, Int32 iFriendFlags);
		[VTableSlot(11)]
		Int32 GetClanCount();
		[VTableSlot(12)]
		CSteamID GetClanByIndex(Int32 iClan);
		[VTableSlot(13)]
		string GetClanName(CSteamID steamIDClan);
		[VTableSlot(14)]
		string GetClanTag(CSteamID steamIDClan);
		[VTableSlot(15)]
		bool GetClanActivityCounts(CSteamID steamID, ref Int32 pnOnline, ref Int32 pnInGame, ref Int32 pnChatting);
		[VTableSlot(16)]
		UInt64 DownloadClanActivityCounts(ref CSteamID groupIDs, Int32 nIds);
		[VTableSlot(17)]
		Int32 GetFriendCountFromSource(CSteamID steamIDSource);
		[VTableSlot(18)]
		CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, Int32 iFriend);
		[VTableSlot(19)]
		bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource);
		[VTableSlot(20)]
		void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking);
		[VTableSlot(21)]
		void ActivateGameOverlay(string pchDialog);
		[VTableSlot(22)]
		void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID);
		[VTableSlot(23)]
		void ActivateGameOverlayToWebPage(string pchURL);
		[VTableSlot(24)]
		void ActivateGameOverlayToStore(UInt32 nAppID);
		[VTableSlot(25)]
		void SetPlayedWith(CSteamID steamIDUserPlayedWith);
		[VTableSlot(26)]
		void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby);
		[VTableSlot(27)]
		Int32 GetSmallFriendAvatar(CSteamID steamIDFriend);
		[VTableSlot(28)]
		Int32 GetMediumFriendAvatar(CSteamID steamIDFriend);
		[VTableSlot(29)]
		Int32 GetLargeFriendAvatar(CSteamID steamIDFriend);
		[VTableSlot(30)]
		bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly);
		[VTableSlot(31)]
		UInt64 RequestClanOfficerList(CSteamID steamIDClan);
		[VTableSlot(32)]
		CSteamID GetClanOwner(CSteamID steamIDClan);
		[VTableSlot(33)]
		Int32 GetClanOfficerCount(CSteamID steamIDClan);
		[VTableSlot(34)]
		CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, Int32 iOfficer);
		[VTableSlot(35)]
		EUserRestriction GetUserRestrictions();
		[VTableSlot(36)]
		bool SetRichPresence(string pchKey, string pchValue);
		[VTableSlot(37)]
		void ClearRichPresence();
		[VTableSlot(38)]
		string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey);
		[VTableSlot(39)]
		Int32 GetFriendRichPresenceKeyCount(CSteamID steamIDFriend);
		[VTableSlot(40)]
		string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, Int32 iKey);
		[VTableSlot(41)]
		bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString);
		[VTableSlot(42)]
		Int32 GetCoplayFriendCount();
		[VTableSlot(43)]
		CSteamID GetCoplayFriend(Int32 iCoplayFriend);
		[VTableSlot(44)]
		Int32 GetFriendCoplayTime(CSteamID steamIDFriend);
		[VTableSlot(45)]
		UInt32 GetFriendCoplayGame(CSteamID steamIDFriend);
		[VTableSlot(46)]
		UInt64 JoinClanChatRoom(CSteamID groupID);
		[VTableSlot(47)]
		bool LeaveClanChatRoom(CSteamID groupID);
		[VTableSlot(48)]
		Int32 GetClanChatMemberCount(CSteamID groupID);
		[VTableSlot(49)]
		CSteamID GetChatMemberByIndex(CSteamID groupID, Int32 iIndex);
		[VTableSlot(50)]
		bool SendClanChatMessage(CSteamID groupID, string cszMessage);
		[VTableSlot(51)]
		Int32 GetClanChatMessage(CSteamID groupID, Int32 iChatID, Byte[] pvData, Int32 cubData, ref EChatEntryType peChatEntryType, ref CSteamID pSteamIDChatter);
		[VTableSlot(52)]
		bool IsClanChatAdmin(CSteamID groupID, CSteamID userID);
		[VTableSlot(53)]
		bool IsClanChatWindowOpenInSteam(CSteamID groupID);
		[VTableSlot(54)]
		bool OpenClanChatWindowInSteam(CSteamID groupID);
		[VTableSlot(55)]
		bool CloseClanChatWindowInSteam(CSteamID groupID);
		[VTableSlot(56)]
		bool SetListenForFriendsMessages(bool bListen);
		[VTableSlot(57)]
		bool ReplyToFriendMessage(CSteamID friendID, string cszMessage);
		[VTableSlot(58)]
		Int32 GetFriendMessage(CSteamID friendID, Int32 iChatID, Byte[] pvData, Int32 cubData, ref EChatEntryType peChatEntryType);
	};
}
