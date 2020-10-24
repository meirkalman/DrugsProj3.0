using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BlObject: IBL
    {
        CheckInteraction CI = new CheckInteraction();
        public IDalService IDalService { get; set; }

        public BlObject()
        {
            IDalService = new DalService();
        }

        public List<string> interactionDrugs(string drugName)
        {
            return CI.interactionDrugs(drugName);
        }
        #region add
        public void AddMedicine(Medicine medicine)
        {
            IDalService.AddMedicine(medicine);
        }

        public void AddPatient(Patient patient)
        {
            IDalService.AddPatient(patient);
        }

        public void AddRecipe(Recipe recipe)
        {
            IDalService.AddRecipe(recipe);
        }

        public void AddUser(User user)
        {
            IDalService.AddUser(user);
        }
        #endregion add

        #region update
        public void UpdateMedicine(Medicine medicine)
        {
            IDalService.UpdateMedicine(medicine);
        }

        public void UpdatePatient(Patient patient)
        {
            IDalService.UpdatePatient(patient);
        }

        public void UpdateRecipe(Recipe recipe)
        {
            IDalService.UpdateRecipe(recipe);
        }

        public void UpdateUser(User user)
        {
            IDalService.UpdateUser(user);
        }
        #endregion update

        #region delete
        public void DeleteMedicine(Medicine medicine)
        {
            IDalService.DeleteMedicine(medicine);
        }

        public void DeletePatient(Patient patient)
        {
            IDalService.DeletePatient(patient);
        }

        public void DeleteRecipe(Recipe recipe)
        {
            IDalService.DeleteRecipe(recipe);
        }

        public void DeleteUser(User user)
        {
            IDalService.DeleteUser(user);
        }
        #endregion delete

        #region get all/some
        public List<Medicine> GetAllMedicines(Func<Medicine, bool> predicate = null)
        {
            return IDalService.GetAllMedicines();
        }

        public List<Patient> GetAllPatients(Func<Patient, bool> predicate = null)
        {
            return IDalService.GetAllPatients();
        }

        public List<Recipe> GetAllRecipes(Func<Recipe, bool> predicate = null)
        {
            return IDalService.GetAllRecipes();
        }

        public List<User> GetAllUsers(Func<User, bool> predicate = null)
        {
            return IDalService.GetAllUsers();
        }
        #endregion get all/some

        #region get 
        public Medicine GetMedicine(int id)
        {
            return IDalService.GetMedicine(id);
        }

        public Patient GetPatient(int id)
        {
            return IDalService.GetPatient(id);
        }

        public Recipe GetRecipe(int recipeId)
        {
            return IDalService.GetRecipe(recipeId);
        }

        public User GetUser(int id)
        {
            return IDalService.GetUser(id);
        }
        #endregion get 

        #region statistics

        public Dictionary<DateTime, int> drugStatistics(int drugID, DateTime start, DateTime finish)
        {
            Dictionary<DateTime, int> result = new Dictionary<DateTime, int>();
            var prescriptionsOnTheAppropriateDate = (from item in IDalService.GetAllRecipes()
                                                     where (drugID == item.MedicineId && start >= item.Date && finish <= item.Date)
                                                     group item by item.Date).ToList();
            var prescriptions = prescriptionsOnTheAppropriateDate.OrderBy(g => g.Key);
            foreach (var g in prescriptions)
            {
                result.Add(g.Key, g.Count());
            }
            return result;

        }
        #endregion

        public int getPrescriptionID ()
        {
            int result;
            Random rnd = new Random();
            result = rnd.Next(100000000, 999999999);
            
            bool flag = false;
            while(!flag)
            {
                flag = true;
                result = rnd.Next(100000000, 999999999);
                foreach (var item in GetAllRecipes())
                {
                    if (result == item.RecipeId)
                    {
                        flag = false;
                        break;
                    }
                        
                    
                }
            }

            return result;
        }
        public List<string> GetAllMedicinesNames()
        {
            var names = (from item in IDalService.GetAllMedicines()           
                         select item.CommercialName).ToList();
            return names; 
        }

        public int GetMedicineId(string medicineName)
        {
            Medicine medicine = new Medicine();

            medicine = (from item in GetAllMedicines()
                        where item.CommercialName == medicineName
                         select item).FirstOrDefault();
            return medicine.Id;
        }
    }
}











//public void AddDoctorVisitToPatient(DoctorVisit doctorVisit, Patient patient)
//{
//    IDalService.AddDoctorVisitToPatient(doctorVisit, patient);
//}
