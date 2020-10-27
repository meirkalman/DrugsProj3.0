using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
    public class StatisticsModel
    {
        public IBL Bl { get; set; }
        public StatisticsModel()
        {
            Bl = new BlObject();
        }

        public Dictionary<DateTime, int> drugStatistics(string drugID, DateTime start, DateTime finish)
        {
            return Bl.drugStatistics(drugID, start, finish);
        }

        public List<Recipe> GetAllRecipes()
        {
            return Bl.GetAllRecipes();
        }
    }
}
