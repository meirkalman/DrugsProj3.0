using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DoctorVisit
    {
        
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        //public string PatientName { get; set; }
        public string Description { get; set; }
       // public List<Medicine> Medicines { get; set; }
        public DateTime Date { get; set; }

        public DoctorVisit(int id, int doctorId, int patientId, string description, DateTime date)
        {
            Id = id;
            DoctorId = doctorId;
            PatientId = patientId;
            Description = description;
            Date = date;
        }
        public DoctorVisit()
        {

        }
    }
}
