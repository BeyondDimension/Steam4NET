// This file is automatically generated.
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Steam4NET
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class ISteamRemoteStorage011VTable
    {
        public IntPtr FileWrite0;
        public IntPtr FileRead1;
        public IntPtr FileForget2;
        public IntPtr FileDelete3;
        public IntPtr FileShare4;
        public IntPtr SetSyncPlatforms5;
        public IntPtr FileWriteStreamOpen6;
        public IntPtr FileWriteStreamWriteChunk7;
        public IntPtr FileWriteStreamClose8;
        public IntPtr FileWriteStreamCancel9;
        public IntPtr FileExists10;
        public IntPtr FilePersisted11;
        public IntPtr GetFileSize12;
        public IntPtr GetFileTimestamp13;
        public IntPtr GetSyncPlatforms14;
        public IntPtr GetFileCount15;
        public IntPtr GetFileNameAndSize16;
        public IntPtr GetQuota17;
        public IntPtr IsCloudEnabledForAccount18;
        public IntPtr IsCloudEnabledForApp19;
        public IntPtr SetCloudEnabledForApp20;
        public IntPtr UGCDownload21;
        public IntPtr GetUGCDownloadProgress22;
        public IntPtr GetUGCDetails23;
        public IntPtr UGCRead24;
        public IntPtr GetCachedUGCCount25;
        public IntPtr GetCachedUGCHandle26;
        public IntPtr PublishWorkshopFile27;
        public IntPtr CreatePublishedFileUpdateRequest28;
        public IntPtr UpdatePublishedFileFile29;
        public IntPtr UpdatePublishedFilePreviewFile30;
        public IntPtr UpdatePublishedFileTitle31;
        public IntPtr UpdatePublishedFileDescription32;
        public IntPtr UpdatePublishedFileVisibility33;
        public IntPtr UpdatePublishedFileTags34;
        public IntPtr CommitPublishedFileUpdate35;
        public IntPtr GetPublishedFileDetails36;
        public IntPtr DeletePublishedFile37;
        public IntPtr EnumerateUserPublishedFiles38;
        public IntPtr SubscribePublishedFile39;
        public IntPtr EnumerateUserSubscribedFiles40;
        public IntPtr UnsubscribePublishedFile41;
        public IntPtr UpdatePublishedFileSetChangeDescription42;
        public IntPtr GetPublishedItemVoteDetails43;
        public IntPtr UpdateUserPublishedItemVote44;
        public IntPtr GetUserPublishedItemVoteDetails45;
        public IntPtr EnumerateUserSharedWorkshopFiles46;
        public IntPtr PublishVideo47;
        public IntPtr SetUserPublishedFileAction48;
        public IntPtr EnumeratePublishedFilesByUserAction49;
        public IntPtr EnumeratePublishedWorkshopFiles50;
        public IntPtr UGCDownloadToLocation51;
        private IntPtr DTorISteamRemoteStorage01152;
    };

    [InteropHelp.InterfaceVersion("STEAMREMOTESTORAGE_INTERFACE_VERSION011")]
    public class ISteamRemoteStorage011 : InteropHelp.NativeWrapper<ISteamRemoteStorage011VTable>
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
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetSyncPlatformsSE(IntPtr thisptr, string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform);
        public bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform)
        {
            return this.GetFunction<NativeSetSyncPlatformsSE>(this.Functions.SetSyncPlatforms5)(this.ObjectAddress, pchFile, eRemoteStoragePlatform);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeFileWriteStreamOpenS(IntPtr thisptr, string pchFile);
        public UInt64 FileWriteStreamOpen(string pchFile)
        {
            return this.GetFunction<NativeFileWriteStreamOpenS>(this.Functions.FileWriteStreamOpen6)(this.ObjectAddress, pchFile);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EResult NativeFileWriteStreamWriteChunkUBI(IntPtr thisptr, UInt64 hStream, Byte[] pvData, Int32 cubData);
        public EResult FileWriteStreamWriteChunk(UInt64 hStream, Byte[] pvData)
        {
            return this.GetFunction<NativeFileWriteStreamWriteChunkUBI>(this.Functions.FileWriteStreamWriteChunk7)(this.ObjectAddress, hStream, pvData, (Int32)pvData.Length);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EResult NativeFileWriteStreamCloseU(IntPtr thisptr, UInt64 hStream);
        public EResult FileWriteStreamClose(UInt64 hStream)
        {
            return this.GetFunction<NativeFileWriteStreamCloseU>(this.Functions.FileWriteStreamClose8)(this.ObjectAddress, hStream);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EResult NativeFileWriteStreamCancelU(IntPtr thisptr, UInt64 hStream);
        public EResult FileWriteStreamCancel(UInt64 hStream)
        {
            return this.GetFunction<NativeFileWriteStreamCancelU>(this.Functions.FileWriteStreamCancel9)(this.ObjectAddress, hStream);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileExistsS(IntPtr thisptr, string pchFile);
        public bool FileExists(string pchFile)
        {
            return this.GetFunction<NativeFileExistsS>(this.Functions.FileExists10)(this.ObjectAddress, pchFile);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFilePersistedS(IntPtr thisptr, string pchFile);
        public bool FilePersisted(string pchFile)
        {
            return this.GetFunction<NativeFilePersistedS>(this.Functions.FilePersisted11)(this.ObjectAddress, pchFile);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFileSizeS(IntPtr thisptr, string pchFile);
        public Int32 GetFileSize(string pchFile)
        {
            return this.GetFunction<NativeGetFileSizeS>(this.Functions.GetFileSize12)(this.ObjectAddress, pchFile);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int64 NativeGetFileTimestampS(IntPtr thisptr, string pchFile);
        public Int64 GetFileTimestamp(string pchFile)
        {
            return this.GetFunction<NativeGetFileTimestampS>(this.Functions.GetFileTimestamp13)(this.ObjectAddress, pchFile);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ERemoteStoragePlatform NativeGetSyncPlatformsS(IntPtr thisptr, string pchFile);
        public ERemoteStoragePlatform GetSyncPlatforms(string pchFile)
        {
            return this.GetFunction<NativeGetSyncPlatformsS>(this.Functions.GetSyncPlatforms14)(this.ObjectAddress, pchFile);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFileCount(IntPtr thisptr);
        public Int32 GetFileCount()
        {
            return this.GetFunction<NativeGetFileCount>(this.Functions.GetFileCount15)(this.ObjectAddress);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFileNameAndSizeII(IntPtr thisptr, Int32 iFile, ref Int32 pnFileSizeInBytes);
        public string GetFileNameAndSize(Int32 iFile, ref Int32 pnFileSizeInBytes)
        {
            return InteropHelp.DecodeANSIReturn(Marshal.PtrToStringAnsi(this.GetFunction<NativeGetFileNameAndSizeII>(this.Functions.GetFileNameAndSize16)(this.ObjectAddress, iFile, ref pnFileSizeInBytes)));
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetQuotaII(IntPtr thisptr, ref Int32 pnTotalBytes, ref Int32 puAvailableBytes);
        public bool GetQuota(ref Int32 pnTotalBytes, ref Int32 puAvailableBytes)
        {
            return this.GetFunction<NativeGetQuotaII>(this.Functions.GetQuota17)(this.ObjectAddress, ref pnTotalBytes, ref puAvailableBytes);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsCloudEnabledForAccount(IntPtr thisptr);
        public bool IsCloudEnabledForAccount()
        {
            return this.GetFunction<NativeIsCloudEnabledForAccount>(this.Functions.IsCloudEnabledForAccount18)(this.ObjectAddress);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsCloudEnabledForApp(IntPtr thisptr);
        public bool IsCloudEnabledForApp()
        {
            return this.GetFunction<NativeIsCloudEnabledForApp>(this.Functions.IsCloudEnabledForApp19)(this.ObjectAddress);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetCloudEnabledForAppB(IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bEnabled);
        public void SetCloudEnabledForApp(bool bEnabled)
        {
            this.GetFunction<NativeSetCloudEnabledForAppB>(this.Functions.SetCloudEnabledForApp20)(this.ObjectAddress, bEnabled);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUGCDownloadUU(IntPtr thisptr, UInt64 hContent, UInt32 uUnk);
        public UInt64 UGCDownload(UInt64 hContent, UInt32 uUnk)
        {
            return this.GetFunction<NativeUGCDownloadUU>(this.Functions.UGCDownload21)(this.ObjectAddress, hContent, uUnk);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUGCDownloadProgressUUU(IntPtr thisptr, UInt64 hContent, ref UInt32 puDownloadedBytes, ref UInt32 puTotalBytes);
        public bool GetUGCDownloadProgress(UInt64 hContent, ref UInt32 puDownloadedBytes, ref UInt32 puTotalBytes)
        {
            return this.GetFunction<NativeGetUGCDownloadProgressUUU>(this.Functions.GetUGCDownloadProgress22)(this.ObjectAddress, hContent, ref puDownloadedBytes, ref puTotalBytes);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUGCDetailsUUSIC(IntPtr thisptr, UInt64 hContent, ref UInt32 pnAppID, StringBuilder ppchName, ref Int32 pnFileSizeInBytes, ref UInt64 pSteamIDOwner);
        public bool GetUGCDetails(UInt64 hContent, ref UInt32 pnAppID, StringBuilder ppchName, ref Int32 pnFileSizeInBytes, ref CSteamID pSteamIDOwner)
        {
            UInt64 s0 = 0; var result = this.GetFunction<NativeGetUGCDetailsUUSIC>(this.Functions.GetUGCDetails23)(this.ObjectAddress, hContent, ref pnAppID, ppchName, ref pnFileSizeInBytes, ref s0); pSteamIDOwner = new CSteamID(s0); return result;
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeUGCReadUBIU(IntPtr thisptr, UInt64 hContent, Byte[] pvData, Int32 cubDataToRead, UInt32 uOffset);
        public Int32 UGCRead(UInt64 hContent, Byte[] pvData, UInt32 uOffset)
        {
            return this.GetFunction<NativeUGCReadUBIU>(this.Functions.UGCRead24)(this.ObjectAddress, hContent, pvData, (Int32)pvData.Length, uOffset);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetCachedUGCCount(IntPtr thisptr);
        public Int32 GetCachedUGCCount()
        {
            return this.GetFunction<NativeGetCachedUGCCount>(this.Functions.GetCachedUGCCount25)(this.ObjectAddress);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetCachedUGCHandleI(IntPtr thisptr, Int32 iCachedContent);
        public UInt64 GetCachedUGCHandle(Int32 iCachedContent)
        {
            return this.GetFunction<NativeGetCachedUGCHandleI>(this.Functions.GetCachedUGCHandle26)(this.ObjectAddress, iCachedContent);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativePublishWorkshopFileSSUSSESE(IntPtr thisptr, string pchFile, string pchPreviewFile, UInt32 nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, ref SteamParamStringArray_t pTags, EWorkshopFileType eWorkshopFileType);
        public UInt64 PublishWorkshopFile(string pchFile, string pchPreviewFile, UInt32 nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, ref SteamParamStringArray_t pTags, EWorkshopFileType eWorkshopFileType)
        {
            return this.GetFunction<NativePublishWorkshopFileSSUSSESE>(this.Functions.PublishWorkshopFile27)(this.ObjectAddress, pchFile, pchPreviewFile, nConsumerAppId, pchTitle, pchDescription, eVisibility, ref pTags, eWorkshopFileType);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeCreatePublishedFileUpdateRequestU(IntPtr thisptr, UInt64 unPublishedFileId);
        public UInt64 CreatePublishedFileUpdateRequest(UInt64 unPublishedFileId)
        {
            return this.GetFunction<NativeCreatePublishedFileUpdateRequestU>(this.Functions.CreatePublishedFileUpdateRequest28)(this.ObjectAddress, unPublishedFileId);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdatePublishedFileFileUS(IntPtr thisptr, UInt64 hUpdateRequest, string pchFile);
        public bool UpdatePublishedFileFile(UInt64 hUpdateRequest, string pchFile)
        {
            return this.GetFunction<NativeUpdatePublishedFileFileUS>(this.Functions.UpdatePublishedFileFile29)(this.ObjectAddress, hUpdateRequest, pchFile);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdatePublishedFilePreviewFileUS(IntPtr thisptr, UInt64 hUpdateRequest, string pchPreviewFile);
        public bool UpdatePublishedFilePreviewFile(UInt64 hUpdateRequest, string pchPreviewFile)
        {
            return this.GetFunction<NativeUpdatePublishedFilePreviewFileUS>(this.Functions.UpdatePublishedFilePreviewFile30)(this.ObjectAddress, hUpdateRequest, pchPreviewFile);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdatePublishedFileTitleUS(IntPtr thisptr, UInt64 hUpdateRequest, string pchTitle);
        public bool UpdatePublishedFileTitle(UInt64 hUpdateRequest, string pchTitle)
        {
            return this.GetFunction<NativeUpdatePublishedFileTitleUS>(this.Functions.UpdatePublishedFileTitle31)(this.ObjectAddress, hUpdateRequest, pchTitle);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdatePublishedFileDescriptionUS(IntPtr thisptr, UInt64 hUpdateRequest, string pchDescription);
        public bool UpdatePublishedFileDescription(UInt64 hUpdateRequest, string pchDescription)
        {
            return this.GetFunction<NativeUpdatePublishedFileDescriptionUS>(this.Functions.UpdatePublishedFileDescription32)(this.ObjectAddress, hUpdateRequest, pchDescription);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdatePublishedFileVisibilityUE(IntPtr thisptr, UInt64 hUpdateRequest, ERemoteStoragePublishedFileVisibility eVisibility);
        public bool UpdatePublishedFileVisibility(UInt64 hUpdateRequest, ERemoteStoragePublishedFileVisibility eVisibility)
        {
            return this.GetFunction<NativeUpdatePublishedFileVisibilityUE>(this.Functions.UpdatePublishedFileVisibility33)(this.ObjectAddress, hUpdateRequest, eVisibility);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdatePublishedFileTagsUS(IntPtr thisptr, UInt64 hUpdateRequest, ref SteamParamStringArray_t pTags);
        public bool UpdatePublishedFileTags(UInt64 hUpdateRequest, ref SteamParamStringArray_t pTags)
        {
            return this.GetFunction<NativeUpdatePublishedFileTagsUS>(this.Functions.UpdatePublishedFileTags34)(this.ObjectAddress, hUpdateRequest, ref pTags);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeCommitPublishedFileUpdateU(IntPtr thisptr, UInt64 hUpdateRequest);
        public UInt64 CommitPublishedFileUpdate(UInt64 hUpdateRequest)
        {
            return this.GetFunction<NativeCommitPublishedFileUpdateU>(this.Functions.CommitPublishedFileUpdate35)(this.ObjectAddress, hUpdateRequest);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetPublishedFileDetailsUU(IntPtr thisptr, UInt64 unPublishedFileId, UInt32 arg1);
        public UInt64 GetPublishedFileDetails(UInt64 unPublishedFileId, UInt32 arg1)
        {
            return this.GetFunction<NativeGetPublishedFileDetailsUU>(this.Functions.GetPublishedFileDetails36)(this.ObjectAddress, unPublishedFileId, arg1);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDeletePublishedFileU(IntPtr thisptr, UInt64 unPublishedFileId);
        public UInt64 DeletePublishedFile(UInt64 unPublishedFileId)
        {
            return this.GetFunction<NativeDeletePublishedFileU>(this.Functions.DeletePublishedFile37)(this.ObjectAddress, unPublishedFileId);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeEnumerateUserPublishedFilesU(IntPtr thisptr, UInt32 uStartIndex);
        public UInt64 EnumerateUserPublishedFiles(UInt32 uStartIndex)
        {
            return this.GetFunction<NativeEnumerateUserPublishedFilesU>(this.Functions.EnumerateUserPublishedFiles38)(this.ObjectAddress, uStartIndex);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeSubscribePublishedFileU(IntPtr thisptr, UInt64 unPublishedFileId);
        public UInt64 SubscribePublishedFile(UInt64 unPublishedFileId)
        {
            return this.GetFunction<NativeSubscribePublishedFileU>(this.Functions.SubscribePublishedFile39)(this.ObjectAddress, unPublishedFileId);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeEnumerateUserSubscribedFilesU(IntPtr thisptr, UInt32 uStartIndex);
        public UInt64 EnumerateUserSubscribedFiles(UInt32 uStartIndex)
        {
            return this.GetFunction<NativeEnumerateUserSubscribedFilesU>(this.Functions.EnumerateUserSubscribedFiles40)(this.ObjectAddress, uStartIndex);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUnsubscribePublishedFileU(IntPtr thisptr, UInt64 unPublishedFileId);
        public UInt64 UnsubscribePublishedFile(UInt64 unPublishedFileId)
        {
            return this.GetFunction<NativeUnsubscribePublishedFileU>(this.Functions.UnsubscribePublishedFile41)(this.ObjectAddress, unPublishedFileId);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdatePublishedFileSetChangeDescriptionUS(IntPtr thisptr, UInt64 hUpdateRequest, string cszDescription);
        public bool UpdatePublishedFileSetChangeDescription(UInt64 hUpdateRequest, string cszDescription)
        {
            return this.GetFunction<NativeUpdatePublishedFileSetChangeDescriptionUS>(this.Functions.UpdatePublishedFileSetChangeDescription42)(this.ObjectAddress, hUpdateRequest, cszDescription);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetPublishedItemVoteDetailsU(IntPtr thisptr, UInt64 unPublishedFileId);
        public UInt64 GetPublishedItemVoteDetails(UInt64 unPublishedFileId)
        {
            return this.GetFunction<NativeGetPublishedItemVoteDetailsU>(this.Functions.GetPublishedItemVoteDetails43)(this.ObjectAddress, unPublishedFileId);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUpdateUserPublishedItemVoteUB(IntPtr thisptr, UInt64 unPublishedFileId, [MarshalAs(UnmanagedType.I1)] bool bVoteUp);
        public UInt64 UpdateUserPublishedItemVote(UInt64 unPublishedFileId, bool bVoteUp)
        {
            return this.GetFunction<NativeUpdateUserPublishedItemVoteUB>(this.Functions.UpdateUserPublishedItemVote44)(this.ObjectAddress, unPublishedFileId, bVoteUp);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetUserPublishedItemVoteDetailsU(IntPtr thisptr, UInt64 unPublishedFileId);
        public UInt64 GetUserPublishedItemVoteDetails(UInt64 unPublishedFileId)
        {
            return this.GetFunction<NativeGetUserPublishedItemVoteDetailsU>(this.Functions.GetUserPublishedItemVoteDetails45)(this.ObjectAddress, unPublishedFileId);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeEnumerateUserSharedWorkshopFilesUCUSS(IntPtr thisptr, UInt32 nAppId, UInt64 creatorSteamID, UInt32 uStartIndex, ref SteamParamStringArray_t pRequiredTags, ref SteamParamStringArray_t pExcludedTags);
        public UInt64 EnumerateUserSharedWorkshopFiles(UInt32 nAppId, CSteamID creatorSteamID, UInt32 uStartIndex, ref SteamParamStringArray_t pRequiredTags, ref SteamParamStringArray_t pExcludedTags)
        {
            return this.GetFunction<NativeEnumerateUserSharedWorkshopFilesUCUSS>(this.Functions.EnumerateUserSharedWorkshopFiles46)(this.ObjectAddress, nAppId, creatorSteamID.ConvertToUint64(), uStartIndex, ref pRequiredTags, ref pExcludedTags);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativePublishVideoESSSUSSES(IntPtr thisptr, EWorkshopVideoProvider eVideoProvider, string cszVideoAccountName, string cszVideoIdentifier, string cszFileName, UInt32 nConsumerAppId, string cszTitle, string cszDescription, ERemoteStoragePublishedFileVisibility eVisibility, ref SteamParamStringArray_t pTags);
        public UInt64 PublishVideo(EWorkshopVideoProvider eVideoProvider, string cszVideoAccountName, string cszVideoIdentifier, string cszFileName, UInt32 nConsumerAppId, string cszTitle, string cszDescription, ERemoteStoragePublishedFileVisibility eVisibility, ref SteamParamStringArray_t pTags)
        {
            return this.GetFunction<NativePublishVideoESSSUSSES>(this.Functions.PublishVideo47)(this.ObjectAddress, eVideoProvider, cszVideoAccountName, cszVideoIdentifier, cszFileName, nConsumerAppId, cszTitle, cszDescription, eVisibility, ref pTags);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeSetUserPublishedFileActionUE(IntPtr thisptr, UInt64 unPublishedFileId, EWorkshopFileAction eAction);
        public UInt64 SetUserPublishedFileAction(UInt64 unPublishedFileId, EWorkshopFileAction eAction)
        {
            return this.GetFunction<NativeSetUserPublishedFileActionUE>(this.Functions.SetUserPublishedFileAction48)(this.ObjectAddress, unPublishedFileId, eAction);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeEnumeratePublishedFilesByUserActionEU(IntPtr thisptr, EWorkshopFileAction eAction, UInt32 uStartIndex);
        public UInt64 EnumeratePublishedFilesByUserAction(EWorkshopFileAction eAction, UInt32 uStartIndex)
        {
            return this.GetFunction<NativeEnumeratePublishedFilesByUserActionEU>(this.Functions.EnumeratePublishedFilesByUserAction49)(this.ObjectAddress, eAction, uStartIndex);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeEnumeratePublishedWorkshopFilesEUUUSS(IntPtr thisptr, EWorkshopEnumerationType eType, UInt32 uStartIndex, UInt32 cDays, UInt32 cCount, ref SteamParamStringArray_t pTags, ref SteamParamStringArray_t pUserTags);
        public UInt64 EnumeratePublishedWorkshopFiles(EWorkshopEnumerationType eType, UInt32 uStartIndex, UInt32 cDays, UInt32 cCount, ref SteamParamStringArray_t pTags, ref SteamParamStringArray_t pUserTags)
        {
            return this.GetFunction<NativeEnumeratePublishedWorkshopFilesEUUUSS>(this.Functions.EnumeratePublishedWorkshopFiles50)(this.ObjectAddress, eType, uStartIndex, cDays, cCount, ref pTags, ref pUserTags);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUGCDownloadToLocationUSU(IntPtr thisptr, UInt64 hContent, string cszLocation, UInt32 uUnk);
        public UInt64 UGCDownloadToLocation(UInt64 hContent, string cszLocation, UInt32 uUnk)
        {
            return this.GetFunction<NativeUGCDownloadToLocationUSU>(this.Functions.UGCDownloadToLocation51)(this.ObjectAddress, hContent, cszLocation, uUnk);
        }
    };
}