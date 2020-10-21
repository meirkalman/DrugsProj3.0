using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Patient
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int PhoneNumber { get; set; }
        public List<Medicine> Medicines { get; set; }
        //public Address PatientAddress { get; set; }
         public List<DoctorVisit> MedicalRecord { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Patient(int id, string fname, string lname, int phoneNumber, /*Address PatientAddress,*/ DateTime dateOfBirth)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
            PhoneNumber = phoneNumber;
            //PatientAddress =new Address(PatientAddress);
            DateOfBirth = dateOfBirth;
            MedicalRecord = new List<DoctorVisit>();

            List<Medicine> medicines = new List<Medicine>();
            medicines.Add(new Medicine(123, "yitzchak", "ravitz", "hh", new DateTime(2 / 4 / 2004)));
            Medicines = medicines;
        }
       
        public Patient(int id, string fname, string lname, int phoneNumber, /*Address PatientAddress,*/ DateTime dateOfBirth, List<DoctorVisit> medicalRecord)
        {
            Id = id;
            Fname = fname;
            Lname = lname;
            PhoneNumber = phoneNumber;
            //PatientAddress =new Address(PatientAddress);/
            DateOfBirth = dateOfBirth;
            MedicalRecord =medicalRecord;
            Medicines = new List<Medicine>();

        }
        public Patient()
        {
        }
    }
}
