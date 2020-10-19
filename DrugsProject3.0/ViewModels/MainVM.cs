using DrugsProject3._0.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.ViewModels
{
    public class MainVM
    {
        public MainVM()
        {
            MainCommand = new MainCommand(this);
        }
        public MainCommand MainCommand { get; set; }
    }
}
