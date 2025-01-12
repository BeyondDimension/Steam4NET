// This file is automatically generated.
using System.Runtime.InteropServices;

namespace Steam4NET;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public class IClientEngineVTable
{
    public IntPtr CreateSteamPipe0;
    public IntPtr BReleaseSteamPipe1;
    public IntPtr CreateGlobalUser2;
    public IntPtr ConnectToGlobalUser3;
    public IntPtr CreateLocalUser4;
    public IntPtr CreatePipeToLocalUser5;
    public IntPtr ReleaseUser6;
    public IntPtr IsValidHSteamUserPipe7;
    public IntPtr GetIClientUser8;
    public IntPtr GetIClientGameServer9;
    public IntPtr SetLocalIPBinding10;
    public IntPtr GetUniverseName11;
    public IntPtr GetIClientFriends12;
    public IntPtr GetIClientUtils13;
    public IntPtr GetIClientBilling14;
    public IntPtr GetIClientMatchmaking15;
    public IntPtr GetIClientApps16;
    public IntPtr GetIClientMatchmakingServers17;
    public IntPtr RunFrame18;
    public IntPtr GetIPCCallCount19;
    public IntPtr GetIClientUserStats20;
    public IntPtr GetIClientGameServerStats21;
    public IntPtr GetIClientNetworking22;
    public IntPtr GetIClientRemoteStorage23;
    public IntPtr GetIClientScreenshots24;
    public IntPtr SetWarningMessageHook25;
    public IntPtr GetIClientGameCoordinator26;
    public IntPtr SetOverlayNotificationPosition27;
    public IntPtr SetOverlayNotificationInsert28;
    public IntPtr HookScreenshots29;
    public IntPtr IsOverlayEnabled30;
    public IntPtr GetAPICallResult31;
    public IntPtr GetIClientProductBuilder32;
    public IntPtr GetIClientDepotBuilder33;
    public IntPtr GetIClientNetworkDeviceManager34;
    public IntPtr ConCommandInit35;
    public IntPtr GetIClientAppManager36;
    public IntPtr GetIClientConfigStore37;
    public IntPtr BOverlayNeedsPresent38;
    public IntPtr GetIClientGameStats39;
    public IntPtr GetIClientHTTP40;
    public IntPtr BShutdownIfAllPipesClosed41;
    public IntPtr GetIClientAudio42;
    public IntPtr GetIClientMusic43;
    public IntPtr GetIClientUnifiedMessages44;
    public IntPtr GetIClientController45;
    public IntPtr GetIClientParentalSettings46;
    public IntPtr GetIClientStreamLauncher47;
    public IntPtr GetIClientDeviceAuth48;
    public IntPtr GetIClientRemoteClientManager49;
    public IntPtr GetIClientStreamClient50;
    public IntPtr GetIClientShortcuts51;
    public IntPtr GetIClientRemoteControlManager52;
    public IntPtr Set_ClientAPI_CPostAPIResultInProcess53;
    public IntPtr Remove_ClientAPI_CPostAPIResultInProcess54;
    public IntPtr GetIClientUGC55;
    public IntPtr GetIClientVR56;
    private IntPtr DTorIClientEngine57;
};

