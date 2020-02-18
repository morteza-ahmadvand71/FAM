using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class Name : Generic<tabName>, IName
    {
        public Name(DbContext db) : base(db)
        {
        }

        public List<tabName> ListNames(int categoryId, string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (filter == "")
                {
                    return db.Name.GetAll().Where(t => t.intCategory == categoryId).ToList();
                }

                return db.Name.GetAll().Where(t => t.nvcName.Contains(filter) && t.intCategory == categoryId).ToList();
            }
        }
    }
}
