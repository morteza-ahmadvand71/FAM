using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;


namespace Baran.Ferroalloy.Automation
{
    public interface ISubBranch:IGeneric<tabSubBranch>
    {
        List<tabSubBranch> ListSubBranches(int branchId, string filter = "");
    }
}
