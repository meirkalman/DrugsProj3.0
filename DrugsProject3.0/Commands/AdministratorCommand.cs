using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DrugsProject3._0.ViewModels;

namespace DrugsProject3._0.Commands
{
    public  class AdministratorCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public AdministratorVM CurrentVM { get; set; }
        public AdministratorCommand(AdministratorVM VM)
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
                (App.Current as App).navigation.ShowControls("AddUserUC");
            }
            if (parameter.ToString() == "AddNewPatient")
            {
                (App.Current as App).navigation.ShowControls("AddNewPatient");
            }
            if (parameter.ToString() == "AddMedicine")
            {
                (App.Current as App).navigation.ShowControls("MedicineUC");
            }
            if (parameter.ToString() == "Statistics")
            {
                (App.Current as App).navigation.ShowControls("StatisticsUC");
            }
        }
    
    }
}
