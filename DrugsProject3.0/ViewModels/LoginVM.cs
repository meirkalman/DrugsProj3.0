using BE;
using DrugsProject3._0.Commands;
using DrugsProject3._0.Models;
using DrugsProject3._0.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.ViewModels
{
    class LoginVM : INotifyPropertyChanged
    {
        
            public event PropertyChangedEventHandler PropertyChanged;
            public User User { get; set; }
        
            public LoginCommand Command { get; set; }

            public LoginModel LoginM { get; set; }
            public IControlManage IControlManage { get; set; }
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

        public string Password { get; set; }

        public LoginVM(IControlManage controlManage)
        {
            IControlManage = controlManage;
            LoginM = new LoginModel();
            Command = new LoginCommand(this);
        }

        internal void Login(string password)
        {
            try
            {
               
                if (Id == null || password == "")
                {
                    throw new ArgumentException("אתה צריך למלא את כל השדות");
                }
                else
                {
                    Password = password;

                    User = LoginM.GetUser(Id);
                    if (Password == User.Password && User.Type.ToString() == "מנהל")
                    {
                        IControlManage.User = User;
                        (App.Current as App).navigation.ShowControls("AdministratorUC");
                    }
                    else if (Password == User.Password && User.Type.ToString() == "רופא")
                    {
                        IControlManage.User = User;
                        (App.Current as App).navigation.ShowControls("DoctorUC");
                    }
                    else
                    {
                        throw new ArgumentException("סיסמה לא נכונה");
                    }
                }
            }
            catch (Exception e)
            {

                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }

        }
    }
}
