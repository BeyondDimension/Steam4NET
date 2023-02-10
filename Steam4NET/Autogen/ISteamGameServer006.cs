// This file is automatically generated.
using System.Runtime.InteropServices;

namespace Steam4NET;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public class ISteamGameServer006VTable
{
    public IntPtr LogOn0;
    public IntPtr LogOff1;
    public IntPtr BLoggedOn2;
    public IntPtr BSecure3;
    public IntPtr GetSteamID4;
    public IntPtr SendUserConnectAndAuthenticate5;
    public IntPtr CreateUnauthenticatedUserConnection6;
    public IntPtr SendUserDisconnect7;
    public IntPtr BUpdateUserData8;
    public IntPtr BSetServerType9;
    public IntPtr UpdateServerStatus10;
    public IntPtr UpdateSpectatorPort11;
    public IntPtr SetGameType12;
    public IntPtr BGetUserAchievementStatus13;
    public IntPtr GetGameplayStats14;
    private IntPtr DTorISteamGameServer00615;
};

[InteropHelp.InterfaceVersion("SteamGameServer006")]
public class ISteamGameServer006 : InteropHelp.NativeWrapper<ISteamGameServer006VTable>
{
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLogOn(IntPtr thisptr);
    public void LogOn()
    {
        this.GetFunction<NativeLogOn>(this.Functions.LogOn0)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLogOff(IntPtr thisptr);
    public void LogOff()
    {
        this.GetFunction<NativeLogOff>(this.Functions.LogOff1)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBLoggedOn(IntPtr thisptr);
    public bool BLoggedOn()
    {
        return this.GetFunction<NativeBLoggedOn>(this.Functions.BLoggedOn2)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBSecure(IntPtr thisptr);
    public bool BSecure()
    {
        return this.GetFunction<NativeBSecure>(this.Functions.BSecure3)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetSteamID(IntPtr thisptr, ref UInt64 retarg);
    public CSteamID GetSteamID()
    {
        UInt64 ret = 0; this.GetFunction<NativeGetSteamID>(this.Functions.GetSteamID4)(this.ObjectAddress, ref ret); return new CSteamID(ret);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendUserConnectAndAuthenticateUBUC(IntPtr thisptr, UInt32 unIPClient, Byte[] pvAuthBlob, UInt32 cubAuthBlobSize, ref UInt64 pSteamIDUser);
    public bool SendUserConnectAndAuthenticate(UInt32 unIPClient, Byte[] pvAuthBlob, ref CSteamID pSteamIDUser)
    {
        UInt64 s0 = 0; var result = this.GetFunction<NativeSendUserConnectAndAuthenticateUBUC>(this.Functions.SendUserConnectAndAuthenticate5)(this.ObjectAddress, unIPClient, pvAuthBlob, (UInt32)pvAuthBlob.Length, ref s0); pSteamIDUser = new CSteamID(s0); return result;
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeCreateUnauthenticatedUserConnection(IntPtr thisptr, ref UInt64 retarg);
    public CSteamID CreateUnauthenticatedUserConnection()
    {
        UInt64 ret = 0; this.GetFunction<NativeCreateUnauthenticatedUserConnection>(this.Functions.CreateUnauthenticatedUserConnection6)(this.ObjectAddress, ref ret); return new CSteamID(ret);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSendUserDisconnectC(IntPtr thisptr, UInt64 steamIDUser);
    public void SendUserDisconnect(CSteamID steamIDUser)
    {
        this.GetFunction<NativeSendUserDisconnectC>(this.Functions.SendUserDisconnect7)(this.ObjectAddress, steamIDUser.ConvertToUint64());
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBUpdateUserDataCSU(IntPtr thisptr, UInt64 steamIDUser, string pchPlayerName, UInt32 uScore);
    public bool BUpdateUserData(CSteamID steamIDUser, string pchPlayerName, UInt32 uScore)
    {
        return this.GetFunction<NativeBUpdateUserDataCSU>(this.Functions.BUpdateUserData8)(this.ObjectAddress, steamIDUser.ConvertToUint64(), pchPlayerName, uScore);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBSetServerTypeUUUUUSSB(IntPtr thisptr, UInt32 unServerFlags, UInt32 unGameIP, UInt16 unGamePort, UInt16 unSpectatorPort, UInt16 usQueryPort, string pchGameDir, string pchVersion, [MarshalAs(UnmanagedType.I1)] bool bLANMode);
    public bool BSetServerType(UInt32 unServerFlags, UInt32 unGameIP, UInt16 unGamePort, UInt16 unSpectatorPort, UInt16 usQueryPort, string pchGameDir, string pchVersion, bool bLANMode)
    {
        return this.GetFunction<NativeBSetServerTypeUUUUUSSB>(this.Functions.BSetServerType9)(this.ObjectAddress, unServerFlags, unGameIP, unGamePort, unSpectatorPort, usQueryPort, pchGameDir, pchVersion, bLANMode);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeUpdateServerStatusIIISSS(IntPtr thisptr, Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pSpectatorServerName, string pchMapName);
    public void UpdateServerStatus(Int32 cPlayers, Int32 cPlayersMax, Int32 cBotPlayers, string pchServerName, string pSpectatorServerName, string pchMapName)
    {
        this.GetFunction<NativeUpdateServerStatusIIISSS>(this.Functions.UpdateServerStatus10)(this.ObjectAddress, cPlayers, cPlayersMax, cBotPlayers, pchServerName, pSpectatorServerName, pchMapName);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeUpdateSpectatorPortU(IntPtr thisptr, UInt16 unSpectatorPort);
    public void UpdateSpectatorPort(UInt16 unSpectatorPort)
    {
        this.GetFunction<NativeUpdateSpectatorPortU>(this.Functions.UpdateSpectatorPort11)(this.ObjectAddress, unSpectatorPort);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetGameTypeS(IntPtr thisptr, string pchGameType);
    public void SetGameType(string pchGameType)
    {
        this.GetFunction<NativeSetGameTypeS>(this.Functions.SetGameType12)(this.ObjectAddress, pchGameType);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBGetUserAchievementStatusCS(IntPtr thisptr, UInt64 steamID, string pchAchievementName);
    public bool BGetUserAchievementStatus(CSteamID steamID, string pchAchievementName)
    {
        return this.GetFunction<NativeBGetUserAchievementStatusCS>(this.Functions.BGetUserAchievementStatus13)(this.ObjectAddress, steamID.ConvertToUint64(), pchAchievementName);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetGameplayStats(IntPtr thisptr);
    public void GetGameplayStats()
    {
        this.GetFunction<NativeGetGameplayStats>(this.Functions.GetGameplayStats14)(this.ObjectAddress);
    }
};