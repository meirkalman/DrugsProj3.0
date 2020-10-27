using BE;
using DrugsProject3._0.Commands;
using DrugsProject3._0.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.ViewModels
{
    class PatientInformationVM
    {
        public PatientInformationModel PatientInformationM;


        public ObservableCollection<Patient> Patients { get; set; }
        public PatientInformationCommand Command { get; set; }

        public PatientInformationVM()
        {
            try
            {
                Command = new PatientInformationCommand(this);
                PatientInformationM = new PatientInformationModel();
                Patients = new ObservableCollection<Patient>(PatientInformationM.GetPatients());
            }
            catch (Exception e)
            {
                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
        }
    }
}
