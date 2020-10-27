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
            Bl.AddRecipe(new BE.Recipe("11", "312246605", "4444", "44", 44, 44,"ll",DateTime.Now));

            // //Bl.print(@"firstpage.pdf", "printttttttttttttttt");
            // Bl.createPDF(new BE.Recipe ("111", "222", "333" ,"444", 2,2,"gfsd", DateTime.Now));
            // Bl.AddMedicine(new BE.Medicine("8124",
            //"phenelzine",
            //"phenelzine",
            //"jf",
            //"gfd",
            //" "));

            //Bl.AddMedicine(new BE.Medicine("199487","moclobemide","moclobemide",
            //"jf",
            //"gfd",
            //" "));


            //Bl.AddMedicine(new BE.Medicine("37418",
            //"sumatriptan",
            //"sumatriptan",
            //"jf",
            //"gfd",
            //" "));


            //    string drugName = "rizatriptan";
            //    List<string> result = Bl.interactionDrugs(drugName);
            //    if (result != null)
            //    {
            //        MessageBox.Show(result[0].ToString());
            //    }

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
