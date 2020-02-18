using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Automation
{
    public class PartsViewModel
    {
        public int intID { get; set; }
        public string storeTitle { get; set; }
        public string categoryTitle { get; set; }
        public string nameTitle { get; set; }
        public string branchTitle { get; set; }
        public string subBranchTitle { get; set; }
        public string measurementUnitTitle { get; set; }
        public double? floOrderPoint { get; set; }
        public double? floSupply { get; set; }
    }
}
