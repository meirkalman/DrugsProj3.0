using BE;
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


        public StatisticsModel StatisticsM;
        

        public ObservableCollection<Recipe> Recipes { get; set; }

        
        public StatisticsVM()
        {
            StatisticsM = new StatisticsModel();

            Command = new StatisticsCommand(this);
            Recipes = new ObservableCollection<Recipe>(StatisticsM.GetAllRecipes());
        }
        
        public StatisticsCommand Command { get; set; }
        //  public DoctorCommand CommandAP { get; set; }

        
    }
}
