using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class SubBranch:Generic<tabSubBranch>,ISubBranch
    {
        public SubBranch(DbContext db) : base(db)
        {
        }

        public List<tabSubBranch> ListSubBranches(int branchId, string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (filter == "")
                {
                    return db.SubBranch.GetAll().Where(t => t.intBranch == branchId).ToList();
                }

                return db.SubBranch.GetAll().Where(t => t.nvcName.Contains(filter) && t.intBranch == branchId).ToList();
            }
        }
    }
}
