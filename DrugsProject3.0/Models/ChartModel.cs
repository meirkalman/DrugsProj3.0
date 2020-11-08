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

        public Dictionary<string,int> GetStatistic(string drugID, DateTime start, DateTime finish)
        {
            try
            {
                return Bl.drugStatistics(drugID, start, finish);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetAllMedicinesNames()
        {
            try
            {
                return Bl.GetAllMedicinesNames();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Recipe> getPatientHistoryByDrug(DateTime first, DateTime second, string patientId = null, string drugID = null)
        {
            try
            {
                return Bl.getPatientHistoryByDrug(first, second, patientId, drugID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetMedicineId(string medicineSelected)
        {
            return Bl.GetMedicineId(medicineSelected);
        }
    }
}
