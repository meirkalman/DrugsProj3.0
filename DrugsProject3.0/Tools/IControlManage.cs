using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugsProject3._0.Tools
{
    public interface IControlManage
    {
     //   Patient GetPatient();
        User User { get; set; }
        Patient Patient { get; set; }
    }
}
