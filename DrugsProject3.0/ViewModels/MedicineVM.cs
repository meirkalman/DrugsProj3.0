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
    class MedicineVM: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Medicine MedicineV;
        public MedicineCommand Command { get; set; }


        public MedicineModel MedicineM { get; set; }


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

        public string MedicineSelected { get; set; }
        public MedicineVM()
        {
            MedicineM = new MedicineModel();
           Command = new MedicineCommand(this);
            //PatientIds = new ObservableCollection<string>(AddPatientM.GetAllPatientsId());
                 
        }

        public void AddMedicine()
        {
            MedicineV = new Medicine(Id, Fname, Lname, PhoneNum, DateOfBirth);
            MedicineM.AddMedicine(MedicineV);
        }
        public void DeleteMedicine()
        {
            MedicineV = MedicineM.GetMedicine(PatientSelected);
            MedicineM.DeleteMedicine(MedicineV);
        }

    {
    }
}
