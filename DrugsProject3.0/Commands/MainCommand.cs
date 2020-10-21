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
      
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public MainCommand()
        {
         
        }
        public MainCommand(MainVM VM)
        {
            this.CurrentVM = VM;
        }
        
        public void Execute(object parameter)
        {
            if (parameter.ToString() == "DoctorUC")
            {
                (App.Current as App).navigation.ShowControls("DoctorUC");
            }
            if (parameter.ToString() == "HomePageUC")
            {
                (App.Current as App).navigation.ShowControls("HomePageUC");
            }
          
        }
    }
}
