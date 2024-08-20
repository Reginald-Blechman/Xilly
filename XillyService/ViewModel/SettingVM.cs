using System;
using Page_Navigation_App.Model;
using Page_Navigation_App.Utilities;

namespace Page_Navigation_App.ViewModel
{
	// Token: 0x0200000F RID: 15
	internal class SettingVM : ViewModelBase
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00009838 File Offset: 0x00007A38
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00009855 File Offset: 0x00007A55
		public bool Settings
		{
			get
			{
				return this._pageModel.LocationStatus;
			}
			set
			{
				this._pageModel.LocationStatus = value;
				base.OnPropertyChanged("Settings");
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00009871 File Offset: 0x00007A71
		public SettingVM()
		{
			this._pageModel = new PageModel();
			this.Settings = true;
		}

		// Token: 0x0400002C RID: 44
		private readonly PageModel _pageModel;
	}
}
