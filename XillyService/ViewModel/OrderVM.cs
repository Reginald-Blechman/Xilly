using System;
using Page_Navigation_App.Model;
using Page_Navigation_App.Utilities;

namespace Page_Navigation_App.ViewModel
{
	// Token: 0x0200000E RID: 14
	internal class OrderVM : ViewModelBase
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000097D8 File Offset: 0x000079D8
		// (set) Token: 0x06000057 RID: 87 RVA: 0x000097F5 File Offset: 0x000079F5
		public DateOnly DisplayOrderDate
		{
			get
			{
				return this._pageModel.OrderDate;
			}
			set
			{
				this._pageModel.OrderDate = value;
				base.OnPropertyChanged("DisplayOrderDate");
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00009811 File Offset: 0x00007A11
		public OrderVM()
		{
			this._pageModel = new PageModel();
			this.DisplayOrderDate = DateOnly.FromDateTime(DateTime.Now);
		}

		// Token: 0x0400002B RID: 43
		private readonly PageModel _pageModel;
	}
}
