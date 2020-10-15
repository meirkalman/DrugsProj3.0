using BE;
using DrugsProject3._0.Commands;
using DrugsProject3._0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.ViewModels
{
    class AddPatientVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public AddPatientCommand AddCommand { get; set; }
        public Patient PatientV { get; set; }
       
        public AddPatientModel AddPatientM { get; set; }

        public AddPatientVM()
        {
            AddPatientM = new AddPatientModel();
            AddCommand = new AddPatientCommand(this);
        }
        public void AddPatient()
        {
            AddPatientM.AddPatient(PatientV);
        }
    }
}
