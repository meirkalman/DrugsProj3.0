using BE;
using CareManagment.Tools;
using DrugsProject3._0.Commands;
using DrugsProject3._0.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.ViewModels
{
    class PatientVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Patient PatientV;
        public PatientCommand Command { get; set; }


        public PatientModel PatientM { get; set; }


        private string fname;
        public string Fname
        {
            get { return fname; }
            set
            {
                if (!new VerifyInput().IsValidName(value))
                {
                    (App.Current as App).navigation.MainWindows.comments.Text = "שם פרטי לא תקין";
                }
                else
                {
                    fname = null;
                    fname = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fname"));
                }
            }
        }

        private string lname;
        public string Lname
        {
            get { return lname; }
            set
            {
                if (!new VerifyInput().IsValidName(value))
                {
                    (App.Current as App).navigation.MainWindows.comments.Text = "שם משפחה לא תקין";
                }
                else
                {
                    lname = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lname"));
                }
            }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                if (!new VerifyInput().IsValidPersonId(value))
                {
                    (App.Current as App).navigation.MainWindows.comments.Text = "מספר id לא תקין ";
                }
                else
                {
                    id = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Id"));
                }
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
        private string phoneNum;
        public string PhoneNum
        {
            get { return phoneNum; }
            set
            {
                if (!new VerifyInput().IsValidPhoneNumber(value))
                {
                    (App.Current as App).navigation.MainWindows.comments.Text = "מספר טלפון לא תקין";
                }
                else
                {
                    phoneNum = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PhoneNum"));
                }
            }
        }
        public ObservableCollection<string> PatientIds { get; set; }

        public string PatientSelected { get; set; }
        public PatientVM()
        {
            PatientM = new PatientModel();
            Command = new PatientCommand(this);
            PatientIds = new ObservableCollection<string>(PatientM.GetAllPatientsId());
               
        }

        public void AddPatient()
        {
            if (Id == null || Fname == null || Lname == null || PhoneNum == null )
            {
                throw new ArgumentException("אתה צריך למלא את כל השדות");
            }
            else
            {
                PatientV = new Patient(Id, Fname, Lname, PhoneNum, DateOfBirth);
              //  PatientM.AddPatient(PatientV);
                PatientIds.Add(PatientV.PatientId);
                (App.Current as App).navigation.MainWindows.comments.Text = "המטופל נוסף בהצלחה";
            }
        }
        public void DeletePatient()
        {
            PatientV = PatientM.GetPatient(PatientSelected);
            PatientM.DeletePatient(PatientV);
            PatientIds.Remove(PatientV.PatientId);
        }

    }
}
