using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalService
    {



        #region add to db

        public void AddPatient(Patient patient)
        {
            using (var db = new DBContext())
            {
                db.Patients.Add(patient);
                db.SaveChanges();
            }
        }
        public void AddMedicine(Medicine medicine)
        {
            using (var db = new DBContext())
            {
                db.Medicines.Add(medicine);
                db.SaveChanges();
            }
        }
        public void AddUser(User user)
        {
            using (var db = new DBContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }

        public void UpdatePatient(Patient patient)
        {
            using (var db = new DBContext())
            {
                var current = db.Patients.Find(patient.Id);
                current.Id = patient.Id;
                current.Lname = patient.Lname;
                current.Fname = patient.Fname;
                current.PhoneNumber = patient.PhoneNumber;
                current.DateOfBirth = patient.DateOfBirth;
                current.Medicines = patient.Medicines;
                current.MedicalRecord = patient.MedicalRecord;
                db.SaveChanges();
            }
        }
        public void UpdateMedicine(Medicine medicine)
        {
            using (var db = new DBContext())
            {
                var current = db.Medicines.Find(medicine.Id);
                current.Id = medicine.Id;
                current.CommercialName = medicine.CommercialName;
                current.GenericName = medicine.GenericName;
                current.Producer = medicine.Producer;
                current.PeriodOfUse = medicine.PeriodOfUse;
                current.Medicines = medicine.Medicines;
                current.MedicalRecord = medicine.MedicalRecord;
                db.SaveChanges();
            }
        }
        public void UpdateUser(User user)
        {
            using (var db = new DBContext())
            {
                var current = db.Patients.Find(patient.Id);
                current.Id = user.Id;
                current.Lname = user.Lname;
                current.Fname = user.Fname;
                current.PhoneNumber = user.PhoneNumber;
                current.DateOfBirth = user.DateOfBirth;
                current.Medicines = user.Medicines;
                current.MedicalRecord = user.MedicalRecord;
                db.SaveChanges();
            }
        }
        #endregion add to db
    }
}































//        //public void AddPatient(Patient patient)
//        //{
//        //    try
//        //    {
//        //        var v = from item in DataSourceTemp.PatientList
//        //                where item.Id == patient.Id
//        //                select item;
//        //        if (v.Any())
//        //            throw new DuplicateWaitObjectException("הלקוח כבר קיימת");
//        //    }
//        //    catch (DuplicateWaitObjectException p) { throw p; }
//        //    DataSourceTemp.PatientList.Add(patient);
//        //}

//        public void DeletePatient(int id)
//        {
//            List<Patient> v = DataSourceTemp.PatientList.Where(t => id == t.Id).ToList();
//            try
//            {
//                if (!v.Any())
//                    throw new KeyNotFoundException("לקוח לא קיים");
//            }
//            catch (KeyNotFoundException p) { throw p; }
//            int index = DataSourceTemp.PatientList.FindIndex(s => s.Id == v[0].Id);
//            DataSourceTemp.PatientList.Remove(DataSourceTemp.PatientList[index]);

//        }

//        public void UpdatePatient(Patient a)
//        {
//            int index = DataSourceTemp.PatientList.FindIndex(s => s.Id == a.Id);
//            try
//            {
//                if (index == -1)
//                    throw new KeyNotFoundException("הלקוח לא נמצא");
//            }
//            catch (KeyNotFoundException p) { throw p; }
//            DataSourceTemp.PatientList[index] = a;
//        }

//        public List<Patient> GetAllPatients()
//        {
//            List<Patient> a = new List<Patient>();
//            foreach (var item in DataSourceTemp.PatientList)
//                a.Add(item);
//            try
//            {
//                if (!a.Any())//If the list is empty
//                    throw new ArgumentNullException("אין אף לקוח");
//            }
//            catch (ArgumentNullException p) { throw p; };
//            return a;
//        }

//        public List<Patient> GetSomePatients(Predicate<Patient> func = null)
//        {
//            var v = (from item in DataSourceTemp.PatientList
//                     where (func(item))
//                     select item).ToList();
//            try
//            {
//                if (!v.Any())//If the list is empty
//                    throw new ArgumentNullException("לא נמצאו לקוחות");
//            }
//            catch (ArgumentNullException p) { throw p; };
//            return v;
//        }

//        public Patient GetPatient(int id)
//        {
//            var v = (from item in DataSourceTemp.PatientList
//                     where item.Id == id
//                     select item).ToList();
//            try
//            {
//                if (!v.Any())//If the list is empty
//                    throw new KeyNotFoundException("הלקוח לא נמצא");
//            }
//            catch (KeyNotFoundException p) { throw p; };
//            return v.First();
//        }
//        public void AddDoctorVisitToPatient(DoctorVisit doctorVisit, Patient patient)
//        {
//            var v = (from item in DataSourceTemp.PatientList
//                     where item.Id == patient.Id
//                     select item).ToList();
//            try
//            {
//                if (!v.Any())//If the list is empty
//                    throw new KeyNotFoundException("הלקוח לא נמצא");
//            }
//            catch (KeyNotFoundException p) { throw p; };
//            v.First().MedicalRecord.Add(doctorVisit);
//            UpdatePatient(patient); 
//        }
//        public void AddUser(User user)
//        {
//            try
//            {
//                var v = from item in DataSourceTemp.UserList
//                        where item.Id == user.Id
//                        select item;
//                if (v.Any())
//                    throw new DuplicateWaitObjectException("משתמש כבר קיימת");
//            }
//            catch (DuplicateWaitObjectException p) { throw p; }
//            DataSourceTemp.UserList.Add(user);
//        }

