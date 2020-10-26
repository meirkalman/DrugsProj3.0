using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
    class PatientModel
    {
        public IBL Bl { get; set; }
        public PatientModel()
        {
            Bl = new BlObject();
        }

        public void AddPatient(Patient patient)
        {
            Bl.AddPatient(patient);
        }

        public List<string> GetAllPatientsId()
        {
            return Bl.GetAllPatientsId();
        }

        public Patient GetPatient(string patientId)
        {
            return Bl.GetPatient(patientId);
        }
        public void DeletePatient(Patient patient)
        {
             Bl.DeletePatient(patient);
        }
    }
}
