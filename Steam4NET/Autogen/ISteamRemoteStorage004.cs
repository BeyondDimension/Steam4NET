// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("STEAMREMOTESTORAGE_INTERFACE_VERSION004")]
	public interface ISteamRemoteStorage004
	{
		[VTableSlot(0)]
		bool FileWrite(string pchFile, Byte[] pvData, Int32 cubData);
		[VTableSlot(1)]
		Int32 FileRead(string pchFile, Byte[] pvData, Int32 cubDataToRead);
		[VTableSlot(2)]
		bool FileForget(string pchFile);
		[VTableSlot(3)]
		bool FileDelete(string pchFile);
		[VTableSlot(4)]
		UInt64 FileShare(string pchFile);
		[VTableSlot(5)]
		bool SetSyncPlatforms(string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform);
		[VTableSlot(6)]
		bool FileExists(string pchFile);
		[VTableSlot(7)]
		bool FilePersisted(string pchFile);
		[VTableSlot(8)]
		Int32 GetFileSize(string pchFile);
		[VTableSlot(9)]
		Int64 GetFileTimestamp(string pchFile);
		[VTableSlot(10)]
		ERemoteStoragePlatform GetSyncPlatforms(string pchFile);
		[VTableSlot(11)]
		Int32 GetFileCount();
		[VTableSlot(12)]
		string GetFileNameAndSize(Int32 iFile, ref Int32 pnFileSizeInBytes);
		[VTableSlot(13)]
		bool GetQuota(ref Int32 pnTotalBytes, ref Int32 puAvailableBytes);
		[VTableSlot(14)]
		bool IsCloudEnabledForAccount();
		[VTableSlot(15)]
		bool IsCloudEnabledForApp();
		[VTableSlot(16)]
		void SetCloudEnabledForApp(bool bEnabled);
		[VTableSlot(17)]
		UInt64 UGCDownload(UInt64 hContent);
		[VTableSlot(18)]
		bool GetUGCDetails(UInt64 hContent, ref UInt32 pnAppID, StringBuilder ppchName, ref Int32 pnFileSizeInBytes, ref CSteamID pSteamIDOwner);
		[VTableSlot(19)]
		Int32 UGCRead(UInt64 hContent, Byte[] pvData, Int32 cubDataToRead);
		[VTableSlot(20)]
		Int32 GetCachedUGCCount();
		[VTableSlot(21)]
		UInt64 GetCachedUGCHandle(Int32 iCachedContent);
	};
}