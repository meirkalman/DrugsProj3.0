using BE;
using BE.EventAggregate;
using DrugsProject3._0.Commands;
using DrugsProject3._0.Models;
using DrugsProject3._0.Tools;
using Prism.Events;
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
        public IControlManage IControlManage { get; set; }
        public Recipe Recipe { get; set; }
        public Patient Patient { get; set; }
        public User User { get; set; }
        public ObservableCollection<string> MedicinesNames { get; set; }

        public AddDoctorVisitVM(IControlManage controlManage)
        {
            IControlManage = controlManage;
            AddDoctorVisitM = new AddDoctorVisitModel();
            AddCommand = new AddDoctorVisitCommand(this);
            MedicinesNames = new ObservableCollection<string>(AddDoctorVisitM.GetAllMedicinesNames());
            Patient = IControlManage.Patient;
            User = IControlManage.User;
        }
       
        public int RecipeId { get; set; }

        private string doctorName;
        public string DoctorName
        {
            get { return doctorName; }
            set { doctorName = User.Fname + User.Lname; }
        }

        private string patientName;
        public string PatientName
        {
            get { return patientName; }
            set { patientName = Patient.Fname + Patient.Lname; }
        }
     
        private string medicineName;
        public string MedicineName
        {
            get { return medicineName; }
            set
            {
                medicineName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("MedicineName"));
            }
        }

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

        public void AddRecipe()
        {
            RecipeId = AddDoctorVisitM.AddRecipeId();///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            int PatientId = Patient.Id;
            int DoctorId = User.Id;
            int MedicineId = AddDoctorVisitM.GetMedicineId(medicineName);
            AddDoctorVisitM.AddRecipe(new Recipe(RecipeId, PatientId, DoctorId, MedicineId, PeriodOfUse, QuantityPerDay, Description, Date));
        }
    }
}





//public string MedicineSelected { get; set; }



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
//public void AddMedicineUC()
//{
//    //Medicine medicine;
//    //medicine = AddDoctorVisitM.GetMedicine(MedicineSelected);
//    //medicineList.Add(medicine);
//}

//patient = new Patient();
//this.eventAggreegator = eventAggreegator;
//  doctorVisit = new DoctorVisit(Id, DoctorName, Description,medicineList, Date);

// AddDoctorVisitM.AddDoctorVisitToPatient(doctorVisit,patient);