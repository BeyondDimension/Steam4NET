// This file is automatically generated.
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Steam4NET
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public class ISteamUser012VTable
    {
        public IntPtr GetHSteamUser0;
        public IntPtr BLoggedOn1;
        public IntPtr GetSteamID2;
        public IntPtr InitiateGameConnection3;
        public IntPtr TerminateGameConnection4;
        public IntPtr TrackAppUsageEvent5;
        public IntPtr GetUserDataFolder6;
        public IntPtr StartVoiceRecording7;
        public IntPtr StopVoiceRecording8;
        public IntPtr GetCompressedVoice9;
        public IntPtr DecompressVoice10;
        public IntPtr GetAuthSessionTicket11;
        public IntPtr BeginAuthSession12;
        public IntPtr EndAuthSession13;
        public IntPtr CancelAuthTicket14;
        public IntPtr UserHasLicenseForApp15;
        private IntPtr DTorISteamUser01216;
    };

    [InteropHelp.InterfaceVersion("SteamUser012")]
    public class ISteamUser012 : InteropHelp.NativeWrapper<ISteamUser012VTable>
    {
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetHSteamUser(IntPtr thisptr);
        public Int32 GetHSteamUser()
        {
            return this.GetFunction<NativeGetHSteamUser>(this.Functions.GetHSteamUser0)(this.ObjectAddress);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeBLoggedOn(IntPtr thisptr);
        public bool BLoggedOn()
        {
            return this.GetFunction<NativeBLoggedOn>(this.Functions.BLoggedOn1)(this.ObjectAddress);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetSteamID(IntPtr thisptr, ref UInt64 retarg);
        public CSteamID GetSteamID()
        {
            UInt64 ret = 0; this.GetFunction<NativeGetSteamID>(this.Functions.GetSteamID2)(this.ObjectAddress, ref ret); return new CSteamID(ret);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeInitiateGameConnectionBICUUB(IntPtr thisptr, Byte[] pAuthBlob, Int32 cbMaxAuthBlob, UInt64 steamIDGameServer, UInt32 unIPServer, UInt16 usPortServer, [MarshalAs(UnmanagedType.I1)] bool bSecure);
        public Int32 InitiateGameConnection(Byte[] pAuthBlob, CSteamID steamIDGameServer, UInt32 unIPServer, UInt16 usPortServer, bool bSecure)
        {
            return this.GetFunction<NativeInitiateGameConnectionBICUUB>(this.Functions.InitiateGameConnection3)(this.ObjectAddress, pAuthBlob, (Int32)pAuthBlob.Length, steamIDGameServer.ConvertToUint64(), unIPServer, usPortServer, bSecure);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeTerminateGameConnectionUU(IntPtr thisptr, UInt32 unIPServer, UInt16 usPortServer);
        public void TerminateGameConnection(UInt32 unIPServer, UInt16 usPortServer)
        {
            this.GetFunction<NativeTerminateGameConnectionUU>(this.Functions.TerminateGameConnection4)(this.ObjectAddress, unIPServer, usPortServer);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeTrackAppUsageEventCES(IntPtr thisptr, UInt64 gameID, EAppUsageEvent eAppUsageEvent, string pchExtraInfo);
        public void TrackAppUsageEvent(CGameID gameID, EAppUsageEvent eAppUsageEvent, string pchExtraInfo)
        {
            this.GetFunction<NativeTrackAppUsageEventCES>(this.Functions.TrackAppUsageEvent5)(this.ObjectAddress, gameID.ConvertToUint64(), eAppUsageEvent, pchExtraInfo);
        }

        [return: MarshalAs(UnmanagedType.I1)]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUserDataFolderSI(IntPtr thisptr, StringBuilder pchBuffer, Int32 cubBuffer);
        public bool GetUserDataFolder(StringBuilder pchBuffer)
        {
            return this.GetFunction<NativeGetUserDataFolderSI>(this.Functions.GetUserDataFolder6)(this.ObjectAddress, pchBuffer, (Int32)pchBuffer.Capacity);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeStartVoiceRecording(IntPtr thisptr);
        public void StartVoiceRecording()
        {
            this.GetFunction<NativeStartVoiceRecording>(this.Functions.StartVoiceRecording7)(this.ObjectAddress);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeStopVoiceRecording(IntPtr thisptr);
        public void StopVoiceRecording()
        {
            this.GetFunction<NativeStopVoiceRecording>(this.Functions.StopVoiceRecording8)(this.ObjectAddress);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EVoiceResult NativeGetCompressedVoiceBUU(IntPtr thisptr, Byte[] pDestBuffer, UInt32 cbDestBufferSize, ref UInt32 nBytesWritten);
        public EVoiceResult GetCompressedVoice(Byte[] pDestBuffer, ref UInt32 nBytesWritten)
        {
            return this.GetFunction<NativeGetCompressedVoiceBUU>(this.Functions.GetCompressedVoice9)(this.ObjectAddress, pDestBuffer, (UInt32)pDestBuffer.Length, ref nBytesWritten);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EVoiceResult NativeDecompressVoiceBUBUU(IntPtr thisptr, Byte[] pCompressed, UInt32 cbCompressed, Byte[] pDestBuffer, UInt32 cbDestBufferSize, ref UInt32 nBytesWritten);
        public EVoiceResult DecompressVoice(Byte[] pCompressed, Byte[] pDestBuffer, ref UInt32 nBytesWritten)
        {
            return this.GetFunction<NativeDecompressVoiceBUBUU>(this.Functions.DecompressVoice10)(this.ObjectAddress, pCompressed, (UInt32)pCompressed.Length, pDestBuffer, (UInt32)pDestBuffer.Length, ref nBytesWritten);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAuthSessionTicketBIU(IntPtr thisptr, Byte[] pTicket, Int32 cbMaxTicket, ref UInt32 pcbTicket);
        public UInt32 GetAuthSessionTicket(Byte[] pTicket, ref UInt32 pcbTicket)
        {
            return this.GetFunction<NativeGetAuthSessionTicketBIU>(this.Functions.GetAuthSessionTicket11)(this.ObjectAddress, pTicket, (Int32)pTicket.Length, ref pcbTicket);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EBeginAuthSessionResult NativeBeginAuthSessionBIC(IntPtr thisptr, Byte[] pAuthTicket, Int32 cbAuthTicket, UInt64 steamID);
        public EBeginAuthSessionResult BeginAuthSession(Byte[] pAuthTicket, CSteamID steamID)
        {
            return this.GetFunction<NativeBeginAuthSessionBIC>(this.Functions.BeginAuthSession12)(this.ObjectAddress, pAuthTicket, (Int32)pAuthTicket.Length, steamID.ConvertToUint64());
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeEndAuthSessionC(IntPtr thisptr, UInt64 steamID);
        public void EndAuthSession(CSteamID steamID)
        {
            this.GetFunction<NativeEndAuthSessionC>(this.Functions.EndAuthSession13)(this.ObjectAddress, steamID.ConvertToUint64());
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeCancelAuthTicketU(IntPtr thisptr, UInt32 hAuthTicket);
        public void CancelAuthTicket(UInt32 hAuthTicket)
        {
            this.GetFunction<NativeCancelAuthTicketU>(this.Functions.CancelAuthTicket14)(this.ObjectAddress, hAuthTicket);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EUserHasLicenseForAppResult NativeUserHasLicenseForAppCU(IntPtr thisptr, UInt64 steamID, UInt32 appID);
        public EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, UInt32 appID)
        {
            return this.GetFunction<NativeUserHasLicenseForAppCU>(this.Functions.UserHasLicenseForApp15)(this.ObjectAddress, steamID.ConvertToUint64(), appID);
        }
    };
}