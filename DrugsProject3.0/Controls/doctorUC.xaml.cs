using DrugsProject3._0.ViewModels;
using Prism.Events;
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
         private IEventAggregator eventAggregator;
        public doctorUC()
        {

            InitializeComponent();
            DoctorVM VM = new DoctorVM(eventAggregator);
            DataContext = VM;

        }
      
    }
}
