// This file is automatically generated.
using System.Runtime.InteropServices;

namespace Steam4NET;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public class ISteamFriends014VTable
{
    public IntPtr GetPersonaName0;
    public IntPtr SetPersonaName1;
    public IntPtr GetPersonaState2;
    public IntPtr GetFriendCount3;
    public IntPtr GetFriendByIndex4;
    public IntPtr GetFriendRelationship5;
    public IntPtr GetFriendPersonaState6;
    public IntPtr GetFriendPersonaName7;
    public IntPtr GetFriendGamePlayed8;
    public IntPtr GetFriendPersonaNameHistory9;
    public IntPtr GetPlayerNickname10;
    public IntPtr HasFriend11;
    public IntPtr GetClanCount12;
    public IntPtr GetClanByIndex13;
    public IntPtr GetClanName14;
    public IntPtr GetClanTag15;
    public IntPtr GetClanActivityCounts16;
    public IntPtr DownloadClanActivityCounts17;
    public IntPtr GetFriendCountFromSource18;
    public IntPtr GetFriendFromSourceByIndex19;
    public IntPtr IsUserInSource20;
    public IntPtr SetInGameVoiceSpeaking21;
    public IntPtr ActivateGameOverlay22;
    public IntPtr ActivateGameOverlayToUser23;
    public IntPtr ActivateGameOverlayToWebPage24;
    public IntPtr ActivateGameOverlayToStore25;
    public IntPtr SetPlayedWith26;
    public IntPtr ActivateGameOverlayInviteDialog27;
    public IntPtr GetSmallFriendAvatar28;
    public IntPtr GetMediumFriendAvatar29;
    public IntPtr GetLargeFriendAvatar30;
    public IntPtr RequestUserInformation31;
    public IntPtr RequestClanOfficerList32;
    public IntPtr GetClanOwner33;
    public IntPtr GetClanOfficerCount34;
    public IntPtr GetClanOfficerByIndex35;
    public IntPtr GetUserRestrictions36;
    public IntPtr SetRichPresence37;
    public IntPtr ClearRichPresence38;
    public IntPtr GetFriendRichPresence39;
    public IntPtr GetFriendRichPresenceKeyCount40;
    public IntPtr GetFriendRichPresenceKeyByIndex41;
    public IntPtr RequestFriendRichPresence42;
    public IntPtr InviteUserToGame43;
    public IntPtr GetCoplayFriendCount44;
    public IntPtr GetCoplayFriend45;
    public IntPtr GetFriendCoplayTime46;
    public IntPtr GetFriendCoplayGame47;
    public IntPtr JoinClanChatRoom48;
    public IntPtr LeaveClanChatRoom49;
    public IntPtr GetClanChatMemberCount50;
    public IntPtr GetChatMemberByIndex51;
    public IntPtr SendClanChatMessage52;
    public IntPtr GetClanChatMessage53;
    public IntPtr IsClanChatAdmin54;
    public IntPtr IsClanChatWindowOpenInSteam55;
    public IntPtr OpenClanChatWindowInSteam56;
    public IntPtr CloseClanChatWindowInSteam57;
    public IntPtr SetListenForFriendsMessages58;
    public IntPtr ReplyToFriendMessage59;
    public IntPtr GetFriendMessage60;
    public IntPtr GetFollowerCount61;
    public IntPtr IsFollowing62;
    public IntPtr EnumerateFollowingList63;
    private IntPtr DTorISteamFriends01464;
};

