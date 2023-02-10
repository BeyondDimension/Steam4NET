// This file is automatically generated.
using System.Runtime.InteropServices;

namespace Steam4NET;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public class ISteamMatchmaking004VTable
{
    public IntPtr GetFavoriteGameCount0;
    public IntPtr GetFavoriteGame1;
    public IntPtr AddFavoriteGame2;
    public IntPtr RemoveFavoriteGame3;
    public IntPtr RequestLobbyList4;
    public IntPtr AddRequestLobbyListFilter5;
    public IntPtr AddRequestLobbyListNumericalFilter6;
    public IntPtr AddRequestLobbyListSlotsAvailableFilter7;
    public IntPtr GetLobbyByIndex8;
    public IntPtr CreateLobby9;
    public IntPtr JoinLobby10;
    public IntPtr LeaveLobby11;
    public IntPtr InviteUserToLobby12;
    public IntPtr GetNumLobbyMembers13;
    public IntPtr GetLobbyMemberByIndex14;
    public IntPtr GetLobbyData15;
    public IntPtr SetLobbyData16;
    public IntPtr GetLobbyMemberData17;
    public IntPtr SetLobbyMemberData18;
    public IntPtr SendLobbyChatMsg19;
    public IntPtr GetLobbyChatEntry20;
    public IntPtr RequestLobbyData21;
    public IntPtr SetLobbyGameServer22;
    public IntPtr GetLobbyGameServer23;
    public IntPtr SetLobbyMemberLimit24;
    public IntPtr GetLobbyMemberLimit25;
    public IntPtr RequestFriendsLobbies26;
    private IntPtr DTorISteamMatchmaking00427;
};

