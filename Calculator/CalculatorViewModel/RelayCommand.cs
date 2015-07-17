﻿using System;
using System.Diagnostics;
using System.Windows.Input;

namespace Calculator.CalculatorViewModel
{
    /// <summary>
    /// Simple WPF ICommand implementation
    /// </summary>
    public class RelayCommand : ICommand
    {
        private readonly Func<bool> _canExecute;
        private readonly Action<object> _execute;

        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        private RelayCommand(Action<object> execute, Func<bool> canExecute)
        {
            if (execute == null)
                throw new ArgumentNullException("execute");

            _execute = execute;
            _canExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}