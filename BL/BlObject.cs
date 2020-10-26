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

    public class BlObject: IBL
    {
        public void createPDF(string content)
        {
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "My First PDF";
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            graph.DrawString(content, font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center);
            string pdfFilename = "firstpage.pdf";
            pdf.Save(pdfFilename);
            Process.Start(pdfFilename);

        }
        CheckInteraction CI = new CheckInteraction();
        public IDalService IDalService { get; set; }

        public List<string> getDrugsNames()
        {
            return CI.getDrugsNames();
        }
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
        public Medicine GetMedicine(string id)
        {
            return IDalService.GetMedicine(id);
        }

        public Patient GetPatient(string id)
        {
            return IDalService.GetPatient(id);
        }

        public Recipe GetRecipe(string recipeId)
        {
            return IDalService.GetRecipe(recipeId);
        }

        public User GetUser(string id)
        {
            return IDalService.GetUser(id);
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

        public string getPrescriptionID ()
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
            var ids = (from item in IDalService.GetAllPatients()
                           select item.PatientId).ToList();
            
            return ids;
        }


        public List<string> GetAllMedicineId()
        {
            var ids = (from item in IDalService.GetAllMedicines()
                         select item.Id).ToList();
            return ids;
        }

        public List<string> GetAllMedicinesNames()
        {
            var names = (from item in IDalService.GetAllMedicines()           
                         select item.CommercialName).ToList();
            return names; 
        }

        public string GetMedicineId(string medicineName)
        {
            Medicine medicine = new Medicine();

            medicine = (from item in GetAllMedicines()
                        where item.CommercialName == medicineName
                         select item).FirstOrDefault();
            return medicine.Id;
        }

        public Dictionary<string, string> getPatientHistory(Patient patient, bool now = false)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            var patientPrescriptions = from p in GetAllRecipes()
                                       where p.PatientId == patient.PatientId
                                       select p;

            if(now)
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

        public int ResolveRxcuiFromName(string name)
        {
            return CI.ResolveRxcuiFromName(name);
        }

        // The PrintPage event is raised for each page to be printed.
        //private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        //{
        //    float linesPerPage = 0;
        //    float yPos = 0;
        //    int count = 0;
        //    float leftMargin = ev.MarginBounds.Left;
        //    float topMargin = ev.MarginBounds.Top;
        //    String line = null;

        //    // Calculate the number of lines per page.
        //    linesPerPage = ev.MarginBounds.Height /
        //       ev.printFont.GetHeight(ev.Graphics);

        //    // Iterate over the file, printing each line.
        //    while (count < linesPerPage &&
        //       ((line = streamToPrint.ReadLine()) != null))
        //    {
        //        yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
        //        ev.Graphics.DrawString(line, printFont, Brushes.Black,
        //           leftMargin, yPos, new StringFormat());
        //        count++;
        //    }

        //    // If more lines exist, print another page.
        //    if (line != null)
        //        ev.HasMorePages = true;
        //    else
        //        ev.HasMorePages = false;
        //}
        //public void Printing(Stream filePath)
        //{
        //    try
        //    {

        //        StreamReader streamToPrint = new StreamReader(filePath);
        //        try
        //        {
        //            Font printFont = new Font("Arial", 10);
        //            PrintDocument pd = new PrintDocument();
        //            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
        //            // Print the document.
        //            pd.Print();
        //        }
        //        finally
        //        {
        //            streamToPrint.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}











//public void AddDoctorVisitToPatient(DoctorVisit doctorVisit, Patient patient)
//{
//    IDalService.AddDoctorVisitToPatient(doctorVisit, patient);
//}
