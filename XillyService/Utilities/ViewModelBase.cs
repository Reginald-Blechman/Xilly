using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Page_Navigation_App.Utilities
{
	// Token: 0x02000012 RID: 18
	internal class ViewModelBase : INotifyPropertyChanged
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000063 RID: 99 RVA: 0x00009914 File Offset: 0x00007B14
		// (remove) Token: 0x06000064 RID: 100 RVA: 0x0000994C File Offset: 0x00007B4C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000065 RID: 101 RVA: 0x00009981 File Offset: 0x00007B81
		public void OnPropertyChanged([CallerMemberName] string propName = null)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propName));
			}
		}
	}
}
