using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BE.User;

namespace DAL
{
    static class DataSourceTemp
    {
       
        public static List<Medicine> MedicineList = new List<Medicine>();
        public static List<Patient> PatientList = new List<Patient>();
        public static List<User> UserList = new List<User>();
        static DataSourceTemp()
        {
            Medicine medicine = new Medicine();
            medicine.Id = 1321;
            medicine.CommercialName = "acamol";
            medicine.GenericName = "Acamol";
            medicine.Producer = "teva";
            medicine.PeriodOfUse = new DateTime();
            medicine.ActiveIngredients = new List<string>();
            medicine.ImageUri = "aaa";
            MedicineList.Add(medicine);

            medicine.Id = 15416;
            medicine.CommercialName = "ssss";
            medicine.GenericName = "ffff";
            medicine.Producer = "teva";
            medicine.PeriodOfUse = new DateTime();
            medicine.ActiveIngredients = new List<string>();
            medicine.ImageUri = "aaa";
            MedicineList.Add(medicine);

            medicine.Id = 1321;
            medicine.CommercialName = "vvvv";
            medicine.GenericName = "Acccc";
            medicine.Producer = "teva";
            medicine.PeriodOfUse = new DateTime();
            medicine.ActiveIngredients = new List<string>();
            medicine.ImageUri = "aaa";
            MedicineList.Add(medicine);

       
            PatientList.Add(new Patient(123, "yitzchak", "ravitz", 054999999, new DateTime(2 / 4 / 2004)));
            PatientList.Add(new Patient(456, "meir", "kalman", 054555555, new DateTime(4 / 9 / 1999)));
            PatientList.Add(new Patient(777, "moshe", "cohen", 054111111, new DateTime(6 / 1 / 1995)));
            PatientList.Add(new Patient(453, "david", "kkk", 054159753, new DateTime(1/3/1992)));
            PatientList.Add(new Patient(124, "moshe", "cohen", 054111111, new DateTime(2 / 6 / 2000)));

            User user = new User();
            user.Type = UserType.ADMIN;
            user.Id = 453;
            user.Fname = "meni";
            user.Fname = "naftali";
            user.PhoneNumber = 45374;
            UserList.Add(user);

            user.Type = UserType.DOCTOR;
            user.Id = 7486;
            user.Fname = "zevi";
            user.Fname = "abc";
            user.PhoneNumber = 73254;
            UserList.Add(user);

            user.Type = UserType.ADMIN;
            user.Id = 8767;
            user.Fname = "avner";
            user.Fname = "shcter";
            user.PhoneNumber = 1464;
            UserList.Add(user);

            user.Type = UserType.DOCTOR;
            user.Id = 97645;
            user.Fname = "ari";
            user.Fname = "rubin";
            user.PhoneNumber = 469;
            UserList.Add(user);
        }
            
    }
}
