using BE;
using System;
using System.Collections.Generic;
using Document = MigraDoc.DocumentObjectModel.Document;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IBL
    {
        int ResolveRxcuiFromName(string name);
        string getPrescriptionID();

        //void createPDF(List<Recipe> r);

        void print(List<Recipe> r);

        List<Recipe> getPatientHistoryByDrug(DateTime first, DateTime second, string patientId = null, string drugID = null);
        List<Recipe> getPatientHistory(string patientId, bool now = false);
        // int getPrescriptionID();
        void AddPatient(Patient patient);

        void AddMedicine(Medicine medicine);
        List<string> GetAllUserId();
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
        List<string> GetAllMedicineId();
        List<string> GetMedicinesNamesFromRecipe(List<Recipe> prescriptionsGiven);
        List<string> GetAllMedicinesNames();
        Medicine GetMedicine(string id);
        string GetMedicineId(string medicineName);

        Recipe GetRecipe(string recipeId);


        User GetUser(string id);

        List<string> interactionDrugs(string drugName);
        Dictionary<DateTime, int> drugStatistics(string drugID, DateTime start, DateTime finish);

        //List<string> GetMedicineNamesOfPatient(string patientId);

        Document CreateDocument(List<Recipe> r);
    }
}

