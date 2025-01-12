// This file is automatically generated.
using System.Runtime.InteropServices;

namespace Steam4NET;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public class IClientGameServerStatsVTable
{
    public IntPtr RequestUserStats0;
    public IntPtr GetUserStat1;
    public IntPtr GetUserStat2;
    public IntPtr GetUserAchievement3;
    public IntPtr SetUserStat4;
    public IntPtr SetUserStat5;
    public IntPtr UpdateUserAvgRateStat6;
    public IntPtr SetUserAchievement7;
    public IntPtr ClearUserAchievement8;
    public IntPtr StoreUserStats9;
    public IntPtr SetMaxStatsLoaded10;
    private IntPtr DTorIClientGameServerStats11;
};

[InteropHelp.InterfaceVersion("CLIENTGAMESERVERSTATS_INTERFACE_VERSION001")]
public class IClientGameServerStats : InteropHelp.NativeWrapper<IClientGameServerStatsVTable>
{
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestUserStatsCC(IntPtr thisptr, UInt64 steamIDUser, UInt64 gameID);
    public UInt64 RequestUserStats(CSteamID steamIDUser, CGameID gameID)
    {
        return this.GetFunction<NativeRequestUserStatsCC>(this.Functions.RequestUserStats0)(this.ObjectAddress, steamIDUser.ConvertToUint64(), gameID.ConvertToUint64());
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserStatCCSF(IntPtr thisptr, UInt64 steamIDUser, UInt64 gameID, string pchName, ref float pData);
    public bool GetUserStat(CSteamID steamIDUser, CGameID gameID, string pchName, ref float pData)
    {
        return this.GetFunction<NativeGetUserStatCCSF>(this.Functions.GetUserStat1)(this.ObjectAddress, steamIDUser.ConvertToUint64(), gameID.ConvertToUint64(), pchName, ref pData);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserStatCCSI(IntPtr thisptr, UInt64 steamIDUser, UInt64 gameID, string pchName, ref Int32 pData);
    public bool GetUserStat(CSteamID steamIDUser, CGameID gameID, string pchName, ref Int32 pData)
    {
        return this.GetFunction<NativeGetUserStatCCSI>(this.Functions.GetUserStat2)(this.ObjectAddress, steamIDUser.ConvertToUint64(), gameID.ConvertToUint64(), pchName, ref pData);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserAchievementCCSBU(IntPtr thisptr, UInt64 steamIDUser, UInt64 gameID, string pchName, ref bool pbAchieved, ref UInt32 prtTime);
    public bool GetUserAchievement(CSteamID steamIDUser, CGameID gameID, string pchName, ref bool pbAchieved, ref UInt32 prtTime)
    {
        return this.GetFunction<NativeGetUserAchievementCCSBU>(this.Functions.GetUserAchievement3)(this.ObjectAddress, steamIDUser.ConvertToUint64(), gameID.ConvertToUint64(), pchName, ref pbAchieved, ref prtTime);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetUserStatCCSF(IntPtr thisptr, UInt64 steamIDUser, UInt64 gameID, string pchName, float fData);
    public bool SetUserStat(CSteamID steamIDUser, CGameID gameID, string pchName, float fData)
    {
        return this.GetFunction<NativeSetUserStatCCSF>(this.Functions.SetUserStat4)(this.ObjectAddress, steamIDUser.ConvertToUint64(), gameID.ConvertToUint64(), pchName, fData);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetUserStatCCSI(IntPtr thisptr, UInt64 steamIDUser, UInt64 gameID, string pchName, Int32 nData);
    public bool SetUserStat(CSteamID steamIDUser, CGameID gameID, string pchName, Int32 nData)
    {
        return this.GetFunction<NativeSetUserStatCCSI>(this.Functions.SetUserStat5)(this.ObjectAddress, steamIDUser.ConvertToUint64(), gameID.ConvertToUint64(), pchName, nData);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdateUserAvgRateStatCCSFD(IntPtr thisptr, UInt64 steamIDUser, UInt64 gameID, string pchName, float flCountThisSession, double dSessionLength);
    public bool UpdateUserAvgRateStat(CSteamID steamIDUser, CGameID gameID, string pchName, float flCountThisSession, double dSessionLength)
    {
        return this.GetFunction<NativeUpdateUserAvgRateStatCCSFD>(this.Functions.UpdateUserAvgRateStat6)(this.ObjectAddress, steamIDUser.ConvertToUint64(), gameID.ConvertToUint64(), pchName, flCountThisSession, dSessionLength);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetUserAchievementCCS(IntPtr thisptr, UInt64 steamIDUser, UInt64 gameID, string pchName);
    public bool SetUserAchievement(CSteamID steamIDUser, CGameID gameID, string pchName)
    {
        return this.GetFunction<NativeSetUserAchievementCCS>(this.Functions.SetUserAchievement7)(this.ObjectAddress, steamIDUser.ConvertToUint64(), gameID.ConvertToUint64(), pchName);
    }

    [return: MarshalAs(UnmanagedType.I1)]
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeClearUserAchievementCCS(IntPtr thisptr, UInt64 steamIDUser, UInt64 gameID, string pchName);
    public bool ClearUserAchievement(CSteamID steamIDUser, CGameID gameID, string pchName)
    {
        return this.GetFunction<NativeClearUserAchievementCCS>(this.Functions.ClearUserAchievement8)(this.ObjectAddress, steamIDUser.ConvertToUint64(), gameID.ConvertToUint64(), pchName);
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeStoreUserStatsCC(IntPtr thisptr, UInt64 steamIDUser, UInt64 gameID);
    public UInt64 StoreUserStats(CSteamID steamIDUser, CGameID gameID)
    {
        return this.GetFunction<NativeStoreUserStatsCC>(this.Functions.StoreUserStats9)(this.ObjectAddress, steamIDUser.ConvertToUint64(), gameID.ConvertToUint64());
    }

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetMaxStatsLoadedU(IntPtr thisptr, UInt32 uMax);
    public void SetMaxStatsLoaded(UInt32 uMax)
    {
        this.GetFunction<NativeSetMaxStatsLoadedU>(this.Functions.SetMaxStatsLoaded10)(this.ObjectAddress, uMax);
    }
};