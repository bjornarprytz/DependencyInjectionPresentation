using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DependencyInjectionPresentation.ViewModels
{
    public class CommandHandler : ICommand
    {
        private Action<object> _execute;
        private Predicate<object> _canExecute;

        public CommandHandler(Action execute, Predicate<object> canExecute = null)
        {
            _execute = (p) => execute();
            _canExecute = canExecute ?? new Predicate<object>((o) => true);
        }

        public CommandHandler(Action<object> execute, Predicate<object> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute ?? new Predicate<object>((o) => true);
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }

}
