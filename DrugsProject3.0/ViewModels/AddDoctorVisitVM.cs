using BE;

using DrugsProject3._0.Commands;
using DrugsProject3._0.Models;
using DrugsProject3._0.Tools;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DrugsProject3._0.ViewModels
{
    class AddDoctorVisitVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public AddDoctorVisitModel AddDoctorVisitM { get; set; }
        public AddDoctorVisitCommand AddCommand { get; set; }
        public IControlManage IControlManage { get; set; }

        public Recipe Recipe { get; set; }
        public Patient Patient { get; set; }
        public User User { get; set; }
        public ObservableCollection<string> MedicinesNames { get; set; }
        public ObservableCollection<string> MedicationsAdded { get; set; }
        public List<Recipe> PrescriptionsGiven { get; set; }
        public List<string> PrescriptionsGivenNames { get; set; }
        public ObservableCollection<Recipe> Recipes { get; set; }
        public ObservableCollection<string> Type { get; set; }
        public AddDoctorVisitVM(IControlManage controlManage)
        {
            try
            {
                IControlManage = controlManage;
                AddDoctorVisitM = new AddDoctorVisitModel();
                AddCommand = new AddDoctorVisitCommand(this);
                MedicinesNames = new ObservableCollection<string>(AddDoctorVisitM.GetAllMedicinesNames());
                Patient = IControlManage.Patient;
                User = IControlManage.User;
                DoctorName = User.Fname + " " + User.Lname;
                PatientName = Patient.Fname + " " + Patient.Lname;
                Recipes = new ObservableCollection<Recipe>(AddDoctorVisitM.getPatientHistory(Patient.PatientId));
                Type = new ObservableCollection<string>(Enum.GetNames(typeof(ShowData)));
                MedicationsAdded = new ObservableCollection<string>();
                PrescriptionsGiven = new List<Recipe>();
            }
            catch (Exception e)
            {
                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
        }

        public string RecipeId { get; set; }
        public string MedicineId { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }

        public string MedicineSelected { get; set; }

        private int periodOfUse;
        public int PeriodOfUse
        {
            get { return periodOfUse; }
            set
            {
                periodOfUse = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PeriodOfUse"));
            }
        }

        private int quantityPerDay;
        public int QuantityPerDay
        {
            get { return quantityPerDay; }
            set
            {
                quantityPerDay = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuantityPerDay"));
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
            }
        }

        public DateTime Date { get; set; }
       
        private ShowData typeSelected;
        public ShowData TypeSelected
        {
            get { return typeSelected; }
            set
            {
                typeSelected = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TypeSelected"));
            }
        }
        public void AddRecipe()
        {
            try
            {
                if (Description == null || QuantityPerDay == 0 || PeriodOfUse == 0)
                {
                    throw new ArgumentException("אתה צריך למלא את כל השדות");
                }
                MedicineId = AddDoctorVisitM.GetMedicineId(MedicineSelected);
                RecipeId = AddDoctorVisitM.AddRecipeId();
                Recipe recipe = new Recipe(RecipeId, MedicineSelected, Patient.PatientId, User.Id, MedicineId, PeriodOfUse, QuantityPerDay, Description, DateTime.Now);
                AddDoctorVisitM.AddRecipe(recipe);
                (App.Current as App).navigation.MainWindows.comments.Text = "תרופה נוספה בהצלחה";
                PrescriptionsGiven.Add(recipe);
                MedicationsAdded.Add(recipe.MedicineName);         
            }
            catch (Exception e)
            {
                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
        }
        public List<string> CheckInteractionDrugs()
        {
            try
            {
                List<string> interactionDrugsList = AddDoctorVisitM.interactionDrugs(MedicineSelected);
                List<string> DrugsList = (from item in AddDoctorVisitM.getPatientHistory(Patient.PatientId, true)
                                          select item.MedicineId).ToList();

                //  List<string> DrugsList = AddDoctorVisitM.getPatientHistory(Patient.PatientId, true);
                List<string> res = new List<string>();
                foreach (string item in DrugsList)
                {
                    foreach (string item2 in interactionDrugsList)
                    {
                        if (item == item2)
                        {
                            res.Add(item);
                        }
                    }
                }
                return res;
            }
            catch (Exception e)
            {
                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
            return null;
        }
        public void DeleteRecipe()
        {
            try
            {
                if (PrescriptionsGiven.Count() == 0)
                {
                    throw new ArgumentException("אין מרשם למחיקה");
                }
                Recipe recipe = PrescriptionsGiven.First();
                AddDoctorVisitM.DeleteRecipe(recipe);
                (App.Current as App).navigation.MainWindows.comments.Text = "תרופה הוסרה בהצלחה";
                PrescriptionsGiven.Remove(recipe);
                MedicationsAdded.Remove(recipe.MedicineName);
            }
            catch (Exception e)
            {
                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
        }
        public void Massage(List<string> res)
        {
            Medicine med = AddDoctorVisitM.GetMedicine(res[0]);
            (App.Current as App).navigation.MainWindows.comments.Text = "יש התנגשות עם " + med.CommercialName;
        }
        public void Print()
        {
            try
            {
                if (Description == null || QuantityPerDay == 0 || PeriodOfUse == 0)
                {
                    throw new ArgumentException("אתה צריך למלא את כל השדות");
                }
               // AddDoctorVisitM.Print(PrescriptionsGiven);
            }
            catch (Exception e)
            {
                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
        }
       
        public void creatPDF()
        {
            try
            {
                if (Description == null || QuantityPerDay == 0 || PeriodOfUse == 0)
                {
                    throw new ArgumentException("אתה צריך למלא את כל השדות");
                }
               // AddDoctorVisitM.creatPDF(PrescriptionsGiven);
            }
            catch (Exception e)
            {
                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
        }

        public enum ShowData { כל_המידע,מידע_עדכני }
        public void getPatientHistory()
        {
            try
            {
                if (TypeSelected == ShowData.מידע_עדכני)
                {
                    Recipes.Clear();
                    foreach (Recipe item in AddDoctorVisitM.getPatientHistory(Patient.PatientId, true))
                    {
                        Recipes.Add(item);
                    }
                }
                if (TypeSelected == ShowData.כל_המידע)
                {
                    Recipes.Clear();
                    foreach (Recipe item in AddDoctorVisitM.getPatientHistory(Patient.PatientId))
                    {
                        Recipes.Add(item);
                    }
                }  
            }
            catch (Exception e)
            {
                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
        }
    }
    
}

  