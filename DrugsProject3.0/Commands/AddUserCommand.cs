using DrugsProject3._0.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DrugsProject3._0.Commands
{
    public class AddUserCommand: ICommand
    {
    
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public AddUserVM CurrentVM { get; set; }
        public AddUserCommand(AddUserVM VM)
        {
            CurrentVM = VM;
        }

        public bool CanExecute(object parameter)
        {
           
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "AddUser")
            {
                CurrentVM.AddUser();
            }
            if (parameter.ToString() == "Return")
            {
                  (App.Current as App).navigation.ShowControls("AdministratorUC");
            }
        }
    }
}
//
