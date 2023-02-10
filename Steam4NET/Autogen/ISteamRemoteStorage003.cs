// This file is automatically generated.
using System.Runtime.InteropServices;
using System.Text;

namespace Steam4NET;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public class ISteamRemoteStorage003VTable
{
    public IntPtr FileWrite0;
    public IntPtr FileRead1;
    public IntPtr FileForget2;
    public IntPtr FileDelete3;
    public IntPtr FileShare4;
    public IntPtr FileExists5;
    public IntPtr FilePersisted6;
    public IntPtr GetFileSize7;
    public IntPtr GetFileTimestamp8;
    public IntPtr GetFileCount9;
    public IntPtr GetFileNameAndSize10;
    public IntPtr GetQuota11;
    public IntPtr IsCloudEnabledForAccount12;
    public IntPtr IsCloudEnabledThisApp13;
    public IntPtr SetCloudEnabledThisApp14;
    public IntPtr UGCDownload15;
    public IntPtr GetUGCDetails16;
    public IntPtr UGCRead17;
    public IntPtr GetCachedUGCCount18;
    public IntPtr GetCachedUGCHandle19;
    private IntPtr DTorISteamRemoteStorage00320;
};

[InteropHelp.InterfaceVersion("STEAMREMOTESTORAGE_INTERFACE_VERSION003")]
public class ISteamRemoteStorage003 : InteropHelp.NativeWrapper<ISteamRemoteStorage003VTable>
{
    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileWriteSBI(IntPtr thisptr, string pchFile, Byte[] pvData, Int32 cubData);
    public bool FileWrite(string pchFile, Byte[] pvData)
    {
        return this.GetFunction<NativeFileWriteSBI>(this.Functions.FileWrite0)(this.ObjectAddress, pchFile, pvData, (Int32)pvData.Length);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeFileReadSBI(IntPtr thisptr, string pchFile, Byte[] pvData, Int32 cubDataToRead);
    public Int32 FileRead(string pchFile, Byte[] pvData)
    {
        return this.GetFunction<NativeFileReadSBI>(this.Functions.FileRead1)(this.ObjectAddress, pchFile, pvData, (Int32)pvData.Length);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileForgetS(IntPtr thisptr, string pchFile);
    public bool FileForget(string pchFile)
    {
        return this.GetFunction<NativeFileForgetS>(this.Functions.FileForget2)(this.ObjectAddress, pchFile);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileDeleteS(IntPtr thisptr, string pchFile);
    public bool FileDelete(string pchFile)
    {
        return this.GetFunction<NativeFileDeleteS>(this.Functions.FileDelete3)(this.ObjectAddress, pchFile);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeFileShareS(IntPtr thisptr, string pchFile);
    public UInt64 FileShare(string pchFile)
    {
        return this.GetFunction<NativeFileShareS>(this.Functions.FileShare4)(this.ObjectAddress, pchFile);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileExistsS(IntPtr thisptr, string pchFile);
    public bool FileExists(string pchFile)
    {
        return this.GetFunction<NativeFileExistsS>(this.Functions.FileExists5)(this.ObjectAddress, pchFile);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFilePersistedS(IntPtr thisptr, string pchFile);
    public bool FilePersisted(string pchFile)
    {
        return this.GetFunction<NativeFilePersistedS>(this.Functions.FilePersisted6)(this.ObjectAddress, pchFile);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFileSizeS(IntPtr thisptr, string pchFile);
    public Int32 GetFileSize(string pchFile)
    {
        return this.GetFunction<NativeGetFileSizeS>(this.Functions.GetFileSize7)(this.ObjectAddress, pchFile);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int64 NativeGetFileTimestampS(IntPtr thisptr, string pchFile);
    public Int64 GetFileTimestamp(string pchFile)
    {
        return this.GetFunction<NativeGetFileTimestampS>(this.Functions.GetFileTimestamp8)(this.ObjectAddress, pchFile);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFileCount(IntPtr thisptr);
    public Int32 GetFileCount()
    {
        return this.GetFunction<NativeGetFileCount>(this.Functions.GetFileCount9)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFileNameAndSizeII(IntPtr thisptr, Int32 iFile, ref Int32 pnFileSizeInBytes);
    public string GetFileNameAndSize(Int32 iFile, ref Int32 pnFileSizeInBytes)
    {
        return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetFileNameAndSizeII>(this.Functions.GetFileNameAndSize10)(this.ObjectAddress, iFile, ref pnFileSizeInBytes)));
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetQuotaII(IntPtr thisptr, ref Int32 pnTotalBytes, ref Int32 puAvailableBytes);
    public bool GetQuota(ref Int32 pnTotalBytes, ref Int32 puAvailableBytes)
    {
        return this.GetFunction<NativeGetQuotaII>(this.Functions.GetQuota11)(this.ObjectAddress, ref pnTotalBytes, ref puAvailableBytes);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsCloudEnabledForAccount(IntPtr thisptr);
    public bool IsCloudEnabledForAccount()
    {
        return this.GetFunction<NativeIsCloudEnabledForAccount>(this.Functions.IsCloudEnabledForAccount12)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsCloudEnabledThisApp(IntPtr thisptr);
    public bool IsCloudEnabledThisApp()
    {
        return this.GetFunction<NativeIsCloudEnabledThisApp>(this.Functions.IsCloudEnabledThisApp13)(this.ObjectAddress);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetCloudEnabledThisAppB(IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bEnable);
    public bool SetCloudEnabledThisApp(bool bEnable)
    {
        return this.GetFunction<NativeSetCloudEnabledThisAppB>(this.Functions.SetCloudEnabledThisApp14)(this.ObjectAddress, bEnable);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUGCDownloadU(IntPtr thisptr, UInt64 hContent);
    public UInt64 UGCDownload(UInt64 hContent)
    {
        return this.GetFunction<NativeUGCDownloadU>(this.Functions.UGCDownload15)(this.ObjectAddress, hContent);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUGCDetailsUUSIC(IntPtr thisptr, UInt64 hContent, ref UInt32 pnAppID, StringBuilder ppchName, ref Int32 pnFileSizeInBytes, ref UInt64 pSteamIDOwner);
    public bool GetUGCDetails(UInt64 hContent, ref UInt32 pnAppID, StringBuilder ppchName, ref Int32 pnFileSizeInBytes, ref CSteamID pSteamIDOwner)
    {
        UInt64 s0 = 0; var result = this.GetFunction<NativeGetUGCDetailsUUSIC>(this.Functions.GetUGCDetails16)(this.ObjectAddress, hContent, ref pnAppID, ppchName, ref pnFileSizeInBytes, ref s0); pSteamIDOwner = new CSteamID(s0); return result;
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeUGCReadUBI(IntPtr thisptr, UInt64 hContent, Byte[] pvData, Int32 cubDataToRead);
    public Int32 UGCRead(UInt64 hContent, Byte[] pvData)
    {
        return this.GetFunction<NativeUGCReadUBI>(this.Functions.UGCRead17)(this.ObjectAddress, hContent, pvData, (Int32)pvData.Length);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetCachedUGCCount(IntPtr thisptr);
    public Int32 GetCachedUGCCount()
    {
        return this.GetFunction<NativeGetCachedUGCCount>(this.Functions.GetCachedUGCCount18)(this.ObjectAddress);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetCachedUGCHandleI(IntPtr thisptr, Int32 iCachedContent);
    public UInt64 GetCachedUGCHandle(Int32 iCachedContent)
    {
        return this.GetFunction<NativeGetCachedUGCHandleI>(this.Functions.GetCachedUGCHandle19)(this.ObjectAddress, iCachedContent);
    }
};