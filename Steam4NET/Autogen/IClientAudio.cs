// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[InterfaceVersion("CLIENTAUDIO_INTERFACE_VERSION001")]
	public interface IClientAudio
	{
		[VTableSlot(0)]
		void StartVoiceRecording();
		[VTableSlot(1)]
		void StopVoiceRecording();
		[VTableSlot(2)]
		void ResetVoiceRecording();
		[VTableSlot(3)]
		EVoiceResult GetAvailableVoice(ref UInt32 pcbCompressed, ref UInt32 pcbUncompressed, UInt32 nUncompressedVoiceDesiredSampleRate);
		[VTableSlot(4)]
		EVoiceResult GetVoice(bool bWantCompressed, Byte[] pDestBuffer, UInt32 cbDestBufferSize, ref UInt32 nBytesWritten, bool bWantUncompressed, Byte[] pUncompressedDestBuffer, UInt32 cbUncompressedDestBufferSize, ref UInt32 nUncompressBytesWritten, UInt32 nUncompressedVoiceDesiredSampleRate);
		[VTableSlot(5)]
		EVoiceResult GetCompressedVoice(Byte[] pDestBuffer, UInt32 cbDestBufferSize, ref UInt32 nBytesWritten);
		[VTableSlot(6)]
		EVoiceResult DecompressVoice(Byte[] pCompressed, UInt32 cbCompressed, Byte[] pDestBuffer, UInt32 cbDestBufferSize, ref UInt32 nBytesWritten, UInt32 nDesiredSampleRate);
		[VTableSlot(7)]
		UInt32 GetVoiceOptimalSampleRate();
		[VTableSlot(8)]
		bool PlayAudio(UInt32 hAudio);
		[VTableSlot(9)]
		void StopAudio();
		[VTableSlot(10)]
		void PauseAudio();
		[VTableSlot(11)]
		void UnPauseAudio();
		[VTableSlot(12)]
		void SetPlayOrder(EPlayMode ePlayMode);
		[VTableSlot(13)]
		void ShufflePlayList();
		[VTableSlot(14)]
		EPlayMode GetPlayMode();
		[VTableSlot(15)]
		UInt32 GetAudioHandle(string cszFilePath);
		[VTableSlot(16)]
		bool GetAudioDetails(UInt32 hAudio, StringBuilder arg1, Int32 arg2, StringBuilder arg3, Int32 arg4, StringBuilder arg5, Int32 arg6);
		[VTableSlot(17)]
		bool GetAudioArtSize(UInt32 hAudio, ref UInt32 punWidth, ref UInt32 punHeight);
		[VTableSlot(18)]
		bool GetAudioArtImage(UInt32 hAudio, Byte[] pubBuffer, Int32 cubBuffer);
		[VTableSlot(19)]
		UInt32 GetPlayListCount();
		[VTableSlot(20)]
		bool AddSongToPlaylist(UInt32 hAudio);
		[VTableSlot(21)]
		bool RemoveSongFromPlaylist(UInt32 hAudio);
		[VTableSlot(22)]
		bool SaveCurrentPlaylistToFile(string cszFilePath);
		[VTableSlot(23)]
		bool LoadPlaylistFromFile(string cszFilePath);
		[VTableSlot(24)]
		UInt32 GetFileSourceCount();
		[VTableSlot(25)]
		UInt32 AddLocalFileSource(string cszFileSource);
		[VTableSlot(26)]
		UInt32 AddSMBFileSource(string cszFileSource);
		[VTableSlot(27)]
		UInt32 AddITunesFileSource(string cszFileSource);
		[VTableSlot(28)]
		bool RemoveFileSource(UInt32 hFileSource);
	};
	public enum EPlayMode : int
	{
	};
	
}
