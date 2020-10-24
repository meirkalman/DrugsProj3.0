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
    class DoctorCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public DoctorVM CurrentVM { get; set; }
        public DoctorCommand(DoctorVM VM)
        {
            CurrentVM = VM;
        }
       

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "OpenDoctorVisit")
            {
                CurrentVM.CManage();
                (App.Current as App).navigation.ShowControls("DoctorVisitUC");
            }
            if (parameter.ToString() == "AddNewPatient")
            {
      
                (App.Current as App).navigation.ShowControls("AddNewPatient");
            }

        }
    }
}
