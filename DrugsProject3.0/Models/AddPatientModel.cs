using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
    class AddPatientModel
    {
        public IBL Bl { get; set; }
        public AddPatientModel()
        {
            Bl = new BlObject();
        }

        public void AddPatient(Patient patient)
        {
            Bl.AddPatient(patient);
        }
    }
}
