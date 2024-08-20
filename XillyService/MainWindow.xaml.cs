using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;

namespace Page_Navigation_App
{
	// Token: 0x02000004 RID: 4
	public partial class MainWindow : Window
	{
		// Token: 0x0600000A RID: 10 RVA: 0x0000215F File Offset: 0x0000035F
		public MainWindow()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002170 File Offset: 0x00000370
		private void CloseApp_Click(object sender, RoutedEventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000217C File Offset: 0x0000037C
		private void Window_MouseDown(object sender, MouseButtonEventArgs e)
		{
			bool flag = e.ChangedButton == MouseButton.Left;
			if (flag)
			{
				base.DragMove();
			}
		}
	}
}
