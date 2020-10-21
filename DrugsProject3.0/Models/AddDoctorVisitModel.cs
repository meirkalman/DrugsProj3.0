using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
    public class AddDoctorVisitModel
    {
        public IBL Bl { get; set; }
        public AddDoctorVisitModel()
        {
            Bl = new BlObject();
        }

       
        public void AddDoctorVisitToPatient(DoctorVisit doctorVisit, Patient patient)
        {
            Bl.AddDoctorVisitToPatient(doctorVisit,patient);
        }

        public List<Medicine> GetMedicineList(int id)
        {
           return Bl.GetPatient(id).Medicines;
        }
        public List<Medicine> GetAllMedicines()
        {
            return Bl.GetAllMedicines();
        }

        internal Medicine GetMedicine(string commercialName)
        {
            return Bl.GetMedicine(commercialName);
        }
    }
}
//public void AddMedicineToDoctorVisit(List<Medicine> medicines)
//{

//}