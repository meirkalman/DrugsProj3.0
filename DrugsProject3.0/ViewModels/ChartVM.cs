using BE;
using DrugsProject3._0.Commands;
using DrugsProject3._0.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.ViewModels
{
    public class ChartVM : INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;


        public ChartCommand Command { get; set; }

        public ChartModel ChartM { get; set; }

        public ObservableCollection<Recipe> RecipeChart { get; set; }

        public ChartVM()
        {
            Command = new ChartCommand(this);
            ChartM = new ChartModel();
            RecipeChart = new ObservableCollection<Recipe>(ChartM.GetStatistic());
        }

    }
}



//private string id;
//public string Id
//{
//    get { return id; }
//    set
//    {
//        id = value;
//        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Id"));
//    }
//}