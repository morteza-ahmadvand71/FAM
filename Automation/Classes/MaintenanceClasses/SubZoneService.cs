using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class SubZoneService : Generic<tabSubZones>, ISubZone
    {
        public SubZoneService(DbContext db) : base(db)
        {
        }

        public List<tabSubZones> ListSubZones(int zoneId, string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (filter == "")
                {
                    return db.SubZone.GetAll().Where(t => t.intZone == zoneId).ToList();
                }

                return db.SubZone.GetAll().Where(t => t.nvcName.Contains(filter) && t.intZone == zoneId).ToList();
            }
        }
    }
}
