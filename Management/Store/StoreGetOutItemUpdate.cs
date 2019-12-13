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
    public partial class StoreGetOutItemUpdate : Form
    {
        public StoreGetOutItem sgoiUpdate;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;

        public StoreGetOutItemUpdate()
        {
            InitializeComponent();

            this.sgoiUpdate = new StoreGetOutItem();
        }

        private void StoreGetOutItemUpdate_Load(object sender, EventArgs e)
        {
            this.cbActionType.DataSource = Enum.GetValues(typeof(ActionType));

            this.tbAmount.Text = this.sgoiUpdate.dobStuffAmount.ToString();
            this.tbStoreGetOutNumber.Text = this.sgoiUpdate.intStoreGetOutNumber.ToString();
            this.labStuff.Text = StoreCode.GetNameByStoreCode(this.cnConnection,this.sgoiUpdate.strStuffStoreCode);
            this.cbActionType.SelectedIndex = --this.sgoiUpdate.intTechnicalActionType;

            SetEnableBtmOk();
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.btmOK.Enabled = false;

            this.sgoiUpdate.dobStuffAmount = double.Parse(this.tbAmount.Text.Trim());
            this.sgoiUpdate.intStoreGetOutNumber = int.Parse(this.tbStoreGetOutNumber.Text.Trim());
            this.sgoiUpdate.intTechnicalActionType = this.cbActionType.SelectedIndex + 1;
            this.sgoiUpdate.Update(this.cnConnection);

            StoreGetOutItems frmStoreGetOutItems = (StoreGetOutItems)this.Owner;
            frmStoreGetOutItems.SearchRequestItems();

            this.Close();
        }

        private void SetEnableBtmOk()
        {
            if (this.tbAmount.Text.Trim().Length != 0 && this.sgoiUpdate.strStuffStoreCode.Length != 0 &&
                this.tbStoreGetOutNumber.Text.Trim().Length != 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbAmount_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void ButStuff_Click(object sender, EventArgs e)
        {
            SelectStuff frmSelectStuff = new SelectStuff();
            frmSelectStuff.Owner = this;
            frmSelectStuff.cnConnection = this.cnConnection;
            frmSelectStuff.setSettings = this.setSettings;
            frmSelectStuff.usUser = this.usUser;
            frmSelectStuff.ShowDialog();
            if(SelectStuff.strStuffStoreCode.Length != 0 )
            {
                this.sgoiUpdate.strStuffStoreCode = SelectStuff.strStuffStoreCode;
                this.labStuff.Text = SelectStuff.strStuffName;
            }

            SetEnableBtmOk();
        }
    }
}
