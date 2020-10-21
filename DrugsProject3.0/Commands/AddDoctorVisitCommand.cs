using DrugsProject3._0.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DrugsProject3._0.Commands
{
    class AddDoctorVisitCommand: ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public AddDoctorVisitVM CurrentVM { get; set; }

        public AddDoctorVisitCommand(AddDoctorVisitVM addVM)
        {
            CurrentVM = addVM;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {    
            if (parameter.ToString() == "AddMedicineToDV")
            {
                CurrentVM.AddMedicine();

            }
            if (parameter.ToString() == "DoctorUC")
            {
               
                (App.Current as App).navigation.ShowControls("DoctorUC");
            }   
        }
    }
}
