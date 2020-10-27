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
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public List<string> GetAllMedicineId()
        {
            try
            {
                return Bl.GetAllMedicineId();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public int ResolveRxcuiFromName(string name)
        {
            try
            {
                return Bl.ResolveRxcuiFromName(name);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public void DeleteMedicine(Medicine medicine)
        {
            try
            {
                Bl.DeleteMedicine(medicine);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public Medicine GetMedicine(string id)
        {
            try
            {
                return Bl.GetMedicine(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
