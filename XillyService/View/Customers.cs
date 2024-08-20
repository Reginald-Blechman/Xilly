using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Xml;

namespace Page_Navigation_App.View
{
	// Token: 0x02000005 RID: 5
	public class Customers : UserControl, IComponentConnector
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002271 File Offset: 0x00000471
		public Customers()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000011 RID: 17
		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);

		// Token: 0x06000012 RID: 18 RVA: 0x000022A8 File Offset: 0x000004A8
		[DebuggerStepThrough]
		private void ManualButton_Click(object sender, RoutedEventArgs e)
		{
			Customers.<ManualButton_Click>d__4 <ManualButton_Click>d__ = new Customers.<ManualButton_Click>d__4();
			<ManualButton_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ManualButton_Click>d__.<>4__this = this;
			<ManualButton_Click>d__.sender = sender;
			<ManualButton_Click>d__.e = e;
			<ManualButton_Click>d__.<>1__state = -1;
			<ManualButton_Click>d__.<>t__builder.Start<Customers.<ManualButton_Click>d__4>(ref <ManualButton_Click>d__);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000022F0 File Offset: 0x000004F0
		[DebuggerStepThrough]
		private void GraphicsButton_Click(object sender, RoutedEventArgs e)
		{
			Customers.<GraphicsButton_Click>d__5 <GraphicsButton_Click>d__ = new Customers.<GraphicsButton_Click>d__5();
			<GraphicsButton_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<GraphicsButton_Click>d__.<>4__this = this;
			<GraphicsButton_Click>d__.sender = sender;
			<GraphicsButton_Click>d__.e = e;
			<GraphicsButton_Click>d__.<>1__state = -1;
			<GraphicsButton_Click>d__.<>t__builder.Start<Customers.<GraphicsButton_Click>d__5>(ref <GraphicsButton_Click>d__);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002338 File Offset: 0x00000538
		[DebuggerStepThrough]
		private void StartGPU()
		{
			Customers.<StartGPU>d__7 <StartGPU>d__ = new Customers.<StartGPU>d__7();
			<StartGPU>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<StartGPU>d__.<>4__this = this;
			<StartGPU>d__.<>1__state = -1;
			<StartGPU>d__.<>t__builder.Start<Customers.<StartGPU>d__7>(ref <StartGPU>d__);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002374 File Offset: 0x00000574
		private void DriverDownloads()
		{
			Thread.Sleep(2000);
			bool flag = this.RADEON.Equals(true);
			if (flag)
			{
				Process.Start(new ProcessStartInfo("https://www.amd.com/en/support")
				{
					UseShellExecute = true
				});
			}
			else
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(Path.GetTempPath() + "GPU.xml");
				string innerText = xmlDocument.SelectSingleNode("/gpuz_dump/card/gpuname").InnerText;
				Process process = new Process();
				process.StartInfo.FileName = Path.GetTempPath() + "NVCleanstall_1.16.0.exe";
				process.Start();
				process.WaitForExit();
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002418 File Offset: 0x00000618
		[DebuggerStepThrough]
		private void FinishButton_Click(object sender, RoutedEventArgs e)
		{
			Customers.<FinishButton_Click>d__9 <FinishButton_Click>d__ = new Customers.<FinishButton_Click>d__9();
			<FinishButton_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<FinishButton_Click>d__.<>4__this = this;
			<FinishButton_Click>d__.sender = sender;
			<FinishButton_Click>d__.e = e;
			<FinishButton_Click>d__.<>1__state = -1;
			<FinishButton_Click>d__.<>t__builder.Start<Customers.<FinishButton_Click>d__9>(ref <FinishButton_Click>d__);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002460 File Offset: 0x00000660
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "7.0.3.0")]
		public void InitializeComponent()
		{
			bool contentLoaded = this._contentLoaded;
			if (!contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocater = new Uri("/XillyService;component/view/apo.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocater);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002498 File Offset: 0x00000698
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "7.0.3.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.ManualButton = (Button)target;
				this.ManualButton.Click += this.ManualButton_Click;
				break;
			case 2:
				this.GraphicsButton = (Button)target;
				this.GraphicsButton.Click += this.GraphicsButton_Click;
				break;
			case 3:
				this.FinishButton = (Button)target;
				this.FinishButton.Click += this.FinishButton_Click;
				break;
			case 4:
				this.RAM = (TextBox)target;
				break;
			default:
				this._contentLoaded = true;
				break;
			}
		}

		// Token: 0x04000005 RID: 5
		private string path = Path.GetPathRoot(Environment.SystemDirectory);

		// Token: 0x04000006 RID: 6
		private bool RADEON = false;

		// Token: 0x04000007 RID: 7
		private string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);

		// Token: 0x04000008 RID: 8
		internal Button ManualButton;

		// Token: 0x04000009 RID: 9
		internal Button GraphicsButton;

		// Token: 0x0400000A RID: 10
		internal Button FinishButton;

		// Token: 0x0400000B RID: 11
		internal TextBox RAM;

		// Token: 0x0400000C RID: 12
		private bool _contentLoaded;
	}
}
