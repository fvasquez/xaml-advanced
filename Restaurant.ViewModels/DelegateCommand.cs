using RestaurantManager.Models;
using System;
using System.Windows.Input;

namespace RestaurantManager.ViewModels
{
    public class DelegateCommand : ICommand
    {
        private readonly Action<MenuItem> _execute;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<MenuItem> execute)
        {
            this._execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MenuItem item = null;

            if (parameter != null)
            {
                item = (MenuItem)parameter;
            }

            this._execute(item);
        }
    }
}
