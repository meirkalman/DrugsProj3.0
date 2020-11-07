using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
     public class ChartModel
    {
        public IBL Bl { get; set; }
        public ChartModel()
        {
            Bl = new BlObject();
        }

        public List<Recipe> GetStatistic()
        {
            try
            {
                return Bl.GetAllRecipes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
