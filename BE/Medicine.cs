using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Medicine
    {
       
        public string Id { get; set; }
        public string CommercialName { get; set; }
        public string GenericName { get; set; }
        public string Producer { get; set; }
        public string Price { get; set; }
        public string ImageUri { get; set; }


        public Medicine()
        {
        }

        public Medicine(string id,string cName, string  gName, string producer, string price, string imageUri)
        {
           Id = id;
           CommercialName =cName;
           GenericName =gName;
           Producer =producer;
            Price = price;
           ImageUri = imageUri;
        }
    }
}







