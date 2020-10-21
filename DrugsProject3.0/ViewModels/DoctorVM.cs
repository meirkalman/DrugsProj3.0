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
using System.Windows.Controls;

namespace DrugsProject3._0.ViewModels
{
    class DoctorVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DoctorModel DoctorM;
        public int PatientSelected { get; set; }

        public ObservableCollection<int> PatientsId { get; set; }

        //private IEventAggregator eventAggreegator;
        public DoctorVM(/*IEventAggregator eventAggreegator*/)
        {
            DoctorM = new DoctorModel();
            //this.eventAggreegator = eventAggreegator;

            Command = new DoctorCommand(this);
           // CommandAP = new DoctorCommand(this);

           // CommandDV.Execute("OpenDoctorVisit");
           // CommandAP.Execute("OpenAddPatient");
            PatientsId = new ObservableCollection<int>(GetAllPatients());
            //PatientsId.CollectionChanged += PatientsId_CollectionChanged;
        }
        //public void EventMenage()
        //{
        //    Patient patient = DoctorM.GetPatient(PatientSelected);
        //    this.eventAggreegator.GetEvent<PatientEvent>().Publish(patient);
        //}

        public DoctorCommand Command { get; set; }
      //  public DoctorCommand CommandAP { get; set; }

        public List<int> GetAllPatients()
        {
            List<int> ids = new List<int>();
            foreach (var item in DoctorM.GetAllPatients())
            {
                ids.Add(item.Id);
            }
            return ids;
        }
    }
}

//public Patient Subscribe(Patient patient)
//{
//    return patient;
//}

//private void PatientsId_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
//{
//    if (e.Action == NotifyCollectionChangedAction.Add)
//    {
//        PatientV = e.NewItems[0] as Patient;
//    }
//}
//public void tt()
//{
//    MessageBox.Show(PatientSelected.ToString());

//}