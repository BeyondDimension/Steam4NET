// This file is automatically generated.
using System.Runtime.InteropServices;

namespace Steam4NET;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public class ISteamAppTicket001VTable
{
    public IntPtr GetAppOwnershipTicketData0;
    private IntPtr DTorISteamAppTicket0011;
};

[InteropHelp.InterfaceVersion("STEAMAPPTICKET_INTERFACE_VERSION001")]
public class ISteamAppTicket001 : InteropHelp.NativeWrapper<ISteamAppTicket001VTable>
{
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetAppOwnershipTicketDataUBUUUUU(IntPtr thisptr, UInt32 nAppId, Byte[] pvSignedTicket, UInt32 cbSignedTicket, ref UInt32 piAppId, ref UInt32 piSteamId, ref UInt32 piSignature, ref UInt32 pcbSignature);
    public UInt32 GetAppOwnershipTicketData(UInt32 nAppId, Byte[] pvSignedTicket, ref UInt32 piAppId, ref UInt32 piSteamId, ref UInt32 piSignature, ref UInt32 pcbSignature)
    {
        return this.GetFunction<NativeGetAppOwnershipTicketDataUBUUUUU>(this.Functions.GetAppOwnershipTicketData0)(this.ObjectAddress, nAppId, pvSignedTicket, (UInt32)pvSignedTicket.Length, ref piAppId, ref piSteamId, ref piSignature, ref pcbSignature);
    }
};