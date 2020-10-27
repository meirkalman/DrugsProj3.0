using BE;
using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Models
{
    class MedicinInformationModel
    {
        public IBL Bl { get; set; }
        public MedicinInformationModel()
        {
            Bl = new BlObject();
        }


        public List<Medicine> GetMedicins()
        {
            try
            {
                return Bl.GetAllMedicines();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
