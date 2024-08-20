using System;
using Page_Navigation_App.Model;
using Page_Navigation_App.Utilities;

namespace Page_Navigation_App.ViewModel
{
	// Token: 0x0200000A RID: 10
	internal class CustomerVM : ViewModelBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000958C File Offset: 0x0000778C
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000095A9 File Offset: 0x000077A9
		public int CustomerID
		{
			get
			{
				return this._pageModel.CustomerCount;
			}
			set
			{
				this._pageModel.CustomerCount = value;
				base.OnPropertyChanged("CustomerID");
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000095C5 File Offset: 0x000077C5
		public CustomerVM()
		{
			this._pageModel = new PageModel();
			this.CustomerID = 100528;
		}

		// Token: 0x04000021 RID: 33
		private readonly PageModel _pageModel;
	}
}
