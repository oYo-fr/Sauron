using Sauron.ViewModels;
using System;
using System.Windows.Input;

namespace Sauron.Commands
{
    public abstract class BaseCommand<T> : BaseViewModel, ICommand
        where T: BaseViewModel
    {
        protected T BaseViewModel;

        public BaseCommand(T baseViewModel)
        {
            BaseViewModel = baseViewModel;
        }

        public event EventHandler CanExecuteChanged;

        protected bool canExecute = false;

        public bool CanExecute(object parameter)
        {
            return canExecute;
        }

        public virtual void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
