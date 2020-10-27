using BE;
using DrugsProject3._0.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.ViewModels
{
    class MedicinInformationVM
    {
        public MedicinInformationModel MedicinInformationM;


        public ObservableCollection<Medicine> Medicines { get; set; }


        public MedicinInformationVM()
        {
            try
            {
                MedicinInformationM = new MedicinInformationModel();
                Medicines = new ObservableCollection<Medicine>(MedicinInformationM.GetMedicins());
            }
            catch (Exception e)
            {
                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
        }
    }
}
