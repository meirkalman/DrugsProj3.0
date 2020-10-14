using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DoctorVisit
    {

        public int Id { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public string Description { get; set; }
        public List<Medicine> Medicines { get; set; }
        public DateTime Date { get; set; }

        public DoctorVisit()
        {
            Id = 2;
        }

    }
}
