using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IBL
    {

        string getPrescriptionID();
        Dictionary<string, string> getPatientHistory(Patient patient, bool now = false);
       // int getPrescriptionID();
        void AddPatient(Patient patient);

        void AddMedicine(Medicine medicine);

        void AddRecipe(Recipe recipe);

        void AddUser(User user);


        void UpdatePatient(Patient patient);

        void UpdateMedicine(Medicine medicine);

        void UpdateRecipe(Recipe recipe);

        void UpdateUser(User user);



        void DeletePatient(Patient patient);

        void DeleteMedicine(Medicine medicine);

        void DeleteRecipe(Recipe recipe);
     

        void DeleteUser(User user);


        List<Patient> GetAllPatients(Func<Patient, bool> predicate = null);


        List<Medicine> GetAllMedicines(Func<Medicine, bool> predicate = null);


        List<Recipe> GetAllRecipes(Func<Recipe, bool> predicate = null);


        List<User> GetAllUsers(Func<User, bool> predicate = null);

        Patient GetPatient(string id);
        List<string> GetAllPatientsId();
        List<string> GetAllMedicinesNames();
        Medicine GetMedicine(string id);
        string GetMedicineId(string medicineName);

        Recipe GetRecipe(string recipeId);


        User GetUser(string id);

        List<string> interactionDrugs(string drugName);
        Dictionary<DateTime, int> drugStatistics(string drugID, DateTime start, DateTime finish);

    }
}

