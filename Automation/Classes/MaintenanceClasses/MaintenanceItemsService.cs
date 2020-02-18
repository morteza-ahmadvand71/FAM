using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class MaintenanceItemsService : Generic<tabMaintenanceItems>, IMaintenanceItem
    {
        private dbAfrzEntities _db;
        public MaintenanceItemsService(DbContext db) : base(db)
        {
            _db = (dbAfrzEntities)db;
        }

        public List<tabMaintenanceItems> ListMaintenanceItems(int maintenanceId, string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (filter == "")
                {
                    return db.MaintenanceItem.Get(t => t.intMaintenance == maintenanceId).ToList();
                }

                return db.MaintenanceItem.GetAll().Where(t => t.intDuration.ToString().Contains(filter) ||
                                                              t.nvcEquip.Contains(filter) || t.nvcCoIdsWorker.Contains(filter) ||
                                                              t.timItem.ToString().Contains(filter)).ToList();
            }
        }
    }
}
