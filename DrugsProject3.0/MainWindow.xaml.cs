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
        public MainWindow()//
        {
            InitializeComponent();
            (App.Current as App).navigation.MainWindows = this;
            MainVM VM = new MainVM();
            DataContext = VM;
        }

        public void ShowControl(UserControl uc,string t)
        {
            title.Text = t;
            InternalGrid.Children.Clear();
            InternalGrid.Children.Add(uc);
        }

        private void TreeViewItem_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    this.ShowControl(uc);
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    this.ShowControl(uc);Command="{Binding MainCommand}"
        //}
    }
}
