using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalService:IDalService
    {



        #region add & update to db

        public bool AddPatient(Patient patient)
        {
            
            using (var db = new DBContext())
            {
                
                var current = db.Patients.Find(patient.PatientId);
                if(current != null)
                {
                    return false;
                }
                db.Patients.Add(patient);
                db.SaveChanges();
                return true;
            }
        }
        public bool AddMedicine(Medicine medicine)
        {
            
            using (var db = new DBContext())
            {
                var current = db.Medicines.Find(medicine.Id);
                if (current != null)
                {
                    return false;
                }
                db.Medicines.Add(medicine);
                db.SaveChanges();
            }
            return true;
        }
        public bool AddRecipe(Recipe recipe)
        {
            using (var db = new DBContext())
            {
                var current = db.Recipes.Find(recipe.RecipeId);
                if (current != null)
                {
                    return false;
                }
                db.Recipes.Add(recipe);
                db.SaveChanges();
            }
            return true;
        }
        public bool AddUser(User user)
        {
            using (var db = new DBContext())
            {
                var current = db.Users.Find(user.Id);
                if (current != null)
                {
                    return false;
                }
                db.Users.Add(user);
                db.SaveChanges();
            }
            return true;
        }


        public bool UpdatePatient(Patient patient)
        {
            using (var db = new DBContext())
            {
                var current = db.Patients.Find(patient.PatientId);
                if (current == null)
                {
                    return false;
                }
                current.PatientId = patient.PatientId;
                current.Lname = patient.Lname;
                current.Fname = patient.Fname;
                current.PhoneNumber = patient.PhoneNumber;
                current.DateOfBirth = patient.DateOfBirth;
                db.SaveChanges();
            }
            return true;
        }
        public bool UpdateMedicine(Medicine medicine)
        {
            using (var db = new DBContext())
            {
                var current = db.Medicines.Find(medicine.Id);
                if (current == null)
                {
                    return false;
                }
                current.Id = medicine.Id;
                current.CommercialName = medicine.CommercialName;
                current.GenericName = medicine.GenericName;
                current.Producer = medicine.Producer;
                current.ActiveIngredients = medicine.ActiveIngredients;
                current.ImageUri = medicine.ImageUri;
                db.SaveChanges();
            }
            return true;
        }
        public bool UpdateRecipe(Recipe recipe)
        {
            using (var db = new DBContext())
            {
                var current = db.Recipes.Find(recipe.RecipeId);
                if (current == null)
                {
                    return false;
                }
                current.RecipeId = recipe.RecipeId;
                current.DoctorId = recipe.DoctorId;
                current.PatientId = recipe.PatientId;
                current.MedicineId = recipe.MedicineId;
                current.PeriodOfUse = recipe.PeriodOfUse;
                current.Description = recipe.Description;
                current.Date = recipe.Date;
                db.SaveChanges();
            }
            return true;
        }
        public bool UpdateUser(User user)
        {
            using (var db = new DBContext())
            {
                var current = db.Users.Find(user.Id);
                if (current == null)
                {
                    return false;
                }
                current.Id = user.Id;
                current.Lname = user.Lname;
                current.Fname = user.Fname;
                current.PhoneNumber = user.PhoneNumber;
                current.Type = user.Type;
                db.SaveChanges();
            }
            return true;
        }
        #endregion add & update to db

        public bool DeletePatient(Patient patient)
        {
            using (var db = new DBContext())
            {
                var current = db.Patients.Find(patient.PatientId);
                if (current == null)
                {
                    return false;
                }
                db.Patients.Remove(current);
                db.SaveChanges();

                return true;
                
            }
        }
        public bool DeleteMedicine(Medicine medicine)
        {
            using (var db = new DBContext())
            {
                var current = db.Medicines.Find(medicine.Id);
                if (current == null)
                {
                    return false;
                }
                db.Medicines.Remove(current);
                db.SaveChanges();
                return true;
            }
        }
        public bool DeleteRecipe(Recipe recipe)
        {
            using (var db = new DBContext())
            {
                var current = db.Recipes.Find(recipe.RecipeId);
                if (current == null)
                {
                    return false;
                }
                db.Recipes.Remove(current);
                db.SaveChanges();
                return true;
            }
        }

        public bool DeleteUser(User user)
        {
            using (var db = new DBContext())
            {
                var current = db.Users.Find(user.Id);
                if (current == null)
                {
                    return false;
                }
                db.Users.Remove(current);
                db.SaveChanges();
                return true;
            }
        }

        public List<Patient> GetAllPatients(Func<Patient, bool> predicate = null)
        {
            List<Patient> PatientList = new List<Patient>();
            using (var db = new DBContext())
            {
                if (predicate == null)
                    PatientList = db.Patients.ToList();
                else
                {
                    PatientList = db.Patients.Where(predicate).ToList();
                }
            }
            return PatientList;
        }

        public List<Medicine> GetAllMedicines(Func<Medicine, bool> predicate = null)
        {
            List<Medicine> MedicinetList = new List<Medicine>();
            using (var db = new DBContext())
            {
                if (predicate == null)
                    MedicinetList = db.Medicines.ToList();
                else
                {
                    MedicinetList = db.Medicines.Where(predicate).ToList();
                }
            }
            return MedicinetList;
        }

        public List<Recipe> GetAllRecipes(Func<Recipe, bool> predicate = null)
        {
            List<Recipe> RecipeList = new List<Recipe>();
            using (var db = new DBContext())
            {
                if (predicate == null)
                    RecipeList = db.Recipes.ToList();
                else
                {
                    RecipeList = db.Recipes.Where(predicate).ToList();
                }
            }
            return RecipeList;
        }

        public List<User> GetAllUsers(Func<User, bool> predicate = null)
        {
            List<User> UserList = new List<User>();
            using (var db = new DBContext())
            {
                if (predicate == null)
                    UserList = db.Users.ToList();
                else
                {
                    UserList = db.Users.Where(predicate).ToList();
                }
            }
            return UserList;
        }

        public Patient GetPatient(int id)
        {
            using (var db = new DBContext())
            {
                var patient = (from item in db.Patients
                               where item.PatientId == id
                               select item).ToList();

                if (patient.Count == 1)
                {
                    return patient.First();
                }
                else if (patient.Count == 0)
                {
                    return null;
                }
                else
                {
                    throw new Exception("error,Patient not found");
                }
            }
        }

        public Medicine GetMedicine(int id)
        {
            using (var db = new DBContext())
            {
                var medicine = (from item in db.Medicines
                                where item.Id == id
                               select item).ToList();

                if (medicine.Count == 1)
                {
                    return medicine.First();
                }
                else if (medicine.Count == 0)
                {
                    return null;
                }
                else
                {
                    throw new Exception("error,medicine not found");
                }
            }
        }

        public Recipe GetRecipe(int recipeId)
        {
            using (var db = new DBContext())
            {
                var recipe = (from item in db.Recipes
                               where item.RecipeId == recipeId
                               select item).ToList();

                if (recipe.Count == 1)
                {
                    return recipe.First();
                }
                else if (recipe.Count == 0)
                {
                    return null;
                }
                else
                {
                    throw new Exception("error,recipe not found");
                }
            }
        }

        public User GetUser(int id)
        {
            using (var db = new DBContext())
            {
                var user = (from item in db.Users
                            where item.Id == id
                               select item).ToList();

                if (user.Count == 1)
                {
                    return user.First();
                }
                else if (user.Count == 0)
                {
                    return null;
                }
                else
                {
                    throw new Exception("error,user not found");
                }
            }
        }
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