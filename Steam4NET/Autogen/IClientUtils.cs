// This file is automatically generated.
using System.Runtime.InteropServices;
using System.Text;

namespace Steam4NET;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public class IClientUtilsVTable
{
    public IntPtr GetInstallPath0;
    public IntPtr GetUserBaseFolderInstallImage1;
    public IntPtr GetManagedContentRoot2;
    public IntPtr GetSecondsSinceAppActive3;
    public IntPtr GetSecondsSinceComputerActive4;
    public IntPtr SetComputerActive5;
    public IntPtr GetConnectedUniverse6;
    public IntPtr GetServerRealTime7;
    public IntPtr GetIPCountry8;
    public IntPtr GetImageSize9;
    public IntPtr GetImageRGBA10;
    public IntPtr GetCSERIPPort11;
    public IntPtr GetNumRunningApps12;
    public IntPtr GetCurrentBatteryPower13;
    public IntPtr SetOfflineMode14;
    public IntPtr GetOfflineMode15;
    public IntPtr SetAppIDForCurrentPipe16;
    public IntPtr GetAppID17;
    public IntPtr SetAPIDebuggingActive18;
    public IntPtr IsAPICallCompleted19;
    public IntPtr GetAPICallFailureReason20;
    public IntPtr GetAPICallResult21;
    public IntPtr SignalAppsToShutDown22;
    public IntPtr TerminateAllAppsMultiStep23;
    public IntPtr GetCellID24;
    public IntPtr BIsGlobalInstance25;
    public IntPtr CheckFileSignature26;
    public IntPtr GetBuildID27;
    public IntPtr SetCurrentUIMode28;
    public IntPtr SetLauncherType29;
    public IntPtr GetLauncherType30;
    public IntPtr ShowGamepadTextInput31;
    public IntPtr GetEnteredGamepadTextLength32;
    public IntPtr GetEnteredGamepadTextInput33;
    public IntPtr GamepadTextInputClosed34;
    public IntPtr SetSpew35;
    public IntPtr BDownloadsDisabled36;
    public IntPtr SetFocusedWindow37;
    public IntPtr GetSteamUILanguage38;
    public IntPtr CheckSteamReachable39;
    public IntPtr SetLastGameLaunchMethod40;
    public IntPtr IsSteamOS41;
    public IntPtr SetVideoAdapterInfo42;
    public IntPtr SetControllerOVerrideMode43;
    public IntPtr SetOverlayWindowFocusForPipe44;
    public IntPtr GetGameOverlayUIInstanceFocusGameID45;
    public IntPtr SetControllerConfigFileForAppID46;
    public IntPtr GetControllerConfigFileForAppID47;
    public IntPtr IsSteamRunningInVR48;
    private IntPtr DTorIClientUtils49;
};

