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
    class UserInformationVM
    {
        public UserInformationModel UserInformationM;


        public ObservableCollection<User> Users { get; set; }
        public UserInformationCommand Command { get; set; }
        

        public UserInformationVM()
        {
            Command = new UserInformationCommand(this);
            try
            {
                UserInformationM = new UserInformationModel();
                Users = new ObservableCollection<User>(UserInformationM.GetUsers());
            }
            catch (Exception e)
            {
                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
        }

    }
}
