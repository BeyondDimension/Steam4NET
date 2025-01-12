// This file is automatically generated.
using System.Runtime.InteropServices;

namespace Steam4NET;

public enum EGameConnectSteamResponse : int
{
    k_EGameConnectSteamResponse_WaitingForResponse = 0,
    k_EGameConnectSteamResponse_AuthorizedToPlay = 1,
    k_EGameConnectSteamResponse_Denied = 2,
    k_EGameConnectSteamResponse_ExceededReasonableTime_StillWaiting = 3,
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct ConnectedUserInfo_t
{
    public Int32 m_cubConnectedUserInfo;
    public Int32 m_nCountOfGuestUsers;
    public SteamID_t m_SteamID;
    public UInt32 m_unIPPublic;
    public UInt32 m_nFrags;
    public double m_flConnectTime;
    public EGameConnectSteamResponse m_eGameConnectSteamResponse;
    public EDenyReason m_eDenyReason;
};

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public class IClientGameServerVTable
{
    public IntPtr GetHSteamUser0;
    public IntPtr InitGameServer1;
    public IntPtr SetProduct2;
    public IntPtr SetGameDescription3;
    public IntPtr SetModDir4;
    public IntPtr SetDedicatedServer5;
    public IntPtr LogOn6;
    public IntPtr LogOnAnonymous7;
    public IntPtr LogOff8;
    public IntPtr GetSteamID9;
    public IntPtr BLoggedOn10;
    public IntPtr BSecure11;
    public IntPtr WasRestartRequested12;
    public IntPtr SetMaxPlayerCount13;
    public IntPtr SetBotPlayerCount14;
    public IntPtr SetServerName15;
    public IntPtr SetMapName16;
    public IntPtr SetPasswordProtected17;
    public IntPtr SetSpectatorPort18;
    public IntPtr SetSpectatorServerName19;
    public IntPtr ClearAllKeyValues20;
    public IntPtr SetKeyValue21;
    public IntPtr SetGameTags22;
    public IntPtr SetGameData23;
    public IntPtr SetRegion24;
    public IntPtr SendUserConnectAndAuthenticate25;
    public IntPtr CreateUnauthenticatedUserConnection26;
    public IntPtr SendUserDisconnect27;
    public IntPtr BUpdateUserData28;
    public IntPtr GetAuthSessionTicket29;
    public IntPtr BeginAuthSession30;
    public IntPtr EndAuthSession31;
    public IntPtr CancelAuthTicket32;
    public IntPtr IsUserSubscribedAppInTicket33;
    public IntPtr RequestUserGroupStatus34;
    public IntPtr GetGameplayStats35;
    public IntPtr GetServerReputation36;
    public IntPtr GetPublicIP37;
    public IntPtr HandleIncomingPacket38;
    public IntPtr GetNextOutgoingPacket39;
    public IntPtr EnableHeartbeats40;
    public IntPtr SetHeartbeatInterval41;
    public IntPtr ForceHeartbeat42;
    public IntPtr GetLogonState43;
    public IntPtr BConnected44;
    public IntPtr RaiseConnectionPriority45;
    public IntPtr ResetConnectionPriority46;
    public IntPtr SetCellID47;
    public IntPtr TrackSteamUsageEvent48;
    public IntPtr SetCountOfSimultaneousGuestUsersPerSteamAccount49;
    public IntPtr EnumerateConnectedUsers50;
    public IntPtr AssociateWithClan51;
    public IntPtr ComputeNewPlayerCompatibility52;
    public IntPtr _BGetUserAchievementStatus53;
    public IntPtr _GSSetSpawnCount54;
    public IntPtr _GSGetSteam2GetEncryptionKeyToSendToNewClient55;
    public IntPtr _GSSendSteam2UserConnect56;
    public IntPtr _GSSendSteam3UserConnect57;
    public IntPtr _GSSendUserConnect58;
    public IntPtr _GSRemoveUserConnect59;
    public IntPtr _GSUpdateStatus60;
    public IntPtr _GSCreateUnauthenticatedUser61;
    public IntPtr _GSSetServerType62;
    public IntPtr _SetBasicServerData63;
    public IntPtr _GSSendUserDisconnect64;
    private IntPtr DTorIClientGameServer65;
};

[InteropHelp.InterfaceVersion("CLIENTGAMESERVER_INTERFACE_VERSION001")]
public class IClientGameServer : InteropHelp.NativeWrapper<IClientGameServerVTable>
{
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetHSteamUser(IntPtr thisptr);
    public Int32 GetHSteamUser()
    {
        return this.GetFunction<NativeGetHSteamUser>(this.Functions.GetHSteamUser0)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeInitGameServerUUUUUS(IntPtr thisptr, UInt32 unGameIP, UInt16 unGamePort, UInt16 usQueryPort, UInt32 unServerFlags, UInt32 nAppID, string pchVersion);
    public bool InitGameServer(UInt32 unGameIP, UInt16 unGamePort, UInt16 usQueryPort, UInt32 unServerFlags, UInt32 nAppID, string pchVersion)
    {
        return this.GetFunction<NativeInitGameServerUUUUUS>(this.Functions.InitGameServer1)(this.ObjectAddress, unGameIP, unGamePort, usQueryPort, unServerFlags, nAppID, pchVersion);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetProductS(IntPtr thisptr, string pchProductName);
    public void SetProduct(string pchProductName)
    {
        this.GetFunction<NativeSetProductS>(this.Functions.SetProduct2)(this.ObjectAddress, pchProductName);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetGameDescriptionS(IntPtr thisptr, string pchGameDescription);
    public void SetGameDescription(string pchGameDescription)
    {
        this.GetFunction<NativeSetGameDescriptionS>(this.Functions.SetGameDescription3)(this.ObjectAddress, pchGameDescription);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetModDirS(IntPtr thisptr, string pchModDir);
    public void SetModDir(string pchModDir)
    {
        this.GetFunction<NativeSetModDirS>(this.Functions.SetModDir4)(this.ObjectAddress, pchModDir);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetDedicatedServerB(IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bDedicatedServer);
    public void SetDedicatedServer(bool bDedicatedServer)
    {
        this.GetFunction<NativeSetDedicatedServerB>(this.Functions.SetDedicatedServer5)(this.ObjectAddress, bDedicatedServer);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLogOnS(IntPtr thisptr, string pchToken);
    public void LogOn(string pchToken)
    {
        this.GetFunction<NativeLogOnS>(this.Functions.LogOn6)(this.ObjectAddress, pchToken);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLogOnAnonymous(IntPtr thisptr);
    public void LogOnAnonymous()
    {
        this.GetFunction<NativeLogOnAnonymous>(this.Functions.LogOnAnonymous7)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLogOff(IntPtr thisptr);
    public void LogOff()
    {
        this.GetFunction<NativeLogOff>(this.Functions.LogOff8)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetSteamID(IntPtr thisptr, ref UInt64 retarg);
    public CSteamID GetSteamID()
    {
        UInt64 ret = 0; this.GetFunction<NativeGetSteamID>(this.Functions.GetSteamID9)(this.ObjectAddress, ref ret); return new CSteamID(ret);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBLoggedOn(IntPtr thisptr);
    public bool BLoggedOn()
    {
        return this.GetFunction<NativeBLoggedOn>(this.Functions.BLoggedOn10)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBSecure(IntPtr thisptr);
    public bool BSecure()
    {
        return this.GetFunction<NativeBSecure>(this.Functions.BSecure11)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeWasRestartRequested(IntPtr thisptr);
    public bool WasRestartRequested()
    {
        return this.GetFunction<NativeWasRestartRequested>(this.Functions.WasRestartRequested12)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetMaxPlayerCountI(IntPtr thisptr, Int32 cPlayersMax);
    public void SetMaxPlayerCount(Int32 cPlayersMax)
    {
        this.GetFunction<NativeSetMaxPlayerCountI>(this.Functions.SetMaxPlayerCount13)(this.ObjectAddress, cPlayersMax);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetBotPlayerCountI(IntPtr thisptr, Int32 cBotPlayers);
    public void SetBotPlayerCount(Int32 cBotPlayers)
    {
        this.GetFunction<NativeSetBotPlayerCountI>(this.Functions.SetBotPlayerCount14)(this.ObjectAddress, cBotPlayers);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetServerNameS(IntPtr thisptr, string pchServerName);
    public void SetServerName(string pchServerName)
    {
        this.GetFunction<NativeSetServerNameS>(this.Functions.SetServerName15)(this.ObjectAddress, pchServerName);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetMapNameS(IntPtr thisptr, string pchMapName);
    public void SetMapName(string pchMapName)
    {
        this.GetFunction<NativeSetMapNameS>(this.Functions.SetMapName16)(this.ObjectAddress, pchMapName);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetPasswordProtectedB(IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bPasswordProtected);
    public void SetPasswordProtected(bool bPasswordProtected)
    {
        this.GetFunction<NativeSetPasswordProtectedB>(this.Functions.SetPasswordProtected17)(this.ObjectAddress, bPasswordProtected);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetSpectatorPortU(IntPtr thisptr, UInt16 unSpectatorPort);
    public void SetSpectatorPort(UInt16 unSpectatorPort)
    {
        this.GetFunction<NativeSetSpectatorPortU>(this.Functions.SetSpectatorPort18)(this.ObjectAddress, unSpectatorPort);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetSpectatorServerNameS(IntPtr thisptr, string pchSpectatorServerName);
    public void SetSpectatorServerName(string pchSpectatorServerName)
    {
        this.GetFunction<NativeSetSpectatorServerNameS>(this.Functions.SetSpectatorServerName19)(this.ObjectAddress, pchSpectatorServerName);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeClearAllKeyValues(IntPtr thisptr);
    public void ClearAllKeyValues()
    {
        this.GetFunction<NativeClearAllKeyValues>(this.Functions.ClearAllKeyValues20)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetKeyValueSS(IntPtr thisptr, string pKey, string pValue);
    public void SetKeyValue(string pKey, string pValue)
    {
        this.GetFunction<NativeSetKeyValueSS>(this.Functions.SetKeyValue21)(this.ObjectAddress, pKey, pValue);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetGameTagsS(IntPtr thisptr, string pchGameTags);
    public void SetGameTags(string pchGameTags)
    {
        this.GetFunction<NativeSetGameTagsS>(this.Functions.SetGameTags22)(this.ObjectAddress, pchGameTags);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetGameDataS(IntPtr thisptr, string pchGameData);
    public void SetGameData(string pchGameData)
    {
        this.GetFunction<NativeSetGameDataS>(this.Functions.SetGameData23)(this.ObjectAddress, pchGameData);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetRegionS(IntPtr thisptr, string pchRegionName);
    public void SetRegion(string pchRegionName)
    {
        this.GetFunction<NativeSetRegionS>(this.Functions.SetRegion24)(this.ObjectAddress, pchRegionName);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EUserConnect NativeSendUserConnectAndAuthenticateUBUC(IntPtr thisptr, UInt32 unIPClient, Byte[] pvAuthBlob, UInt32 cubAuthBlobSize, ref UInt64 pSteamIDUser);
    public EUserConnect SendUserConnectAndAuthenticate(UInt32 unIPClient, Byte[] pvAuthBlob, ref CSteamID pSteamIDUser)
    {
        UInt64 s0 = 0; var result = this.GetFunction<NativeSendUserConnectAndAuthenticateUBUC>(this.Functions.SendUserConnectAndAuthenticate25)(this.ObjectAddress, unIPClient, pvAuthBlob, (UInt32)pvAuthBlob.Length, ref s0); pSteamIDUser = new CSteamID(s0); return result;
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeCreateUnauthenticatedUserConnection(IntPtr thisptr, ref UInt64 retarg);
    public CSteamID CreateUnauthenticatedUserConnection()
    {
        UInt64 ret = 0; this.GetFunction<NativeCreateUnauthenticatedUserConnection>(this.Functions.CreateUnauthenticatedUserConnection26)(this.ObjectAddress, ref ret); return new CSteamID(ret);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSendUserDisconnectC(IntPtr thisptr, UInt64 steamIDUser);
    public void SendUserDisconnect(CSteamID steamIDUser)
    {
        this.GetFunction<NativeSendUserDisconnectC>(this.Functions.SendUserDisconnect27)(this.ObjectAddress, steamIDUser.ConvertToUint64());
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBUpdateUserDataCSU(IntPtr thisptr, UInt64 steamIDUser, string pchPlayerName, UInt32 uScore);
    public bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, UInt32 uScore)
    {
        return this.GetFunction<NativeBUpdateUserDataCSU>(this.Functions.BUpdateUserData28)(this.ObjectAddress, steamIDUser.ConvertToUint64(), pchPlayerName, uScore);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAuthSessionTicketBIU(IntPtr thisptr, Byte[] pTicket, Int32 cbMaxTicket, ref UInt32 pcbTicket);
    public UInt32 GetAuthSessionTicket(Byte[] pTicket, ref UInt32 pcbTicket)
    {
        return this.GetFunction<NativeGetAuthSessionTicketBIU>(this.Functions.GetAuthSessionTicket29)(this.ObjectAddress, pTicket, (Int32)pTicket.Length, ref pcbTicket);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EBeginAuthSessionResult NativeBeginAuthSessionBIC(IntPtr thisptr, Byte[] pAuthTicket, Int32 cbAuthTicket, UInt64 steamID);
    public EBeginAuthSessionResult BeginAuthSession(Byte[] pAuthTicket, CSteamID steamID)
    {
        return this.GetFunction<NativeBeginAuthSessionBIC>(this.Functions.BeginAuthSession30)(this.ObjectAddress, pAuthTicket, (Int32)pAuthTicket.Length, steamID.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeEndAuthSessionC(IntPtr thisptr, UInt64 steamID);
    public void EndAuthSession(CSteamID steamID)
    {
        this.GetFunction<NativeEndAuthSessionC>(this.Functions.EndAuthSession31)(this.ObjectAddress, steamID.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeCancelAuthTicketU(IntPtr thisptr, UInt32 hAuthTicket);
    public void CancelAuthTicket(UInt32 hAuthTicket)
    {
        this.GetFunction<NativeCancelAuthTicketU>(this.Functions.CancelAuthTicket32)(this.ObjectAddress, hAuthTicket);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EUserHasLicenseForAppResult NativeIsUserSubscribedAppInTicketCU(IntPtr thisptr, UInt64 steamID, UInt32 appID);
    public EUserHasLicenseForAppResult IsUserSubscribedAppInTicket(CSteamID steamID, UInt32 appID)
    {
        return this.GetFunction<NativeIsUserSubscribedAppInTicketCU>(this.Functions.IsUserSubscribedAppInTicket33)(this.ObjectAddress, steamID.ConvertToUint64(), appID);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestUserGroupStatusCC(IntPtr thisptr, UInt64 steamIDUser, UInt64 steamIDGroup);
    public bool RequestUserGroupStatus(CSteamID steamIDUser, CSteamID steamIDGroup)
    {
        return this.GetFunction<NativeRequestUserGroupStatusCC>(this.Functions.RequestUserGroupStatus34)(this.ObjectAddress, steamIDUser.ConvertToUint64(), steamIDGroup.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetGameplayStats(IntPtr thisptr);
    public void GetGameplayStats()
    {
        this.GetFunction<NativeGetGameplayStats>(this.Functions.GetGameplayStats35)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetServerReputation(IntPtr thisptr);
    public UInt64 GetServerReputation()
    {
        return this.GetFunction<NativeGetServerReputation>(this.Functions.GetServerReputation36)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetPublicIP(IntPtr thisptr);
    public UInt32 GetPublicIP()
    {
        return this.GetFunction<NativeGetPublicIP>(this.Functions.GetPublicIP37)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeHandleIncomingPacketBIUU(IntPtr thisptr, Byte[] pData, Int32 cbData, UInt32 srcIP, UInt16 srcPort);
    public bool HandleIncomingPacket(Byte[] pData, UInt32 srcIP, UInt16 srcPort)
    {
        return this.GetFunction<NativeHandleIncomingPacketBIUU>(this.Functions.HandleIncomingPacket38)(this.ObjectAddress, pData, (Int32)pData.Length, srcIP, srcPort);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetNextOutgoingPacketBIUU(IntPtr thisptr, Byte[] pOut, Int32 cbMaxOut, ref UInt32 pNetAdr, ref UInt16 pPort);
    public Int32 GetNextOutgoingPacket(Byte[] pOut, ref UInt32 pNetAdr, ref UInt16 pPort)
    {
        return this.GetFunction<NativeGetNextOutgoingPacketBIUU>(this.Functions.GetNextOutgoingPacket39)(this.ObjectAddress, pOut, (Int32)pOut.Length, ref pNetAdr, ref pPort);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeEnableHeartbeatsB(IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bEnabled);
    public void EnableHeartbeats(bool bEnabled)
    {
        this.GetFunction<NativeEnableHeartbeatsB>(this.Functions.EnableHeartbeats40)(this.ObjectAddress, bEnabled);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetHeartbeatIntervalI(IntPtr thisptr, Int32 iInterval);
    public void SetHeartbeatInterval(Int32 iInterval)
    {
        this.GetFunction<NativeSetHeartbeatIntervalI>(this.Functions.SetHeartbeatInterval41)(this.ObjectAddress, iInterval);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeForceHeartbeat(IntPtr thisptr);
    public void ForceHeartbeat()
    {
        this.GetFunction<NativeForceHeartbeat>(this.Functions.ForceHeartbeat42)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ELogonState NativeGetLogonState(IntPtr thisptr);
    public ELogonState GetLogonState()
    {
        return this.GetFunction<NativeGetLogonState>(this.Functions.GetLogonState43)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBConnected(IntPtr thisptr);
    public bool BConnected()
    {
        return this.GetFunction<NativeBConnected>(this.Functions.BConnected44)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeRaiseConnectionPriorityE(IntPtr thisptr, EConnectionPriority eConnectionPriority);
    public Int32 RaiseConnectionPriority(EConnectionPriority eConnectionPriority)
    {
        return this.GetFunction<NativeRaiseConnectionPriorityE>(this.Functions.RaiseConnectionPriority45)(this.ObjectAddress, eConnectionPriority);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeResetConnectionPriorityI(IntPtr thisptr, Int32 hRaiseConnectionPriorityPrev);
    public void ResetConnectionPriority(Int32 hRaiseConnectionPriorityPrev)
    {
        this.GetFunction<NativeResetConnectionPriorityI>(this.Functions.ResetConnectionPriority46)(this.ObjectAddress, hRaiseConnectionPriorityPrev);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetCellIDU(IntPtr thisptr, UInt32 cellID);
    public void SetCellID(UInt32 cellID)
    {
        this.GetFunction<NativeSetCellIDU>(this.Functions.SetCellID47)(this.ObjectAddress, cellID);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeTrackSteamUsageEventEBU(IntPtr thisptr, ESteamUsageEvent eSteamUsageEvent, Byte[] pubKV, UInt32 cubKV);
    public void TrackSteamUsageEvent(ESteamUsageEvent eSteamUsageEvent, Byte[] pubKV)
    {
        this.GetFunction<NativeTrackSteamUsageEventEBU>(this.Functions.TrackSteamUsageEvent48)(this.ObjectAddress, eSteamUsageEvent, pubKV, (UInt32)pubKV.Length);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetCountOfSimultaneousGuestUsersPerSteamAccountI(IntPtr thisptr, Int32 nCount);
    public void SetCountOfSimultaneousGuestUsersPerSteamAccount(Int32 nCount)
    {
        this.GetFunction<NativeSetCountOfSimultaneousGuestUsersPerSteamAccountI>(this.Functions.SetCountOfSimultaneousGuestUsersPerSteamAccount49)(this.ObjectAddress, nCount);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeEnumerateConnectedUsersIC(IntPtr thisptr, Int32 iterator, ref ConnectedUserInfo_t pConnectedUserInfo);
    public bool EnumerateConnectedUsers(Int32 iterator, ref ConnectedUserInfo_t pConnectedUserInfo)
    {
        return this.GetFunction<NativeEnumerateConnectedUsersIC>(this.Functions.EnumerateConnectedUsers50)(this.ObjectAddress, iterator, ref pConnectedUserInfo);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeAssociateWithClanC(IntPtr thisptr, UInt64 clanID);
    public UInt64 AssociateWithClan(CSteamID clanID)
    {
        return this.GetFunction<NativeAssociateWithClanC>(this.Functions.AssociateWithClan51)(this.ObjectAddress, clanID.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeComputeNewPlayerCompatibilityC(IntPtr thisptr, UInt64 steamID);
    public UInt64 ComputeNewPlayerCompatibility(CSteamID steamID)
    {
        return this.GetFunction<NativeComputeNewPlayerCompatibilityC>(this.Functions.ComputeNewPlayerCompatibility52)(this.ObjectAddress, steamID.ConvertToUint64());
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_BGetUserAchievementStatusCS(IntPtr thisptr, UInt64 steamID, string pchAchievementName);
    public bool _BGetUserAchievementStatus(CSteamID steamID, string pchAchievementName)
    {
        return this.GetFunction<Native_BGetUserAchievementStatusCS>(this.Functions._BGetUserAchievementStatus53)(this.ObjectAddress, steamID.ConvertToUint64(), pchAchievementName);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void Native_GSSetSpawnCountU(IntPtr thisptr, UInt32 ucSpawn);
    public void _GSSetSpawnCount(UInt32 ucSpawn)
    {
        this.GetFunction<Native_GSSetSpawnCountU>(this.Functions._GSSetSpawnCount54)(this.ObjectAddress, ucSpawn);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSGetSteam2GetEncryptionKeyToSendToNewClientBUU(IntPtr thisptr, Byte[] pvEncryptionKey, ref UInt32 pcbEncryptionKey, UInt32 cbMaxEncryptionKey);
    public bool _GSGetSteam2GetEncryptionKeyToSendToNewClient(Byte[] pvEncryptionKey, ref UInt32 pcbEncryptionKey, UInt32 cbMaxEncryptionKey)
    {
        return this.GetFunction<Native_GSGetSteam2GetEncryptionKeyToSendToNewClientBUU>(this.Functions._GSGetSteam2GetEncryptionKeyToSendToNewClient55)(this.ObjectAddress, pvEncryptionKey, ref pcbEncryptionKey, cbMaxEncryptionKey);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSSendSteam2UserConnectUBUUUBU(IntPtr thisptr, UInt32 unUserID, Byte[] pvRawKey, UInt32 unKeyLen, UInt32 unIPPublic, UInt16 usPort, Byte[] pvCookie, UInt32 cubCookie);
    public bool _GSSendSteam2UserConnect(UInt32 unUserID, Byte[] pvRawKey, UInt32 unIPPublic, UInt16 usPort, Byte[] pvCookie)
    {
        return this.GetFunction<Native_GSSendSteam2UserConnectUBUUUBU>(this.Functions._GSSendSteam2UserConnect56)(this.ObjectAddress, unUserID, pvRawKey, (UInt32)pvRawKey.Length, unIPPublic, usPort, pvCookie, (UInt32)pvCookie.Length);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSSendSteam3UserConnectCUBU(IntPtr thisptr, UInt64 steamID, UInt32 unIPPublic, Byte[] pvCookie, UInt32 cubCookie);
    public bool _GSSendSteam3UserConnect(CSteamID steamID, UInt32 unIPPublic, Byte[] pvCookie)
    {
        return this.GetFunction<Native_GSSendSteam3UserConnectCUBU>(this.Functions._GSSendSteam3UserConnect57)(this.ObjectAddress, steamID.ConvertToUint64(), unIPPublic, pvCookie, (UInt32)pvCookie.Length);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSSendUserConnectUUUBU(IntPtr thisptr, UInt32 unUserID, UInt32 unIPPublic, UInt16 usPort, Byte[] pvCookie, UInt32 cubCookie);
    public bool _GSSendUserConnect(UInt32 unUserID, UInt32 unIPPublic, UInt16 usPort, Byte[] pvCookie)
    {
        return this.GetFunction<Native_GSSendUserConnectUUUBU>(this.Functions._GSSendUserConnect58)(this.ObjectAddress, unUserID, unIPPublic, usPort, pvCookie, (UInt32)pvCookie.Length);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSRemoveUserConnectU(IntPtr thisptr, UInt32 unUserID);
    public bool _GSRemoveUserConnect(UInt32 unUserID)
    {
        return this.GetFunction<Native_GSRemoveUserConnectU>(this.Functions._GSRemoveUserConnect59)(this.ObjectAddress, unUserID);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSUpdateStatusIIISSS(IntPtr thisptr, Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pSpectatorServerName, string pchMapName);
    public bool _GSUpdateStatus(Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pSpectatorServerName, string pchMapName)
    {
        return this.GetFunction<Native_GSUpdateStatusIIISSS>(this.Functions._GSUpdateStatus60)(this.ObjectAddress, cPlayers, cPlayersMax, cBotPlayers, pchServerName, pSpectatorServerName, pchMapName);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSCreateUnauthenticatedUserC(IntPtr thisptr, ref UInt64 pSteamID);
    public bool _GSCreateUnauthenticatedUser(ref CSteamID pSteamID)
    {
        UInt64 s0 = 0; var result = this.GetFunction<Native_GSCreateUnauthenticatedUserC>(this.Functions._GSCreateUnauthenticatedUser61)(this.ObjectAddress, ref s0); pSteamID = new CSteamID(s0); return result;
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSSetServerTypeIUUUUUSSB(IntPtr thisptr, Int32 iAppID, UInt32 unServerFlags, UInt32 unGameIP, UInt16 unGamePort, UInt16 unSpectatorPort, UInt16 usQueryPort, string pchGameDir, string pchVersion, [MarshalAs(UnmanagedType.I1)] bool bLANMode);
    public bool _GSSetServerType(Int32 iAppID, UInt32 unServerFlags, UInt32 unGameIP, UInt16 unGamePort, UInt16 unSpectatorPort, UInt16 usQueryPort, string pchGameDir, string pchVersion, bool bLANMode)
    {
        return this.GetFunction<Native_GSSetServerTypeIUUUUUSSB>(this.Functions._GSSetServerType62)(this.ObjectAddress, iAppID, unServerFlags, unGameIP, unGamePort, unSpectatorPort, usQueryPort, pchGameDir, pchVersion, bLANMode);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void Native_SetBasicServerDataUBSSUBS(IntPtr thisptr, UInt16 nProtocolVersion, [MarshalAs(UnmanagedType.I1)] bool bDedicatedServer, string pRegionName, string pProductName, UInt16 nMaxReportedClients, [MarshalAs(UnmanagedType.I1)] bool bPasswordProtected, string pGameDescription);
    public void _SetBasicServerData(UInt16 nProtocolVersion, bool bDedicatedServer, string pRegionName, string pProductName, UInt16 nMaxReportedClients, bool bPasswordProtected, string pGameDescription)
    {
        this.GetFunction<Native_SetBasicServerDataUBSSUBS>(this.Functions._SetBasicServerData63)(this.ObjectAddress, nProtocolVersion, bDedicatedServer, pRegionName, pProductName, nMaxReportedClients, bPasswordProtected, pGameDescription);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool Native_GSSendUserDisconnectCU(IntPtr thisptr, UInt64 arg0, UInt32 unUserID);
    public bool _GSSendUserDisconnect(CSteamID arg0, UInt32 unUserID)
    {
        return this.GetFunction<Native_GSSendUserDisconnectCU>(this.Functions._GSSendUserDisconnect64)(this.ObjectAddress, arg0.ConvertToUint64(), unUserID);
    }
};