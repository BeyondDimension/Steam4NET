// This file is automatically generated.
using System;
using System.Runtime.InteropServices;

namespace Steam4NET
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class ISteamStreamLauncher001VTable
    {
        public IntPtr StartStreaming0;
        public IntPtr StopStreaming1;
        private IntPtr DTorISteamStreamLauncher0012;
    };

    [InteropHelp.InterfaceVersion("STEAMSTREAMLAUNCHER_INTERFACE_VERSION001")]
    public class ISteamStreamLauncher001 : InteropHelp.NativeWrapper<ISteamStreamLauncher001VTable>
    {
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EStreamLauncherResult NativeStartStreamingS(IntPtr thisptr, string cszFilePath);
        public EStreamLauncherResult StartStreaming(string cszFilePath)
        {
            return this.GetFunction<NativeStartStreamingS>(this.Functions.StartStreaming0)(this.ObjectAddress, cszFilePath);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeStopStreaming(IntPtr thisptr);
        public void StopStreaming()
        {
            this.GetFunction<NativeStopStreaming>(this.Functions.StopStreaming1)(this.ObjectAddress);
        }
    };
}