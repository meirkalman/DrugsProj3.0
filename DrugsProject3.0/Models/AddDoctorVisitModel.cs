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

        public Medicine GetMedicine(string id)
        {
            return Bl.GetMedicine(id);
        }

        public string AddRecipeId()
        {
            return "4444";
        }

        public List<string> GetAllMedicinesNames()
        {
            return Bl.GetAllMedicinesNames();
        }

        public string GetMedicineId(string medicineName)
        {
            return Bl.GetMedicineId(medicineName);
        }

        public void AddRecipe(Recipe recipe)
        {
            Bl.AddRecipe(recipe);
        }
        public List<string> interactionDrugs(string drugName)
        {
           return Bl.interactionDrugs(drugName);
        }

        public List<string> getPatientHistory(string patientId)
        {
            return Bl.getPatientHistory(Bl.GetPatient(patientId),true).Keys.ToList();
        }
    }
}
//public void AddMedicineToDoctorVisit(List<Medicine> medicines)
//{

//}
