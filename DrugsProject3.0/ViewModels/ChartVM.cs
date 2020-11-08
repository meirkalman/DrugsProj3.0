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

        public Dictionary<string, int> RecipeChart { get; set; }
        public ObservableCollection<DateTime> Dates { get; set; }
        public ObservableCollection<int> Counts { get; set; }
        public ObservableCollection<string> Medicines { get; set; }
        public string MedicineSelected { get; set; }

        private DateTime dateStart = DateTime.Now.AddDays(-500);
        public DateTime DateStart
        {
            get { return dateStart; }
            set
            {
                dateStart = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DateStart"));
            }
        }

        private DateTime dateFinish = DateTime.Now.AddDays(200);
        public DateTime DateFinish
        {
            get { return dateFinish; }
            set
            {
                dateFinish = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DateFinish"));
            }
        }
        public ChartVM()
        {
            Command = new ChartCommand(this);
            ChartM = new ChartModel();
            Medicines = new ObservableCollection<string>(ChartM.GetAllMedicinesNames());
            RecipeChart = new Dictionary<string, int>();
            Dates = new ObservableCollection<DateTime>();
            Counts = new ObservableCollection<int>();
        }

        public void getMedicineStatisticByDrug()
        {
            try
            {


                Dates.Clear();
                Counts.Clear();
                string medicineId = null;
                if (MedicineSelected != null)
                {
                    medicineId = ChartM.GetMedicineId(MedicineSelected);
                }
                RecipeChart = ChartM.GetStatistic(medicineId, DateStart, DateFinish);

               // Dates = new ObservableCollection<DateTime>(RecipeChart.Keys);// = RecipeChart.Keys;// = new ObservableCollection<DateTime>(RecipeChart.Keys);
               // Counts = new ObservableCollection<int>(RecipeChart.Values);// RecipeChart.Values;//= new ObservableCollection<int>(RecipeChart.Values);
             

            }
            catch (Exception e)
            {
                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
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