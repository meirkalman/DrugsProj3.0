using DrugsProject3._0.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DrugsProject3._0.Commands
{
    class MedicineCommand: ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public MedicineVM CurrentVM { get; set; }

        public MedicineCommand(MedicineVM VM)
        {
            CurrentVM = VM;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter.ToString() == "AddImage")
            {
                CurrentVM.AddImegeUri();
            }
            if (parameter.ToString() == "AddMedicine")
            {
                CurrentVM.AddMedicine();
            }
            if (parameter.ToString() == "DeleteMedicine")
            {
                CurrentVM.DeleteMedicine();
            }
            if (parameter.ToString() == "Return")
            {
                (App.Current as App).navigation.ShowControls("AdministratorUC");
            }
        }

    }
}
