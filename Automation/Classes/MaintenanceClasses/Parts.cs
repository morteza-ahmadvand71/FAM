using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class Parts : Generic<tabParts>, IParts

    {
        private dbAfrzEntities _db;
        public Parts(DbContext db) : base(db)
        {
            _db = (dbAfrzEntities) db;
        }

        public List<dgvListStoresViewModel> ListParts(string filter = "")
        {
            if (filter == "")
            {

                return _db.tabParts.Select(t=>new dgvListStoresViewModel()
                {
                    intID = t.intID,
                    intNumber =t.intStore + "" + t.intCategory + "" + t.intName + "" + t.intBranch + "" + t.intSubBranch,
                    namePart = t.tabName.nvcName + " " + t.tabBranch.nvcName + " " + t.tabSubBranch.nvcName
                }).ToList();
            }

            
            var parts = _db.tabParts.ToList();
            List<dgvListStoresViewModel> list = new List<dgvListStoresViewModel>();
            foreach (var item in parts)
            {

                list.Add(new dgvListStoresViewModel()
                {
                    intID = item.intID,
                    intNumber = item.intStore + "" + item.intCategory + "" + item.intName + "" + item.intBranch + "" + item.intSubBranch,
                    namePart = item.tabName.nvcName + " " + item.tabBranch.nvcName + " " + item.tabSubBranch.nvcName
                });
            }

            return list.Where(t=>t.namePart.Contains(filter)).ToList();
        }
    }
}
