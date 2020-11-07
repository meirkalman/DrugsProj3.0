using BL;
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
    /// Interaction logic for LoginUC.xaml
    /// </summary>
    public partial class LoginUC : UserControl
    {
        public IBL Bl { get; set; }
        public LoginUC()
        {
            LoginVM VM = new LoginVM((App.Current as App).controlManage);
            DataContext = VM;
            InitializeComponent();
            Bl = new BlObject();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          //  Bl.AddRecipe(new BE.Recipe("1234", "phenelzine", "999999999", "222222222", "8124", 30, 2, "כאב בטן", DateTime.Now.AddDays(-500)));
          //  Bl.AddRecipe(new BE.Recipe("1235", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-2000)));
          //  Bl.AddRecipe(new BE.Recipe("1236", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-1000)));
            Bl.AddUser(new BE.User("1", "מאיר", "קלמן", "11111111", BE.User.UserType.מנהל, "1"));
            Bl.AddUser(new BE.User("2", "יצחקי", "רביץ", "22222222", BE.User.UserType.רופא, "2"));
            Bl.AddUser(new BE.User("333333333", "זאבי", "קמינסקי", "77", BE.User.UserType.רופא, "33333333"));
            Bl.AddPatient(new BE.Patient("999999999", "משה", "כהן", "0527631366", DateTime.Now.AddDays(-100)));
            Bl.AddPatient(new BE.Patient("888888888", "יוסף", "ברקוביץ", "0527631366", DateTime.Now.AddDays(-200)));
            Bl.AddPatient(new BE.Patient("777777777", "הלל", "לוי", "0527631366", DateTime.Now.AddDays(-107)));
            Bl.AddMedicine(new BE.Medicine("8123", "phenelzine", "phenelzine", "טבע", "30", "gfjd"));
            Bl.AddMedicine(new BE.Medicine("199487", "moclobemide", "moclobemide", "טבע", "900", "ddd"));
            Bl.AddMedicine(new BE.Medicine("37418", "sumatriptan", "sumatriptan", "טבע", "87", "llll"));
        }
    }
}
