using BE;
using CareManagment.Tools;
using DrugsProject3._0.Commands;
using DrugsProject3._0.Controls;
using DrugsProject3._0.Models;
using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace DrugsProject3._0.ViewModels
{
    class MedicineVM: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Medicine MedicineV;
        public MedicineCommand Command { get; set; }


        public MedicineModel MedicineM { get; set; }

        public string ImageUri { get; set; }
       
        
      

        private string commercialName;
        public string CommercialName
        {
            get { return commercialName; }
            set
            {
                if (!new VerifyInput().IsMedicineName(value))
                {
                    (App.Current as App).navigation.MainWindows.comments.Text = "שם לא תקין ";
                }
                else
                {
                    commercialName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CommercialName"));
                }
            }
        }

        private string genericName;
        public string GenericName
        {
            get { return genericName; }
            set
            {
                if(!new VerifyInput().IsMedicineName(value))
                {
                    (App.Current as App).navigation.MainWindows.comments.Text = "שם לא תקין ";
                }
                else
                {
                    (App.Current as App).navigation.MainWindows.comments.Text = "";
                    genericName = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("GenericName"));
                }
            }
        }

        private string producer;
        public string Producer
        {
            get { return producer; }
            set
            {
                if (!new VerifyInput().IsMedicineName(value))
                {
                    (App.Current as App).navigation.MainWindows.comments.Text = "שם לא תקין ";
                }
                else
                {
                    producer = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Producer"));
                }
            }
        }

        private string price;
        public string Price
        {
            get { return price; }
            set
            {
                if (!new VerifyInput().IsValidPrice(value))
                {
                    (App.Current as App).navigation.MainWindows.comments.Text = "מחיר לא תקין ";
                }
                else
                {
                    (App.Current as App).navigation.MainWindows.comments.Text = "";
                    price = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                }
            }
        }
        
       
        
        public ObservableCollection<string> MedicineIds { get; set; }

        public string MedicineSelected { get; set; }
        public MedicineVM()
        {
            MedicineM = new MedicineModel();
            Command = new MedicineCommand(this);
            try
            {
                MedicineIds = new ObservableCollection<string>(MedicineM.GetAllMedicineId());
            }
            catch (Exception e)
            {

                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
            
        }

        public void AddMedicine()
        {
            try
            {



                if (CommercialName == null || GenericName == null || Producer == null || Price == null)
                {
                    throw new ArgumentException("אתה צריך למלא את כל השדות");
                }
                else
                {

                    string Id = MedicineM.ResolveRxcuiFromName(CommercialName).ToString();
                    if (Id == "0")
                    {
                        throw new ArgumentException("תרופה לא קיימת ");
                    }
                    MedicineM.AddMedicine(new Medicine(Id, CommercialName, GenericName, Producer, Price, ImageUri));
                    MedicineIds.Add(Id);
                    (App.Current as App).navigation.MainWindows.comments.Text = "התרופה נוספה בהצלחה";
                }
            }
            catch (Exception e)
            {

                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }

        }
        public void DeleteMedicine()
        {
            try
            {

                MedicineV = MedicineM.GetMedicine(MedicineSelected);
                MedicineM.DeleteMedicine(MedicineV);
                MedicineIds.Remove(MedicineV.Id);
                (App.Current as App).navigation.MainWindows.comments.Text = "התרופה הוסרה בהצלחה";
            }
            catch (Exception e)
            {

                (App.Current as App).navigation.MainWindows.comments.Text = e.Message.ToString();
            }
        }
        public void AddImegeUri()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ImageUri = openFileDialog.FileName;
            }
        }

    }
}


