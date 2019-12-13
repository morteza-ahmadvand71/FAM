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
    public partial class StoreGetOutInsert : Form
    {
        public StoreGetOut sgoInsert;
        public Connection cnConnection;
        public FamSetting setSettings;
        public User usLogined;
        public Employee emLogined;

        public StoreGetOutInsert()
        {
            InitializeComponent();

            this.sgoInsert = new StoreGetOut();
        }

        private void RequestInsert_Load(object sender, EventArgs e)
        {
            

            this.labRequester.Text = this.emLogined.strName;
            this.labDepartment.Text = Department.GetNameByNumber(this.cnConnection, this.emLogined.intDepartment);
            SubDepartment sdSubDepartment = new SubDepartment();
            sdSubDepartment.intDepartmnt = this.emLogined.intDepartment;
            sdSubDepartment.intNumber = this.emLogined.intSubDepartment;
            this.labSubDepartment.Text = SubDepartment.GetNameByNumber(this.cnConnection, sdSubDepartment);
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.btmOK.Enabled = false;

            this.sgoInsert.dtDate = this.dtpDate.Value;
            this.sgoInsert.intGroupNumber = int.Parse(this.tbGroupNumber.Text.Trim());
            this.sgoInsert.strRequesterCoID = this.usLogined.strCoID;
            this.sgoInsert.intDepartment = this.emLogined.intDepartment;
            this.sgoInsert.intSubDepartment = this.emLogined.intSubDepartment;

            this.sgoInsert.Insert(this.cnConnection);

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
            if (this.tbGroupNumber.Text.Trim().Length != 0)
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
    }
}
