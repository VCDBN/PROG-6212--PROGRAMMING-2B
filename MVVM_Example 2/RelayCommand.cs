using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Example
{
    public class RelayCommand : ICommand// Implements an interface.
                                        // This means the class is cable of performing actions specified by the Icommand interface
    {
        private Action _action;

        public RelayCommand(Action action)
        {
            _action = action;// this variable is declared to hold the action to be executed
        }

        public bool CanExecute(object parameter)
        {
            return true;// used to determine whether the command can execute of not
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _action();// invokes the action
        }
    }
}
