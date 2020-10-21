using BE;
using BE.EventAggregate;
using DrugsProject3._0.Commands;
using DrugsProject3._0.Models;
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

        public DoctorVisit doctorVisit;
        public Patient patient;
        public List< Medicine> medicineList;

        public string MedicineSelected { get; set; }

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

       // private IEventAggregator eventAggreegator;
        public AddDoctorVisitVM(/*IEventAggregator eventAggreegator*/)
        {
            //patient = new Patient();
            //this.eventAggreegator = eventAggreegator;
            AddDoctorVisitM = new AddDoctorVisitModel();
            AddCommand = new AddDoctorVisitCommand(this);


            // eventAggreegator.GetEvent<PatientEvent>().Subscribe(EventSubscribe);
            MedicinesNames = new ObservableCollection<string>(GetAllMedicines());
         
            //Medicines.CollectionChanged += Medicines_CollectionChanged;
            medicineList = new List<Medicine>();
            
        }

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
        public void AddMedicine()
        {
            Medicine medicine;
            medicine = AddDoctorVisitM.GetMedicine(MedicineSelected);
            medicineList.Add(medicine);
        }
        
            public void AddDoctorVisitToPatient()
            {
           
            doctorVisit = new DoctorVisit(Id, DoctorName, Description,medicineList, Date);

            AddDoctorVisitM.AddDoctorVisitToPatient(doctorVisit,patient);
            }


        }
    }

