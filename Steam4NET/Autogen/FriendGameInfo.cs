// This file is automatically generated.
using System;
using System.Runtime.InteropServices;

namespace Steam4NET
{
    [StructLayout(LayoutKind.Sequential, Pack = 8)]
    public struct FriendGameInfo_t
    {
        public GameID_t m_gameID;
        public UInt32 m_unGameIP;
        public UInt16 m_usGamePort;
        public UInt16 m_usQueryPort;
        public SteamID_t m_steamIDLobby;
    };
}