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
    public partial class StoreGetOutItemInsert : Form
    {
        public StoreGetOutItem sgoiInsert;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;

        public StoreGetOutItemInsert()
        {
            InitializeComponent();

            this.sgoiInsert = new StoreGetOutItem();
        }

        private void RequestItemInsert_Load(object sender, EventArgs e)
        {
            this.cbActionType.DataSource = Enum.GetValues(typeof(ActionType));
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.btmOK.Enabled = false;

            this.sgoiInsert.dobStuffAmount = double.Parse(this.tbAmount.Text.Trim());
            this.sgoiInsert.intTechnicalActionType = ++this.cbActionType.SelectedIndex;
            this.sgoiInsert.Insert(this.cnConnection);

            StoreGetOutItems frmStoreGetOutItems = (StoreGetOutItems)this.Owner;
            frmStoreGetOutItems.SearchRequestItems();

            this.Close();
        }

        private void SetEnableBtmOk()
        {
            if (this.tbAmount.Text.Trim().Length != 0 && this.sgoiInsert.strStuffStoreCode.Length != 0)
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
                this.sgoiInsert.strStuffStoreCode = SelectStuff.strStuffStoreCode;
                this.labStuff.Text = SelectStuff.strStuffName;
            }

            SetEnableBtmOk();
        }
    }
}
