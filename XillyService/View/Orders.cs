using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Page_Navigation_App.View
{
	// Token: 0x02000008 RID: 8
	public class Orders : UserControl, IComponentConnector
	{
		// Token: 0x0600002D RID: 45 RVA: 0x000091EC File Offset: 0x000073EC
		public Orders()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00009200 File Offset: 0x00007400
		[DebuggerStepThrough]
		private void installhwinfo_Click(object sender, RoutedEventArgs e)
		{
			Orders.<installhwinfo_Click>d__1 <installhwinfo_Click>d__ = new Orders.<installhwinfo_Click>d__1();
			<installhwinfo_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<installhwinfo_Click>d__.<>4__this = this;
			<installhwinfo_Click>d__.sender = sender;
			<installhwinfo_Click>d__.e = e;
			<installhwinfo_Click>d__.<>1__state = -1;
			<installhwinfo_Click>d__.<>t__builder.Start<Orders.<installhwinfo_Click>d__1>(ref <installhwinfo_Click>d__);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00009248 File Offset: 0x00007448
		[DebuggerStepThrough]
		private void installcpuz_Click(object sender, RoutedEventArgs e)
		{
			Orders.<installcpuz_Click>d__2 <installcpuz_Click>d__ = new Orders.<installcpuz_Click>d__2();
			<installcpuz_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<installcpuz_Click>d__.<>4__this = this;
			<installcpuz_Click>d__.sender = sender;
			<installcpuz_Click>d__.e = e;
			<installcpuz_Click>d__.<>1__state = -1;
			<installcpuz_Click>d__.<>t__builder.Start<Orders.<installcpuz_Click>d__2>(ref <installcpuz_Click>d__);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00009290 File Offset: 0x00007490
		[DebuggerStepThrough]
		private void uninstallddu_Click(object sender, RoutedEventArgs e)
		{
			Orders.<uninstallddu_Click>d__3 <uninstallddu_Click>d__ = new Orders.<uninstallddu_Click>d__3();
			<uninstallddu_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<uninstallddu_Click>d__.<>4__this = this;
			<uninstallddu_Click>d__.sender = sender;
			<uninstallddu_Click>d__.e = e;
			<uninstallddu_Click>d__.<>1__state = -1;
			<uninstallddu_Click>d__.<>t__builder.Start<Orders.<uninstallddu_Click>d__3>(ref <uninstallddu_Click>d__);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000092D8 File Offset: 0x000074D8
		[DebuggerStepThrough]
		private void nvcleanstall_Click(object sender, RoutedEventArgs e)
		{
			Orders.<nvcleanstall_Click>d__4 <nvcleanstall_Click>d__ = new Orders.<nvcleanstall_Click>d__4();
			<nvcleanstall_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<nvcleanstall_Click>d__.<>4__this = this;
			<nvcleanstall_Click>d__.sender = sender;
			<nvcleanstall_Click>d__.e = e;
			<nvcleanstall_Click>d__.<>1__state = -1;
			<nvcleanstall_Click>d__.<>t__builder.Start<Orders.<nvcleanstall_Click>d__4>(ref <nvcleanstall_Click>d__);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00009320 File Offset: 0x00007520
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "7.0.3.0")]
		public void InitializeComponent()
		{
			bool contentLoaded = this._contentLoaded;
			if (!contentLoaded)
			{
				this._contentLoaded = true;
				Uri resourceLocater = new Uri("/XillyService;component/view/pccheckup.xaml", UriKind.Relative);
				Application.LoadComponent(this, resourceLocater);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00009358 File Offset: 0x00007558
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "7.0.3.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IComponentConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 1:
				this.installhwinfo = (Button)target;
				this.installhwinfo.Click += this.installhwinfo_Click;
				break;
			case 2:
				this.installcpuz = (Button)target;
				this.installcpuz.Click += this.installcpuz_Click;
				break;
			case 3:
				this.uninstallddu = (Button)target;
				this.uninstallddu.Click += this.uninstallddu_Click;
				break;
			case 4:
				this.nvcleanstall = (Button)target;
				this.nvcleanstall.Click += this.nvcleanstall_Click;
				break;
			default:
				this._contentLoaded = true;
				break;
			}
		}

		// Token: 0x04000018 RID: 24
		internal Button installhwinfo;

		// Token: 0x04000019 RID: 25
		internal Button installcpuz;

		// Token: 0x0400001A RID: 26
		internal Button uninstallddu;

		// Token: 0x0400001B RID: 27
		internal Button nvcleanstall;

		// Token: 0x0400001C RID: 28
		private bool _contentLoaded;
	}
}
