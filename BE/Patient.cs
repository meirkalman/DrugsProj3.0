using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Patient
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int PhoneNumber { get; set; }
        public List<Medicine> Medicines { get; set; }
        public string Address { get; set; }
        public List<DoctorVisit> MedicalRecord { get; set; }


        public Patient()
        {
            Id = 3;
        }
    }
}
