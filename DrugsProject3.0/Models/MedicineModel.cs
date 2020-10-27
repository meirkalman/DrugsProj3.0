using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
    class MedicineModel
    {
        public IBL Bl { get; set; }
        public MedicineModel()
        {
            Bl = new BlObject();
        }

        public void AddMedicine(Medicine medicine)
        {
            try
            {
                Bl.AddMedicine(medicine);
            }
            catch (Exception)
            {

                throw new Exception("כבר קיימת תרופה כזו");
            }
            
        }

        public List<string> GetAllMedicineId()
        {
            return Bl.GetAllMedicineId();
        }

        public int ResolveRxcuiFromName(string name)
        {
            return Bl.ResolveRxcuiFromName(name);
        }
        public void DeleteMedicine(Medicine medicine)
        {
            Bl.DeleteMedicine(medicine);
        }

        public Medicine GetMedicine(string id)
        {
           return Bl.GetMedicine(id);
        }
    }
}
