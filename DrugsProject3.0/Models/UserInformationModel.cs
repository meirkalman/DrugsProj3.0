using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
    class UserInformationModel
    {
        public IBL Bl { get; set; }
        public UserInformationModel()
        {
            Bl = new BlObject();
        }


        public List<User> GetUsers()
        {
            return Bl.GetAllUsers();
        }
    }
}
