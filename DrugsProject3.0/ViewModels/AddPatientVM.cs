using BE;
using DrugsProject3._0.Commands;
using DrugsProject3._0.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.ViewModels
{
    class AddPatientVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Patient PatientV;
        public AddPatientCommand AddCommand { get; set; }


        public AddPatientModel AddPatientM { get; set; }


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
        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                
                id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Id"));
            }
        }
        private DateTime dateOfBirth = DateTime.Now;
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
              //  dateOfBirth = DateTime.Now;
                dateOfBirth = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DateOfBirth"));
            }
        }
        private int phoneNum;
        public int PhoneNum
        {
            get { return phoneNum; }
            set
            {
                phoneNum = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PhoneNum"));
            }
        }
        public ObservableCollection<string> PatientIds { get; set; }
        
        public AddPatientVM()
        {
            AddPatientM = new AddPatientModel();
            AddCommand = new AddPatientCommand(this);
            PatientIds = new ObservableCollection<string>(AddPatientM.GetAllPatientsId());
        }
        
        public void AddPatient()
        {
            PatientV = new Patient(Id, Fname, Lname, PhoneNum, DateOfBirth);
            AddPatientM.AddPatient(PatientV);
        }

        
    }
}
