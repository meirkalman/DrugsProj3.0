using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class User
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int PhoneNumber { get; set; }
        //public List<Patient> Patients { get; set; }
        public string Address { get; set; }

        public UserType Type { get; set; }

        public enum UserType { DOCTOR, ADMIN }

        public User()
        {
            Id = 1;
        }
    }
}
