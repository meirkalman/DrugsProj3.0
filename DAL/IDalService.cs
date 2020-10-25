using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDalService
    {
        bool AddPatient(Patient patient);

        bool AddMedicine(Medicine medicine);

        bool AddRecipe(Recipe recipe);

        bool AddUser(User user);


        bool UpdatePatient(Patient patient);

        bool UpdateMedicine(Medicine medicine);

        bool UpdateRecipe(Recipe recipe);

        bool UpdateUser(User user);



        bool DeletePatient(Patient patient);

        bool DeleteMedicine(Medicine medicine);

        bool DeleteRecipe(Recipe recipe);


        bool DeleteUser(User user);


        List<Patient> GetAllPatients(Func<Patient, bool> predicate = null);


        List<Medicine> GetAllMedicines(Func<Medicine, bool> predicate = null);


        List<Recipe> GetAllRecipes(Func<Recipe, bool> predicate = null);


        List<User> GetAllUsers(Func<User, bool> predicate = null);

        Patient GetPatient(string id);


        Medicine GetMedicine(string id);


        Recipe GetRecipe(string recipeId);


        User GetUser(string id);
       
    }
}
