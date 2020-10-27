using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.ViewModels
{
    class AdministratorInformationVM
    {
        public AdministratorInformationModel AdministratorInformationM;


        public ObservableCollection<Recipe> Recipes { get; set; }


        public AdministratorInformationVM()
        {
            AdministratorInformationM = new AdministratorInformationModel\();

            Command = new StatisticsCommand(this);
            Recipes = new ObservableCollection<Recipe>(AdministratorInformationM.GetAllRecipes());
        }

        public StatisticsCommand Command { get; set; }
        //  public DoctorCommand CommandAP { get; set; }

    }
}
