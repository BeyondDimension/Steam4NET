// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;
using Steam4NET.Attributes;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct ClientAppInfo
	{
		public Int32 m_iPadding;
	};
	
	public enum EParentalFeature : int
	{
		k_EParentalFeatureInvalid = 0,
		k_EParentalFeatureStore = 1,
		k_EParentalFeatureCommunity = 2,
		k_EParentalFeatureProfile = 3,
		k_EParentalFeatureFriends = 4,
		k_EParentalFeatureNews = 5,
		k_EParentalFeatureTrading = 6,
		k_EParentalFeatureSettings = 7,
		k_EParentalFeatureConsole = 8,
		k_EParentalFeatureBrowser = 9,
		k_EParentalFeatureOverlay = 10,
	};
	
	[StructLayout(LayoutKind.Sequential,Pack=8)]
	public struct COffline_OfflineLogonTicket
	{
		public Int32 m_iPadding;
	};
	
	[InterfaceVersion("CLIENTUSER_INTERFACE_VERSION001")]
	public interface IClientUser
	{
		[VTableSlot(0)]
		Int32 GetHSteamUser();
		[VTableSlot(1)]
		void LogOn(bool bInteractive, CSteamID steamID);
		[VTableSlot(2)]
		void LogOnWithPassword(bool bInteractive, string pchLogin, string pchPassword);
		[VTableSlot(3)]
		void LogOnAndCreateNewSteamAccountIfNeeded(bool bInteractive);
		[VTableSlot(4)]
		EResult LogOnConnectionless();
		[VTableSlot(5)]
		void LogOff();
		[VTableSlot(6)]
		bool BLoggedOn();
		[VTableSlot(7)]
		ELogonState GetLogonState();
		[VTableSlot(8)]
		bool BConnected();
		[VTableSlot(9)]
		bool BTryingToLogin();
		[VTableSlot(10)]
		CSteamID GetSteamID();
		[VTableSlot(11)]
		CSteamID GetConsoleSteamID();
		[VTableSlot(12)]
		bool IsVACBanned(UInt32 nGameID);
		[VTableSlot(13)]
		bool RequireShowVACBannedMessage(UInt32 nAppID);
		[VTableSlot(14)]
		void AcknowledgeVACBanning(UInt32 nAppID);
		[VTableSlot(15)]
		void SetSteam2Ticket(Byte[] pubTicket, Int32 cubTicket);
		[VTableSlot(16)]
		bool BExistsSteam2Ticket();
		[VTableSlot(17)]
		bool SetEmail(string pchEmail);
		[VTableSlot(18)]
		bool SetConfigString(ERegistrySubTree eRegistrySubTree, string pchKey, string pchValue);
		[VTableSlot(19)]
		bool GetConfigString(ERegistrySubTree eRegistrySubTree, string pchKey, StringBuilder pchValue, Int32 cbValue);
		[VTableSlot(20)]
		bool SetConfigInt(ERegistrySubTree eRegistrySubTree, string pchKey, Int32 iValue);
		[VTableSlot(21)]
		bool GetConfigInt(ERegistrySubTree eRegistrySubTree, string pchKey, ref Int32 pValue);
		[VTableSlot(22)]
		bool GetConfigStoreKeyName(ERegistrySubTree eRegistrySubTree, string pchKey, StringBuilder pchStoreName, Int32 cbStoreName);
		[VTableSlot(23)]
		Int32 InitiateGameConnection(Byte[] pOutputBlob, Int32 cbBlobMax, CSteamID steamIDGS, CGameID gameID, UInt32 unIPServer, UInt16 usPortServer, bool bSecure);
		[VTableSlot(24)]
		Int32 InitiateGameConnectionOld(Byte[] pOutputBlob, Int32 cbBlobMax, CSteamID steamIDGS, CGameID gameID, UInt32 unIPServer, UInt16 usPortServer, bool bSecure, Byte[] pvSteam2GetEncryptionKey, Int32 cbSteam2GetEncryptionKey);
		[VTableSlot(25)]
		void TerminateGameConnection(UInt32 unIPServer, UInt16 usPortServer);
		[VTableSlot(26)]
		void SetSelfAsPrimaryChatDestination();
		[VTableSlot(27)]
		bool IsPrimaryChatDestination();
		[VTableSlot(28)]
		void RequestLegacyCDKey(UInt32 iAppID);
		[VTableSlot(29)]
		bool SendGuestPassByEmail(string pchEmailAccount, UInt64 gidGuestPassID, bool bResending);
		[VTableSlot(30)]
		bool SendGuestPassByAccountID(UInt32 uAccountID, UInt64 gidGuestPassID, bool bResending);
		[VTableSlot(31)]
		bool AckGuestPass(string pchGuestPassCode);
		[VTableSlot(32)]
		bool RedeemGuestPass(string pchGuestPassCode);
		[VTableSlot(33)]
		UInt32 GetGuestPassToGiveCount();
		[VTableSlot(34)]
		UInt32 GetGuestPassToRedeemCount();
		[VTableSlot(35)]
		UInt32 GetGuestPassLastUpdateTime();
		[VTableSlot(36)]
		bool GetGuestPassToGiveInfo(UInt32 nPassIndex, ref UInt64 pgidGuestPassID, ref UInt32 pnPackageID, ref UInt32 pRTime32Created, ref UInt32 pRTime32Expiration, ref UInt32 pRTime32Sent, ref UInt32 pRTime32Redeemed, StringBuilder pchRecipientAddress, Int32 cRecipientAddressSize);
		[VTableSlot(37)]
		bool GetGuestPassToRedeemInfo(UInt32 nPassIndex, ref UInt64 pgidGuestPassID, ref UInt32 pnPackageID, ref UInt32 pRTime32Created, ref UInt32 pRTime32Expiration, ref UInt32 pRTime32Sent, ref UInt32 pRTime32Redeemed);
		[VTableSlot(38)]
		bool GetGuestPassToRedeemSenderAddress(UInt32 nPassIndex, StringBuilder pchSenderAddress, Int32 cSenderAddressSize);
		[VTableSlot(39)]
		bool GetGuestPassToRedeemSenderName(UInt32 nPassIndex, StringBuilder pchSenderName, Int32 cSenderNameSize);
		[VTableSlot(40)]
		bool RequestGuestPassTargetList(UInt64 gidGuestPassID);
		[VTableSlot(41)]
		bool RequestGiftTargetList(UInt32 nPackageID);
		[VTableSlot(42)]
		void AcknowledgeMessageByGID(string pchMessageGID);
		[VTableSlot(43)]
		bool SetLanguage(string pchLanguage);
		[VTableSlot(44)]
		void TrackAppUsageEvent(CGameID gameID, Int32 eAppUsageEvent, string pchExtraInfo);
		[VTableSlot(45)]
		Int32 RaiseConnectionPriority(EConnectionPriority eConnectionPriority);
		[VTableSlot(46)]
		void ResetConnectionPriority(Int32 hRaiseConnectionPriorityPrev);
		[VTableSlot(47)]
		void SetAccountNameFromSteam2(string pchAccountName);
		[VTableSlot(48)]
		bool SetPasswordFromSteam2(string pchPassword);
		[VTableSlot(49)]
		bool BHasCachedCredentials(string pchUnk);
		[VTableSlot(50)]
		bool SetAccountNameForCachedCredentialLogin(string pchAccountName, bool bUnk);
		[VTableSlot(51)]
		void SetLoginInformation(string pchAccountName, string pchPassword, bool bRememberPassword);
		[VTableSlot(52)]
		void SetLauncherType(ELauncherType eLauncherType);
		[VTableSlot(53)]
		void ClearAllLoginInformation();
		[VTableSlot(54)]
		void SetAccountCreationTime(UInt32 rtime32Time);
		[VTableSlot(55)]
		UInt64 RequestWebAuthToken();
		[VTableSlot(56)]
		bool GetCurrentWebAuthToken(StringBuilder pchBuffer, Int32 cubBuffer);
		[VTableSlot(57)]
		bool GetLanguage(StringBuilder pchLanguage, Int32 cbLanguage);
		[VTableSlot(58)]
		bool BIsCyberCafe();
		[VTableSlot(59)]
		bool BIsAcademicAccount();
		[VTableSlot(60)]
		void CreateAccount(string pchAccountName, string pchNewPassword, string pchNewEmail, Int32 iQuestion, string pchNewQuestion, string pchNewAnswer);
		[VTableSlot(61)]
		UInt64 ResetPassword(string pchAccountName, string pchOldPassword, string pchNewPassword, string pchValidationCode, string pchAnswer);
		[VTableSlot(62)]
		void TrackNatTraversalStat(ref CNatTraversalStat pNatStat);
		[VTableSlot(63)]
		UInt32 GetPackageIDForGuestPassToRedeemByGID(UInt64 gid);
		[VTableSlot(64)]
		void TrackSteamUsageEvent(ESteamUsageEvent eSteamUsageEvent, Byte[] pubKV, UInt32 cubKV);
		[VTableSlot(65)]
		void TrackSteamGUIUsage(string arg0);
		[VTableSlot(66)]
		void SetComputerInUse();
		[VTableSlot(67)]
		bool BIsGameRunning(CGameID gameID);
		[VTableSlot(68)]
		UInt64 GetCurrentSessionToken();
		[VTableSlot(69)]
		bool BUpdateAppOwnershipTicket(UInt32 nAppID, bool bOnlyUpdateIfStale, bool bIsDepot);
		[VTableSlot(70)]
		bool RequestCustomBinary(string pszAbsolutePath, UInt32 nAppID, bool bForceUpdate, bool bAppLaunchRequest);
		[VTableSlot(71)]
		EResult GetCustomBinariesState(UInt32 unAppID, ref UInt32 punProgress);
		[VTableSlot(72)]
		EResult RequestCustomBinaries(UInt32 unAppID, bool arg1, bool arg2, ref UInt32 arg3);
		[VTableSlot(73)]
		void SetCellID(UInt32 cellID);
		[VTableSlot(74)]
		void SetWinningPingTimeForCellID(UInt32 uPing);
		[VTableSlot(75)]
		string GetUserBaseFolder();
		[VTableSlot(76)]
		bool GetUserDataFolder(CGameID gameID, StringBuilder pchBuffer, Int32 cubBuffer);
		[VTableSlot(77)]
		bool GetUserConfigFolder(StringBuilder pchBuffer, Int32 cubBuffer);
		[VTableSlot(78)]
		bool GetAccountName(StringBuilder pchAccountName, UInt32 cb);
		[VTableSlot(79)]
		bool GetAccountName(CSteamID userID, StringBuilder pchAccountName, UInt32 cb);
		[VTableSlot(80)]
		bool IsPasswordRemembered();
		[VTableSlot(81)]
		bool RequiresLegacyCDKey(UInt32 nAppID);
		[VTableSlot(82)]
		bool GetLegacyCDKey(UInt32 nAppID, StringBuilder pchKeyData, Int32 cbKeyData);
		[VTableSlot(83)]
		bool HasLegacyCDKey(UInt32 nAppID);
		[VTableSlot(84)]
		bool SetLegacyCDKey(UInt32 nAppID, string pchKeyData);
		[VTableSlot(85)]
		void RemoveLegacyCDKey(UInt32 nAppID);
		[VTableSlot(86)]
		void RequestLegacyCDKeyFromApp(UInt32 nMainAppID, UInt32 nDLCAppID);
		[VTableSlot(87)]
		bool BIsAnyGameRunning();
		[VTableSlot(88)]
		void TestAvailablePassword(Byte[] pubDigestPassword, Int32 cubDigestPassword);
		[VTableSlot(89)]
		void GetSteamGuardDetails();
		[VTableSlot(90)]
		void ChangePassword(string pchOldPassword, string pchNewPassword);
		[VTableSlot(91)]
		void ChangeEmail(string arg0, string pchEmail);
		[VTableSlot(92)]
		void ChangeSecretQuestionAndAnswer(string arg0, Int32 iQuestion, string pchNewQuestion, string pchNewAnswer);
		[VTableSlot(93)]
		void SetSteam2FullASTicket(Byte[] pubTicket, Int32 cubTicket);
		[VTableSlot(94)]
		Int32 GetSteam2FullASTicket(Byte[] pubTicket, Int32 cubTicket);
		[VTableSlot(95)]
		bool GetEmail(StringBuilder pchEmail, Int32 cchEmail, ref bool pbValidated);
		[VTableSlot(96)]
		void RequestForgottenPasswordEmail(string pchAccountName, string pchTriedPassword);
		[VTableSlot(97)]
		void FindAccountsByEmailAddress(string pchEmailAddress);
		[VTableSlot(98)]
		void FindAccountsByCdKey(string pchCdKey);
		[VTableSlot(99)]
		void GetNumAccountsWithEmailAddress(string pchEmailAddress);
		[VTableSlot(100)]
		void IsAccountNameInUse(string pchAccountName);
		[VTableSlot(101)]
		void Test_FakeConnectionTimeout();
		[VTableSlot(102)]
		bool RunInstallScript(ref UInt32 pAppIDs, Int32 cAppIDs, string pchInstallPath, string pchLanguage, bool bUninstall);
		[VTableSlot(103)]
		UInt32 IsInstallScriptRunning();
		[VTableSlot(104)]
		bool GetInstallScriptState(StringBuilder pchDescription, UInt32 cchDescription, ref UInt32 punNumSteps, ref UInt32 punCurrStep);
		[VTableSlot(105)]
		bool SpawnProcess(Byte[] lpVACBlob, UInt32 cbBlobSize, string lpApplicationName, string lpCommandLine, UInt32 dwCreationFlags, string lpCurrentDirectory, CGameID gameID, UInt32 nAppID, string pchGameName, bool bAlwaysUseShellExec);
		[VTableSlot(106)]
		UInt32 GetAppOwnershipTicketLength(UInt32 nAppID);
		[VTableSlot(107)]
		UInt32 GetAppOwnershipTicketData(UInt32 nAppID, Byte[] pvBuffer, UInt32 cbBufferLength);
		[VTableSlot(108)]
		UInt32 GetAppOwnershipTicketExtendedData(UInt32 nAppID, Byte[] pvBuffer, UInt32 cbBufferLength, ref UInt32 piAppId, ref UInt32 piSteamId, ref UInt32 piSignature, ref UInt32 pcbSignature);
		[VTableSlot(109)]
		Int32 GetMarketingMessageCount();
		[VTableSlot(110)]
		bool GetMarketingMessage(Int32 cMarketingMessage, ref UInt64 gidMarketingMessageID, StringBuilder pubMsgUrl, Int32 cubMessageUrl, ref EMarketingMessageFlags eMarketingMssageFlags);
		[VTableSlot(111)]
		UInt32 GetAuthSessionTicket(Byte[] pMyAuthTicket, Int32 cbMaxMyAuthTicket, ref UInt32 pcbAuthTicket);
		[VTableSlot(112)]
		EBeginAuthSessionResult BeginAuthSession(Byte[] pTheirAuthTicket, Int32 cbTicket, CSteamID steamID);
		[VTableSlot(113)]
		void EndAuthSession(CSteamID steamID);
		[VTableSlot(114)]
		void CancelAuthTicket(UInt32 hAuthTicket);
		[VTableSlot(115)]
		EUserHasLicenseForAppResult IsUserSubscribedAppInTicket(CSteamID steamID, UInt32 appID);
		[VTableSlot(116)]
		void AdvertiseGame(CGameID gameID, CSteamID steamIDGameServer, UInt32 unIPServer, UInt16 usPortServer);
		[VTableSlot(117)]
		UInt64 RequestEncryptedAppTicket(Byte[] pUserData, Int32 cbUserData);
		[VTableSlot(118)]
		bool GetEncryptedAppTicket(Byte[] pTicket, Int32 cbMaxTicket, ref UInt32 pcbTicket);
		[VTableSlot(119)]
		Int32 GetGameBadgeLevel(Int32 nSeries, bool bFoil);
		[VTableSlot(120)]
		Int32 GetPlayerSteamLevel();
		[VTableSlot(121)]
		void SetAccountLimited(bool bAccountLimited);
		[VTableSlot(122)]
		bool BIsAccountLimited();
		[VTableSlot(123)]
		void SetAccountCommunityBanned(bool bBanned);
		[VTableSlot(124)]
		bool BIsAccountCommunityBanned();
		[VTableSlot(125)]
		void SendValidationEmail();
		[VTableSlot(126)]
		bool BGameConnectTokensAvailable();
		[VTableSlot(127)]
		Int32 NumGamesRunning();
		[VTableSlot(128)]
		CGameID GetRunningGameID(Int32 iGame);
		[VTableSlot(129)]
		UInt32 GetAccountSecurityPolicyFlags();
		[VTableSlot(130)]
		void RequestChangeEmail(string pchPassword, Int32 eRequestType);
		[VTableSlot(131)]
		void ChangePasswordWithCode(string pchOldPassword, string pchCode, string pchNewPassword);
		[VTableSlot(132)]
		void ChangeEmailWithCode(string pchPassword, string pchCode, string pchEmail, bool bFinal);
		[VTableSlot(133)]
		void ChangeSecretQuestionAndAnswerWithCode(string pchPassword, string pchCode, string pchNewQuestion, string pchNewAnswer);
		[VTableSlot(134)]
		void SetClientStat(EClientStat eStat, Int64 llValue, UInt32 nAppID, UInt32 nDepotID, UInt32 nCellID);
		[VTableSlot(135)]
		void VerifyPassword(string pchPassword);
		[VTableSlot(136)]
		bool BSupportUser();
		[VTableSlot(137)]
		bool BIsAppOverlayEnabled(UInt32 nAppID);
		[VTableSlot(138)]
		bool BIsBehindNAT();
		[VTableSlot(139)]
		UInt32 GetMicroTxnAppID(UInt64 gidTransID);
		[VTableSlot(140)]
		UInt64 GetMicroTxnOrderID(UInt64 gidTransID);
		[VTableSlot(141)]
		bool BGetMicroTxnPrice(UInt64 gidTransID, ref CAmount pamtTotal, ref CAmount pamtTax, ref bool pbVat);
		[VTableSlot(142)]
		Int32 GetMicroTxnLineItemCount(UInt64 gidTransID);
		[VTableSlot(143)]
		bool BGetMicroTxnLineItem(UInt64 gidTransID, UInt32 unLineItem, ref CAmount pamt, ref UInt32 punQuantity, StringBuilder pchDescription, UInt32 cubDescriptionLength, ref Int32 pRecurringTimeUnit, Byte[] pRecurringFrequency, ref CAmount pRecurringAmount, ref bool pbUnk);
		[VTableSlot(144)]
		bool BIsSandboxMicroTxn(UInt64 gidTransID, ref bool pbSandbox);
		[VTableSlot(145)]
		bool BMicroTxnRequiresCachedPmtMethod(UInt64 gidTransID, ref bool pbRequired);
		[VTableSlot(146)]
		UInt64 AuthorizeMicroTxn(UInt64 gidTransID, EMicroTxnAuthResponse eMicroTxnAuthResponse);
		[VTableSlot(147)]
		bool BGetWalletBalance(ref bool pbHasWallet, ref CAmount pamtBalance);
		[VTableSlot(148)]
		UInt64 RequestMicroTxnInfo(UInt64 gidTransID);
		[VTableSlot(149)]
		bool BGetAppMinutesPlayed(UInt32 nAppId, ref Int32 pnForever, ref Int32 pnLastTwoWeeks);
		[VTableSlot(150)]
		UInt32 GetAppLastPlayedTime(UInt32 nAppId);
		[VTableSlot(151)]
		bool BGetGuideURL(UInt32 uAppID, StringBuilder pchURL, UInt32 cchURL);
		[VTableSlot(152)]
		void GetClientAppListResponse_AddApp(ref ClientAppInfo pClientAppInfo);
		[VTableSlot(153)]
		void GetClientAppListResponse_AddDLC(UInt32 nAppId, bool bInstalled);
		[VTableSlot(154)]
		void GetClientAppListResponse_Done(UInt64 ulBytesFreeOnDrive);
		[VTableSlot(155)]
		void PostUIResultToClientJob(UInt64 ulJobID, EResult eResult);
		[VTableSlot(156)]
		bool BPromptToVerifyEmail();
		[VTableSlot(157)]
		bool BPromptToChangePassword();
		[VTableSlot(158)]
		bool BAccountLocked();
		[VTableSlot(159)]
		bool BAccountShouldShowLockUI();
		[VTableSlot(160)]
		bool BAccountLockedByIPT();
		[VTableSlot(161)]
		Int32 GetCountAuthedComputers();
		[VTableSlot(162)]
		ESteamGuardProvider GetSteamGuardProvider();
		[VTableSlot(163)]
		bool GetSteamGuardRequireCodeByDefault();
		[VTableSlot(164)]
		bool ShowSteamGuardProviderOptions();
		[VTableSlot(165)]
		bool SteamGuardProviderMobileIsOption();
		[VTableSlot(166)]
		bool BSteamGuardNewMachineNotification();
		[VTableSlot(167)]
		UInt32 GetSteamGuardEnabledTime();
		[VTableSlot(168)]
		bool GetSteamGuardHistoryEntry(Int32 iEntryIndex, ref UInt32 puTimestamp, ref UInt32 puIP, ref bool pbIsRemembered, StringBuilder pchGeolocInfo, Int32 cchGeolocInfo, StringBuilder pchUnk, Int32 cbUnk);
		[VTableSlot(169)]
		void SetSteamGuardNewMachineDialogResponse(bool bIsApproved, bool bIsWizardComplete);
		[VTableSlot(170)]
		bool BAccountCanUseIPT();
		[VTableSlot(171)]
		void ChangeTwoFactorAuthOptions(Int32 eOption);
		[VTableSlot(172)]
		void ChangeSteamGuardOptions(string pchUnk, ESteamGuardProvider eProvider, bool bRequireCode);
		[VTableSlot(173)]
		void Set2ndFactorAuthCode(string pchAuthCode, bool bDontRememberComputer);
		[VTableSlot(174)]
		void SetUserMachineName(string pchMachineName);
		[VTableSlot(175)]
		bool GetUserMachineName(StringBuilder pchMachineName, Int32 cbMachineName);
		[VTableSlot(176)]
		bool BAccountHasIPTConfig();
		[VTableSlot(177)]
		bool GetEmailDomainFromLogonFailure(StringBuilder pchEmailDomain, Int32 cbEmailDomain);
		[VTableSlot(178)]
		bool BIsSubscribedApp(UInt32 nAppId);
		[VTableSlot(179)]
		UInt64 RegisterActivationCode(string pchActivationCode);
		[VTableSlot(180)]
		void OptionalDLCInstallation(UInt32 nAppID, bool bInstall);
		[VTableSlot(181)]
		void AckSystemIM(UInt64 arg0);
		[VTableSlot(182)]
		UInt64 RequestSpecialSurvey(UInt32 uSurveyId);
		[VTableSlot(183)]
		UInt64 SendSpecialSurveyResponse(UInt32 uSurveyId, Byte[] pubData, UInt32 cubData);
		[VTableSlot(184)]
		void RequestNotifications();
		[VTableSlot(185)]
		bool GetAppOwnershipInfo(UInt32 unAppId, ref UInt32 pRTime32Created, StringBuilder pchCountry);
		[VTableSlot(186)]
		void SendGameWebCallback(UInt32 unAppId, string szData);
		[VTableSlot(187)]
		bool BIsCurrentlyStreaming();
		[VTableSlot(188)]
		void RequestStopStreaming();
		[VTableSlot(189)]
		void OnBigPictureStreamingResult(bool arg0, Byte[] arg1);
		[VTableSlot(190)]
		void OnBigPictureStreamingDone();
		[VTableSlot(191)]
		void OnBigPictureStreamRestarting();
		[VTableSlot(192)]
		void LockParentalLock();
		[VTableSlot(193)]
		void UnlockParentalLock(string pchUnk);
		[VTableSlot(194)]
		void BlockApp(UInt32 unAppID);
		[VTableSlot(195)]
		void UnblockApp(UInt32 unAppID);
		[VTableSlot(196)]
		bool BIsParentalLockEnabled();
		[VTableSlot(197)]
		bool BIsParentalLockLocked();
		[VTableSlot(198)]
		bool BIsAppBlocked(UInt32 unAppID);
		[VTableSlot(199)]
		bool BIsAppInBlockList(UInt32 unAppID);
		[VTableSlot(200)]
		bool BIsFeatureBlocked(EParentalFeature eParentalFeature);
		[VTableSlot(201)]
		bool BIsFeatureInBlockList(EParentalFeature eParentalFeature);
		[VTableSlot(202)]
		EResult ValidateOfflineLogonTicket(string pchUnk);
		[VTableSlot(203)]
		bool BGetOfflineLogonTicket(string pchUnk, ref COffline_OfflineLogonTicket pTicket);
	};
}
