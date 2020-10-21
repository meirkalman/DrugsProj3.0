using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Class1
    {//
    }
}
//public class DBContext : DbContext
//{
//    public DBContext() : base("DrugProj")
//    {
//        //this.Configuration.LazyLoadingEnabled = false;

//    }
//    public DbSet<Medicine> Medicines { get; set; }
//    public DbSet<Patient> Patient { get; set; }
//    public DbSet<User> Users { get; set; }

//    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
//    //{
//    //    modelBuilder.Entity<Nutritions>()
//    //        .HasOptional<IceCream>(s => s.IceCream)
//    //        .WithRequired(ad => ad.Nutrients)
//    //        .WillCascadeOnDelete(true);
//    //}
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



//public void AddPatient(Patient patient)
//{
//    using (var db = new DBContext())
//    {
//        var patients = db.Set<Patient>();
//        patients.Add(patient);
//        db.SaveChanges();
//    }
//}

//public void AddUser(User user)
//{
//    using (var db = new DBContext())
//    {
//        var users = db.Set<User>();
//        users.Add(user);
//        db.SaveChanges();
//    }
//}

//public void UpdateMedicine(Medicine medicine)
//    {
//        using (var db = new DBContext())
//        {
//            var med = db.Medicines.Find(medicine.Id);
//            if (med != null)
//            {
//                db.Medicines.Remove(med);
//                db.Medicines.Add(medicine);
//                db.SaveChanges();
//            }
//        }
// }