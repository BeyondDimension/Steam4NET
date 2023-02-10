// This file is automatically generated.
using System.Runtime.InteropServices;

namespace Steam4NET;

public enum ESteamItemFlags : int
{
    k_ESteamItemNoTrade = 1,
    k_ESteamItemRemoved = 256,
    k_ESteamItemConsumed = 512,
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct SteamItemDetails_t
{
    public UInt64 m_itemId;
    public Int32 m_iDefinition;
    public UInt16 m_unQuantity;
    public UInt16 m_unFlags;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(4700)]
public struct SteamInventoryResultReady_t
{
    public const int k_iCallback = 4700;
    public Int32 m_handle;
    public EResult m_result;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(4701)]
public struct SteamInventoryFullUpdate_t
{
    public const int k_iCallback = 4701;
    public Int32 m_handle;
};

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[InteropHelp.CallbackIdentity(4702)]
public struct SteamInventoryDefinitionUpdate_t
{
    public const int k_iCallback = 4702;
};