using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Medicine
    {
        public int Id { get; set; }
        public string CommercialName { get; set; }
        public string GenericName { get; set; }
        public string Producer { get; set; }
        public DateTime PeriodOfUse { get; set; }
        public List<string> ActiveIngredients { get; set; }
        public string ImageUri { get; set; }


        public Medicine()
        {
        }
        // /   public Medicine(int id,string CommercialName, string CommercialName, string GenericName, string Producer, DateTime PeriodOfUse, string CommercialName, )
        //{
        //    Id = 1;
        //    CommercialName = "acamol";
        //    GenericName = "acamol";
        //    Producer = "teva";
        //    PeriodOfUse = DateTime.Now;

        //}
        public Medicine(Medicine medicine)
        {
            this.Id = medicine.Id;
            this.CommercialName = medicine.CommercialName;
            this.GenericName = medicine.GenericName;
            this.Producer = medicine.Producer;
            this.PeriodOfUse = medicine.PeriodOfUse;
            this.ActiveIngredients = medicine.ActiveIngredients;
            this.ImageUri = medicine.ImageUri;
        }
        public Medicine(int id,string cName, string  gName, string producer, DateTime periodOfUse)
        {
           Id = id;
           CommercialName =cName;
           GenericName =gName;
           Producer =producer;
           PeriodOfUse =periodOfUse;
           ActiveIngredients = new List<string>();
           ImageUri = "aaa";
        }
    }
}
