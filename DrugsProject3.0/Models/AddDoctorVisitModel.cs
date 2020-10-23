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
      
        internal Medicine GetMedicine(int id)
        {
            return Bl.GetMedicine(id);
        }

        internal int AddRecipeId()
        {
            throw new NotImplementedException();
        }

        internal List<string> GetAllMedicinesNames()
        {
            return Bl.GetAllMedicinesNames();
        }
    }
}
//public void AddMedicineToDoctorVisit(List<Medicine> medicines)
//{

//}
