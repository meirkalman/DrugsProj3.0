using DrugsProject3._0.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.ViewModels
{
      public  class AdministratorVM
      {

        //public event PropertyChangedEventHandler PropertyChanged;
        public AdministratorCommand Command { get; set; }

        public AdministratorVM()
        {
            Command = new AdministratorCommand(this);
        }
    }
}
