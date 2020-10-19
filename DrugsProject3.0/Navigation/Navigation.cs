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
        public void ShowControl()
        {
            wnd.ShowControl(userControl);
        }
    }
}
