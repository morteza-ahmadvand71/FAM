using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;


namespace Baran.Ferroalloy.Automation
{
    public class Store : Generic<tabStores>, IStore
    {
        public Store(DbContext db) : base(db)
        {
        }

        public List<tabStores> ListStores(string filter = "")
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                if (filter == "")
                {
                    return db.Stores.GetAll().ToList();
                }

                return db.Stores.GetAll().Where(t => t.nvcName.Contains(filter)).ToList();
            }
        }
    }
}
