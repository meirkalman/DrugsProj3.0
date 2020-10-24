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
        [Key]
        public int RecipeId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int MedicineId { get; set; }
        public int PeriodOfUse { get; set; }
        public int QuantityPerDay { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }



        public Recipe()
        {

        }
        public Recipe(int recipeId, int patientId, int doctorId, int medicineId, int periodOfUse, int quantityPerDay, string description, DateTime date)
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
