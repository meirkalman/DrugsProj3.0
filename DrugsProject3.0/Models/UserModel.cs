using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
    public class UserModel
    {
        public IBL Bl { get; set; }
        public UserModel()
        {
            Bl = new BlObject();
        }

        public void AddUser(User user)
        {

            Bl.AddUser(user);
        }

        public List<string> GetAllUserId()
        {
            return Bl.GetAllUserId();
        }

        public User GetUser(string userSelected)
        {
            return Bl.GetUser(userSelected);
        }

        public void DeleteUser(User user)
        {
             Bl.DeleteUser(user);
        }
    }
}
