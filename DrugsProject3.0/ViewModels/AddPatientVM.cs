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

        private string fname;
        public string Fname
        {
            get { return fname; }
            set
            {
                fname = null;
                fname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fname"));
            }
        }

        private string lname;
        public string Lname
        {
            get { return lname; }
            set
            {
                lname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lname"));
            }
        }
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Id"));
            }
        }
        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                dateOfBirth = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DateOfBirth"));
            }
        }

        public Patient PatientV = new Patient(id, fname, lname, DateOfBirth); 

        public AddPatientCommand AddCommand { get; set; }
       

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
