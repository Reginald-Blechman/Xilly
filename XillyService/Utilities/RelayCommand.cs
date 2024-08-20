using System;
using System.Windows.Input;

namespace Page_Navigation_App.Utilities
{
	// Token: 0x02000011 RID: 17
	internal class RelayCommand : ICommand
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600005E RID: 94 RVA: 0x000098BE File Offset: 0x00007ABE
		// (remove) Token: 0x0600005F RID: 95 RVA: 0x000098C8 File Offset: 0x00007AC8
		public event EventHandler CanExecuteChanged
		{
			add
			{
				CommandManager.RequerySuggested += value;
			}
			remove
			{
				CommandManager.RequerySuggested -= value;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000098D2 File Offset: 0x00007AD2
		public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
		{
			this._execute = execute;
			this._canExecute = canExecute;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000098EA File Offset: 0x00007AEA
		public bool CanExecute(object parameter)
		{
			return this._canExecute == null || this._canExecute(parameter);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00009903 File Offset: 0x00007B03
		public void Execute(object parameter)
		{
			this._execute(parameter);
		}

		// Token: 0x0400002D RID: 45
		private readonly Action<object> _execute;

		// Token: 0x0400002E RID: 46
		private readonly Func<object, bool> _canExecute;
	}
}
