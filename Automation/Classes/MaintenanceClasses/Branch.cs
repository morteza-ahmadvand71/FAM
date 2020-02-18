using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;


namespace Baran.Ferroalloy.Automation
{
    public class Branch:Generic<tabBranch>,IBranch
    {
        public Branch(DbContext db) : base(db)
        {
        }

        public List<tabBranch> ListBranches(int nameId, string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (filter == "")
                {
                    return db.Branch.GetAll().Where(t => t.intName == nameId).ToList();
                }

                return db.Branch.GetAll().Where(t => t.nvcName.Contains(filter) && t.intName == nameId).ToList();
            }
        }
    }
}
