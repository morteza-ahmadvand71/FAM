using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class SubZoneService:Generic<tabSubZones>,ISubZone
    {
        public SubZoneService(DbContext db) : base(db)
        {
        }
    }
}
