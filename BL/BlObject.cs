using BE;
using DAL;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
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
                XPdfFontOptions options = new XPdfFontOptions(PdfFontEncoding.Unicode, PdfFontEmbedding.Always);
                PdfPage pdfPage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfPage);
                XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
                Medicine medicine = GetMedicine(recipe.MedicineId);
                Patient patient = GetPatient(recipe.PatientId);
                string texts = recipe.ToString();
                

                    PdfPage page = pdf.AddPage();

                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    XTextFormatter tf = new XTextFormatter(gfx);

                    tf.Alignment = XParagraphAlignment.Left;

                    tf.DrawString(texts, font, XBrushes.Black,
                    new XRect(100, 100, page.Width - 200, 600), XStringFormats.TopLeft);

                    string pdfFilename = recipe.RecipeId + ".pdf";
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
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void AddPatient(Patient patient)
        {
            try
            {
                IDalService.AddPatient(patient);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void AddRecipe(Recipe recipe)
        {
            try
            {
                IDalService.AddRecipe(recipe);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void AddUser(User user)
        {
            try
            {
                IDalService.AddUser(user);
            }
            catch (Exception ex)
            {

                throw ex;
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
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void UpdatePatient(Patient patient)
        {
            try
            {
                IDalService.UpdatePatient(patient);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void UpdateRecipe(Recipe recipe)
        {
            try
            {
                IDalService.UpdateRecipe(recipe);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void UpdateUser(User user)
        {
            try
            {
                IDalService.UpdateUser(user);
            }
            catch (Exception ex)
            {

                throw ex;
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
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void DeletePatient(Patient patient)
        {
            try
            {
                IDalService.DeletePatient(patient);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void DeleteRecipe(Recipe recipe)
        {
            try
            {
                IDalService.DeleteRecipe(recipe);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void DeleteUser(User user)
        {
            try
            {
                IDalService.DeleteUser(user);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion delete

        #region get all/some
        public List<Medicine> GetAllMedicines(Func<Medicine, bool> predicate = null)
        {
            try
            {
                List<Medicine> res = IDalService.GetAllMedicines();
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Patient> GetAllPatients(Func<Patient, bool> predicate = null)
        {
            try
            {
                List<Patient> res = IDalService.GetAllPatients();
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Recipe> GetAllRecipes(Func<Recipe, bool> predicate = null)
        {
            try
            {
                List<Recipe> res = IDalService.GetAllRecipes();
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<User> GetAllUsers(Func<User, bool> predicate = null)
        {
            try
            {
                List<User> res = IDalService.GetAllUsers();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
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
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Patient GetPatient(string id)
        {
            try
            {
                return IDalService.GetPatient(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public Recipe GetRecipe(string recipeId)
        {
            try
            {
                return IDalService.GetRecipe(recipeId);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public User GetUser(string id)
        {
            try
            {
                return IDalService.GetUser(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion get 


        #region statistics

        public Dictionary<DateTime, int> drugStatistics(string drugID, DateTime start, DateTime finish)
        {
            try
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
            catch (Exception e)
            {

                throw e;
            }


        }


        //public List<Recipe> drugStatistics(string drugID, DateTime start, DateTime finish)
        //{
        //    List<Recipe> result = new List<Recipe>();
        //    var prescriptionsOnTheAppropriateDate = (from item in IDalService.GetAllRecipes()
        //                                             where (drugID == item.MedicineId && start >= item.Date && finish <= item.Date)
        //                                             group item by item.Date).ToList();
        //    var prescriptions = prescriptionsOnTheAppropriateDate.OrderBy(g => g.Key);
        //    foreach (var g in prescriptions)
        //    {
        //        result.Add(g.Key, g.Count());
        //    }
        //    return result;

        //}
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
            catch (Exception ex)
            {

                throw ex;
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
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<string> GetMedicinesNamesFromRecipe(List<Recipe> prescriptionsGiven)
        {
            try
            {
                List<string> res = new List<string>();
                res = (from item in prescriptionsGiven
                       select item.MedicineName).ToList();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
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
            catch (Exception ex)
            {
                throw ex;
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
                if (medicine == null)
                {
                    throw new Exception("אין כזו תרופה");
                }
                return medicine.Id;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<Recipe> getPatientHistoryByDrug(DateTime first, DateTime second, string patientId = null, string drugID = null)
        {
            try
            {
                List<Recipe> result = new List<Recipe>();
                if (patientId != null && drugID != null)
                {
                    result = (from item in getPatientHistory(patientId)
                              where drugID == item.MedicineId && item.Date.Day <= second.Day && item.Date.AddDays(item.PeriodOfUse) > first
                              select item).ToList();
                }
                if (patientId != null && drugID == null)
                {
                    result = (from item in getPatientHistory(patientId)
                              where item.Date <= second && item.Date.AddDays(item.PeriodOfUse) > first
                              select item).ToList();
                }
                if (patientId == null && drugID != null)
                {
                    result = (from item in IDalService.GetAllRecipes()
                              where drugID == item.MedicineId && item.Date <= second && item.Date.AddDays(item.PeriodOfUse) > first
                              select item).ToList();
                }
                if (patientId == null && drugID == null)
                {
                    result = (from item in IDalService.GetAllRecipes()
                              where  item.Date <= second && item.Date.AddDays(item.PeriodOfUse) > first
                              select item).ToList();
                }
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<Recipe> getPatientHistory(string patientId, bool now = false)
        {
            try
            {
                var patientPrescriptions = (from p in GetAllRecipes()
                                           where p.PatientId == patientId
                                           select p).ToList();

                if (now)
                {
                    var drugsRightOfToday = (from p in patientPrescriptions
                                             where p.Date.AddDays(p.PeriodOfUse) > DateTime.Now
                                             select p).ToList();
                    return drugsRightOfToday;

                }
                else
                {
                    return patientPrescriptions.ToList();
                }

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
            catch (Exception ex)
            {

                throw ex;
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
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public void print(Recipe recipe)
        {

            createPDF(recipe);
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = recipe.RecipeId + ".pdf";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = new Process();
            p.StartInfo = info;
            p.Start();

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(3000);
            if (false == p.CloseMainWindow())
                 p.Kill();
            
        }

        
    }
}











