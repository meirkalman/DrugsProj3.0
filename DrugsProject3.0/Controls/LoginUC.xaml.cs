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
            MessageBox.Show(DateTime.Now.ToString("MMMMM"));
            //Bl.AddRecipe(new BE.Recipe("123418", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-500)));
            //Bl.AddRecipe(new BE.Recipe("123517", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-2000)));
            //Bl.AddRecipe(new BE.Recipe("123616", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-1000)));
            //Bl.AddRecipe(new BE.Recipe("123415", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-500)));
            //Bl.AddRecipe(new BE.Recipe("123514", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-2000)));
            //Bl.AddRecipe(new BE.Recipe("1236134", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-1000)));
            //Bl.AddRecipe(new BE.Recipe("123412", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-10)));
            //Bl.AddRecipe(new BE.Recipe("12351", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-11)));
            //Bl.AddRecipe(new BE.Recipe("12362", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-12)));
            //Bl.AddRecipe(new BE.Recipe("12343", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-31)));
            //Bl.AddRecipe(new BE.Recipe("12354", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-32)));
            //Bl.AddRecipe(new BE.Recipe("12365", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-33)));
            //Bl.AddRecipe(new BE.Recipe("12346", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-66)));
            //Bl.AddRecipe(new BE.Recipe("12357", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-66)));
            //Bl.AddRecipe(new BE.Recipe("12368", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-66)));
            //Bl.AddRecipe(new BE.Recipe("12349", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-66)));
            //Bl.AddRecipe(new BE.Recipe("12350", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-66)));
            //Bl.AddRecipe(new BE.Recipe("123611", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-66)));
            //Bl.AddRecipe(new BE.Recipe("123422", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-100)));
            //Bl.AddRecipe(new BE.Recipe("123533", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-111)));
            //Bl.AddRecipe(new BE.Recipe("123644", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-1000)));

            //Bl.AddRecipe(new BE.Recipe("2123418", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-500)));
            //Bl.AddRecipe(new BE.Recipe("2123517", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-1200)));
            //Bl.AddRecipe(new BE.Recipe("2123616", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-1000)));
            //Bl.AddRecipe(new BE.Recipe("2123415", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-500)));
            //Bl.AddRecipe(new BE.Recipe("2123514", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-100)));
            //Bl.AddRecipe(new BE.Recipe("21236134", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-1000)));
            //Bl.AddRecipe(new BE.Recipe("2123412", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-150)));
            //Bl.AddRecipe(new BE.Recipe("212351", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-150)));
            //Bl.AddRecipe(new BE.Recipe("212362", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-150)));
            //Bl.AddRecipe(new BE.Recipe("212343", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-150)));
            //Bl.AddRecipe(new BE.Recipe("212354", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-150)));
            //Bl.AddRecipe(new BE.Recipe("212365", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-150)));
            //Bl.AddRecipe(new BE.Recipe("212346", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-250)));
            //Bl.AddRecipe(new BE.Recipe("212357", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-66)));
            //Bl.AddRecipe(new BE.Recipe("212368", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-250)));
            //Bl.AddRecipe(new BE.Recipe("212349", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-66)));
            //Bl.AddRecipe(new BE.Recipe("212350", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-66)));
            //Bl.AddRecipe(new BE.Recipe("2123611", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-250)));
            //Bl.AddRecipe(new BE.Recipe("2123422", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-100)));
            //Bl.AddRecipe(new BE.Recipe("2123533", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-111)));
            //Bl.AddRecipe(new BE.Recipe("2123644", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-250)));

            //Bl.AddRecipe(new BE.Recipe("3123418", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-500)));
            //Bl.AddRecipe(new BE.Recipe("3123517", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-250)));
            //Bl.AddRecipe(new BE.Recipe("3123616", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-1000)));
            //Bl.AddRecipe(new BE.Recipe("3123415", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-500)));
            //Bl.AddRecipe(new BE.Recipe("3123514", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-2000)));
            //Bl.AddRecipe(new BE.Recipe("31236134", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-1000)));
            //Bl.AddRecipe(new BE.Recipe("3123412", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-10)));
            //Bl.AddRecipe(new BE.Recipe("312351", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-11)));
            //Bl.AddRecipe(new BE.Recipe("312362", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-100)));
            //Bl.AddRecipe(new BE.Recipe("312343", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-31)));
            //Bl.AddRecipe(new BE.Recipe("312354", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-100)));
            //Bl.AddRecipe(new BE.Recipe("312365", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-33)));
            //Bl.AddRecipe(new BE.Recipe("312346", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-66)));
            //Bl.AddRecipe(new BE.Recipe("312357", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-66)));
            //Bl.AddRecipe(new BE.Recipe("312368", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-100)));
            //Bl.AddRecipe(new BE.Recipe("312349", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-66)));
            //Bl.AddRecipe(new BE.Recipe("312350", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-66)));
            //Bl.AddRecipe(new BE.Recipe("3123611", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-66)));
            //Bl.AddRecipe(new BE.Recipe("3123422", "phenelzine", "999999999", "222222222", "8123", 30, 2, "כאב בטן", DateTime.Now.AddDays(-100)));
            //Bl.AddRecipe(new BE.Recipe("3123533", "moclobemide", "888888888", "222222222", "199487", 40, 3, "כאב", DateTime.Now.AddDays(-111)));
            //Bl.AddRecipe(new BE.Recipe("3123644", "sumatriptan", "777777777", "222222222", "37418", 40, 3, "שלשול", DateTime.Now.AddDays(-1000)));

            //Bl.AddUser(new BE.User("1", "מאיר", "קלמן", "11111111", BE.User.UserType.מנהל,"dd", "1"));
           // Bl.AddUser(new BE.User("2", "יצחקי", "רביץ", "22222222", BE.User.UserType.רופא, "dd", "2"));
            //Bl.AddUser(new BE.User("333333333", "זאבי", "קמינסקי", "77", BE.User.UserType.רופא, "33333333"));
            //Bl.AddPatient(new BE.Patient("999999999", "משה", "כהן", "0527631366", DateTime.Now.AddDays(-100)));
            //Bl.AddPatient(new BE.Patient("888888888", "יוסף", "ברקוביץ", "0527631366", DateTime.Now.AddDays(-200)));
            //Bl.AddPatient(new BE.Patient("777777777", "הלל", "לוי", "0527631366", DateTime.Now.AddDays(-107)));
            Bl.AddMedicine(new BE.Medicine("8123", "phenelzine", "phenelzine", "טבע", "30", "gfjd"));
            Bl.AddMedicine(new BE.Medicine("199487", "moclobemide", "moclobemide", "טבע", "900", "ddd"));
            Bl.AddMedicine(new BE.Medicine("37418", "sumatriptan", "sumatriptan", "טבע", "87", "llll"));
        }
    }
}
