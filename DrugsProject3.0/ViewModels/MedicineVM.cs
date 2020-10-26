using BE;
using DrugsProject3._0.Commands;
using DrugsProject3._0.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.ViewModels
{
    class MedicineVM: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

       // public Medicine MedicineV;
        public MedicineCommand Command { get; set; }


        public MedicineModel MedicineM { get; set; }


        private string commercialName;
        public string CommercialName
        {
            get { return commercialName; }
            set
            {
               
                commercialName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CommercialName"));
            }
        }

        private string genericName;
        public string GenericName
        {
            get { return genericName; }
            set
            {
                genericName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GenericName"));
            }
        }

        private string producer;
        public string Producer
        {
            get { return producer; }
            set
            {
                producer = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Producer"));
            }
        }

        private string price;
        public string Price
        {
            get { return price; }
            set
            {
                price = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }
        
        public string ImageUri { get; set; }
        
       // public ObservableCollection<string> PatientIds { get; set; }

        public string MedicineSelected { get; set; }
        public MedicineVM()
        {
            MedicineM = new MedicineModel();
           Command = new MedicineCommand(this);
            //PatientIds = new ObservableCollection<string>(AddPatientM.GetAllPatientsId());
                 
        }

        public void AddMedicine()
        {
            string Id = MedicineM.ResolveRxcuiFromName(CommercialName).ToString();
            MedicineM.AddMedicine(new Medicine(Id, CommercialName, GenericName, Producer, Price,ImageUri)); 
        }
        public void DeleteMedicine()
        {
            //MedicineV = MedicineM.GetMedicine(PatientSelected);
           // MedicineM.DeleteMedicine(MedicineV);
        }
        public void AddImegeUri()
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //if (openFileDialog.ShowDialog() == true)
            //{
            //    ImageUri = openFileDialog.SafeFileName;
            //}
            ImageUri = "rr";
        }

    }
}


