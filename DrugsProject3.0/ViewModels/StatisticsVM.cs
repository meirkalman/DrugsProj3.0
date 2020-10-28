using BE;
using DrugsProject3._0.Commands;
using DrugsProject3._0.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.ViewModels
{
    public class StatisticsVM: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
   
        public StatisticsCommand Command { get; set; }
        public StatisticsModel StatisticsM;

        public string PatientSelected { get; set; }
        public string MedicineSelected { get; set; }

        private DateTime dateStart = DateTime.Now;
        public DateTime DateStart
        {
            get { return dateStart; }
            set
            {
                dateStart = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DateStart"));
            }
        }

        private DateTime dateFinish = DateTime.Now;
        public DateTime DateFinish
        {
            get { return dateFinish; }
            set
            {
                dateFinish = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DateFinish"));
            }
        }
        public ObservableCollection<Recipe> Recipes { get; set; }
        public ObservableCollection<string> Patients { get; set; }
        public ObservableCollection<string> Medicines { get; set; }

        public StatisticsVM()
        {
            try
            {
                StatisticsM = new StatisticsModel();
                Command = new StatisticsCommand(this);
                Recipes = new ObservableCollection<Recipe>(StatisticsM.GetAllRecipes());
                Patients = new ObservableCollection<string>(StatisticsM.GetAllPatientsId());
                Medicines = new ObservableCollection<string>(StatisticsM.GetAllMedicinesNames());
            }
            catch (Exception e)
            {
                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
        }

        public void getPatientHistoryByDrug()
        {
            try
            {
                Recipes.Clear();
                string medicineId = null;
                if (MedicineSelected != null)
                {
                     medicineId = StatisticsM.GetMedicineId(MedicineSelected);
                }
                foreach (var item in StatisticsM.getPatientHistoryByDrug( DateStart, DateFinish, PatientSelected, medicineId))
                {
                    Recipes.Add(item);
                }
            }
            catch (Exception e)
            {
                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
        }

    }
}
