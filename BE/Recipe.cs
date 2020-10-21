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
        public string PatientId { get; set; }
        public string MedicineId { get; set; }
        public DateTime Date { get; set; }

        public Recipe()
        {

        }
        public Recipe(int recipeId, string patientId, string medicineId, DateTime date)
        {
            RecipeId = recipeId;
            PatientId = patientId;
            MedicineId = medicineId;
            Date = date;
        }           

}
