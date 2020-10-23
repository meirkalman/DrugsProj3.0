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

        public Medicine GetMedicine(int id)
        {
            return Bl.GetMedicine(id);
        }

        public int AddRecipeId()
        {
            return 4444;
        }

        public List<string> GetAllMedicinesNames()
        {
            return Bl.GetAllMedicinesNames();
        }

        public int GetMedicineId(string medicineName)
        {
            return Bl.GetMedicineId(medicineName);
        }

        internal void AddRecipe(Recipe recipe)
        {
            Bl.AddRecipe(recipe);
        }
    }
}
//public void AddMedicineToDoctorVisit(List<Medicine> medicines)
//{

//}
