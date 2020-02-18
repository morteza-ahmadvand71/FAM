using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Automation
{
    public class dgvMaintenanceViewModel
    {
        public int intID { get; set; }
        public DateTime datWorkGroup { get; set; }
        public string nameSubDepartment { get; set; }
        public string nameShift { get; set; }
        public string workers { get; set; }
        public string leaderWorker { get; set; }
    }
}
