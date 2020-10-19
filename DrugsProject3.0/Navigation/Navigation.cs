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
        public MainWindow wnd = new MainWindow();
        UserControl uc = new UserControl();

        public void ShowControl(UserControl uc)
        {
            wnd.MainWindowGrid.Children.Clear();
            wnd.MainWindowGrid.Children.Add(uc);
        }

          
        public void ShowControl(string UserControl)
        {
            switch (UserControl)
            {
                case "LoginUC":
                    uc = new LoginUC();
                    ShowControl(uc);
                    break;
                case "HomePage":
                    uc = new HomePage();
                    ShowControl(uc);
                    break;
                case "DoctorVisitUC":
                    uc = new DoctorVisitUC();
                    ShowControl(uc);
                    break;
                case "doctorUC":
                    uc = new doctorUC();
                    ShowControl(uc);
                    break;
                case "AdministratorUC":
                    uc = new AdministratorUC();
                    ShowControl(uc);
                    break;
                case "AddNewPatient":
                    uc = new AddNewPatient();
                    ShowControl(uc);
                    break;
               
            }
           
        }
    }
}