[InteropHelp.InterfaceVersion("CLIENTENGINE_INTERFACE_VERSION005")]
public class IClientEngine : InteropHelp.NativeWrapper<IClientEngineVTable>
{
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeCreateSteamPipe(IntPtr thisptr);
    public Int32 CreateSteamPipe()
    {
        return this.GetFunction<NativeCreateSteamPipe>(this.Functions.CreateSteamPipe0)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBReleaseSteamPipeI(IntPtr thisptr, Int32 hSteamPipe);
    public bool BReleaseSteamPipe(Int32 hSteamPipe)
    {
        return this.GetFunction<NativeBReleaseSteamPipeI>(this.Functions.BReleaseSteamPipe1)(this.ObjectAddress, hSteamPipe);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeCreateGlobalUserI(IntPtr thisptr, ref Int32 phSteamPipe);
    public Int32 CreateGlobalUser(ref Int32 phSteamPipe)
    {
        return this.GetFunction<NativeCreateGlobalUserI>(this.Functions.CreateGlobalUser2)(this.ObjectAddress, ref phSteamPipe);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeConnectToGlobalUserI(IntPtr thisptr, Int32 hSteamPipe);
    public Int32 ConnectToGlobalUser(Int32 hSteamPipe)
    {
        return this.GetFunction<NativeConnectToGlobalUserI>(this.Functions.ConnectToGlobalUser3)(this.ObjectAddress, hSteamPipe);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeCreateLocalUserIE(IntPtr thisptr, ref Int32 phSteamPipe, EAccountType eAccountType);
    public Int32 CreateLocalUser(ref Int32 phSteamPipe, EAccountType eAccountType)
    {
        return this.GetFunction<NativeCreateLocalUserIE>(this.Functions.CreateLocalUser4)(this.ObjectAddress, ref phSteamPipe, eAccountType);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeCreatePipeToLocalUserII(IntPtr thisptr, Int32 hSteamUser, ref Int32 phSteamPipe);
    public void CreatePipeToLocalUser(Int32 hSteamUser, ref Int32 phSteamPipe)
    {
        this.GetFunction<NativeCreatePipeToLocalUserII>(this.Functions.CreatePipeToLocalUser5)(this.ObjectAddress, hSteamUser, ref phSteamPipe);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeReleaseUserII(IntPtr thisptr, Int32 hSteamPipe, Int32 hUser);
    public void ReleaseUser(Int32 hSteamPipe, Int32 hUser)
    {
        this.GetFunction<NativeReleaseUserII>(this.Functions.ReleaseUser6)(this.ObjectAddress, hSteamPipe, hUser);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsValidHSteamUserPipeII(IntPtr thisptr, Int32 hSteamPipe, Int32 hUser);
    public bool IsValidHSteamUserPipe(Int32 hSteamPipe, Int32 hUser)
    {
        return this.GetFunction<NativeIsValidHSteamUserPipeII>(this.Functions.IsValidHSteamUserPipe7)(this.ObjectAddress, hSteamPipe, hUser);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientUserIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientUser<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientUserIIS>(this.Functions.GetIClientUser8)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientGameServerIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientGameServer<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientGameServerIIS>(this.Functions.GetIClientGameServer9)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetLocalIPBindingUU(IntPtr thisptr, UInt32 unIP, UInt16 usPort);
    public void SetLocalIPBinding(UInt32 unIP, UInt16 usPort)
    {
        this.GetFunction<NativeSetLocalIPBindingUU>(this.Functions.SetLocalIPBinding10)(this.ObjectAddress, unIP, usPort);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetUniverseNameE(IntPtr thisptr, EUniverse eUniverse);
    public string GetUniverseName(EUniverse eUniverse)
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetUniverseNameE>(this.Functions.GetUniverseName11)(this.ObjectAddress, eUniverse)));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientFriendsIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientFriends<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientFriendsIIS>(this.Functions.GetIClientFriends12)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientUtilsIS(IntPtr thisptr, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientUtils<TClass>(Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientUtilsIS>(this.Functions.GetIClientUtils13)(this.ObjectAddress, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientBillingIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientBilling<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientBillingIIS>(this.Functions.GetIClientBilling14)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientMatchmakingIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientMatchmaking<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientMatchmakingIIS>(this.Functions.GetIClientMatchmaking15)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientAppsIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientApps<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientAppsIIS>(this.Functions.GetIClientApps16)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientMatchmakingServersIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientMatchmakingServers<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientMatchmakingServersIIS>(this.Functions.GetIClientMatchmakingServers17)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRunFrame(IntPtr thisptr);
    public void RunFrame()
    {
        this.GetFunction<NativeRunFrame>(this.Functions.RunFrame18)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetIPCCallCount(IntPtr thisptr);
    public UInt32 GetIPCCallCount()
    {
        return this.GetFunction<NativeGetIPCCallCount>(this.Functions.GetIPCCallCount19)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientUserStatsIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientUserStats<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientUserStatsIIS>(this.Functions.GetIClientUserStats20)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientGameServerStatsIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientGameServerStats<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientGameServerStatsIIS>(this.Functions.GetIClientGameServerStats21)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientNetworkingIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientNetworking<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientNetworkingIIS>(this.Functions.GetIClientNetworking22)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientRemoteStorageIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientRemoteStorage<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientRemoteStorageIIS>(this.Functions.GetIClientRemoteStorage23)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientScreenshotsIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientScreenshots<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientScreenshotsIIS>(this.Functions.GetIClientScreenshots24)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetWarningMessageHookI(IntPtr thisptr, ref IntPtr pFunction);
    public void SetWarningMessageHook(ref IntPtr pFunction)
    {
        this.GetFunction<NativeSetWarningMessageHookI>(this.Functions.SetWarningMessageHook25)(this.ObjectAddress, ref pFunction);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientGameCoordinatorIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientGameCoordinator<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientGameCoordinatorIIS>(this.Functions.GetIClientGameCoordinator26)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetOverlayNotificationPositionE(IntPtr thisptr, ENotificationPosition eNotificationPosition);
    public void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
    {
        this.GetFunction<NativeSetOverlayNotificationPositionE>(this.Functions.SetOverlayNotificationPosition27)(this.ObjectAddress, eNotificationPosition);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetOverlayNotificationInsertII(IntPtr thisptr, Int32 arg0, Int32 arg1);
    public void SetOverlayNotificationInsert(Int32 arg0, Int32 arg1)
    {
        this.GetFunction<NativeSetOverlayNotificationInsertII>(this.Functions.SetOverlayNotificationInsert28)(this.ObjectAddress, arg0, arg1);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeHookScreenshotsB(IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bHook);
    public bool HookScreenshots(bool bHook)
    {
        return this.GetFunction<NativeHookScreenshotsB>(this.Functions.HookScreenshots29)(this.ObjectAddress, bHook);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsOverlayEnabled(IntPtr thisptr);
    public bool IsOverlayEnabled()
    {
        return this.GetFunction<NativeIsOverlayEnabled>(this.Functions.IsOverlayEnabled30)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAPICallResultIUBIIB(IntPtr thisptr, Int32 hSteamPipe, UInt64 hSteamAPICall, Byte[] pCallback, Int32 cubCallback, Int32 iCallbackExpected, ref bool pbFailed);
    public bool GetAPICallResult(Int32 hSteamPipe, UInt64 hSteamAPICall, Byte[] pCallback, Int32 iCallbackExpected, ref bool pbFailed)
    {
        return this.GetFunction<NativeGetAPICallResultIUBIIB>(this.Functions.GetAPICallResult31)(this.ObjectAddress, hSteamPipe, hSteamAPICall, pCallback, (Int32)pCallback.Length, iCallbackExpected, ref pbFailed);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientProductBuilderIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientProductBuilder<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientProductBuilderIIS>(this.Functions.GetIClientProductBuilder32)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientDepotBuilderIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientDepotBuilder<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientDepotBuilderIIS>(this.Functions.GetIClientDepotBuilder33)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientNetworkDeviceManagerIS(IntPtr thisptr, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientNetworkDeviceManager<TClass>(Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientNetworkDeviceManagerIS>(this.Functions.GetIClientNetworkDeviceManager34)(this.ObjectAddress, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeConCommandInitI(IntPtr thisptr, ref IntPtr pAccessor);
    public void ConCommandInit(ref IntPtr pAccessor)
    {
        this.GetFunction<NativeConCommandInitI>(this.Functions.ConCommandInit35)(this.ObjectAddress, ref pAccessor);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientAppManagerIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientAppManager<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientAppManagerIIS>(this.Functions.GetIClientAppManager36)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientConfigStoreIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientConfigStore<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientConfigStoreIIS>(this.Functions.GetIClientConfigStore37)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBOverlayNeedsPresent(IntPtr thisptr);
    public bool BOverlayNeedsPresent()
    {
        return this.GetFunction<NativeBOverlayNeedsPresent>(this.Functions.BOverlayNeedsPresent38)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientGameStatsIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientGameStats<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientGameStatsIIS>(this.Functions.GetIClientGameStats39)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientHTTPIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientHTTP<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientHTTPIIS>(this.Functions.GetIClientHTTP40)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBShutdownIfAllPipesClosed(IntPtr thisptr);
    public bool BShutdownIfAllPipesClosed()
    {
        return this.GetFunction<NativeBShutdownIfAllPipesClosed>(this.Functions.BShutdownIfAllPipesClosed41)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientAudioIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientAudio<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientAudioIIS>(this.Functions.GetIClientAudio42)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientMusicIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientMusic<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientMusicIIS>(this.Functions.GetIClientMusic43)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientUnifiedMessagesIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientUnifiedMessages<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientUnifiedMessagesIIS>(this.Functions.GetIClientUnifiedMessages44)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientControllerIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientController<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientControllerIIS>(this.Functions.GetIClientController45)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientParentalSettingsIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientParentalSettings<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientParentalSettingsIIS>(this.Functions.GetIClientParentalSettings46)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientStreamLauncherIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientStreamLauncher<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientStreamLauncherIIS>(this.Functions.GetIClientStreamLauncher47)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientDeviceAuthIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientDeviceAuth<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientDeviceAuthIIS>(this.Functions.GetIClientDeviceAuth48)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientRemoteClientManagerIS(IntPtr thisptr, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientRemoteClientManager<TClass>(Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientRemoteClientManagerIS>(this.Functions.GetIClientRemoteClientManager49)(this.ObjectAddress, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientStreamClientIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientStreamClient<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientStreamClientIIS>(this.Functions.GetIClientStreamClient50)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientShortcutsIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientShortcuts<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientShortcutsIIS>(this.Functions.GetIClientShortcuts51)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientRemoteControlManagerIS(IntPtr thisptr, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientRemoteControlManager<TClass>(Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientRemoteControlManagerIS>(this.Functions.GetIClientRemoteControlManager52)(this.ObjectAddress, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeSet_ClientAPI_CPostAPIResultInProcessI(IntPtr thisptr, ref IntPtr arg0);
    public Int32 Set_ClientAPI_CPostAPIResultInProcess(ref IntPtr arg0)
    {
        return this.GetFunction<NativeSet_ClientAPI_CPostAPIResultInProcessI>(this.Functions.Set_ClientAPI_CPostAPIResultInProcess53)(this.ObjectAddress, ref arg0);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeRemove_ClientAPI_CPostAPIResultInProcessI(IntPtr thisptr, ref IntPtr arg0);
    public Int32 Remove_ClientAPI_CPostAPIResultInProcess(ref IntPtr arg0)
    {
        return this.GetFunction<NativeRemove_ClientAPI_CPostAPIResultInProcessI>(this.Functions.Remove_ClientAPI_CPostAPIResultInProcess54)(this.ObjectAddress, ref arg0);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientUGCIIS(IntPtr thisptr, Int32 hSteamUser, Int32 hSteamPipe, string pchVersion);
    public TClass GetIClientUGC<TClass>(Int32 hSteamUser, Int32 hSteamPipe) where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientUGCIIS>(this.Functions.GetIClientUGC55)(this.ObjectAddress, hSteamUser, hSteamPipe, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIClientVRS(IntPtr thisptr, string pchVersion);
    public TClass GetIClientVR<TClass>() where TClass : InteropHelp.INativeWrapper, new()
    {
        return InteropHelp.CastInterface<TClass>(this.GetFunction<NativeGetIClientVRS>(this.Functions.GetIClientVR56)(this.ObjectAddress, InterfaceVersions.GetInterfaceIdentifier(typeof(TClass))));
    }
};