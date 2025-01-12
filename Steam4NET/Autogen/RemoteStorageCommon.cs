// This file is automatically generated.
using System.Runtime.InteropServices;

namespace Steam4NET;

public enum ERemoteStorageFileRoot : int
{
    k_ERemoteStorageFileRootInvalid = -1,
    k_ERemoteStorageFileRootDefault = 0,
    k_ERemoteStorageFileRootGameInstall = 1,
    k_ERemoteStorageFileRootWinMyDocuments = 2,
    k_ERemoteStorageFileRootWinAppDataLocal = 3,
    k_ERemoteStorageFileRootWinAppDataRoaming = 4,
    k_ERemoteStorageFileRootSteamUserBaseStorage = 5,
    k_ERemoteStorageFileRootMacHome = 6,
    k_ERemoteStorageFileRootMacAppSupport = 7,
    k_ERemoteStorageFileRootMacDocuments = 8,
    k_ERemoteStorageFileRootWinSavedGames = 9,
    k_ERemoteStorageFileRootWinProgramData = 10,
    k_ERemoteStorageFileRootSteamCloudDocuments = 11,
    k_ERemoteStorageFileRootWinAppDataLocalLow = 12,
    k_ERemoteStorageFileRootMacCaches = 13,
    k_ERemoteStorageFileRootLinuxHome = 14,
    k_ERemoteStorageFileRootLinuxXdgDataHome = 15,
    k_ERemoteStorageFileRootMax = 16,
};

public enum ERemoteStorageSyncState : int
{
    k_ERemoteSyncStateDisabled = 0,
    k_ERemoteSyncStateUnknown = 1,
    k_ERemoteSyncStateSynchronized = 2,
    k_ERemoteSyncStateSyncInProgress = 3,
    k_ERemoteSyncStatePendingChangesInCloud = 4,
    k_ERemoteSyncStatePendingChangesLocally = 5,
    k_ERemoteSyncStatePendingChangesInCloudAndLocally = 6,
    k_ERemoteSyncStateConflictingChanges = 7,
};

public enum EFileRemoteStorageSyncState : int
{
};

public enum EUCMFilePrivacyState : int
{
    k_EUCMFilePrivacyStateInvalid = -1,
    k_EUCMFilePrivacyStateUnpublished = 0,
    k_EUCMFilePrivacyStatePublished = 1,
    k_EUCMFilePrivacyStatePrivate = 2,
    k_EUCMFilePrivacyStateFriendsOnly = 4,
    k_EUCMFilePrivacyStatePublic = 8,
    k_EUCMFilePrivacyStateAll = 14,
};

public enum ERemoteStoragePlatform : int
{
    k_ERemoteStoragePlatformNone = 0,
    k_ERemoteStoragePlatformWindows = 1,
    k_ERemoteStoragePlatformOSX = 2,
    k_ERemoteStoragePlatformPS3 = 4,
    k_ERemoteStoragePlatformLinux = 8,
    k_ERemoteStoragePlatformReserved2 = 16,
    k_ERemoteStoragePlatformAll = -1,
};

public enum EResolveConflict : int
{
    k_EResolveConflictKeepClient = 1,
    k_EResolveConflictKeepServer = 2,
};

public enum ERemoteStoragePublishedFileVisibility : int
{
    k_ERemoteStoragePublishedFileVisibilityPublic = 0,
    k_ERemoteStoragePublishedFileVisibilityFriendsOnly = 1,
    k_ERemoteStoragePublishedFileVisibilityPrivate = 2,
};

public enum ERemoteStoragePublishedFileSortOrder : int
{
};

public enum EWorkshopFileType : int
{
    k_EWorkshopFileTypeFirst = 0,
    k_EWorkshopFileTypeCommunity = 0,
    k_EWorkshopFileTypeMicrotransaction = 1,
    k_EWorkshopFileTypeCollection = 2,
    k_EWorkshopFileTypeArt = 3,
    k_EWorkshopFileTypeVideo = 4,
    k_EWorkshopFileTypeScreenshot = 5,
    k_EWorkshopFileTypeGame = 6,
    k_EWorkshopFileTypeSoftware = 7,
    k_EWorkshopFileTypeConcept = 8,
    k_EWorkshopFileTypeWebGuide = 9,
    k_EWorkshopFileTypeIntegratedGuide = 10,
    k_EWorkshopFileTypeMerch = 11,
    k_EWorkshopFileTypeControllerBinding = 12,
    k_EWorkshopFileTypeSteamworksAccessInvite = 13,
    k_EWorkshopFileTypeSteamVideo = 14,
    k_EWorkshopFileTypeMax = 15,
};

public enum EWorkshopVote : int
{
    k_EWorkshopVoteUnvoted = 0,
    k_EWorkshopVoteFor = 1,
    k_EWorkshopVoteAgainst = 2,
};

public enum EWorkshopVideoProvider : int
{
};

public enum EWorkshopFileAction : int
{
    k_EWorkshopFileActionPlayed = 0,
    k_EWorkshopFileActionCompleted = 1,
};