[InteropHelp.InterfaceVersion("CLIENTUTILS_INTERFACE_VERSION001")]
public class IClientUtils : InteropHelp.NativeWrapper<IClientUtilsVTable>
{
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetInstallPath(IntPtr thisptr);
    public string GetInstallPath()
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetInstallPath>(this.Functions.GetInstallPath0)(this.ObjectAddress)));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetUserBaseFolderInstallImage(IntPtr thisptr);
    public string GetUserBaseFolderInstallImage()
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetUserBaseFolderInstallImage>(this.Functions.GetUserBaseFolderInstallImage1)(this.ObjectAddress)));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetManagedContentRoot(IntPtr thisptr);
    public string GetManagedContentRoot()
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetManagedContentRoot>(this.Functions.GetManagedContentRoot2)(this.ObjectAddress)));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetSecondsSinceAppActive(IntPtr thisptr);
    public UInt32 GetSecondsSinceAppActive()
    {
        return this.GetFunction<NativeGetSecondsSinceAppActive>(this.Functions.GetSecondsSinceAppActive3)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetSecondsSinceComputerActive(IntPtr thisptr);
    public UInt32 GetSecondsSinceComputerActive()
    {
        return this.GetFunction<NativeGetSecondsSinceComputerActive>(this.Functions.GetSecondsSinceComputerActive4)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetComputerActive(IntPtr thisptr);
    public void SetComputerActive()
    {
        this.GetFunction<NativeSetComputerActive>(this.Functions.SetComputerActive5)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EUniverse NativeGetConnectedUniverse(IntPtr thisptr);
    public EUniverse GetConnectedUniverse()
    {
        return this.GetFunction<NativeGetConnectedUniverse>(this.Functions.GetConnectedUniverse6)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetServerRealTime(IntPtr thisptr);
    public UInt32 GetServerRealTime()
    {
        return this.GetFunction<NativeGetServerRealTime>(this.Functions.GetServerRealTime7)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIPCountry(IntPtr thisptr);
    public string GetIPCountry()
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetIPCountry>(this.Functions.GetIPCountry8)(this.ObjectAddress)));
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetImageSizeIUU(IntPtr thisptr, Int32 iImage, ref UInt32 pnWidth, ref UInt32 pnHeight);
    public bool GetImageSize(Int32 iImage, ref UInt32 pnWidth, ref UInt32 pnHeight)
    {
        return this.GetFunction<NativeGetImageSizeIUU>(this.Functions.GetImageSize9)(this.ObjectAddress, iImage, ref pnWidth, ref pnHeight);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetImageRGBAIBI(IntPtr thisptr, Int32 iImage, Byte[] pubDest, Int32 nDestBufferSize);
    public bool GetImageRGBA(Int32 iImage, Byte[] pubDest, Int32 nDestBufferSize)
    {
        return this.GetFunction<NativeGetImageRGBAIBI>(this.Functions.GetImageRGBA10)(this.ObjectAddress, iImage, pubDest, nDestBufferSize);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetCSERIPPortUU(IntPtr thisptr, ref UInt32 unIP, ref UInt16 usPort);
    public bool GetCSERIPPort(ref UInt32 unIP, ref UInt16 usPort)
    {
        return this.GetFunction<NativeGetCSERIPPortUU>(this.Functions.GetCSERIPPort11)(this.ObjectAddress, ref unIP, ref usPort);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumRunningApps(IntPtr thisptr);
    public UInt32 GetNumRunningApps()
    {
        return this.GetFunction<NativeGetNumRunningApps>(this.Functions.GetNumRunningApps12)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Byte NativeGetCurrentBatteryPower(IntPtr thisptr);
    public Byte GetCurrentBatteryPower()
    {
        return this.GetFunction<NativeGetCurrentBatteryPower>(this.Functions.GetCurrentBatteryPower13)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetOfflineModeB(IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bOffline);
    public void SetOfflineMode(bool bOffline)
    {
        this.GetFunction<NativeSetOfflineModeB>(this.Functions.SetOfflineMode14)(this.ObjectAddress, bOffline);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetOfflineMode(IntPtr thisptr);
    public bool GetOfflineMode()
    {
        return this.GetFunction<NativeGetOfflineMode>(this.Functions.GetOfflineMode15)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeSetAppIDForCurrentPipeUB(IntPtr thisptr, UInt32 nAppID, [MarshalAs(UnmanagedType.I1)] bool bTrackProcess);
    public UInt32 SetAppIDForCurrentPipe(UInt32 nAppID, bool bTrackProcess)
    {
        return this.GetFunction<NativeSetAppIDForCurrentPipeUB>(this.Functions.SetAppIDForCurrentPipe16)(this.ObjectAddress, nAppID, bTrackProcess);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAppID(IntPtr thisptr);
    public UInt32 GetAppID()
    {
        return this.GetFunction<NativeGetAppID>(this.Functions.GetAppID17)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetAPIDebuggingActiveBB(IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bActive, [MarshalAs(UnmanagedType.I1)] bool bVerbose);
    public void SetAPIDebuggingActive(bool bActive, bool bVerbose)
    {
        this.GetFunction<NativeSetAPIDebuggingActiveBB>(this.Functions.SetAPIDebuggingActive18)(this.ObjectAddress, bActive, bVerbose);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsAPICallCompletedUB(IntPtr thisptr, UInt64 hSteamAPICall, ref bool pbFailed);
    public bool IsAPICallCompleted(UInt64 hSteamAPICall, ref bool pbFailed)
    {
        return this.GetFunction<NativeIsAPICallCompletedUB>(this.Functions.IsAPICallCompleted19)(this.ObjectAddress, hSteamAPICall, ref pbFailed);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ESteamAPICallFailure NativeGetAPICallFailureReasonU(IntPtr thisptr, UInt64 hSteamAPICall);
    public ESteamAPICallFailure GetAPICallFailureReason(UInt64 hSteamAPICall)
    {
        return this.GetFunction<NativeGetAPICallFailureReasonU>(this.Functions.GetAPICallFailureReason20)(this.ObjectAddress, hSteamAPICall);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAPICallResultUBIIB(IntPtr thisptr, UInt64 hSteamAPICall, Byte[] pCallback, Int32 cubCallback, Int32 iCallbackExpected, ref bool pbFailed);
    public bool GetAPICallResult(UInt64 hSteamAPICall, Byte[] pCallback, Int32 iCallbackExpected, ref bool pbFailed)
    {
        return this.GetFunction<NativeGetAPICallResultUBIIB>(this.Functions.GetAPICallResult21)(this.ObjectAddress, hSteamAPICall, pCallback, (Int32)pCallback.Length, iCallbackExpected, ref pbFailed);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSignalAppsToShutDown(IntPtr thisptr);
    public bool SignalAppsToShutDown()
    {
        return this.GetFunction<NativeSignalAppsToShutDown>(this.Functions.SignalAppsToShutDown22)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeTerminateAllAppsMultiStepU(IntPtr thisptr, UInt32 uUnk);
    public bool TerminateAllAppsMultiStep(UInt32 uUnk)
    {
        return this.GetFunction<NativeTerminateAllAppsMultiStepU>(this.Functions.TerminateAllAppsMultiStep23)(this.ObjectAddress, uUnk);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetCellID(IntPtr thisptr);
    public UInt32 GetCellID()
    {
        return this.GetFunction<NativeGetCellID>(this.Functions.GetCellID24)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBIsGlobalInstance(IntPtr thisptr);
    public bool BIsGlobalInstance()
    {
        return this.GetFunction<NativeBIsGlobalInstance>(this.Functions.BIsGlobalInstance25)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeCheckFileSignatureS(IntPtr thisptr, string szFileName);
    public UInt64 CheckFileSignature(string szFileName)
    {
        return this.GetFunction<NativeCheckFileSignatureS>(this.Functions.CheckFileSignature26)(this.ObjectAddress, szFileName);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetBuildID(IntPtr thisptr);
    public UInt64 GetBuildID()
    {
        return this.GetFunction<NativeGetBuildID>(this.Functions.GetBuildID27)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetCurrentUIModeE(IntPtr thisptr, EUIMode eUIMode);
    public void SetCurrentUIMode(EUIMode eUIMode)
    {
        this.GetFunction<NativeSetCurrentUIModeE>(this.Functions.SetCurrentUIMode28)(this.ObjectAddress, eUIMode);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetLauncherTypeE(IntPtr thisptr, ELauncherType eLauncherType);
    public void SetLauncherType(ELauncherType eLauncherType)
    {
        this.GetFunction<NativeSetLauncherTypeE>(this.Functions.SetLauncherType29)(this.ObjectAddress, eLauncherType);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ELauncherType NativeGetLauncherType(IntPtr thisptr);
    public ELauncherType GetLauncherType()
    {
        return this.GetFunction<NativeGetLauncherType>(this.Functions.GetLauncherType30)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeShowGamepadTextInputEESUS(IntPtr thisptr, EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eInputLineMode, string szText, UInt32 uMaxLength, string szUnk);
    public bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eInputLineMode, string szText, UInt32 uMaxLength, string szUnk)
    {
        return this.GetFunction<NativeShowGamepadTextInputEESUS>(this.Functions.ShowGamepadTextInput31)(this.ObjectAddress, eInputMode, eInputLineMode, szText, uMaxLength, szUnk);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetEnteredGamepadTextLength(IntPtr thisptr);
    public UInt32 GetEnteredGamepadTextLength()
    {
        return this.GetFunction<NativeGetEnteredGamepadTextLength>(this.Functions.GetEnteredGamepadTextLength32)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetEnteredGamepadTextInputSU(IntPtr thisptr, StringBuilder pchValue, UInt32 cchValueMax);
    public bool GetEnteredGamepadTextInput(StringBuilder pchValue)
    {
        return this.GetFunction<NativeGetEnteredGamepadTextInputSU>(this.Functions.GetEnteredGamepadTextInput33)(this.ObjectAddress, pchValue, (UInt32)pchValue.Capacity);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGamepadTextInputClosedIBS(IntPtr thisptr, Int32 hSteamPipe, [MarshalAs(UnmanagedType.I1)] bool arg1, string arg2);
    public void GamepadTextInputClosed(Int32 hSteamPipe, bool arg1, string arg2)
    {
        this.GetFunction<NativeGamepadTextInputClosedIBS>(this.Functions.GamepadTextInputClosed34)(this.ObjectAddress, hSteamPipe, arg1, arg2);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetSpewEII(IntPtr thisptr, ESpewGroup eSpewGroup, Int32 iSpewLevel, Int32 iLogLevel);
    public void SetSpew(ESpewGroup eSpewGroup, Int32 iSpewLevel, Int32 iLogLevel)
    {
        this.GetFunction<NativeSetSpewEII>(this.Functions.SetSpew35)(this.ObjectAddress, eSpewGroup, iSpewLevel, iLogLevel);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBDownloadsDisabled(IntPtr thisptr);
    public bool BDownloadsDisabled()
    {
        return this.GetFunction<NativeBDownloadsDisabled>(this.Functions.BDownloadsDisabled36)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetFocusedWindowECU(IntPtr thisptr, EWindowType eWindowType, UInt64 gameID, UInt64 ulUnk);
    public void SetFocusedWindow(EWindowType eWindowType, CGameID gameID, UInt64 ulUnk)
    {
        this.GetFunction<NativeSetFocusedWindowECU>(this.Functions.SetFocusedWindow37)(this.ObjectAddress, eWindowType, gameID.ConvertToUint64(), ulUnk);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetSteamUILanguage(IntPtr thisptr);
    public string GetSteamUILanguage()
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetSteamUILanguage>(this.Functions.GetSteamUILanguage38)(this.ObjectAddress)));
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeCheckSteamReachable(IntPtr thisptr);
    public UInt64 CheckSteamReachable()
    {
        return this.GetFunction<NativeCheckSteamReachable>(this.Functions.CheckSteamReachable39)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetLastGameLaunchMethodE(IntPtr thisptr, EGameLaunchMethod eGameLaunchMethod);
    public void SetLastGameLaunchMethod(EGameLaunchMethod eGameLaunchMethod)
    {
        this.GetFunction<NativeSetLastGameLaunchMethodE>(this.Functions.SetLastGameLaunchMethod40)(this.ObjectAddress, eGameLaunchMethod);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsSteamOS(IntPtr thisptr);
    public bool IsSteamOS()
    {
        return this.GetFunction<NativeIsSteamOS>(this.Functions.IsSteamOS41)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetVideoAdapterInfoIIIII(IntPtr thisptr, Int32 arg0, Int32 arg1, Int32 arg2, Int32 arg3, Int32 arg4);
    public void SetVideoAdapterInfo(Int32 arg0, Int32 arg1, Int32 arg2, Int32 arg3, Int32 arg4)
    {
        this.GetFunction<NativeSetVideoAdapterInfoIIIII>(this.Functions.SetVideoAdapterInfo42)(this.ObjectAddress, arg0, arg1, arg2, arg3, arg4);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetControllerOVerrideModeECS(IntPtr thisptr, EWindowType eWindowType, UInt64 gameID, string szUnk);
    public void SetControllerOVerrideMode(EWindowType eWindowType, CGameID gameID, string szUnk)
    {
        this.GetFunction<NativeSetControllerOVerrideModeECS>(this.Functions.SetControllerOVerrideMode43)(this.ObjectAddress, eWindowType, gameID.ConvertToUint64(), szUnk);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetOverlayWindowFocusForPipeBBC(IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool arg0, [MarshalAs(UnmanagedType.I1)] bool arg1, UInt64 gameID);
    public void SetOverlayWindowFocusForPipe(bool arg0, bool arg1, CGameID gameID)
    {
        this.GetFunction<NativeSetOverlayWindowFocusForPipeBBC>(this.Functions.SetOverlayWindowFocusForPipe44)(this.ObjectAddress, arg0, arg1, gameID.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetGameOverlayUIInstanceFocusGameIDB(IntPtr thisptr, ref UInt64 retarg, ref bool pbUnk);
    public CGameID GetGameOverlayUIInstanceFocusGameID(ref bool pbUnk)
    {
        UInt64 ret = 0; this.GetFunction<NativeGetGameOverlayUIInstanceFocusGameIDB>(this.Functions.GetGameOverlayUIInstanceFocusGameID45)(this.ObjectAddress, ref ret, ref pbUnk); return new CGameID(ret);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetControllerConfigFileForAppIDUS(IntPtr thisptr, UInt32 unAppID, string pszControllerConfigFile);
    public bool SetControllerConfigFileForAppID(UInt32 unAppID, string pszControllerConfigFile)
    {
        return this.GetFunction<NativeSetControllerConfigFileForAppIDUS>(this.Functions.SetControllerConfigFileForAppID46)(this.ObjectAddress, unAppID, pszControllerConfigFile);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetControllerConfigFileForAppIDUSU(IntPtr thisptr, UInt32 unAppID, string pszControllerConfigFile, UInt32 cubControllerConfigFile);
    public bool GetControllerConfigFileForAppID(UInt32 unAppID, string pszControllerConfigFile, UInt32 cubControllerConfigFile)
    {
        return this.GetFunction<NativeGetControllerConfigFileForAppIDUSU>(this.Functions.GetControllerConfigFileForAppID47)(this.ObjectAddress, unAppID, pszControllerConfigFile, cubControllerConfigFile);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsSteamRunningInVR(IntPtr thisptr);
    public bool IsSteamRunningInVR()
    {
        return this.GetFunction<NativeIsSteamRunningInVR>(this.Functions.IsSteamRunningInVR48)(this.ObjectAddress);
    }
};