[InteropHelp.InterfaceVersion("SteamFriends014")]
public class ISteamFriends014 : InteropHelp.NativeWrapper<ISteamFriends014VTable>
{
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetPersonaName(IntPtr thisptr);
    public string GetPersonaName()
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetPersonaName>(this.Functions.GetPersonaName0)(this.ObjectAddress)));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeSetPersonaNameS(IntPtr thisptr, string pchPersonaName);
    public UInt64 SetPersonaName(string pchPersonaName)
    {
        return this.GetFunction<NativeSetPersonaNameS>(this.Functions.SetPersonaName1)(this.ObjectAddress, pchPersonaName);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPersonaState NativeGetPersonaState(IntPtr thisptr);
    public EPersonaState GetPersonaState()
    {
        return this.GetFunction<NativeGetPersonaState>(this.Functions.GetPersonaState2)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendCountI(IntPtr thisptr, Int32 iFriendFlags);
    public Int32 GetFriendCount(Int32 iFriendFlags)
    {
        return this.GetFunction<NativeGetFriendCountI>(this.Functions.GetFriendCount3)(this.ObjectAddress, iFriendFlags);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetFriendByIndexII(IntPtr thisptr, ref UInt64 retarg, Int32 iFriend, Int32 iFriendFlags);
    public CSteamID GetFriendByIndex(Int32 iFriend, Int32 iFriendFlags)
    {
        UInt64 ret = 0; this.GetFunction<NativeGetFriendByIndexII>(this.Functions.GetFriendByIndex4)(this.ObjectAddress, ref ret, iFriend, iFriendFlags); return new CSteamID(ret);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EFriendRelationship NativeGetFriendRelationshipC(IntPtr thisptr, UInt64 steamIDFriend);
    public EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend)
    {
        return this.GetFunction<NativeGetFriendRelationshipC>(this.Functions.GetFriendRelationship5)(this.ObjectAddress, steamIDFriend.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPersonaState NativeGetFriendPersonaStateC(IntPtr thisptr, UInt64 steamIDFriend);
    public EPersonaState GetFriendPersonaState(CSteamID steamIDFriend)
    {
        return this.GetFunction<NativeGetFriendPersonaStateC>(this.Functions.GetFriendPersonaState6)(this.ObjectAddress, steamIDFriend.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendPersonaNameC(IntPtr thisptr, UInt64 steamIDFriend);
    public string GetFriendPersonaName(CSteamID steamIDFriend)
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetFriendPersonaNameC>(this.Functions.GetFriendPersonaName7)(this.ObjectAddress, steamIDFriend.ConvertToUint64())));
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetFriendGamePlayedCF(IntPtr thisptr, UInt64 steamIDFriend, ref FriendGameInfo_t pFriendGameInfo);
    public bool GetFriendGamePlayed(CSteamID steamIDFriend, ref FriendGameInfo_t pFriendGameInfo)
    {
        return this.GetFunction<NativeGetFriendGamePlayedCF>(this.Functions.GetFriendGamePlayed8)(this.ObjectAddress, steamIDFriend.ConvertToUint64(), ref pFriendGameInfo);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendPersonaNameHistoryCI(IntPtr thisptr, UInt64 steamIDFriend, Int32 iPersonaName);
    public string GetFriendPersonaNameHistory(CSteamID steamIDFriend, Int32 iPersonaName)
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetFriendPersonaNameHistoryCI>(this.Functions.GetFriendPersonaNameHistory9)(this.ObjectAddress, steamIDFriend.ConvertToUint64(), iPersonaName)));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetPlayerNicknameC(IntPtr thisptr, UInt64 steamIDPlayer);
    public string GetPlayerNickname(CSteamID steamIDPlayer)
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetPlayerNicknameC>(this.Functions.GetPlayerNickname10)(this.ObjectAddress, steamIDPlayer.ConvertToUint64())));
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeHasFriendCI(IntPtr thisptr, UInt64 steamIDFriend, Int32 iFriendFlags);
    public bool HasFriend(CSteamID steamIDFriend, Int32 iFriendFlags)
    {
        return this.GetFunction<NativeHasFriendCI>(this.Functions.HasFriend11)(this.ObjectAddress, steamIDFriend.ConvertToUint64(), iFriendFlags);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetClanCount(IntPtr thisptr);
    public Int32 GetClanCount()
    {
        return this.GetFunction<NativeGetClanCount>(this.Functions.GetClanCount12)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetClanByIndexI(IntPtr thisptr, ref UInt64 retarg, Int32 iClan);
    public CSteamID GetClanByIndex(Int32 iClan)
    {
        UInt64 ret = 0; this.GetFunction<NativeGetClanByIndexI>(this.Functions.GetClanByIndex13)(this.ObjectAddress, ref ret, iClan); return new CSteamID(ret);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetClanNameC(IntPtr thisptr, UInt64 steamIDClan);
    public string GetClanName(CSteamID steamIDClan)
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetClanNameC>(this.Functions.GetClanName14)(this.ObjectAddress, steamIDClan.ConvertToUint64())));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetClanTagC(IntPtr thisptr, UInt64 steamIDClan);
    public string GetClanTag(CSteamID steamIDClan)
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetClanTagC>(this.Functions.GetClanTag15)(this.ObjectAddress, steamIDClan.ConvertToUint64())));
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetClanActivityCountsCIII(IntPtr thisptr, UInt64 steamID, ref Int32 pnOnline, ref Int32 pnInGame, ref Int32 pnChatting);
    public bool GetClanActivityCounts(CSteamID steamID, ref Int32 pnOnline, ref Int32 pnInGame, ref Int32 pnChatting)
    {
        return this.GetFunction<NativeGetClanActivityCountsCIII>(this.Functions.GetClanActivityCounts16)(this.ObjectAddress, steamID.ConvertToUint64(), ref pnOnline, ref pnInGame, ref pnChatting);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDownloadClanActivityCountsCI(IntPtr thisptr, ref UInt64 groupIDs, Int32 nIds);
    public UInt64 DownloadClanActivityCounts(ref CSteamID groupIDs, Int32 nIds)
    {
        UInt64 s0 = 0; var result = this.GetFunction<NativeDownloadClanActivityCountsCI>(this.Functions.DownloadClanActivityCounts17)(this.ObjectAddress, ref s0, nIds); groupIDs = new CSteamID(s0); return result;
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendCountFromSourceC(IntPtr thisptr, UInt64 steamIDSource);
    public Int32 GetFriendCountFromSource(CSteamID steamIDSource)
    {
        return this.GetFunction<NativeGetFriendCountFromSourceC>(this.Functions.GetFriendCountFromSource18)(this.ObjectAddress, steamIDSource.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetFriendFromSourceByIndexCI(IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDSource, Int32 iFriend);
    public CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, Int32 iFriend)
    {
        UInt64 ret = 0; this.GetFunction<NativeGetFriendFromSourceByIndexCI>(this.Functions.GetFriendFromSourceByIndex19)(this.ObjectAddress, ref ret, steamIDSource.ConvertToUint64(), iFriend); return new CSteamID(ret);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsUserInSourceCC(IntPtr thisptr, UInt64 steamIDUser, UInt64 steamIDSource);
    public bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource)
    {
        return this.GetFunction<NativeIsUserInSourceCC>(this.Functions.IsUserInSource20)(this.ObjectAddress, steamIDUser.ConvertToUint64(), steamIDSource.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetInGameVoiceSpeakingCB(IntPtr thisptr, UInt64 steamIDUser, [MarshalAs(UnmanagedType.I1)] bool bSpeaking);
    public void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking)
    {
        this.GetFunction<NativeSetInGameVoiceSpeakingCB>(this.Functions.SetInGameVoiceSpeaking21)(this.ObjectAddress, steamIDUser.ConvertToUint64(), bSpeaking);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayS(IntPtr thisptr, string pchDialog);
    public void ActivateGameOverlay(string pchDialog)
    {
        this.GetFunction<NativeActivateGameOverlayS>(this.Functions.ActivateGameOverlay22)(this.ObjectAddress, pchDialog);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayToUserSC(IntPtr thisptr, string pchDialog, UInt64 steamID);
    public void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID)
    {
        this.GetFunction<NativeActivateGameOverlayToUserSC>(this.Functions.ActivateGameOverlayToUser23)(this.ObjectAddress, pchDialog, steamID.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayToWebPageS(IntPtr thisptr, string pchURL);
    public void ActivateGameOverlayToWebPage(string pchURL)
    {
        this.GetFunction<NativeActivateGameOverlayToWebPageS>(this.Functions.ActivateGameOverlayToWebPage24)(this.ObjectAddress, pchURL);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayToStoreUE(IntPtr thisptr, UInt32 nAppID, EOverlayToStoreFlag eFlag);
    public void ActivateGameOverlayToStore(UInt32 nAppID, EOverlayToStoreFlag eFlag)
    {
        this.GetFunction<NativeActivateGameOverlayToStoreUE>(this.Functions.ActivateGameOverlayToStore25)(this.ObjectAddress, nAppID, eFlag);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetPlayedWithC(IntPtr thisptr, UInt64 steamIDUserPlayedWith);
    public void SetPlayedWith(CSteamID steamIDUserPlayedWith)
    {
        this.GetFunction<NativeSetPlayedWithC>(this.Functions.SetPlayedWith26)(this.ObjectAddress, steamIDUserPlayedWith.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayInviteDialogC(IntPtr thisptr, UInt64 steamIDLobby);
    public void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby)
    {
        this.GetFunction<NativeActivateGameOverlayInviteDialogC>(this.Functions.ActivateGameOverlayInviteDialog27)(this.ObjectAddress, steamIDLobby.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetSmallFriendAvatarC(IntPtr thisptr, UInt64 steamIDFriend);
    public Int32 GetSmallFriendAvatar(CSteamID steamIDFriend)
    {
        return this.GetFunction<NativeGetSmallFriendAvatarC>(this.Functions.GetSmallFriendAvatar28)(this.ObjectAddress, steamIDFriend.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetMediumFriendAvatarC(IntPtr thisptr, UInt64 steamIDFriend);
    public Int32 GetMediumFriendAvatar(CSteamID steamIDFriend)
    {
        return this.GetFunction<NativeGetMediumFriendAvatarC>(this.Functions.GetMediumFriendAvatar29)(this.ObjectAddress, steamIDFriend.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLargeFriendAvatarC(IntPtr thisptr, UInt64 steamIDFriend);
    public Int32 GetLargeFriendAvatar(CSteamID steamIDFriend)
    {
        return this.GetFunction<NativeGetLargeFriendAvatarC>(this.Functions.GetLargeFriendAvatar30)(this.ObjectAddress, steamIDFriend.ConvertToUint64());
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestUserInformationCB(IntPtr thisptr, UInt64 steamIDUser, [MarshalAs(UnmanagedType.I1)] bool bRequireNameOnly);
    public bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly)
    {
        return this.GetFunction<NativeRequestUserInformationCB>(this.Functions.RequestUserInformation31)(this.ObjectAddress, steamIDUser.ConvertToUint64(), bRequireNameOnly);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestClanOfficerListC(IntPtr thisptr, UInt64 steamIDClan);
    public UInt64 RequestClanOfficerList(CSteamID steamIDClan)
    {
        return this.GetFunction<NativeRequestClanOfficerListC>(this.Functions.RequestClanOfficerList32)(this.ObjectAddress, steamIDClan.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetClanOwnerC(IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDClan);
    public CSteamID GetClanOwner(CSteamID steamIDClan)
    {
        UInt64 ret = 0; this.GetFunction<NativeGetClanOwnerC>(this.Functions.GetClanOwner33)(this.ObjectAddress, ref ret, steamIDClan.ConvertToUint64()); return new CSteamID(ret);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetClanOfficerCountC(IntPtr thisptr, UInt64 steamIDClan);
    public Int32 GetClanOfficerCount(CSteamID steamIDClan)
    {
        return this.GetFunction<NativeGetClanOfficerCountC>(this.Functions.GetClanOfficerCount34)(this.ObjectAddress, steamIDClan.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetClanOfficerByIndexCI(IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDClan, Int32 iOfficer);
    public CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, Int32 iOfficer)
    {
        UInt64 ret = 0; this.GetFunction<NativeGetClanOfficerByIndexCI>(this.Functions.GetClanOfficerByIndex35)(this.ObjectAddress, ref ret, steamIDClan.ConvertToUint64(), iOfficer); return new CSteamID(ret);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EUserRestriction NativeGetUserRestrictions(IntPtr thisptr);
    public EUserRestriction GetUserRestrictions()
    {
        return this.GetFunction<NativeGetUserRestrictions>(this.Functions.GetUserRestrictions36)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetRichPresenceSS(IntPtr thisptr, string pchKey, string pchValue);
    public bool SetRichPresence(string pchKey, string pchValue)
    {
        return this.GetFunction<NativeSetRichPresenceSS>(this.Functions.SetRichPresence37)(this.ObjectAddress, pchKey, pchValue);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeClearRichPresence(IntPtr thisptr);
    public void ClearRichPresence()
    {
        this.GetFunction<NativeClearRichPresence>(this.Functions.ClearRichPresence38)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendRichPresenceCS(IntPtr thisptr, UInt64 steamIDFriend, string pchKey);
    public string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey)
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetFriendRichPresenceCS>(this.Functions.GetFriendRichPresence39)(this.ObjectAddress, steamIDFriend.ConvertToUint64(), pchKey)));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendRichPresenceKeyCountC(IntPtr thisptr, UInt64 steamIDFriend);
    public Int32 GetFriendRichPresenceKeyCount(CSteamID steamIDFriend)
    {
        return this.GetFunction<NativeGetFriendRichPresenceKeyCountC>(this.Functions.GetFriendRichPresenceKeyCount40)(this.ObjectAddress, steamIDFriend.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendRichPresenceKeyByIndexCI(IntPtr thisptr, UInt64 steamIDFriend, Int32 iKey);
    public string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, Int32 iKey)
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetFriendRichPresenceKeyByIndexCI>(this.Functions.GetFriendRichPresenceKeyByIndex41)(this.ObjectAddress, steamIDFriend.ConvertToUint64(), iKey)));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRequestFriendRichPresenceC(IntPtr thisptr, UInt64 steamIDFriend);
    public void RequestFriendRichPresence(CSteamID steamIDFriend)
    {
        this.GetFunction<NativeRequestFriendRichPresenceC>(this.Functions.RequestFriendRichPresence42)(this.ObjectAddress, steamIDFriend.ConvertToUint64());
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeInviteUserToGameCS(IntPtr thisptr, UInt64 steamIDFriend, string pchConnectString);
    public bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString)
    {
        return this.GetFunction<NativeInviteUserToGameCS>(this.Functions.InviteUserToGame43)(this.ObjectAddress, steamIDFriend.ConvertToUint64(), pchConnectString);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetCoplayFriendCount(IntPtr thisptr);
    public Int32 GetCoplayFriendCount()
    {
        return this.GetFunction<NativeGetCoplayFriendCount>(this.Functions.GetCoplayFriendCount44)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetCoplayFriendI(IntPtr thisptr, ref UInt64 retarg, Int32 iCoplayFriend);
    public CSteamID GetCoplayFriend(Int32 iCoplayFriend)
    {
        UInt64 ret = 0; this.GetFunction<NativeGetCoplayFriendI>(this.Functions.GetCoplayFriend45)(this.ObjectAddress, ref ret, iCoplayFriend); return new CSteamID(ret);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendCoplayTimeC(IntPtr thisptr, UInt64 steamIDFriend);
    public Int32 GetFriendCoplayTime(CSteamID steamIDFriend)
    {
        return this.GetFunction<NativeGetFriendCoplayTimeC>(this.Functions.GetFriendCoplayTime46)(this.ObjectAddress, steamIDFriend.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetFriendCoplayGameC(IntPtr thisptr, UInt64 steamIDFriend);
    public UInt32 GetFriendCoplayGame(CSteamID steamIDFriend)
    {
        return this.GetFunction<NativeGetFriendCoplayGameC>(this.Functions.GetFriendCoplayGame47)(this.ObjectAddress, steamIDFriend.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeJoinClanChatRoomC(IntPtr thisptr, UInt64 steamIDClan);
    public UInt64 JoinClanChatRoom(CSteamID steamIDClan)
    {
        return this.GetFunction<NativeJoinClanChatRoomC>(this.Functions.JoinClanChatRoom48)(this.ObjectAddress, steamIDClan.ConvertToUint64());
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeLeaveClanChatRoomC(IntPtr thisptr, UInt64 steamIDClan);
    public bool LeaveClanChatRoom(CSteamID steamIDClan)
    {
        return this.GetFunction<NativeLeaveClanChatRoomC>(this.Functions.LeaveClanChatRoom49)(this.ObjectAddress, steamIDClan.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetClanChatMemberCountC(IntPtr thisptr, UInt64 steamIDClan);
    public Int32 GetClanChatMemberCount(CSteamID steamIDClan)
    {
        return this.GetFunction<NativeGetClanChatMemberCountC>(this.Functions.GetClanChatMemberCount50)(this.ObjectAddress, steamIDClan.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetChatMemberByIndexCI(IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDClan, Int32 iUser);
    public CSteamID GetChatMemberByIndex(CSteamID steamIDClan, Int32 iUser)
    {
        UInt64 ret = 0; this.GetFunction<NativeGetChatMemberByIndexCI>(this.Functions.GetChatMemberByIndex51)(this.ObjectAddress, ref ret, steamIDClan.ConvertToUint64(), iUser); return new CSteamID(ret);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendClanChatMessageCS(IntPtr thisptr, UInt64 steamIDClanChat, string pchText);
    public bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText)
    {
        return this.GetFunction<NativeSendClanChatMessageCS>(this.Functions.SendClanChatMessage52)(this.ObjectAddress, steamIDClanChat.ConvertToUint64(), pchText);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetClanChatMessageCIBIEC(IntPtr thisptr, UInt64 steamIDClanChat, Int32 iMessage, Byte[] prgchText, Int32 cchTextMax, ref EChatEntryType peChatEntryType, ref UInt64 pSteamIDChatter);
    public Int32 GetClanChatMessage(CSteamID steamIDClanChat, Int32 iMessage, Byte[] prgchText, ref EChatEntryType peChatEntryType, ref CSteamID pSteamIDChatter)
    {
        UInt64 s0 = 0; var result = this.GetFunction<NativeGetClanChatMessageCIBIEC>(this.Functions.GetClanChatMessage53)(this.ObjectAddress, steamIDClanChat.ConvertToUint64(), iMessage, prgchText, (Int32)prgchText.Length, ref peChatEntryType, ref s0); pSteamIDChatter = new CSteamID(s0); return result;
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsClanChatAdminCC(IntPtr thisptr, UInt64 steamIDClanChat, UInt64 steamIDUser);
    public bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser)
    {
        return this.GetFunction<NativeIsClanChatAdminCC>(this.Functions.IsClanChatAdmin54)(this.ObjectAddress, steamIDClanChat.ConvertToUint64(), steamIDUser.ConvertToUint64());
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsClanChatWindowOpenInSteamC(IntPtr thisptr, UInt64 steamIDClanChat);
    public bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat)
    {
        return this.GetFunction<NativeIsClanChatWindowOpenInSteamC>(this.Functions.IsClanChatWindowOpenInSteam55)(this.ObjectAddress, steamIDClanChat.ConvertToUint64());
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeOpenClanChatWindowInSteamC(IntPtr thisptr, UInt64 steamIDClanChat);
    public bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat)
    {
        return this.GetFunction<NativeOpenClanChatWindowInSteamC>(this.Functions.OpenClanChatWindowInSteam56)(this.ObjectAddress, steamIDClanChat.ConvertToUint64());
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCloseClanChatWindowInSteamC(IntPtr thisptr, UInt64 steamIDClanChat);
    public bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat)
    {
        return this.GetFunction<NativeCloseClanChatWindowInSteamC>(this.Functions.CloseClanChatWindowInSteam57)(this.ObjectAddress, steamIDClanChat.ConvertToUint64());
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetListenForFriendsMessagesB(IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bInterceptEnabled);
    public bool SetListenForFriendsMessages(bool bInterceptEnabled)
    {
        return this.GetFunction<NativeSetListenForFriendsMessagesB>(this.Functions.SetListenForFriendsMessages58)(this.ObjectAddress, bInterceptEnabled);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeReplyToFriendMessageCS(IntPtr thisptr, UInt64 steamIDFriend, string pchMsgToSend);
    public bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend)
    {
        return this.GetFunction<NativeReplyToFriendMessageCS>(this.Functions.ReplyToFriendMessage59)(this.ObjectAddress, steamIDFriend.ConvertToUint64(), pchMsgToSend);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendMessageCIBIE(IntPtr thisptr, UInt64 steamIDFriend, Int32 iMessageID, Byte[] pvData, Int32 cubData, ref EChatEntryType peChatEntryType);
    public Int32 GetFriendMessage(CSteamID steamIDFriend, Int32 iMessageID, Byte[] pvData, ref EChatEntryType peChatEntryType)
    {
        return this.GetFunction<NativeGetFriendMessageCIBIE>(this.Functions.GetFriendMessage60)(this.ObjectAddress, steamIDFriend.ConvertToUint64(), iMessageID, pvData, (Int32)pvData.Length, ref peChatEntryType);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetFollowerCountC(IntPtr thisptr, UInt64 steamID);
    public UInt64 GetFollowerCount(CSteamID steamID)
    {
        return this.GetFunction<NativeGetFollowerCountC>(this.Functions.GetFollowerCount61)(this.ObjectAddress, steamID.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeIsFollowingC(IntPtr thisptr, UInt64 steamID);
    public UInt64 IsFollowing(CSteamID steamID)
    {
        return this.GetFunction<NativeIsFollowingC>(this.Functions.IsFollowing62)(this.ObjectAddress, steamID.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeEnumerateFollowingListU(IntPtr thisptr, UInt32 unStartIndex);
    public UInt64 EnumerateFollowingList(UInt32 unStartIndex)
    {
        return this.GetFunction<NativeEnumerateFollowingListU>(this.Functions.EnumerateFollowingList63)(this.ObjectAddress, unStartIndex);
    }
};