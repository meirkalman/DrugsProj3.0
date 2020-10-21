using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IBL
    {
        void AddMedicine(Medicine medicine);


        void DeleteMedicine(int id);


        void UpdateMedicine(Medicine medicine);


        List<Medicine> GetAllMedicines();


        List<Medicine> GetSomeMedicines(Predicate<Medicine> func = null);


        Medicine GetMedicine(string commercialName );



        void AddPatient(Patient patient);


        void DeletePatient(int id);


        void UpdatePatient(Patient patient);


        List<Patient> GetAllPatients();


        List<Patient> GetSomePatients(Predicate<Patient> func = null);


        Patient GetPatient(int id);

        void AddDoctorVisitToPatient(DoctorVisit doctorVisit, Patient patient);

        void AddUser(User user);


        void DeleteUser(int id);


        void UpdateUser(User user);


        List<User> GetAllUsers();


        List<User> GetSomeUsers(Predicate<User> func = null);


        User GetUser(int id);
       
    }
}

