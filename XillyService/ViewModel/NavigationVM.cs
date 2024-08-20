using System;
using System.Windows.Input;
using Page_Navigation_App.Utilities;

namespace Page_Navigation_App.ViewModel
{
	// Token: 0x0200000D RID: 13
	internal class NavigationVM : ViewModelBase
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0000964C File Offset: 0x0000784C
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00009664 File Offset: 0x00007864
		public object CurrentView
		{
			get
			{
				return this._currentView;
			}
			set
			{
				this._currentView = value;
				base.OnPropertyChanged("CurrentView");
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0000967A File Offset: 0x0000787A
		// (set) Token: 0x06000043 RID: 67 RVA: 0x00009682 File Offset: 0x00007882
		public ICommand HomeCommand { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000968B File Offset: 0x0000788B
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00009693 File Offset: 0x00007893
		public ICommand CustomersCommand { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0000969C File Offset: 0x0000789C
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000096A4 File Offset: 0x000078A4
		public ICommand ProductsCommand { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000096AD File Offset: 0x000078AD
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000096B5 File Offset: 0x000078B5
		public ICommand OrdersCommand { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000096BE File Offset: 0x000078BE
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000096C6 File Offset: 0x000078C6
		public ICommand TransactionsCommand { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000096CF File Offset: 0x000078CF
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000096D7 File Offset: 0x000078D7
		public ICommand ShipmentsCommand { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000096E0 File Offset: 0x000078E0
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000096E8 File Offset: 0x000078E8
		public ICommand SettingsCommand { get; set; }

		// Token: 0x06000050 RID: 80 RVA: 0x000096F1 File Offset: 0x000078F1
		private void Home(object obj)
		{
			this.CurrentView = new HomeVM();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000096FF File Offset: 0x000078FF
		private void Customer(object obj)
		{
			this.CurrentView = new CustomerVM();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000970D File Offset: 0x0000790D
		private void Product(object obj)
		{
			this.CurrentView = new ProductVM();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000971B File Offset: 0x0000791B
		private void Order(object obj)
		{
			this.CurrentView = new OrderVM();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00009729 File Offset: 0x00007929
		private void Setting(object obj)
		{
			this.CurrentView = new SettingVM();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00009738 File Offset: 0x00007938
		public NavigationVM()
		{
			this.HomeCommand = new RelayCommand(new Action<object>(this.Home), null);
			this.CustomersCommand = new RelayCommand(new Action<object>(this.Customer), null);
			this.ProductsCommand = new RelayCommand(new Action<object>(this.Product), null);
			this.OrdersCommand = new RelayCommand(new Action<object>(this.Order), null);
			this.SettingsCommand = new RelayCommand(new Action<object>(this.Setting), null);
			this.CurrentView = new HomeVM();
		}

		// Token: 0x04000023 RID: 35
		private object _currentView;
	}
}
