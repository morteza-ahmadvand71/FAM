using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class EmployeesService:Generic<tabEmployees>,IEmployees
    {
        public EmployeesService(DbContext db) : base(db)
        {
        }
    }
}
