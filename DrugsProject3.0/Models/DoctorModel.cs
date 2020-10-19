using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
    class DoctorModel
    {
        public IBL Bl { get; set; }
        public DoctorModel()
        {
            Bl = new BlObject();
        }

        public List<Patient> GetAllPatients()
        {
            return Bl.GetAllPatients();
        }
        public Patient GetPatient(int id)
        {
            return Bl.GetPatient(id);
        }
    }
}
