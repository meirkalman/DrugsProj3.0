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
            Id = 1;
            CommercialName = "acamol";
            GenericName = "acamol";
            Producer = "teva";
            PeriodOfUse = DateTime.Now;

        }
    }
}
