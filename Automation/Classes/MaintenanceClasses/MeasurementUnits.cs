using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class MeasurementUnits:Generic<tabMeasurementUnits>,IMeasurementUnits
    {
        public MeasurementUnits(DbContext db) : base(db)
        {
        }

        public List<tabMeasurementUnits> ListMeasurementUnits(int categoryId, string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (filter == "")
                {
                    return db.MeasurementUnits.GetAll().Where(t => t.intCategory == categoryId).ToList();
                }

                return db.MeasurementUnits.GetAll().Where(t => t.nvcName.Contains(filter) && t.intCategory == categoryId).ToList();
            }
        }
    }
}
