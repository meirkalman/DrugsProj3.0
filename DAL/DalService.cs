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

        public void AddPatient(Patient patient)
        {
            
            using (var db = new DBContext())
            {
                
                var current = db.Patients.Find(patient.PatientId);
                if(current != null)
                {
                    throw new Exception("חולה כבר קיים ");
                }
                db.Patients.Add(patient);
                db.SaveChanges();
            }
        }
        public void AddMedicine(Medicine medicine)
        {
            
            using (var db = new DBContext())
            {
                var current = db.Medicines.Find(medicine.Id);
                if (current != null)
                {
                    throw new Exception("תרופה כבר קיימת ");
                }
                db.Medicines.Add(medicine);
                db.SaveChanges();
            }
        }
        public void AddRecipe(Recipe recipe)
        {
            using (var db = new DBContext())
            {
                var current = db.Recipes.Find(recipe.RecipeId);
                if (current != null)
                {
                    throw new Exception("מרשם כבר קיים ");
                }
                db.Recipes.Add(recipe);
                db.SaveChanges();
            }
        }
        public void AddUser(User user)
        {
            using (var db = new DBContext())
            {
                var current = db.Users.Find(user.Id);
                if (current != null)
                {
                    throw new Exception("משתמש כבר קיים במערכת");
                }
                db.Users.Add(user);
                db.SaveChanges();
            }
        }


        public void UpdatePatient(Patient patient)
        {
            using (var db = new DBContext())
            {
                var current = db.Patients.Find(patient.PatientId);
                if (current == null)
                {
                    throw new Exception("חולה כבר קיים ");
                }
                current.PatientId = patient.PatientId;
                current.Lname = patient.Lname;
                current.Fname = patient.Fname;
                current.PhoneNumber = patient.PhoneNumber;
                current.DateOfBirth = patient.DateOfBirth;
                current.MailAddress = patient.MailAddress;
                db.SaveChanges();
            }  
        }
        public void UpdateMedicine(Medicine medicine)
        {
            using (var db = new DBContext())
            {
                var current = db.Medicines.Find(medicine.Id);
                if (current == null)
                {
                    throw new Exception("תרופה לא במערכת ");
                }
                current.Id = medicine.Id;
                current.CommercialName = medicine.CommercialName;
                current.GenericName = medicine.GenericName;
                current.Producer = medicine.Producer;
                current.Price = medicine.Price;
                current.ImageUri = medicine.ImageUri;
                db.SaveChanges();
            }
        }
        public void UpdateRecipe(Recipe recipe)
        {
            using (var db = new DBContext())
            {
                var current = db.Recipes.Find(recipe.RecipeId);
                if (current == null)
                {
                    throw new Exception("מרשם לא במערכת ");
                }
                current.RecipeId = recipe.RecipeId;
                current.MedicineName = recipe.MedicineName;
                current.DoctorId = recipe.DoctorId;
                current.PatientId = recipe.PatientId;
                current.MedicineId = recipe.MedicineId;
                current.PeriodOfUse = recipe.PeriodOfUse;
                current.Description = recipe.Description;
                current.Date = recipe.Date;
                db.SaveChanges();
            }
        }
        public void UpdateUser(User user)
        {
            using (var db = new DBContext())
            {
                var current = db.Users.Find(user.Id);
                if (current == null)
                {
                    throw new Exception("משתמש לא במערכת ");
                }
                current.Id = user.Id;
                current.Lname = user.Lname;
                current.Fname = user.Fname;
                current.PhoneNumber = user.PhoneNumber;
                current.Type = user.Type;
                current.MailAddress = user.MailAddress;
                db.SaveChanges();
            }
        }
        #endregion add & update to db
        #region delete
        public void DeletePatient(Patient patient)
        {
            using (var db = new DBContext())
            {
                var current = db.Patients.Find(patient.PatientId);
                if (current == null)
                {
                    throw new Exception("חולה לא במערכת ");
                }
                db.Patients.Remove(current);
                db.SaveChanges();
            }
        }
        public void DeleteMedicine(Medicine medicine)
        {
            using (var db = new DBContext())
            {
                var current = db.Medicines.Find(medicine.Id);
                if (current == null)
                {
                    throw new Exception("תרופה לא במערכת ");
                }
                db.Medicines.Remove(current);
                db.SaveChanges();

            }
        }
        public void DeleteRecipe(Recipe recipe)
        {
            using (var db = new DBContext())
            {
                var current = db.Recipes.Find(recipe.RecipeId);
                if (current == null)
                {
                    throw new Exception("מרשם לא במערכת ");
                }
                db.Recipes.Remove(current);
                db.SaveChanges();

            }
        }

        public void DeleteUser(User user)
        {
            using (var db = new DBContext())
            {
                var current = db.Users.Find(user.Id);
                if (current == null)
                {
                    throw new Exception("משתמש לא במערכת ");
                }
                db.Users.Remove(current);
                db.SaveChanges();

            }
        }
        #endregion delete

        #region get all 
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
            if (PatientList.Count == 0)
                throw new Exception("אין חולים במערכת ");
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
            if (MedicinetList.Count == 0)
                throw new Exception("אין תרופות במערכת ");
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
            //if (RecipeList.Count == 0)
            //    throw new Exception("אין מרשמים במערכת ");
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
            if (UserList.Count == 0)
                throw new Exception("אין משתמשים במערכת ");
            return UserList;
        }
        #endregion get all

        #region get 
        public Patient GetPatient(string id)
        {
            using (var db = new DBContext())
            {
                var patient = (from item in db.Patients
                               where item.PatientId == id
                               select item).ToList();

                if (patient.Count != 1)
                    throw new Exception("חולה לא נמצא");
                return patient.First();

            }
        }

        public Medicine GetMedicine(string id)
        {
            using (var db = new DBContext())
            {
                var medicine = (from item in db.Medicines
                                where item.Id == id
                                select item).ToList();

                if (medicine.Count != 1)
                    throw new Exception("תרופה לא במערכת");
                return medicine.First();
            }
        }

        public Recipe GetRecipe(string recipeId)
        {
            using (var db = new DBContext())
            {
                var recipe = (from item in db.Recipes
                              where item.RecipeId == recipeId
                              select item).ToList();

                if (recipe.Count != 1)
                    throw new Exception("מרשם לא במערכת");
                return recipe.First();
            }
        }

        public User GetUser(string id)
        {
            using (var db = new DBContext())
            {
                var user = (from item in db.Users
                            where item.Id == id
                            select item).ToList();

                if (user.Count == 0)
                    throw new Exception("שם משתמש שגוי");
                return user.First();
            }
        }
       
       
        #endregion get
    }
}

