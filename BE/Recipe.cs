using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Recipe
    {
       
        public String RecipeId { get; set; }
        public String PatientId { get; set; }
        public String DoctorId { get; set; }
        public string MedicineId { get; set; }
        public int PeriodOfUse { get; set; }
        public int QuantityPerDay { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }



        public Recipe()
        {

        }
        public Recipe(string recipeId, string patientId, string doctorId, string medicineId, int periodOfUse, int quantityPerDay, string description, DateTime date)
        {
            RecipeId = recipeId;
            PatientId = patientId;
            DoctorId = doctorId;
            MedicineId = medicineId;
            PeriodOfUse = periodOfUse;
            QuantityPerDay = quantityPerDay;
            Description = description;
            Date = date;
        }
    }
}
