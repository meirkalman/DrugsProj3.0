using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
    public class AddUserModel
    {
        public IBL Bl { get; set; }
        public AddUserModel()
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

        internal User GetUser(string userSelected)
        {
            throw new NotImplementedException();
        }
    }
}
