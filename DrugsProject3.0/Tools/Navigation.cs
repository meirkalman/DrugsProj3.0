using DrugsProject3._0.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DrugsProject3._0.Navigation
{
    public class NavigationClass
    {
        string title;
        
        public MainWindow MainWindows { get; set; }
        public void ShowControls(string UserControl)
        {
            UserControl uc = null;
            switch (UserControl)
            {
                case "MedicinInformationUC":
                    uc = new MedicinInformationUC();
                    title = "מידע על תרופות";
                    break;
                case "PatientInformationUC":
                    uc = new PatientInformationUC();
                    title = "מידע על חולים";
                    break;
                case "UserInformationUC":
                    uc = new UserInformationUC();
                    title = "מידע על רופאים";
                    break;
                case "LoginUC":
                    uc = new LoginUC();
                    title = "ברוך הבא";
                    break;
                case "DoctorVisitUC":
                    uc = new DoctorVisitUC();
                    title = "רופא";
                    break;
                case "DoctorUC":
                    uc = new DoctorUC();
                    title = "רופא";
                    break;
                case "AdministratorUC":
                    uc = new AdministratorUC();
                    title = "אדמיניסטרטור";
                    
                    break;
                case "PatientUC":
                    uc = new PatientUC();
                    title = "ניהול חולים";
                    break;
                case "AddUserUC":
                    uc = new UserUC();
                    title = "ניהול משתמשים ";
                    break;
                case "MedicineUC":
                    uc = new MedicineUC();
                    title = "ניהול תרופות";
                    break;
                case "StatisticsUC":
                    uc = new StatisticsUC();
                    title = "היסטורית צריכת תרופות";
                    break;
                case "ChartUC":
                    uc = new ChartUC();
                    title = "גרף נתונים";
                    break;
            }
             (App.Current as App).navigation.MainWindows.comments.Text = "";
            ShowControl(uc, title);
        }


        public void ShowControl(UserControl uc, string t)
        {
            if (t != "ברוך הבא")
            {
                string userName = (App.Current as App).controlManage.User.Fname + " " + (App.Current as App).controlManage.User.Lname;
                MainWindows.UserName.Text = userName;
            }
            else
            {
                MainWindows.UserName.Text = "";
            }
            MainWindows.title.Text = t;
            MainWindows.InternalGrid.Children.Clear();
            MainWindows.InternalGrid.Children.Add(uc);
        }
    }
}
