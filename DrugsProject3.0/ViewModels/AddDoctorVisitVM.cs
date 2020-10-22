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

        public Patient patient;
       
        private int id;
        public int Id
        {
            get { return id; }
            set
            {

                id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Id"));
            }
        }

        private string doctorName;
            public string DoctorName
        {
                get { return doctorName; }
                set
                {
                doctorName = null;
                doctorName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DoctorName"));
                }
            }

            private string description;
            public string Description
        {
                get { return description; }
                set
                {
                description = null;
                description = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
                }
            }

       // private ObservableCollection<Medicine> medicines;

        public ObservableCollection<string> MedicinesNames { get; set; }
       

        private DateTime date = DateTime.Now;
            public DateTime Date
        {
                get { return date; }
                set
                {
               
                date = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Date"));
                }
            }


        public AddDoctorVisitModel AddDoctorVisitM { get; set; }

        public IControlManage iControlManage;
      
     
       
           
            public AddDoctorVisitVM(IControlManage controlManage)
        {
            this.iControlManage = controlManage;
          
            AddDoctorVisitM = new AddDoctorVisitModel();
            AddCommand = new AddDoctorVisitCommand(this);


           
            MedicinesNames = new ObservableCollection<string>(GetAllMedicines());
         
         
            medicineList = new List<Medicine>();
            
        }

     

        public AddDoctorVisitCommand AddCommand { get; set; }



        public List<string> GetAllMedicines()
        {
            List<string> names = new List<string>();
            foreach (var item in AddDoctorVisitM.GetAllMedicines())
            {
                names.Add(item.CommercialName);
            }
            return names;
        }

        
            public void AddDoctorVisitToPatient()
            {
           
        
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
//public void AddMedicine()
//{
//    //Medicine medicine;
//    //medicine = AddDoctorVisitM.GetMedicine(MedicineSelected);
//    //medicineList.Add(medicine);
//}

//patient = new Patient();
//this.eventAggreegator = eventAggreegator;
//  doctorVisit = new DoctorVisit(Id, DoctorName, Description,medicineList, Date);

// AddDoctorVisitM.AddDoctorVisitToPatient(doctorVisit,patient);