//        public void DeleteUser(int id)
//        {
//            List<User> v = (DataSourceTemp.UserList.Where(t => id == t.Id)).ToList();
//            try
//            {
//                if (!v.Any())
//                    throw new KeyNotFoundException("משתמש לא קיים");
//            }
//            catch (KeyNotFoundException p) { throw p; }
//            int index = DataSourceTemp.UserList.FindIndex(s => s.Id == v[0].Id);
//            DataSourceTemp.UserList.Remove(DataSourceTemp.UserList[index]);

//        }

//        public void UpdateUser(User a)
//        {
//            int index = DataSourceTemp.UserList.FindIndex(s => s.Id == a.Id);
//            try
//            {
//                if (index == -1)
//                    throw new KeyNotFoundException("משתמש לא נמצאת");
//            }
//            catch (KeyNotFoundException p) { throw p; }
//            DataSourceTemp.UserList[index] = a;
//        }

//        public List<User> GetAllUsers()
//        {
//            List<User> a = new List<User>();
//            foreach (var item in DataSourceTemp.UserList)
//                a.Add(item);
//            try
//            {
//                if (!a.Any())//If the list is empty
//                    throw new ArgumentNullException("אין אף משתמש");
//            }
//            catch (ArgumentNullException p) { throw p; };
//            return a;
//        }

//        public List<User> GetSomeUsers(Predicate<User> func = null)
//        {
//            var v = (from item in DataSourceTemp.UserList
//                     where (func(item))
//                     select item).ToList();
//            try
//            {
//                if (!v.Any())//If the list is empty
//                    throw new ArgumentNullException("לא נמצאו משתמשים");
//            }
//            catch (ArgumentNullException p) { throw p; };
//            return v;
//        }

//        public User GetUser(int id)
//        {
//            var v = (from item in DataSourceTemp.UserList
//                     where item.Id == id
//                     select item).ToList();
//            try
//            {
//                if (!v.Any())//If the list is empty
//                    throw new KeyNotFoundException("משתמש לא נמצא");
//            }
//            catch (KeyNotFoundException p) { throw p; };
//            return v.First();
//        }


//    }
//}
//public void AddMedicine(Medicine medicine)
//{
//    try
//    {
//        var v = from item in DataSourceTemp.MedicineList
//                where item.Id == medicine.Id
//                select item;
//        if (v.Any())
//            throw new DuplicateWaitObjectException("התרופה כבר קיימת");
//    }
//    catch (DuplicateWaitObjectException p) { throw p; }
//    DataSourceTemp.MedicineList.Add(medicine);
//}

//public void DeleteMedicine(int id)
//{
//    List<Medicine> v = (DataSourceTemp.MedicineList.Where(t => id == t.Id)).ToList();
//    try
//    {
//        if (!v.Any())
//            throw new KeyNotFoundException("תרופה לא קיים");
//    }
//    catch (KeyNotFoundException p) { throw p; }
//    int index = DataSourceTemp.MedicineList.FindIndex(s => s.Id == v[0].Id);
//    DataSourceTemp.MedicineList.Remove(DataSourceTemp.MedicineList[index]);

//}

//public void UpdateMedicine(Medicine a)
//{
//    int index = DataSourceTemp.MedicineList.FindIndex(s => s.Id == a.Id);
//    try
//    {
//        if (index == -1)
//            throw new KeyNotFoundException("התרופה לא נמצאת");
//    }
//    catch (KeyNotFoundException p) { throw p; }
//    DataSourceTemp.MedicineList[index] = a;
//}

//public List<Medicine> GetAllMedicines()
//{
//    List<Medicine> a = new List<Medicine>();
//    foreach (var item in DataSourceTemp.MedicineList)
//        a.Add(item);
//    try
//    {
//        if (!a.Any())//If the list is empty
//            throw new ArgumentNullException("אין אף תרופה");
//    }
//    catch (ArgumentNullException p) { throw p; };
//    return a;
//}

//public List<Medicine> GetSomeMedicines(Predicate<Medicine> func = null)
//{
//    var v = (from item in DataSourceTemp.MedicineList
//             where (func(item))
//             select item).ToList();
//    try
//    {
//        if (!v.Any())//If the list is empty
//            throw new ArgumentNullException("לא נמצאו תרופות");
//    }
//    catch (ArgumentNullException p) { throw p; };
//    return v;
//}

//public Medicine GetMedicine(string commercialName)
//{
//    var v = (from item in DataSourceTemp.MedicineList
//             where item.CommercialName == commercialName
//             select item).ToList();
//    try
//    {
//        if (!v.Any())//If the list is empty
//            throw new KeyNotFoundException("התרופה לא נמצאת");
//    }
//    catch (KeyNotFoundException p) { throw p; };
//    return v.First();
//}
//    public void AddMedicine(Medicine medicine)
//    {
//        using (var db = new DBContext())
//        {
//            var medicines = db.Set<Medicine>();
//            medicines.Add(medicine);
//             db.SaveChanges();
//        }
//    }