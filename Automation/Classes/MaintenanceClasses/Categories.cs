using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;


namespace Baran.Ferroalloy.Automation
{
    public class Categories : Generic<tabCategories>, ICategories
    {
        public Categories(DbContext db) : base(db)
        {
        }

        public List<tabCategories> ListCategories(string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (filter == "")
                {
                    return db.Categories.GetAll().ToList();
                }

                return db.Categories.GetAll().Where(t => t.nvcName.Contains(filter)).ToList();
            }
        }
    }
}
