using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;


namespace Baran.Ferroalloy.Automation
{
    public class UnitOfWork : IDisposable
    {
        dbAfrzEntities db = new dbAfrzEntities();
        private IParts _parts;
        private ICategories _categories;
        private IStore _stores;
        private IName _name;
        private IBranch _branch;
        private ISubBranch _subBranch;
        private IMeasurementUnits _measurementUnits;
        private IProperties _properties;
        private IShift _shift;
        private IDepartment _department;
        private ISubDepartment _subDepartment;
        private IMaintenanceItem _maintenanceItem;
        private IMaintenanceParts _maintenanceParts;
        private IEmployees _employees;
        private IMaintenance _maintenance;
        private IZone _zone;
        private ISubZone _subZone;
        private IEquipName _equipName;
        private IEquip _equip;

        public IParts Parts
        {
            get
            {
                if (_parts == null)
                {
                    _parts = new Parts(db);
                }
                return _parts;
            }
        }

        public ICategories Categories
        {
            get
            {
                if (_categories == null)
                {
                    _categories=new Categories(db);
                }

                return _categories;
            }
        }

        public IStore Stores
        {
            get
            {
                if (_stores == null)
                {
                    _stores=new Store(db);
                }

                return _stores;
            }
        }

        public IName Name
        {
            get
            {
                if (_name == null)
                {
                    _name=new Name(db);
                }

                return _name;
            }
        }

        public IBranch Branch
        {
            get
            {
                if (_branch == null)
                {
                    _branch=new Branch(db);
                }

                return _branch;
            }
        }

        public ISubBranch SubBranch
        {
            get
            {
                if (_subBranch == null)
                {
                    _subBranch=new SubBranch(db);
                }

                return _subBranch;
            }
        }

        public IMeasurementUnits MeasurementUnits
        {
            get
            {
                if (_measurementUnits == null)
                {
                    _measurementUnits=new MeasurementUnits(db);
                }

                return _measurementUnits;
            }
        }

        public IProperties properties
        {
            get
            {
                if (_properties == null)
                {
                    _properties=new Properties(db);
                }

                return _properties;
            }
        }

        public IShift shift
        {
            get
            {
                if (_shift == null)
                {
                    _shift=new Shift(db);
                }

                return _shift;
            }
        }

        public IDepartment department
        {
            get
            {
                if (_department == null)
                {
                    _department=new DepartmentService(db);
                }

                return _department;
            }
        }

        public ISubDepartment subDepartment
        {
            get
            {
                if (_subDepartment == null)
                {
                    _subDepartment=new SubDepartmentService(db);
                }

                return _subDepartment;
            }
        }

        public IMaintenanceItem MaintenanceItem
        {
            get
            {
                if (_maintenanceItem == null)
                {
                    _maintenanceItem=new MaintenanceItemsService(db);
                }

                return _maintenanceItem;
            }
        }

        public IMaintenanceParts MaintenanceParts
        {
            get
            {
                if (_maintenanceParts == null)
                {
                    _maintenanceParts=new MaintenancePartsService(db);
                }

                return _maintenanceParts;
            }
        }

        public IEmployees Employees
        {
            get
            {
                if (_employees == null)
                {
                    _employees = new EmployeesService(db);
                }

                return _employees;
            }
            
        }

        public IMaintenance Maintenance
        {
            get
            {
                if (_maintenance == null)
                {
                    _maintenance=new MaintenanceService(db);
                }

                return _maintenance;
            }
        }

        public IZone Zone
        {
            get
            {
                if (_zone == null)
                {
                    _zone=new ZoneService(db);
                }

                return _zone;
            }
        }

        public ISubZone SubZone
        {
            get
            {
                if (_subZone == null)
                {
                    _subZone=new SubZoneService(db);
                }

                return _subZone;
            }
        }

        public IEquipName EquipName
        {
            get
            {
                if (_equipName == null)
                {
                    _equipName=new EquipNameService(db);
                }

                return _equipName;
            }
        }

        public IEquip Equip
        {
            get
            {
                if (_equip == null)
                {
                    _equip=new EquipService(db);
                }

                return _equip;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
