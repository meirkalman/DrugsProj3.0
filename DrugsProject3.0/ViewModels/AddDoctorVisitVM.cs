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

        public DoctorVisit DoctorVisitV;
        public Patient patient;
        public List< Medicine> MedicineV;

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

        private ObservableCollection<Medicine> medicines;

        public ObservableCollection<Medicine> Medicines
        {
            get { return medicines; }
            set { medicines = value; }
        }

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
        public AddDoctorVisitVM(IEventAggregator eventAggreegator)
        {
            //patient = new Patient();
            //this.eventAggreegator = eventAggreegator;
            AddDoctorVisitM = new AddDoctorVisitModel();
            AddCommand = new AddDoctorVisitCommand(this);


            eventAggreegator.GetEvent<PatientEvent>().Subscribe(EventSubscribe);
           // Medicines = new ObservableCollection<Medicine>(AddDoctorVisitM.GetMedicineList(patient.Id));
            //Medicines.CollectionChanged += Medicines_CollectionChanged;
            MedicineV = new List<Medicine>();
            
        }

        private void EventSubscribe(Patient patient)
        {
            this.patient = patient;
            MessageBox.Show("dd");
            MessageBox.Show(patient.Id.ToString());
        }
        public void tt()
        {
            MessageBox.Show(patient.Id.ToString());

        }

        private void Medicines_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                MedicineV.Add(e.NewItems[0] as Medicine);
            }
        }

        public AddDoctorVisitCommand AddCommand { get; set; }


            

            public void AddDoctorVisitToPatient()
            {
           
            DoctorVisitV = new DoctorVisit(Id, DoctorName, Description,MedicineV, Date);
            AddDoctorVisitM.AddDoctorVisitToPatient(DoctorVisitV,patient);
            }


        }
    }

