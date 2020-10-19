using BE;
using DrugsProject3._0.Models;
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

        public ObservableCollection<Patient> Patients
        {
            get { return Patients; }
            set { Patients = value; }
        }
        public DoctorVM()
        {
            DoctorM = new DoctorModel();
            Patients = new ObservableCollection<Patient>(DoctorM.GetAllPatients());
        }
       
    }
}






//private void Patients_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
//{
//    if (e.Action == NotifyCollectionChangedAction.Add)
//    {
//        MedicineV.Add(e.NewItems[0] as Medicine);
//    }
//}