public enum EWorkshopEnumerationType : int
{
    k_EWorkshopEnumerationTypeRankedByVote = 0,
    k_EWorkshopEnumerationTypeRecent = 1,
    k_EWorkshopEnumerationTypeTrending = 2,
    k_EWorkshopEnumerationTypeFavoritesOfFriends = 3,
    k_EWorkshopEnumerationTypeVotedByFriends = 4,
    k_EWorkshopEnumerationTypeContentByFriends = 5,
    k_EWorkshopEnumerationTypeRecentFromFollowedUsers = 6,
};

public enum EPublishedFileInfoMatchingFileType : int
{
};

public enum EUGCReadAction : int
{
    k_EUGCRead_ContinueReadingUntilFinished = 0,
    k_EUGCRead_ContinueReading = 1,
    k_EUGCRead_Close = 2,
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct SteamParamStringArray_t
{
    public string m_ppStrings;
    public Int32 m_nNumStrings;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct RemoteStorageUpdatePublishedFileRequest_t
{
    public UInt64 m_unPublishedFileId;
    public string m_pchFile;
    public string m_pchPreviewFile;
    public string m_pchTitle;
    public string m_pchDescription;
    public ERemoteStoragePublishedFileVisibility m_eVisibility;
    public IntPtr m_pTags;
    [MarshalAs(UnmanagedType.I1)]
    public bool m_bUpdateFile;
    [MarshalAs(UnmanagedType.I1)]
    public bool m_bUpdatePreviewFile;
    [MarshalAs(UnmanagedType.I1)]
    public bool m_bUpdateTitle;
    [MarshalAs(UnmanagedType.I1)]
    public bool m_bUpdateDescription;
    [MarshalAs(UnmanagedType.I1)]
    public bool m_bUpdateVisibility;
    [MarshalAs(UnmanagedType.I1)]
    public bool m_bUpdateTags;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1301)]
public struct RemoteStorageAppSyncedClient_t
{
    public const int k_iCallback = 1301;
    public UInt32 m_nAppID;
    public EResult m_eResult;
    public Int32 m_unNumDownloads;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1302)]
public struct RemoteStorageAppSyncedServer_t
{
    public const int k_iCallback = 1302;
    public UInt32 m_nAppID;
    public EResult m_eResult;
    public Int32 m_unNumUploads;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1303)]
public struct RemoteStorageAppSyncProgress_t
{
    public const int k_iCallback = 1303;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string m_rgchCurrentFile;
    public UInt32 m_nAppID;
    public UInt32 m_uBytesTransferredThisChunk;
    public double m_dAppPercentComplete;
    [MarshalAs(UnmanagedType.I1)]
    public bool m_bUploading;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1304)]
public struct RemoteStorageAppInfoLoaded_t
{
    public const int k_iCallback = 1304;
    public UInt32 m_nAppID;
    public EResult m_eResult;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1305)]
public struct RemoteStorageAppSyncStatusCheck_t
{
    public const int k_iCallback = 1305;
    public UInt32 m_nAppID;
    public EResult m_eResult;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1306)]
public struct RemoteStorageConflictResolution_t
{
    public const int k_iCallback = 1306;
    public UInt32 m_nAppID;
    public EResult m_eResult;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1307)]
public struct RemoteStorageFileShareResult_t
{
    public const int k_iCallback = 1307;
    public EResult m_eResult;
    public UInt64 m_hFile;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1308)]
public struct _Deprecated_RemoteStorageDownloadUGCResult_t
{
    public const int k_iCallback = 1308;
    public EResult m_eResult;
    public UInt64 m_hFile;
    public UInt32 m_nAppID;
    public Int32 m_nSizeInBytes;
    public string m_pchFileName;
    public UInt64 m_ulSteamIDOwner;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1309)]
public struct RemoteStoragePublishFileResult_t
{
    public const int k_iCallback = 1309;
    public EResult m_eResult;
    public UInt64 m_nPublishedFileId;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1310)]
public struct _Deprecated_RemoteStorageGetPublishedFileDetailsResult_t
{
    public const int k_iCallback = 1310;
    public EResult m_eResult;
    public UInt64 m_nPublishedFileId;
    public UInt32 m_nCreatorAppID;
    public UInt32 m_nConsumerAppID;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public string m_rgchTitle;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 257)]
    public string m_rgchDescription;
    public UInt64 m_hFile;
    public UInt64 m_hPreviewFile;
    public UInt64 m_ulSteamIDOwner;
    public UInt32 m_rtimeCreated;
    public UInt32 m_rtimeUpdated;
    public ERemoteStoragePublishedFileVisibility m_eVisibility;
    [MarshalAs(UnmanagedType.I1)]
    public bool m_bBanned;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1025)]
    public string m_rgchTags;
    [MarshalAs(UnmanagedType.I1)]
    public bool m_bTagsTruncated;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string m_pchFileName;
    public EWorkshopFileType m_eFileType;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1311)]
public struct RemoteStorageDeletePublishedFileResult_t
{
    public const int k_iCallback = 1311;
    public EResult m_eResult;
    public UInt64 m_nPublishedFileId;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1312)]
