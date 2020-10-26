using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
    class LoginModel
    {
        public IBL Bl { get; set; }
        public LoginModel()
        {
            Bl = new BlObject();
        }

        public User GetUser(string id)
        {
             return Bl.GetUser(id);
        }
    }
}
