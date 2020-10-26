using DrugsProject3._0.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                case "LoginUC":
                    uc = new LoginUC();
                    title="עמוד הבית";
                    break;
                case "HomePageUC":
                    uc = new HomePageUC();
                    title = "עמוד הבית";
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
                case "AddNewPatient":
                    uc = new AddNewPatient();
                    title = "הוספת מטופל חדש";
                    break;
                case "AddUserUC":
                    uc = new AddDoctorUC();
                    title = "הוספת משתמש חדש";
                    break;
                case "MedicineUC":
                    uc = new MedicineUC();
                    title = "הוספת משתמש חדש";
                    break;

            }
            


            MainWindows.ShowControl(uc, title);
        }

       
    }
}
