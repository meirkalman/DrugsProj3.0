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
            //Bl.AddRecipe(new BE.Recipe("11", "312246605", "4444", "44", 44, 44,"ll",DateTime.Now));
            //Bl.AddRecipe(new BE.Recipe("22", "5555", "555", "55", 88, 88, "88", DateTime.Now.AddDays(-10)));
            //Bl.AddRecipe(new BE.Recipe("33", "3333", "333", "333", 33, 33, "33", DateTime.Now.AddDays(-20)));
            //Bl.AddUser(new BE.User("11", "hh", "hh", "44", BE.User.UserType.ADMIN, "kk"));
            //Bl.AddUser(new BE.User("74", "yy", "yy", "78", BE.User.UserType.ADMIN, "55"));
            //Bl.AddUser(new BE.User("478", "kk", "kkk", "77", BE.User.UserType.DOCTOR, "66"));
            //Bl.AddPatient(new BE.Patient("44444", "oo", "oo", "47888", DateTime.Now.AddDays(-100)));
            //Bl.AddPatient(new BE.Patient("888888", "ll", "lll", "7777777", DateTime.Now.AddDays(-200)));
            //Bl.AddPatient(new BE.Patient("7777777", "gg", "gg", "6656", DateTime.Now.AddDays(-107)));
            //Bl.AddMedicine(new BE.Medicine("8124", "phenelzine", "phenelzine", "jf", "gfd", "gfjd"));
            //Bl.AddMedicine(new BE.Medicine("199487", "moclobemide", "moclobemide", "dd", "dd", "ddd"));
            //Bl.AddMedicine(new BE.Medicine("37418", "sumatriptan", "sumatriptan", "lll", "lll", "llll"));
           
                string drugName = "rizatriptan";
                List<string> result = Bl.interactionDrugs(drugName);
                if (result != null)
                {
                    MessageBox.Show(result[0].ToString());
                }

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
