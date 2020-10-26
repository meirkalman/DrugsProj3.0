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
            Bl.AddMedicine(medicine);
        }

        public List<string> GetAllMedicineId()
        {
            return Bl.GetAllMedicineId();
        }

        public Medicine GetMedicine(string medicinetId)
        {
            return Bl.GetMedicine(medicinetId);
        }
        public void DeleteMedicine(Medicine medicine)
        {
            Bl.DeleteMedicine(medicine);
        }
    }
}
