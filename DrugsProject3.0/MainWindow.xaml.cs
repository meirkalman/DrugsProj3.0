using BL;
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
        public IBL Bl { get; set; }
        
          
       
        public MainWindow()//
        {
            Bl = new BlObject();
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Bl.AddRecipe(new BE.Recipe("1234", "999999999", "222222222", "8124", 30, 2, "כאב בטן", DateTime.Now.AddDays(-3)));
            //Bl.AddRecipe(new BE.Recipe("1235", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-10)));
            //Bl.AddRecipe(new BE.Recipe("1236", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-20)));
            //Bl.AddUser(new BE.User("111111111", "מאיר", "קלמן", "11111111", BE.User.UserType.ADMIN, "11111111"));
            //Bl.AddUser(new BE.User("222222222", "יצחקי", "רביץ", "22222222", BE.User.UserType.DOCTOR, "22222222"));
            //Bl.AddUser(new BE.User("333333333", "זאבי", "קמינסקי", "77", BE.User.UserType.DOCTOR, "33333333"));
            //Bl.AddPatient(new BE.Patient("999999999", "משה", "כהן", "0527631366", DateTime.Now.AddDays(-100)));
            //Bl.AddPatient(new BE.Patient("888888888", "יוסף", "ברקוביץ", "0527631366", DateTime.Now.AddDays(-200)));
            //Bl.AddPatient(new BE.Patient("777777777", "הלל", "לוי", "0527631366", DateTime.Now.AddDays(-107)));
            //Bl.AddMedicine(new BE.Medicine("8124", "phenelzine", "phenelzine", "טבע", "30", "gfjd"));
            //Bl.AddMedicine(new BE.Medicine("199487", "moclobemide", "moclobemide", "טבע", "900", "ddd"));
            //Bl.AddMedicine(new BE.Medicine("37418", "sumatriptan", "sumatriptan", "טבע", "87", "llll"));
            Bl.print(new BE.Recipe("1234", "999999999", "222222222", "8124", 30, 2, "כאב בטן", DateTime.Now.AddDays(-3)));
            Bl.createPDF(new BE.Recipe("1234", "999999999", "222222222", "8124", 30, 2, "כאב בטן", DateTime.Now.AddDays(-3)));
            //string drugName = "rizatriptan";
            //List<string> result = Bl.interactionDrugs(drugName);
            //if (result != null)
            //{
            //    MessageBox.Show(result[0].ToString());
            //}

        }

        private void Button1(object sender, RoutedEventArgs e)
        {
            Bl.AddRecipe(new BE.Recipe("456985", "999999999", "222222222", "8124", 30, 2, "כאב בטן", new DateTime(7/8/2010)));
            Bl.AddRecipe(new BE.Recipe("23225566", "888888888", "222222222", "199487", 40, 3, "כאב", new DateTime(7/8/2009)));
            Bl.AddRecipe(new BE.Recipe("5623652", "777777777", "222222222", "37418", 40, 3, "שלשול", new DateTime(7/8/2001)));
        }
        //    //phenelzine
        //    moclobemide
        //    isocarboxazid
        //methylene blue
        //tranylcypromine
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
