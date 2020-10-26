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

namespace DrugsProject3._0.ViewModels
{
    class AddDoctorVisitVM : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;   
        public AddDoctorVisitModel AddDoctorVisitM { get; set; }
        public AddDoctorVisitCommand AddCommand { get; set; }
        public IControlManage IControlManage { get; set; }/////////////////////////////////////////////

        public Recipe Recipe { get; set; }
        public Patient Patient { get; set; }
        public User User { get; set; }
        public ObservableCollection<string> MedicinesNames { get; set; }

        public AddDoctorVisitVM(IControlManage controlManage)/////////////////////////////////////////////
        {
            IControlManage = controlManage;/////////////////////////////////////////////
            AddDoctorVisitM = new AddDoctorVisitModel();
            AddCommand = new AddDoctorVisitCommand(this);
            MedicinesNames = new ObservableCollection<string>(AddDoctorVisitM.GetAllMedicinesNames());
            Patient = IControlManage.Patient;
            User = IControlManage.User;
            PatientName = Patient.Fname + Patient.Lname;
        }

        public void Massage(List<string> res)
        {
            (App.Current as App).navigation.MainWindows.comments.Text = res.ToString();/////////////////////////////////////////////
        }

        public string RecipeId { get; set; }
        public string MedicineId { get; set; }
        private string doctorName;
        public string DoctorName
        {
            get { return doctorName; }
            set { doctorName = User.Fname + User.Lname; }
        }

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
        public List<string> CheckInteractionDrugs()
        {
            List<string> interactionDrugsList =  AddDoctorVisitM.interactionDrugs(MedicineSelected);
            List<string> DrugsList = AddDoctorVisitM.getPatientHistory(Patient.PatientId);
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
            public void AddRecipe()
        {
            MedicineId = AddDoctorVisitM.GetMedicineId(MedicineSelected);
            RecipeId = AddDoctorVisitM.AddRecipeId();///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            string PatientId = Patient.PatientId;
            string DoctorId = "888"; /*User.Id;*/
            Date = DateTime.Now;
            AddDoctorVisitM.AddRecipe(new Recipe(RecipeId, PatientId, DoctorId, MedicineId, PeriodOfUse, QuantityPerDay, Description, Date));
         
        }

        //private void MedicinesNames_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        //{
        //    if (e.Action == NotifyCollectionChangedAction.Add)
        //    {
        //        MedicinesNames.Add(e.NewItems[0] as string);
        //    }
        //}
    }
}





/////public string MedicineSelected { get; set; }



//Medicines.CollectionChanged += Medicines_CollectionChanged;
// eventAggreegator.GetEvent<PatientEvent>().Subscribe(EventSubscribe);

//private void EventSubscribe(Patient patient)
//{
//    this.patient = patient;
//    MessageBox.Show("dd");
//    MessageBox.Show(patient.Id.ToString());
//}
//public void tt()
//{
//    MessageBox.Show(patient.Id.ToString());

//}

//private void Medicines_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
//{
//    if (e.Action == NotifyCollectionChangedAction.Add)
//    {
//        MedicineV.Add(e.NewItems[0] as Medicine);
//    }
//}
//public void MedicineUC()
//{
//    //Medicine medicine;
//    //medicine = AddDoctorVisitM.GetMedicine(MedicineSelected);
//    //medicineList.Add(medicine);
//}

//patient = new Patient();
//this.eventAggreegator = eventAggreegator;
//  doctorVisit = new DoctorVisit(Id, DoctorName, Description,medicineList, Date);

// AddDoctorVisitM.AddDoctorVisitToPatient(doctorVisit,patient);