using DrugsProject3._0.Controls;
using DrugsProject3._0.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace DrugsProject3._0.Commands
{
    public class MainCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public MainVM CurrentVM { get; set; }
        public MainWindow mainWindow { get; set; }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public MainCommand()
        {
            mainWindow = new MainWindow();
        }
        public MainCommand(MainVM VM)
        {
            this.CurrentVM = VM;
        }
        UserControl UC = new doctorUC();
        public void Execute(object parameter)
        {
            mainWindow.ShowControl(UC);
        }
    }
}
