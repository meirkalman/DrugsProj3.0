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
     
        public string Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string PhoneNumber { get; set; }
        public UserType Type { get; set; }
        public string Password { get; set; }

        public enum UserType { רופא, מנהל }

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
            Password = user.Password;
        }

        public User(string id, string fname, string lname, string phoneNumber, UserType type, string password)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
            PhoneNumber = phoneNumber;
            Type = type;
            Password = password;
        }
    }
}   

            

            