using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Automation.ViewModels
{
    public class ListMaintenancesViewModel
    {
        public string subDepartment { get; set; }
        public string shift { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
    }
}
