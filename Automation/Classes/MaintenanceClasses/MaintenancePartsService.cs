using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class MaintenancePartsService : Generic<tabMaintenanceParts>, IMaintenanceParts
    {
        private dbAfrzEntities _db;
        public MaintenancePartsService(DbContext db) : base(db)
        {
            _db = (dbAfrzEntities)db;
        }

        public List<tabMaintenanceParts> ListMaintenanceParts(string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (filter == "")
                {
                    return db.MaintenanceParts.GetAll().ToList();
                }


                return db.MaintenanceParts.GetAll().Where(t => t.nvcPart.Contains(filter)).ToList();
            }
        }

        public List<dgvListMaintenancePartsViewModel> dgvListMaintenanceParts(int maiantenanceItemId, string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var name = "";
                var branch = "";
                var subBranch = "";
                var maintenancePartses = db.MaintenanceParts.Get(t => t.intMaintenanceItem == maiantenanceItemId).ToList();
                foreach (var item in maintenancePartses)
                {
                    var part = item.nvcPart.Split('-');
                    var nameId = Convert.ToInt32(part[2]);
                    var branchId = Convert.ToInt32(part[3]);
                    var subBranchId = Convert.ToInt32(part[4]);
                    name = db.Name.GetEntity(t => t.intNumber == nameId).nvcName;
                    branch = db.Branch.GetEntity(t => t.intNumber == branchId).nvcName;
                    subBranch = db.SubBranch.GetEntity(t => t.intNumber == subBranchId).nvcName;
                }
                if (filter == "")
                {
                    return _db.tabMaintenanceParts.Where(t => t.intMaintenanceItem == maiantenanceItemId).Select(t => new dgvListMaintenancePartsViewModel()
                    {
                        intID = t.intID,
                        maintenanceType = t.intMaintenaceType.ToString(),
                        count = t.intCount,
                        namePart = name + " " + branch + " " + subBranch
                    }).ToList();
                }

                List<dgvListMaintenancePartsViewModel> list = new List<dgvListMaintenancePartsViewModel>();
                foreach (var item in maintenancePartses)
                {

                    list.Add(new dgvListMaintenancePartsViewModel()
                    {
                        intID = item.intID,
                        maintenanceType = item.intMaintenaceType.ToString(),
                        count = item.intCount,
                        namePart = name + " " + branch + " " + subBranch
                    });
                }

                return list.Where(t => t.namePart.Contains(filter) || t.count.Equals(filter)).ToList();
            }
        }
    }
}
