using System;
using Page_Navigation_App.Model;
using Page_Navigation_App.Utilities;

namespace Page_Navigation_App.ViewModel
{
	// Token: 0x0200000B RID: 11
	internal class ProductVM : ViewModelBase
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000095E8 File Offset: 0x000077E8
		// (set) Token: 0x0600003D RID: 61 RVA: 0x00009605 File Offset: 0x00007805
		public string ProductAvailability
		{
			get
			{
				return this._pageModel.ProductStatus;
			}
			set
			{
				this._pageModel.ProductStatus = value;
				base.OnPropertyChanged("ProductAvailability");
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00009621 File Offset: 0x00007821
		public ProductVM()
		{
			this._pageModel = new PageModel();
			this.ProductAvailability = "Out of Stock";
		}

		// Token: 0x04000022 RID: 34
		private readonly PageModel _pageModel;
	}
}
