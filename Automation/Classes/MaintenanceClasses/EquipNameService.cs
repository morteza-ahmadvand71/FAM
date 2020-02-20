using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class EquipNameService:Generic<tabEquipName>,IEquipName
    {
        public EquipNameService(DbContext db) : base(db)
        {
        }

        public List<tabEquipName> ListEquipNames(int categoryId, string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (filter == "")
                {
                    return db.EquipName.GetAll().Where(t => t.intCategory == categoryId).ToList();
                }

                return db.EquipName.GetAll().Where(t => t.nvcName.Contains(filter) && t.intCategory == categoryId).ToList();
            }
        }
    }
}