[InteropHelp.InterfaceVersion("SteamMatchMaking004")]
public class ISteamMatchmaking004 : InteropHelp.NativeWrapper<ISteamMatchmaking004VTable>
{
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFavoriteGameCount(IntPtr thisptr);
    public Int32 GetFavoriteGameCount()
    {
        return this.GetFunction<NativeGetFavoriteGameCount>(this.Functions.GetFavoriteGameCount0)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetFavoriteGameIUUUUUU(IntPtr thisptr, Int32 iGame, ref UInt32 pnAppID, ref UInt32 pnIP, ref UInt16 pnConnPort, ref UInt16 pnQueryPort, ref UInt32 punFlags, ref UInt32 pRTime32LastPlayedOnServer);
    public bool GetFavoriteGame(Int32 iGame, ref UInt32 pnAppID, ref UInt32 pnIP, ref UInt16 pnConnPort, ref UInt16 pnQueryPort, ref UInt32 punFlags, ref UInt32 pRTime32LastPlayedOnServer)
    {
        return this.GetFunction<NativeGetFavoriteGameIUUUUUU>(this.Functions.GetFavoriteGame1)(this.ObjectAddress, iGame, ref pnAppID, ref pnIP, ref pnConnPort, ref pnQueryPort, ref punFlags, ref pRTime32LastPlayedOnServer);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeAddFavoriteGameUUUUUU(IntPtr thisptr, UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags, UInt32 rTime32LastPlayedOnServer);
    public Int32 AddFavoriteGame(UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags, UInt32 rTime32LastPlayedOnServer)
    {
        return this.GetFunction<NativeAddFavoriteGameUUUUUU>(this.Functions.AddFavoriteGame2)(this.ObjectAddress, nAppID, nIP, nConnPort, nQueryPort, unFlags, rTime32LastPlayedOnServer);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRemoveFavoriteGameUUUUU(IntPtr thisptr, UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags);
    public bool RemoveFavoriteGame(UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags)
    {
        return this.GetFunction<NativeRemoveFavoriteGameUUUUU>(this.Functions.RemoveFavoriteGame3)(this.ObjectAddress, nAppID, nIP, nConnPort, nQueryPort, unFlags);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestLobbyList(IntPtr thisptr);
    public UInt64 RequestLobbyList()
    {
        return this.GetFunction<NativeRequestLobbyList>(this.Functions.RequestLobbyList4)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeAddRequestLobbyListFilterSS(IntPtr thisptr, string pchKeyToMatch, string pchValueToMatch);
    public void AddRequestLobbyListFilter(string pchKeyToMatch, string pchValueToMatch)
    {
        this.GetFunction<NativeAddRequestLobbyListFilterSS>(this.Functions.AddRequestLobbyListFilter5)(this.ObjectAddress, pchKeyToMatch, pchValueToMatch);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeAddRequestLobbyListNumericalFilterSII(IntPtr thisptr, string pchKeyToMatch, Int32 nValueToMatch, Int32 nComparisonType);
    public void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, Int32 nValueToMatch, Int32 nComparisonType)
    {
        this.GetFunction<NativeAddRequestLobbyListNumericalFilterSII>(this.Functions.AddRequestLobbyListNumericalFilter6)(this.ObjectAddress, pchKeyToMatch, nValueToMatch, nComparisonType);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeAddRequestLobbyListSlotsAvailableFilter(IntPtr thisptr);
    public void AddRequestLobbyListSlotsAvailableFilter()
    {
        this.GetFunction<NativeAddRequestLobbyListSlotsAvailableFilter>(this.Functions.AddRequestLobbyListSlotsAvailableFilter7)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetLobbyByIndexI(IntPtr thisptr, ref UInt64 retarg, Int32 iLobby);
    public CSteamID GetLobbyByIndex(Int32 iLobby)
    {
        UInt64 ret = 0; this.GetFunction<NativeGetLobbyByIndexI>(this.Functions.GetLobbyByIndex8)(this.ObjectAddress, ref ret, iLobby); return new CSteamID(ret);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeCreateLobbyB(IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bPrivate);
    public void CreateLobby(bool bPrivate)
    {
        this.GetFunction<NativeCreateLobbyB>(this.Functions.CreateLobby9)(this.ObjectAddress, bPrivate);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeJoinLobbyC(IntPtr thisptr, UInt64 steamIDLobby);
    public void JoinLobby(CSteamID steamIDLobby)
    {
        this.GetFunction<NativeJoinLobbyC>(this.Functions.JoinLobby10)(this.ObjectAddress, steamIDLobby.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLeaveLobbyC(IntPtr thisptr, UInt64 steamIDLobby);
    public void LeaveLobby(CSteamID steamIDLobby)
    {
        this.GetFunction<NativeLeaveLobbyC>(this.Functions.LeaveLobby11)(this.ObjectAddress, steamIDLobby.ConvertToUint64());
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeInviteUserToLobbyCC(IntPtr thisptr, UInt64 steamIDLobby, UInt64 steamIDInvitee);
    public bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee)
    {
        return this.GetFunction<NativeInviteUserToLobbyCC>(this.Functions.InviteUserToLobby12)(this.ObjectAddress, steamIDLobby.ConvertToUint64(), steamIDInvitee.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetNumLobbyMembersC(IntPtr thisptr, UInt64 steamIDLobby);
    public Int32 GetNumLobbyMembers(CSteamID steamIDLobby)
    {
        return this.GetFunction<NativeGetNumLobbyMembersC>(this.Functions.GetNumLobbyMembers13)(this.ObjectAddress, steamIDLobby.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetLobbyMemberByIndexCI(IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDLobby, Int32 iMember);
    public CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, Int32 iMember)
    {
        UInt64 ret = 0; this.GetFunction<NativeGetLobbyMemberByIndexCI>(this.Functions.GetLobbyMemberByIndex14)(this.ObjectAddress, ref ret, steamIDLobby.ConvertToUint64(), iMember); return new CSteamID(ret);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetLobbyDataCS(IntPtr thisptr, UInt64 steamIDLobby, string pchKey);
    public string GetLobbyData(CSteamID steamIDLobby, string pchKey)
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetLobbyDataCS>(this.Functions.GetLobbyData15)(this.ObjectAddress, steamIDLobby.ConvertToUint64(), pchKey)));
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetLobbyDataCSS(IntPtr thisptr, UInt64 steamIDLobby, string pchKey, string pchValue);
    public bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue)
    {
        return this.GetFunction<NativeSetLobbyDataCSS>(this.Functions.SetLobbyData16)(this.ObjectAddress, steamIDLobby.ConvertToUint64(), pchKey, pchValue);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetLobbyMemberDataCCS(IntPtr thisptr, UInt64 steamIDLobby, UInt64 steamIDUser, string pchKey);
    public string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey)
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetLobbyMemberDataCCS>(this.Functions.GetLobbyMemberData17)(this.ObjectAddress, steamIDLobby.ConvertToUint64(), steamIDUser.ConvertToUint64(), pchKey)));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetLobbyMemberDataCSS(IntPtr thisptr, UInt64 steamIDLobby, string pchKey, string pchValue);
    public void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue)
    {
        this.GetFunction<NativeSetLobbyMemberDataCSS>(this.Functions.SetLobbyMemberData18)(this.ObjectAddress, steamIDLobby.ConvertToUint64(), pchKey, pchValue);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendLobbyChatMsgCBI(IntPtr thisptr, UInt64 steamIDLobby, Byte[] pvMsgBody, Int32 cubMsgBody);
    public bool SendLobbyChatMsg(CSteamID steamIDLobby, Byte[] pvMsgBody)
    {
        return this.GetFunction<NativeSendLobbyChatMsgCBI>(this.Functions.SendLobbyChatMsg19)(this.ObjectAddress, steamIDLobby.ConvertToUint64(), pvMsgBody, (Int32)pvMsgBody.Length);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLobbyChatEntryCICBIE(IntPtr thisptr, UInt64 steamIDLobby, Int32 iChatID, ref UInt64 pSteamIDUser, Byte[] pvData, Int32 cubData, ref EChatEntryType peChatEntryType);
    public Int32 GetLobbyChatEntry(CSteamID steamIDLobby, Int32 iChatID, ref CSteamID pSteamIDUser, Byte[] pvData, ref EChatEntryType peChatEntryType)
    {
        UInt64 s0 = 0; var result = this.GetFunction<NativeGetLobbyChatEntryCICBIE>(this.Functions.GetLobbyChatEntry20)(this.ObjectAddress, steamIDLobby.ConvertToUint64(), iChatID, ref s0, pvData, (Int32)pvData.Length, ref peChatEntryType); pSteamIDUser = new CSteamID(s0); return result;
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestLobbyDataC(IntPtr thisptr, UInt64 steamIDLobby);
    public bool RequestLobbyData(CSteamID steamIDLobby)
    {
        return this.GetFunction<NativeRequestLobbyDataC>(this.Functions.RequestLobbyData21)(this.ObjectAddress, steamIDLobby.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetLobbyGameServerCUUC(IntPtr thisptr, UInt64 steamIDLobby, UInt32 unGameServerIP, UInt16 unGameServerPort, UInt64 steamIDGameServer);
    public void SetLobbyGameServer(CSteamID steamIDLobby, UInt32 unGameServerIP, UInt16 unGameServerPort, CSteamID steamIDGameServer)
    {
        this.GetFunction<NativeSetLobbyGameServerCUUC>(this.Functions.SetLobbyGameServer22)(this.ObjectAddress, steamIDLobby.ConvertToUint64(), unGameServerIP, unGameServerPort, steamIDGameServer.ConvertToUint64());
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetLobbyGameServerCUUC(IntPtr thisptr, UInt64 steamIDLobby, ref UInt32 punGameServerIP, ref UInt16 punGameServerPort, ref UInt64 psteamIDGameServer);
    public bool GetLobbyGameServer(CSteamID steamIDLobby, ref UInt32 punGameServerIP, ref UInt16 punGameServerPort, ref CSteamID psteamIDGameServer)
    {
        UInt64 s0 = 0; var result = this.GetFunction<NativeGetLobbyGameServerCUUC>(this.Functions.GetLobbyGameServer23)(this.ObjectAddress, steamIDLobby.ConvertToUint64(), ref punGameServerIP, ref punGameServerPort, ref s0); psteamIDGameServer = new CSteamID(s0); return result;
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetLobbyMemberLimitCI(IntPtr thisptr, UInt64 steamIDLobby, Int32 cMaxMembers);
    public bool SetLobbyMemberLimit(CSteamID steamIDLobby, Int32 cMaxMembers)
    {
        return this.GetFunction<NativeSetLobbyMemberLimitCI>(this.Functions.SetLobbyMemberLimit24)(this.ObjectAddress, steamIDLobby.ConvertToUint64(), cMaxMembers);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLobbyMemberLimitC(IntPtr thisptr, UInt64 steamIDLobby);
    public Int32 GetLobbyMemberLimit(CSteamID steamIDLobby)
    {
        return this.GetFunction<NativeGetLobbyMemberLimitC>(this.Functions.GetLobbyMemberLimit25)(this.ObjectAddress, steamIDLobby.ConvertToUint64());
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestFriendsLobbies(IntPtr thisptr);
    public bool RequestFriendsLobbies()
    {
        return this.GetFunction<NativeRequestFriendsLobbies>(this.Functions.RequestFriendsLobbies26)(this.ObjectAddress);
    }
};