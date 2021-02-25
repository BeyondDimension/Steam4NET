// This file is automatically generated.
using System;
using System.Runtime.InteropServices;

namespace Steam4NET
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class ISteamRemoteStorage001VTable
    {
        public IntPtr FileWrite0;
        public IntPtr GetFileSize1;
        public IntPtr FileRead2;
        public IntPtr FileExists3;
        public IntPtr FileDelete4;
        public IntPtr GetFileCount5;
        public IntPtr GetFileNameAndSize6;
        public IntPtr GetQuota7;
        private IntPtr DTorISteamRemoteStorage0018;
    };

    [InteropHelp.InterfaceVersion("STEAMREMOTESTORAGE_INTERFACE_VERSION001")]
    public class ISteamRemoteStorage001 : InteropHelp.NativeWrapper<ISteamRemoteStorage001VTable>
    {
        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileWriteSBI(IntPtr thisptr, string filename, Byte[] data, Int32 arg2);
        public bool FileWrite(string filename, Byte[] data, Int32 arg2)
        {
            return this.GetFunction<NativeFileWriteSBI>(this.Functions.FileWrite0)(this.ObjectAddress, filename, data, arg2);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetFileSizeS(IntPtr thisptr, string filename);
        public UInt32 GetFileSize(string filename)
        {
            return this.GetFunction<NativeGetFileSizeS>(this.Functions.GetFileSize1)(this.ObjectAddress, filename);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileReadSBI(IntPtr thisptr, string filename, Byte[] buffer, Int32 size);
        public bool FileRead(string filename, Byte[] buffer, Int32 size)
        {
            return this.GetFunction<NativeFileReadSBI>(this.Functions.FileRead2)(this.ObjectAddress, filename, buffer, size);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileExistsS(IntPtr thisptr, string filename);
        public bool FileExists(string filename)
        {
            return this.GetFunction<NativeFileExistsS>(this.Functions.FileExists3)(this.ObjectAddress, filename);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileDeleteS(IntPtr thisptr, string filename);
        public bool FileDelete(string filename)
        {
            return this.GetFunction<NativeFileDeleteS>(this.Functions.FileDelete4)(this.ObjectAddress, filename);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetFileCount(IntPtr thisptr);
        public UInt32 GetFileCount()
        {
            return this.GetFunction<NativeGetFileCount>(this.Functions.GetFileCount5)(this.ObjectAddress);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFileNameAndSizeII(IntPtr thisptr, Int32 index, ref Int32 size);
        public string GetFileNameAndSize(Int32 index, ref Int32 size)
        {
            return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetFileNameAndSizeII>(this.Functions.GetFileNameAndSize6)(this.ObjectAddress, index, ref size)));
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetQuotaII(IntPtr thisptr, ref Int32 current, ref Int32 maximum);
        public bool GetQuota(ref Int32 current, ref Int32 maximum)
        {
            return this.GetFunction<NativeGetQuotaII>(this.Functions.GetQuota7)(this.ObjectAddress, ref current, ref maximum);
        }
    };
}