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
            
            PatientsId = new ObservableCollection<int>(GetAllPatients());
            
        }
        

        public StatistucsCommand Command { get; set; }
        //  public DoctorCommand CommandAP { get; set; }

        public List<int> GetAllPatients()
        {
            List<int> ids = new List<int>();
            foreach (var item in DoctorM.GetAllPatients())
            {
                ids.Add(item.Id);
            }
            return ids;
        }
    }
}
