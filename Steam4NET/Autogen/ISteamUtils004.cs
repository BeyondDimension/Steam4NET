// This file is automatically generated.
using System.Runtime.InteropServices;

namespace Steam4NET;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public class ISteamUtils004VTable
{
    public IntPtr GetSecondsSinceAppActive0;
    public IntPtr GetSecondsSinceComputerActive1;
    public IntPtr GetConnectedUniverse2;
    public IntPtr GetServerRealTime3;
    public IntPtr GetIPCountry4;
    public IntPtr GetImageSize5;
    public IntPtr GetImageRGBA6;
    public IntPtr GetCSERIPPort7;
    public IntPtr GetCurrentBatteryPower8;
    public IntPtr GetAppID9;
    public IntPtr SetOverlayNotificationPosition10;
    public IntPtr IsAPICallCompleted11;
    public IntPtr GetAPICallFailureReason12;
    public IntPtr GetAPICallResult13;
    public IntPtr RunFrame14;
    public IntPtr GetIPCCallCount15;
    public IntPtr SetWarningMessageHook16;
    public IntPtr IsOverlayEnabled17;
    private IntPtr DTorISteamUtils00418;
};

[InteropHelp.InterfaceVersion("SteamUtils004")]
public class ISteamUtils004 : InteropHelp.NativeWrapper<ISteamUtils004VTable>
{
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetSecondsSinceAppActive(IntPtr thisptr);
    public UInt32 GetSecondsSinceAppActive()
    {
        return this.GetFunction<NativeGetSecondsSinceAppActive>(this.Functions.GetSecondsSinceAppActive0)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetSecondsSinceComputerActive(IntPtr thisptr);
    public UInt32 GetSecondsSinceComputerActive()
    {
        return this.GetFunction<NativeGetSecondsSinceComputerActive>(this.Functions.GetSecondsSinceComputerActive1)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EUniverse NativeGetConnectedUniverse(IntPtr thisptr);
    public EUniverse GetConnectedUniverse()
    {
        return this.GetFunction<NativeGetConnectedUniverse>(this.Functions.GetConnectedUniverse2)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetServerRealTime(IntPtr thisptr);
    public UInt32 GetServerRealTime()
    {
        return this.GetFunction<NativeGetServerRealTime>(this.Functions.GetServerRealTime3)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetIPCountry(IntPtr thisptr);
    public string GetIPCountry()
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetIPCountry>(this.Functions.GetIPCountry4)(this.ObjectAddress)));
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetImageSizeIUU(IntPtr thisptr, Int32 iImage, ref UInt32 pnWidth, ref UInt32 pnHeight);
    public bool GetImageSize(Int32 iImage, ref UInt32 pnWidth, ref UInt32 pnHeight)
    {
        return this.GetFunction<NativeGetImageSizeIUU>(this.Functions.GetImageSize5)(this.ObjectAddress, iImage, ref pnWidth, ref pnHeight);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetImageRGBAIBI(IntPtr thisptr, Int32 iImage, Byte[] pubDest, Int32 nDestBufferSize);
    public bool GetImageRGBA(Int32 iImage, Byte[] pubDest, Int32 nDestBufferSize)
    {
        return this.GetFunction<NativeGetImageRGBAIBI>(this.Functions.GetImageRGBA6)(this.ObjectAddress, iImage, pubDest, nDestBufferSize);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetCSERIPPortUU(IntPtr thisptr, ref UInt32 unIP, ref UInt16 usPort);
    public bool GetCSERIPPort(ref UInt32 unIP, ref UInt16 usPort)
    {
        return this.GetFunction<NativeGetCSERIPPortUU>(this.Functions.GetCSERIPPort7)(this.ObjectAddress, ref unIP, ref usPort);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Byte NativeGetCurrentBatteryPower(IntPtr thisptr);
    public Byte GetCurrentBatteryPower()
    {
        return this.GetFunction<NativeGetCurrentBatteryPower>(this.Functions.GetCurrentBatteryPower8)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAppID(IntPtr thisptr);
    public UInt32 GetAppID()
    {
        return this.GetFunction<NativeGetAppID>(this.Functions.GetAppID9)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetOverlayNotificationPositionE(IntPtr thisptr, ENotificationPosition eNotificationPosition);
    public void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
    {
        this.GetFunction<NativeSetOverlayNotificationPositionE>(this.Functions.SetOverlayNotificationPosition10)(this.ObjectAddress, eNotificationPosition);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsAPICallCompletedUB(IntPtr thisptr, UInt64 hSteamAPICall, ref bool pbFailed);
    public bool IsAPICallCompleted(UInt64 hSteamAPICall, ref bool pbFailed)
    {
        return this.GetFunction<NativeIsAPICallCompletedUB>(this.Functions.IsAPICallCompleted11)(this.ObjectAddress, hSteamAPICall, ref pbFailed);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ESteamAPICallFailure NativeGetAPICallFailureReasonU(IntPtr thisptr, UInt64 hSteamAPICall);
    public ESteamAPICallFailure GetAPICallFailureReason(UInt64 hSteamAPICall)
    {
        return this.GetFunction<NativeGetAPICallFailureReasonU>(this.Functions.GetAPICallFailureReason12)(this.ObjectAddress, hSteamAPICall);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetAPICallResultUBIIB(IntPtr thisptr, UInt64 hSteamAPICall, Byte[] pCallback, Int32 cubCallback, Int32 iCallbackExpected, ref bool pbFailed);
    public bool GetAPICallResult(UInt64 hSteamAPICall, Byte[] pCallback, Int32 iCallbackExpected, ref bool pbFailed)
    {
        return this.GetFunction<NativeGetAPICallResultUBIIB>(this.Functions.GetAPICallResult13)(this.ObjectAddress, hSteamAPICall, pCallback, (Int32)pCallback.Length, iCallbackExpected, ref pbFailed);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRunFrame(IntPtr thisptr);
    public void RunFrame()
    {
        this.GetFunction<NativeRunFrame>(this.Functions.RunFrame14)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetIPCCallCount(IntPtr thisptr);
    public UInt32 GetIPCCallCount()
    {
        return this.GetFunction<NativeGetIPCCallCount>(this.Functions.GetIPCCallCount15)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetWarningMessageHookI(IntPtr thisptr, ref IntPtr pFunction);
    public void SetWarningMessageHook(ref IntPtr pFunction)
    {
        this.GetFunction<NativeSetWarningMessageHookI>(this.Functions.SetWarningMessageHook16)(this.ObjectAddress, ref pFunction);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsOverlayEnabled(IntPtr thisptr);
    public bool IsOverlayEnabled()
    {
        return this.GetFunction<NativeIsOverlayEnabled>(this.Functions.IsOverlayEnabled17)(this.ObjectAddress);
    }
};