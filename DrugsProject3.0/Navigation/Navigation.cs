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
        
        public MainWindow MainWindows { get; set; }
        public void ShowControls(string UserControl)
        {
            UserControl uc = null;
            switch (UserControl)
            {
                case "LoginUC":
                    uc = new LoginUC();
                    break;
                case "HomePage":
                    uc = new HomePage();
                    break;
                case "DoctorVisitUC":
                    uc = new DoctorVisitUC();
                    break;
                case "doctorUC":
                    uc = new doctorUC();
                    break;
                case "AdministratorUC":
                    uc = new AdministratorUC();
                    break;
                case "AddNewPatient":
                    uc = new AddNewPatient();
                    break;

            }
            MainWindows.ShowControl(uc);
        }

       
    }
}
