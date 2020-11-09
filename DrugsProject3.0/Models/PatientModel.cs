using BE;
using BL;
using DrugsProject3._0.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
    class PatientModel
    {
        public IBL Bl { get; set; }
        
        public PatientModel()
        {
            Bl = new BlObject();
        }

        public void AddPatient(Patient patient)
        {
            try
            {
                Bl.AddPatient(patient);
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public List<string> GetAllPatientsId()
        {
            try
            {
                return Bl.GetAllPatientsId();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public Patient GetPatient(string patientId)
        {
            try
            {
                return Bl.GetPatient(patientId);
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
                Bl.DeletePatient(patient);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void SendMail(Patient patient)
        {
            try
            {
                Mail mail = new Mail();
                string mailTo = patient.MailAddress;
                string mailSubject = "משתמש חדש";
                string mailBody = "היי " + patient.Fname + "," + "\n\n" + "ברוכים הבאים על הצטרפותך למערכת למניעת התנגשויות בתרופות." + "\n\n" + "בברכת והסירותי מחלה מקרבך , צוות ההנהלה.";
                Thread thread = new Thread(() => mail.SendMail(mailTo, mailSubject, mailBody));
                thread.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
