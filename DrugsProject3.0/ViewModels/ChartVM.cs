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
        public ObservableCollection<KeyValuePair<string, int>> KeyValues { get; set; }
        public ChartCommand Command { get; set; }
        public ChartModel ChartM { get; set; }
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
            KeyValues = new ObservableCollection<KeyValuePair<string, int>>(ChartM.GetStatistic(DateStart, DateFinish));
        }

        public void getMedicineStatisticByDrug()
        {
            try
            {  
                KeyValues.Clear();
                string medicineId = null;
                if (MedicineSelected != null)
                {
                    medicineId = ChartM.GetMedicineId(MedicineSelected);
                }
                foreach (var item in ChartM.GetStatistic(DateStart, DateFinish, medicineId))
                {
                    KeyValues.Add(new KeyValuePair<string, int>(item.Key, item.Value));
                }
            }
            catch (Exception e)
            {
                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
        }
    }
}
