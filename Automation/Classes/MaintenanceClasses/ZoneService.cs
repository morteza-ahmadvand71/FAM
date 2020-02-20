using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class ZoneService:Generic<tabZones>,IZone
    {
        public ZoneService(DbContext db) : base(db)
        {
        }

        public List<tabZones> ListZones(string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (filter == "")
                {
                    return db.Zone.GetAll().ToList();
                }

                return db.Zone.GetAll().Where(t => t.nvcName.Contains(filter)).ToList();
            }
        }
    }
}
