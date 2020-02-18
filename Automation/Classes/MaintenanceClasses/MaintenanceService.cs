using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;
using Baran.Ferroalloy.Automation.ViewModels;

namespace Baran.Ferroalloy.Automation
{
    public class MaintenanceService : Generic<tabMaintenances>, IMaintenance
    {
        private dbAfrzEntities _db;
        public MaintenanceService(DbContext db) : base(db)
        {
            _db = (dbAfrzEntities)db;
        }

        //public List<dgvMaintenanceViewModel> dgvMaintenanceList(string filter = "")
        //{
        //    var leaderWorker = "";
        //    var workers = "";
        //    var maintenances = _db.tabMaintenances.ToList();
        //    foreach (var item in maintenances)
        //    {
        //        var leader = _db.tabEmployees.FirstOrDefault(t => t.nvcCoID == item.nvcCoIdLeader);
        //        leaderWorker = leader.nvcFirstname + " " + leader.nvcLastname;
        //        var coIds = item.nvcCoIdsWorkGroup.Split('-');
        //        var coId = "";
        //        for (int i = 0; i < coIds.Length; i++)
        //        {
        //            coId = coIds[i];
        //            var coIdEmployee = _db.tabEmployees.FirstOrDefault(t => t.nvcCoID == coId);
        //            workers += coIdEmployee.nvcFirstname + " " + coIdEmployee.nvcLastname + "-";
        //        }

        //        workers = workers.Remove(workers.Length - 1);

        //    }
        //    if (filter == "")
        //    {
        //        return _db.tabMaintenances.Select(t => new dgvMaintenanceViewModel()
        //        {
        //            intID = t.intID,
        //            datWorkGroup = t.datWorkGroup.Date,
        //            leaderWorker = leaderWorker,
        //            nameDapartment = t.tabDepartments.nvcName,
        //            nameShift = t.tabShifts.nvcName,
        //            nameSubDepartment = t.tabSubDepartments.nvcName,
        //            workers = workers,
        //        }).ToList();
        //    }

        //}

    }
}
