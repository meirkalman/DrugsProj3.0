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

namespace DrugsProject3._0.ViewModels
{
    class DoctorVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DoctorModel DoctorM;
        public Patient PatientV;
        //public ObservableCollection<int> PatientsId { get; set; }

       // private IEventAggregator eventAggreegator;
        public DoctorVM(/*IEventAggregator eventAggreegator*/)
        {
            PatientV = new Patient();
            DoctorM = new DoctorModel();
            //this.eventAggreegator = eventAggreegator;
            
            AddDvCommand = new DoctorCommand(this);
           // PatientsId = new ObservableCollection<int>(from item in DoctorM.GetAllPatients() select item.Id);
          //  PatientsId.CollectionChanged += PatientsId_CollectionChanged;
        }

        //private void PatientsId_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        //{
        //    if (e.Action == NotifyCollectionChangedAction.Add)
        //    {
        //        PatientV = e.NewItems[0] as Patient;
        //    }
        //}

        //public void EventMenage()
        //{
        //    this.eventAggreegator.GetEvent<PatientEvent>().Subscribe(PatientV);
        //}
       
        public DoctorCommand AddDvCommand { get; set; }
    }
}

