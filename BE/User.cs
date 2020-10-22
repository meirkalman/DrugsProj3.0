using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int PhoneNumber { get; set; }
        public UserType Type { get; set; }

        public enum UserType { DOCTOR, ADMIN }

        public User()
        {

        }
        public User(User user)
        {
            Id = user.Id;
            Fname = user.Fname;
            Lname = user.Lname;
            PhoneNumber = user.PhoneNumber;
            Type = user.Type;
        }

        public User(int id, string fname, string lname, int phoneNumber, UserType type)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
            PhoneNumber = phoneNumber;
            Type = type;
        }
    }
}   

            

            