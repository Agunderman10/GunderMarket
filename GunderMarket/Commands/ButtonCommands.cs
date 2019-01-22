using System;
using System.Windows;
using System.Windows.Input;

namespace GunderMarket
{
    internal sealed class ButtonCommands : ICommand
    {
        private Action _action;

        public ButtonCommands(Action action)
        {
            this._action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
        }

        public event EventHandler CanExecuteChanged;
    }
}
