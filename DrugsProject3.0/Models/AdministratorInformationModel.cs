using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
    class AdministratorInformationModel
    {
        public IBL Bl { get; set; }
        public AdministratorInformationModel()
        {
            Bl = new BlObject();
        }
        

        public List<User> GetUsers()
        {
            try
            {
                return Bl.GetAllUsers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
 