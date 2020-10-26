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
using System.Windows;
using static BE.User;

namespace DrugsProject3._0.ViewModels
{

    public class AddUserVM : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;
        public User User { get; set; }

        public AddUserCommand Command { get; set; }

        public AddUserModel AddUserM { get; set; }

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
                    (App.Current as App).navigation.MainWindows.comments.Text = "";
                    id = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Id"));
                }

            }
        }

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
                    (App.Current as App).navigation.MainWindows.comments.Text = "";
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
                    (App.Current as App).navigation.MainWindows.comments.Text = "";
                    lname = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lname"));
                }
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

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (!new VerifyInput().IsValidPassword(value))
                {
                    (App.Current as App).navigation.MainWindows.comments.Text = "סיסמה צריכה להיות 8 ספרות";
                }
                else
                {
                    (App.Current as App).navigation.MainWindows.comments.Text = "";
                    password = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
                }
            }
        }
        public ObservableCollection<string> Type { get; set; }

        private String typeSelected;
        public String TypeSelected
        {
            get { return typeSelected; }
            set
            {
                typeSelected = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TypeSelected"));
            }
        }
        public ObservableCollection<string> UserIds { get; set; }

        public string UserSelected { get; set; }
        public AddUserVM()
        {
            AddUserM = new AddUserModel();
            Command = new AddUserCommand(this);
            Type = new ObservableCollection<string>(Enum.GetNames(typeof(UserType)));
            UserIds = new ObservableCollection<string>(AddUserM.GetAllUserId());
        }



        public void AddUser()
        {
            try
            {


                UserType userType = (UserType)Enum.Parse(typeof(UserType), TypeSelected);
                if (Id == null || Fname == null || Lname == null || PhoneNum == null || Password == null)
                {
                    throw new ArgumentException("אתה צריך למלא את כל השדות");
                }
                else
                {

                    User = new User(Id, Fname, Lname, PhoneNum, userType, Password);
                    AddUserM.AddUser(User);
                    (App.Current as App).navigation.MainWindows.comments.Text = "משתמש נוסף בהצלחה";
                }
            }
            catch (Exception e)
            {

                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }


        }

        public void DeleteUser()
        {
            //User = AddUserM.GetUser(UserSelected);
            //AddPatientM.DeletePatient(PatientV);
        }

    }

}







