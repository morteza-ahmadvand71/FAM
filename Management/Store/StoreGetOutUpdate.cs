using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Finance;
using Baran.Ferroalloy.Maintenance;
using Baran.Ferroalloy.Office;
using Baran.Ferroalloy.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Management
{
    public partial class StoreGetOutUpdate : Form
    {
        public StoreGetOut sgoUpdate;
        public Connection cnConnection;
        public FamSetting setSettings;
        public User usLogined;
        public Employee emLogined;
        private Employee emUpdate;

        public StoreGetOutUpdate()
        {
            InitializeComponent();

            this.sgoUpdate = new StoreGetOut();
        }

        private void RequestInsert_Load(object sender, EventArgs e)
        {
            this.emUpdate = Employee.GetByCoID(this.cnConnection, this.sgoUpdate.strRequesterCoID);

            this.tbNumber.Text = this.sgoUpdate.intNumber.ToString();
            this.tbGroupNumber.Text = this.sgoUpdate.intGroupNumber.ToString();
            this.labRequester.Text = this.emUpdate.strName;
            this.labDepartment.Text = Department.GetNameByNumber(this.cnConnection, this.emUpdate.intDepartment);

            SubDepartment sdSubDepartment = new SubDepartment();
            sdSubDepartment.intDepartmnt = this.emUpdate.intDepartment;
            sdSubDepartment.intNumber = this.emUpdate.intSubDepartment;
            this.labSubDepartment.Text = SubDepartment.GetNameByNumber(this.cnConnection, sdSubDepartment);
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.btmOK.Enabled = false;

            this.sgoUpdate.dtDate = this.dtpDate.Value;
            this.sgoUpdate.intGroupNumber = int.Parse(this.tbGroupNumber.Text.Trim());
            this.sgoUpdate.intNumber = int.Parse(this.tbNumber.Text.Trim());
            
            this.sgoUpdate.Update(this.cnConnection);

            StoreGetOuts frmStoreGetOuts = (StoreGetOuts)this.Owner;
            frmStoreGetOuts.SearchRequests();
            this.Close();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetEnableBtmOk()
        {
            if (this.tbGroupNumber.Text.Trim().Length != 0 && this.tbNumber.Text.Trim().Length != 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void DtpDate_ValueChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbGroupNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }
    }
}
