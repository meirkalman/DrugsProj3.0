using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BlObject: IBL
    {
        DalService dalService = new DalService();
        public void AddMedicine(Medicine medicine)
        {
            dalService.AddMedicine(medicine);
        }

        public void DeleteMedicine(int id)
        {
            dalService.DeleteMedicine(id);
        }

        public void UpdateMedicine(Medicine medicine)
        {
            dalService.UpdateMedicine(medicine);
        }

        public List<Medicine> GetAllMedicines()
        {
            return dalService.GetAllMedicines();
        }

        public List<Medicine> GetSomeMedicines(Predicate<Medicine> func = null)
        {
            return dalService.GetSomeMedicines();
        }

        public Medicine GetMedicine(string commercialName)
        {
            return dalService.GetMedicine(commercialName);
        }


        public void AddPatient(Patient patient)
        {
            dalService.AddPatient(patient);
        }

        public void DeletePatient(int id)
        {
            dalService.DeletePatient(id);
        }

        public void UpdatePatient(Patient patient)
        {
            dalService.UpdatePatient(patient);
        }

        public List<Patient> GetAllPatients()
        {
            return dalService.GetAllPatients();
        }

        public List<Patient> GetSomePatients(Predicate<Patient> func = null)
        {
            return dalService.GetSomePatients();
        }

        public Patient GetPatient(int id)
        {
            return dalService.GetPatient(id);
        }

        public void AddDoctorVisitToPatient(DoctorVisit doctorVisit, Patient patient)
        {
            dalService.AddDoctorVisitToPatient(doctorVisit, patient);
        }
       


        public void AddUser(User user)
        {
            DalService dalService = new DalService();
            dalService.AddUser(user);
        }

        public void DeleteUser(int id)
        {
            dalService.DeleteUser(id);
        }

        public void UpdateUser(User user)
        {
            dalService.UpdateUser(user);
        }

        public List<User> GetAllUsers()
        {
            return dalService.GetAllUsers();
        }

        public List<User> GetSomeUsers(Predicate<User> func = null)
        {
            return dalService.GetSomeUsers();
        }

        public User GetUser(int id)
        {
            return dalService.GetUser(id);
        }
    }
}
