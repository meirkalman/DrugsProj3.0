using BE;
using DrugsProject3._0.Commands;
using DrugsProject3._0.Models;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ObservableCollection<int> PatientsId { get; set; }








        private IEventAggregator eventAggreegator;
        public DoctorVM(EventAggregator eventAggreegator)
        {
            DoctorM = new DoctorModel();
            this.eventAggreegator = eventAggreegator;
            eventAggreegator.GetEvent<EventAggreegator> ().Publish();




            AddDvCommand = new DoctorCommand(this);
            PatientsId = new ObservableCollection<int>(from item in DoctorM.GetAllPatients() select item.Id);

        }
        






        public DoctorCommand AddDvCommand { get; set; }
    }
}






//private void Patients_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
//{
//    if (e.Action == NotifyCollectionChangedAction.Add)
//    {
//        MedicineV.Add(e.NewItems[0] as Medicine);
//    }
//}