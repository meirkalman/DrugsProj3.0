using DrugsProject3._0.Commands;
using DrugsProject3._0.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.ViewModels
{
    public class StatisticsVM
    {


        public StatisticsModel StatisticsModel;
        

        public ObservableCollection<int> PatientsId { get; set; }

        
        public StatisticsVM()
        {
            StatisticsModel = new StatisticsModel();

            Command = new StatisticsCommand(this);
            
            
            
        }
        

        public StatisticsCommand Command { get; set; }
        //  public DoctorCommand CommandAP { get; set; }

        
    }
}
