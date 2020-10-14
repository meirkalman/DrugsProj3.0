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

        public void AddMedicine(Medicine medicine)
        {
            DalService dalService = new DalService();
            dalService.AddMedicine(medicine);
        }

        public void DeleteMedicine(int id)
        {
            DalService dalService = new DalService();
            dalService.DeleteMedicine(id);
        }

        public void UpdateMedicine(Medicine medicine)
        {
            DalService dalService = new DalService();
            dalService.UpdateMedicine(medicine);
        }

        public List<Medicine> GetAllMedicines()
        {
            DalService dalService = new DalService();
            return dalService.GetAllMedicines();
        }

        public List<Medicine> GetSomeMedicines(Predicate<Medicine> func = null)
        {
            DalService dalService = new DalService();
            return dalService.GetSomeMedicines();
        }

        public Medicine GetMedicine(int id)
        {
            DalService dalService = new DalService();
            return dalService.GetMedicine(id);
        }


        public void AddPatient(Patient patient)
        {
            DalService dalService = new DalService();
            dalService.AddPatient(patient);
        }

        public void DeletePatient(int id)
        {
            DalService dalService = new DalService();
            dalService.DeletePatient(id);
        }

        public void UpdatePatient(Patient patient)
        {
            DalService dalService = new DalService();
            dalService.UpdatePatient(patient);
        }

        public List<Patient> GetAllPatients()
        {
            DalService dalService = new DalService();
            return dalService.GetAllPatients();
        }

        public List<Patient> GetSomePatients(Predicate<Patient> func = null)
        {
            DalService dalService = new DalService();
            return dalService.GetSomePatients();
        }

        public Patient GetPatient(int id)
        {
            DalService dalService = new DalService();
            return dalService.GetPatient(id);
        }

        public void AddUser(User user)
        {
            DalService dalService = new DalService();
            dalService.AddUser(user);
        }

        public void DeleteUser(int id)
        {
            DalService dalService = new DalService();
            dalService.DeleteUser(id);
        }

        public void UpdateUser(User user)
        {
            DalService dalService = new DalService();
            dalService.UpdateUser(user);
        }

        public List<User> GetAllUsers()
        {
            DalService dalService = new DalService();
            return dalService.GetAllUsers();
        }

        public List<User> GetSomeUsers(Predicate<User> func = null)
        {
            DalService dalService = new DalService();
            return dalService.GetSomeUsers();
        }

        public User GetUser(int id)
        {
            DalService dalService = new DalService();
            return dalService.GetUser(id);
        }
    }
}
