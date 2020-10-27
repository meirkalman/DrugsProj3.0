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
    class AdministratorInformationVM
    {
        public AdministratorInformationModel AdministratorInformationM;


        public ObservableCollection<User> Users { get; set; }


        public AdministratorInformationVM()
        {
            AdministratorInformationM = new AdministratorInformationModel();

           
            Users = new ObservableCollection<User>(AdministratorInformationM.GetUsers());
        }

     
    }
}
