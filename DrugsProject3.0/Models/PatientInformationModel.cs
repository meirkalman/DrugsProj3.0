using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
    class PatientInformationModel
    {
        public IBL Bl { get; set; }
        public PatientInformationModel()
        {
            Bl = new BlObject();
        }
        

        public List<Patient> GetPatients()
        {
            try
            {
                return Bl.GetAllPatients();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
 