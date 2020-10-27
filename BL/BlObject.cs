using BE;
using DAL;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
//using PdfSharp.Drawing;
//using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BL
{

    public class BlObject : IBL
    {
        public IDalService IDalService { get; set; }
        public CheckInteraction CI { get; set; }
        public BlObject()
        {
            IDalService = new DalService();
            CI = new CheckInteraction();
        }
        public void createPDF(Recipe recipe)
        {
            try
            {
                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Prescription";

                PdfPage pdfPage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
                Medicine medicine = GetMedicine(recipe.MedicineId);
                Patient patient = GetPatient(recipe.PatientId);
                graph.DrawString("recipe number: " + recipe.RecipeId +
                    "/n patient ID: " + recipe.PatientId +
                    "/n " + patient.Fname + " " + patient.Lname +
                    " need to take " + medicine.CommercialName +
                    " " + recipe.PeriodOfUse + " " + recipe.QuantityPerDay,
                    font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center);
                string pdfFilename = "prescription.pdf";
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
            }
            catch (Exception)
            {

                throw new Exception("pdf cannot be create");
            }
            

        }
        
       

        public List<string> getDrugsNames()
        {
            return CI.getDrugsNames();
        }
        

        public List<string> interactionDrugs(string drugName)
        {
            return CI.interactionDrugs(drugName);
        }
        #region add
        public void AddMedicine(Medicine medicine)
        {
            try
            {
                IDalService.AddMedicine(medicine);
            }
            catch (Exception)
            {

                throw new Exception("כבר קיימת תרופה כזו");
            }
            
        }

        public void AddPatient(Patient patient)
        {
            try
            {
                IDalService.AddPatient(patient);
            }
            catch (Exception)
            {

                throw  new Exception("כבר קיים חולה כזה");
            }
            
        }

        public void AddRecipe(Recipe recipe)
        {
            try
            {
                IDalService.AddRecipe(recipe);
            }
            catch (Exception)
            {

                throw new Exception("כבר קיים מרשם כזה");
            }
            
        }

        public void AddUser(User user)
        {
            try
            {
                IDalService.AddUser(user);
            }
            catch (Exception)
            {

                throw new Exception("כבר קיים משתמש כזה");
            }
            
        }
        #endregion add

        #region update
        public void UpdateMedicine(Medicine medicine)
        {
            try
            {
                IDalService.UpdateMedicine(medicine);
            }
            catch (Exception)
            {

                throw new Exception("אין תרופה כזו במערכת");
            }
            
        }

        public void UpdatePatient(Patient patient)
        {
            try
            {
                IDalService.UpdatePatient(patient);
            }
            catch (Exception)
            {

                throw new Exception("אין חולה כזה במערכת");
            }
            
        }

        public void UpdateRecipe(Recipe recipe)
        {
            try
            {
                IDalService.UpdateRecipe(recipe);
            }
            catch (Exception)
            {

                throw new Exception("אין מרשם כזה במערכת");
            }
            
        }

        public void UpdateUser(User user)
        {
            try
            {
                IDalService.UpdateUser(user);
            }
            catch (Exception)
            {

                throw new Exception("אין משתמש כזה במערכת");
            }
            
        }
        #endregion update

        #region delete
        public void DeleteMedicine(Medicine medicine)
        {
            try
            {
                IDalService.DeleteMedicine(medicine);
            }
            catch (Exception)
            {

                throw new Exception("אין תרופה כזו במערכת");
            }
            
        }

        public void DeletePatient(Patient patient)
        {
            try
            {
                IDalService.DeletePatient(patient);
            }
            catch (Exception)
            {

                throw new Exception("אין חולה כזה במערכת");
            }
            
        }

        public void DeleteRecipe(Recipe recipe)
        {
            try
            {
                IDalService.DeleteRecipe(recipe);
            }
            catch (Exception)
            {

                throw new Exception("אין מרשם כזה במערכת");
            }
            
        }

        public void DeleteUser(User user)
        {
            try
            {
                IDalService.DeleteUser(user);
            }
            catch (Exception)
            {

                throw new Exception("אין משתמש כזה במערכת");
            }
            
        }
        #endregion delete

        #region get all/some
        public List<Medicine> GetAllMedicines(Func<Medicine, bool> predicate = null)
        {
            try
            {
                List<Medicine> res = IDalService.GetAllMedicines();
                if (res.Count == 0 || res == null)
                    throw new Exception("אין תרופות במערכת");
                return res;
            }
            catch (Exception)
            {

                throw new Exception("אין תרופות במערכת" );
            } 
            
        }

        public List<Patient> GetAllPatients(Func<Patient, bool> predicate = null)
        {
            try
            {
                List < Patient > res = IDalService.GetAllPatients();
                if(res.Count == 0 || res ==null)
                    throw new Exception("אין חולים במערכת");
                return res;
            }
            catch (Exception)
            {

                throw new Exception("אין חולים במערכת");
            }
            
        }

        public List<Recipe> GetAllRecipes(Func<Recipe, bool> predicate = null)
        {
            try
            {
                List < Recipe> res = IDalService.GetAllRecipes();
                if(res.Count== 0 || res == null)
                    throw new Exception("אין מרשמים במערכת");
                return res;
            }
            catch (Exception)
            {

                throw new Exception("אין מרשמים במערכת");
            }
            
        }

        public List<User> GetAllUsers(Func<User, bool> predicate = null)
        {
            try
            {
                List<User> res = IDalService.GetAllUsers();
                if (res.Count == 0 || res == null)
                    throw new Exception("אין משתמשים במערכת");
                return res;
            
            }
            catch (Exception)
            {

                throw new Exception("אין משתמשים במערכת");
            }
            
        }
        #endregion get all/some

        #region get 
        public Medicine GetMedicine(string id)
        {
            try
            {
                return IDalService.GetMedicine(id);
            }
            catch (Exception)
            {

                throw new Exception("אין כזו תרופה במערכת");
            }
            
        }

        public Patient GetPatient(string id)
        {
            try
            {
                return IDalService.GetPatient(id);
            }
            catch (Exception)
            {

                throw new Exception("אין כזה חולה במערכת");
            }
            
        }

        public Recipe GetRecipe(string recipeId)
        {
            try
            {
                return IDalService.GetRecipe(recipeId);
            }
            catch (Exception)
            {

                throw new Exception("אין כזה מרשם במערכת");
            }
            
        }

        public User GetUser(string id)
        {
            try
            {
                return IDalService.GetUser(id);
            }
            catch (Exception)
            {

                throw new Exception("אין כזה משתמש במערכת");
            }
            
        }
        #endregion get 


        #region statistics

        public Dictionary<DateTime, int> drugStatistics(string drugID, DateTime start, DateTime finish)
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

        public string getPrescriptionID()
        {
            int result;
            Random rnd = new Random();
            result = rnd.Next(100000000, 999999999);

            bool flag = false;
            while (!flag)
            {
                flag = true;
                result = rnd.Next(100000000, 999999999);
                foreach (var item in GetAllRecipes())
                {
                    if (result == int.Parse(item.RecipeId))
                    {
                        flag = false;
                        break;
                    }


                }
            }

            return result.ToString();
        }
        public List<string> GetAllPatientsId()
        {
            try
            {
                var ids = (from item in IDalService.GetAllPatients()
                           select item.PatientId).ToList();

                return ids;
            }
            catch (Exception)
            {

                throw new Exception("אין חולים במערכת");
            }
            
        }


        public List<string> GetAllMedicineId()
        {
            try
            {
                var ids = (from item in IDalService.GetAllMedicines()
                           select item.Id).ToList();
                return ids;
            }
            catch (Exception)
            {

                throw new Exception("אין תרופות במערכת");
            }
            
        }

        public List<string> GetAllMedicinesNames()
        {
            try
            {
                var names = (from item in IDalService.GetAllMedicines()
                             select item.CommercialName).ToList();
                return names;
            }
            catch (Exception)
            {

                throw new Exception("אין תרופות במערכת");
            }
            
        }

        public string GetMedicineId(string medicineName)
        {
            try
            {
                Medicine medicine = new Medicine();

                medicine = (from item in GetAllMedicines()
                            where item.CommercialName == medicineName
                            select item).FirstOrDefault();
                return medicine.Id;
            }
            catch (Exception)
            {

                throw new Exception("לא נמצאה התרופה");
            }
            
        }

        public Dictionary<string, string> getPatientHistory(Patient patient, bool now = false)
        {
            try
            {
                Dictionary<string, string> result = new Dictionary<string, string>();
                var patientPrescriptions = from p in GetAllRecipes()
                                           where p.PatientId == patient.PatientId
                                           select p;

                if (now)
                {
                    var drugsRightOfToday = from p in patientPrescriptions
                                            where p.Date.AddDays(p.PeriodOfUse) > DateTime.Now
                                            select p;
                    foreach (var d in drugsRightOfToday)
                    {
                        Medicine medicine = GetMedicine(d.MedicineId);
                        result.Add(medicine.GenericName, d.Description);
                    }
                }
                else
                {
                    foreach (var p in patientPrescriptions)
                    {
                        Medicine medicine = GetMedicine(p.MedicineId);
                        result.Add(medicine.GenericName, p.Description);
                    }
                }


                return result;
            }
            catch (Exception)
            {

                throw new Exception("לא נמצא חולה במערכת");
            }
            


        }

        public int ResolveRxcuiFromName(string name)
        {
            try
            {
                return CI.ResolveRxcuiFromName(name);
            }
            catch (Exception)
            {

                throw new Exception(" אין כזו תרופה");
            }
            
        }


        public List<string> GetAllUserId()
        {
            try
            {
                var res = (from item in GetAllUsers()
                           select item.Id).ToList();
                return res;
            }
            catch (Exception)
            {

                throw new Exception (" אין משתמשים");
            }
            
            
        }
        void print(string filePath, Recipe recipe)
        {

            createPDF(recipe);
            Printing p = new Printing(filePath);
        }

        //public List<string> GetMedicineNamesOfPatient(string patientId)
        //{
        //    List<Recipe> recipes = IDalService.GetAllRecipes(x => x.PatientId == patientId).ToList();
        //    var ids = (from item in recipes select item.MedicineId).ToList();
        //    return ids;
        //}
    }
}











//public void AddDoctorVisitToPatient(DoctorVisit doctorVisit, Patient patient)
//{
//    IDalService.AddDoctorVisitToPatient(doctorVisit, patient);
//}
