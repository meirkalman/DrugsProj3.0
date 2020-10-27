using BE;
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


        public UserInformationVM()
        {
            UserInformationM = new UserInformationModel();


            Users = new ObservableCollection<User>(UserInformationM.GetUsers());
        }

    }
}
