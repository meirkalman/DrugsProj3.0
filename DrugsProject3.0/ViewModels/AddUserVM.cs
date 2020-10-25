using BE;
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
                id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Id"));
            }
        }

        private string fname;
        public string Fname
        {
            get { return fname; }
            set
            {
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

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public ObservableCollection<string> Type { get; set; }
        public UserType user { get; set; }
        //private UserType type;
        //public UserType Type
        //{
        //    get { return type; }
        //    set
        //    {
        //        type = value;
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Type"));
        //    }
        //}

        public AddUserVM()
        {
            AddUserM = new AddUserModel();
            Command = new AddUserCommand(this);
            Type = new ObservableCollection<string>(Enum.GetNames(typeof(UserType)));
            Type.CollectionChanged += Type_CollectionChanged;
        }

        private void Type_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                user = (UserType)Enum.Parse(typeof(UserType), e.NewItems[0] as string); 
            }
        }

        public void AddUser()
        {
            User = new User(Id,Fname,Lname,PhoneNum, user, Password);
            AddUserM.AddUser(User);
        }
   
    }
}







  //<ComboBoxItem>
  //                      רופא
  //                  </ComboBoxItem>
  //                  <ComboBoxItem>
  //                      אדמיניסטרטור
  //                  </ComboBoxItem>