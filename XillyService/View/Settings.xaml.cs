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
	// Token: 0x02000009 RID: 9
	public partial class Settings : UserControl
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00009426 File Offset: 0x00007626
		public Settings()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00009438 File Offset: 0x00007638
		[DebuggerStepThrough]
		private void NVIDIAOC_Click(object sender, RoutedEventArgs e)
		{
			Settings.<NVIDIAOC_Click>d__1 <NVIDIAOC_Click>d__ = new Settings.<NVIDIAOC_Click>d__1();
			<NVIDIAOC_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<NVIDIAOC_Click>d__.<>4__this = this;
			<NVIDIAOC_Click>d__.sender = sender;
			<NVIDIAOC_Click>d__.e = e;
			<NVIDIAOC_Click>d__.<>1__state = -1;
			<NVIDIAOC_Click>d__.<>t__builder.Start<Settings.<NVIDIAOC_Click>d__1>(ref <NVIDIAOC_Click>d__);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00009480 File Offset: 0x00007680
		[DebuggerStepThrough]
		private void SCEWIN_Click(object sender, RoutedEventArgs e)
		{
			Settings.<SCEWIN_Click>d__2 <SCEWIN_Click>d__ = new Settings.<SCEWIN_Click>d__2();
			<SCEWIN_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<SCEWIN_Click>d__.<>4__this = this;
			<SCEWIN_Click>d__.sender = sender;
			<SCEWIN_Click>d__.e = e;
			<SCEWIN_Click>d__.<>1__state = -1;
			<SCEWIN_Click>d__.<>t__builder.Start<Settings.<SCEWIN_Click>d__2>(ref <SCEWIN_Click>d__);
		}
	}
}
