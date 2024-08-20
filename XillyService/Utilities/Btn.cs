using System;
using System.Windows;
using System.Windows.Controls;

namespace Page_Navigation_App.Utilities
{
	// Token: 0x02000010 RID: 16
	public class Btn : RadioButton
	{
		// Token: 0x0600005C RID: 92 RVA: 0x0000988E File Offset: 0x00007A8E
		static Btn()
		{
			FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(Btn), new FrameworkPropertyMetadata(typeof(Btn)));
		}
	}
}
