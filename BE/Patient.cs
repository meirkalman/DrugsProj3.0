using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Patient
    {
       
        public string PatientId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Patient(string id, string fname, string lname, int phoneNumber,  DateTime dateOfBirth)
        {
            PatientId = id;
            Fname = fname;
            Lname = lname;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
        }
       
        public Patient()
        {
        }
    }
}