public struct RemoteStorageEnumerateUserPublishedFilesResult_t
{
    public const int k_iCallback = 1312;
    public EResult m_eResult;
    public Int32 m_nResultsReturned;
    public Int32 m_nTotalResultCount;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public UInt64[] m_rgPublishedFileId;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1313)]
public struct RemoteStorageSubscribePublishedFileResult_t
{
    public const int k_iCallback = 1313;
    public EResult m_eResult;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1314)]
public struct RemoteStorageEnumerateUserSubscribedFilesResult_t
{
    public const int k_iCallback = 1314;
    public EResult m_eResult;
    public Int32 m_nResultsReturned;
    public Int32 m_nTotalResultCount;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public UInt64[] m_rgPublishedFileId;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public UInt32[] m_rgRTimeSubscribed;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1315)]
public struct RemoteStorageUnsubscribePublishedFileResult_t
{
    public const int k_iCallback = 1315;
    public EResult m_eResult;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1316)]
public struct RemoteStorageUpdatePublishedFileResult_t
{
    public const int k_iCallback = 1316;
    public EResult m_eResult;
    public UInt64 m_nPublishedFileId;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1317)]
public struct RemoteStorageDownloadUGCResult_t
{
    public const int k_iCallback = 1317;
    public EResult m_eResult;
    public UInt64 m_hFile;
    public UInt32 m_nAppID;
    public Int32 m_nSizeInBytes;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string m_pchFileName;
    public UInt64 m_ulSteamIDOwner;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1318)]
public struct RemoteStorageGetPublishedFileDetailsResult_t
{
    public const int k_iCallback = 1318;
    public EResult m_eResult;
    public UInt64 m_nPublishedFileId;
    public UInt32 m_nCreatorAppID;
    public UInt32 m_nConsumerAppID;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 129)]
    public string m_rgchTitle;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8000)]
    public string m_rgchDescription;
    public UInt64 m_hFile;
    public UInt64 m_hPreviewFile;
    public UInt64 m_ulSteamIDOwner;
    public UInt32 m_rtimeCreated;
    public UInt32 m_rtimeUpdated;
    public ERemoteStoragePublishedFileVisibility m_eVisibility;
    [MarshalAs(UnmanagedType.I1)]
    public bool m_bBanned;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1025)]
    public string m_rgchTags;
    [MarshalAs(UnmanagedType.I1)]
    public bool m_bTagsTruncated;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string m_pchFileName;
    public Int32 m_nFileSize;
    public Int32 m_nPreviewFileSize;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1319)]
public struct RemoteStorageEnumerateWorkshopFilesResult_t
{
    public const int k_iCallback = 1319;
    public EResult m_eResult;
    public Int32 m_nResultsReturned;
    public Int32 m_nTotalResultCount;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public UInt64[] m_rgPublishedFileId;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public float[] m_rgScore;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1320)]
public struct RemoteStorageGetPublishedItemVoteDetailsResult_t
{
    public const int k_iCallback = 1320;
    public EResult m_eResult;
    public UInt64 m_unPublishedFileId;
    public Int32 m_nVotesFor;
    public Int32 m_nVotesAgainst;
    public Int32 m_nReports;
    public float m_fScore;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1321)]
public struct RemoteStoragePublishedFileSubscribed_t
{
    public const int k_iCallback = 1321;
    public UInt64 m_unPublishedFileId;
    public UInt32 m_nAppID;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1322)]
public struct RemoteStoragePublishedFileUnsubscribed_t
{
    public const int k_iCallback = 1322;
    public UInt64 m_unPublishedFileId;
    public UInt32 m_nAppID;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1323)]
public struct RemoteStoragePublishedFileDeleted_t
{
    public const int k_iCallback = 1323;
    public UInt64 m_unPublishedFileId;
    public UInt32 m_nAppID;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1324)]
public struct RemoteStorageUpdateUserPublishedItemVoteResult_t
{
    public const int k_iCallback = 1324;
    public EResult m_eResult;
    public UInt64 m_unPublishedFileId;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1325)]
public struct RemoteStorageUserVoteDetails_t
{
    public const int k_iCallback = 1325;
    public EResult m_eResult;
    public Int32 m_iVote;
    public UInt64 m_unPublishedFileId;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1326)]
public struct RemoteStorageEnumerateUserSharedWorkshopFilesResult_t
{
    public const int k_iCallback = 1326;
    public EResult m_eResult;
    public Int32 m_nResultsReturned;
    public Int32 m_nTotalResultCount;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public UInt64[] m_rgPublishedFileId;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1327)]
public struct RemoteStorageSetUserPublishedFileActionResult_t
{
    public const int k_iCallback = 1327;
    public EResult m_eResult;
    public UInt64 m_unPublishedFileId;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1328)]
public struct RemoteStorageEnumeratePublishedFilesByUserActionResult_t
{
    public const int k_iCallback = 1328;
    public EResult m_eResult;
    public EWorkshopFileAction m_eAction;
    public Int32 m_nResultsReturned;
    public Int32 m_nTotalResultCount;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public UInt64[] m_rgPublishedFileId;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public UInt32[] m_rgRTimes;
};