using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Tools
{
    public class ControlManage : IControlManage
    {
        public Patient Patient { get; set; }
        public User User { get; set; }

        public ControlManage()
        {

        }
        public ControlManage(Patient patient, User user)
        {
            Patient = patient;
            User = user;
        }
    }
}
