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
        private Patient patientV { get; set; }
       
        public AddPatientModel addPatientModel { get; set; }

        public AddPatientVM()
        {
            AddCommand = new AddPatientCommand();
        }
        public void AddPatient()
        {
            addPatientModel.AddPatient(patientV);
        }
    }
}
