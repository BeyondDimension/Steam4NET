// This file is automatically generated.
using System.Runtime.InteropServices;

namespace Steam4NET;

public enum ESteamUserStatType : int
{
    k_ESteamUserStatTypeINVALID = 0,
    k_ESteamUserStatTypeINT = 1,
    k_ESteamUserStatTypeFLOAT = 2,
    k_ESteamUserStatTypeAVGRATE = 3,
    k_ESteamUserStatTypeACHIEVEMENTS = 4,
    k_ESteamUserStatTypeGROUPACHIEVEMENTS = 5,
};

public enum ELeaderboardDataRequest : int
{
    k_ELeaderboardDataRequestGlobal = 0,
    k_ELeaderboardDataRequestGlobalAroundUser = 1,
    k_ELeaderboardDataRequestFriends = 2,
    k_ELeaderboardDataRequestUsers = 3,
};

public enum ELeaderboardDisplayType : int
{
    k_ELeaderboardDisplayTypeNone = 0,
    k_ELeaderboardDisplayTypeNumeric = 1,
    k_ELeaderboardDisplayTypeTimeSeconds = 2,
    k_ELeaderboardDisplayTypeTimeMilliSeconds = 3,
};

public enum ELeaderboardUploadScoreMethod : int
{
    k_ELeaderboardUploadScoreMethodNone = 0,
    k_ELeaderboardUploadScoreMethodKeepBest = 1,
    k_ELeaderboardUploadScoreMethodForceUpdate = 2,
};

public enum ELeaderboardSortMethod : int
{
    k_ELeaderboardSortMethodNone = 0,
    k_ELeaderboardSortMethodAscending = 1,
    k_ELeaderboardSortMethodDescending = 2,
};

public enum EGetAchievementIcon : int
{
    k_EGetAchievementIconUser = 0,
    k_EGetAchievementIconAchieved = 1,
    k_EGetAchievementIconUnachieved = 2,
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct LeaderboardEntry001_t
{
    public SteamID_t m_steamIDUser;
    public Int32 m_nGlobalRank;
    public Int32 m_nScore;
    public Int32 m_cDetails;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct LeaderboardEntry002_t
{
    public SteamID_t m_steamIDUser;
    public Int32 m_nGlobalRank;
    public Int32 m_nScore;
    public Int32 m_cDetails;
    public UInt64 m_hUGC;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1101)]
public struct UserStatsReceived_t
{
    public const int k_iCallback = 1101;
    public UInt64 m_nGameID;
    public EResult m_eResult;
    public SteamID_t m_steamIDUser;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1102)]
public struct UserStatsStored_t
{
    public const int k_iCallback = 1102;
    public UInt64 m_nGameID;
    public EResult m_eResult;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1103)]
public struct UserAchievementStored_t
{
    public const int k_iCallback = 1103;
    public UInt64 m_nGameID;
    [MarshalAs(UnmanagedType.I1)]
    public bool m_bGroupAchievement;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string m_rgchAchievementName;
    public UInt32 m_nCurProgress;
    public UInt32 m_nMaxProgress;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1104)]
public struct LeaderboardFindResult_t
{
    public const int k_iCallback = 1104;
    public UInt64 m_hSteamLeaderboard;
    public Byte m_bLeaderboardFound;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1105)]
public struct LeaderboardScoresDownloaded_t
{
    public const int k_iCallback = 1105;
    public UInt64 m_hSteamLeaderboard;
    public UInt64 m_hSteamLeaderboardEntries;
    public Int32 m_cEntryCount;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1106)]
public struct LeaderboardScoreUploaded_t
{
    public const int k_iCallback = 1106;
    public Byte m_bSuccess;
    public UInt64 m_hSteamLeaderboard;
    public Int32 m_nScore;
    public Byte m_bScoreChanged;
    public Int32 m_nGlobalRankNew;
    public Int32 m_nGlobalRankPrevious;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1107)]
public struct NumberOfCurrentPlayers_t
{
    public const int k_iCallback = 1107;
    public Byte m_bSuccess;
    public Int32 m_cPlayers;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1108)]
public struct UserStatsUnloaded_t
{
    public const int k_iCallback = 1108;
    public SteamID_t m_steamIDUser;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1109)]
public struct UserAchievementIconFetched_t
{
    public const int k_iCallback = 1109;
    public GameID_t m_nGameID;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string m_rgchAchievementName;
    [MarshalAs(UnmanagedType.I1)]
    public bool m_bAchieved;
    public Int32 m_nIconHandle;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1110)]
public struct GlobalAchievementPercentagesReady_t
{
    public const int k_iCallback = 1110;
    public UInt64 m_nGameID;
    public EResult m_eResult;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1111)]
public struct LeaderboardUGCSet_t
{
    public const int k_iCallback = 1111;
    public EResult m_eResult;
    public UInt64 m_hSteamLeaderboard;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(1112)]
public struct GlobalStatsReceived_t
{
    public const int k_iCallback = 1112;
    public UInt64 m_nGameID;
    public EResult m_eResult;
};