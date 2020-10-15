using DrugsProject3._0.Controls;
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

namespace DrugsProject3._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           

        }


    UserControl Uc = new doctorUC();

        public void ShowControl(UserControl uc)
        {
            MainWindowGrid.Children.Clear();
            MainWindowGrid.Children.Add(uc);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowControl(Uc);
        }
    }
}
