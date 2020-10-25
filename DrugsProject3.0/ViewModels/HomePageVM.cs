using BE;
using DrugsProject3._0.Commands;
using DrugsProject3._0.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.ViewModels
{
    class HomePageVM : INotifyPropertyChanged
    {
        
            public event PropertyChangedEventHandler PropertyChanged;

            
            public HomePageCommand Command { get; set; }

            public HomePageModel HomePageM { get; set; }

            private string id;
            public string Id
            {
                get { return id; }
                set
                {
                id = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Id"));
                }
            }

        public HomePageVM()
        {
            HomePageM = new HomePageModel();
            Command = new HomePageCommand(this);
        }
    }
}
