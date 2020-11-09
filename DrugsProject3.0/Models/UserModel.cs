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
    public class UserModel
    {
        public IBL Bl { get; set; }
        public UserModel()
        {
            Bl = new BlObject();
        }

        public void AddUser(User user)
        {
            try
            {
                Bl.AddUser(user);
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
                return Bl.GetAllUserId();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
            

        public User GetUser(string userSelected)
        {
                try
                {
                    return Bl.GetUser(userSelected);
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
                Bl.DeleteUser(user);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void SendMail(User user)
        {
            try
            {
                Mail mail = new Mail();
                string mailTo = user.MailAddress;
                string mailSubject = "משתמש חדש";
                string mailBody = "היי " + user.Fname + "," + "\n\n" + "ברוכים הבאים על הצטרפותך למערכת למניעת התנגשויות בתרופות." + "\n\n" + "מחכים לך בכיליון עיניים, צוות ההנהלה.";
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
