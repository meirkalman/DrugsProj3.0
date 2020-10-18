using DrugsProject3._0.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DrugsProject3._0.Controls
{
    /// <summary>
    /// Interaction logic for doctorUC.xaml
    /// </summary>
    public partial class doctorUC : UserControl
    {
        public doctorUC()
        {
            InitializeComponent();
            AddPatientVM VM = new AddPatientVM();
            DataContext = VM;
        }
        UserControl Uc = new AddNewPatient();
        public void ShowControl(UserControl uc)
        {
            DoctorGrid.Children.Clear();
            DoctorGrid.Children.Add(uc);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowControl(Uc);
        }
    }
}
