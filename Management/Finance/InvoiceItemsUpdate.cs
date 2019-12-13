using Baran.Ferroalloy.Automation;
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
    public partial class InvoiceItemsUpdate : Form
    {
        public InvoiceItem iiUpdate;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        private double dblOrginalSupply;

        public InvoiceItemsUpdate()
        {
            InitializeComponent();

            this.iiUpdate = new InvoiceItem();
        }

        private void InvoiceUpdate_Load(object sender, EventArgs e)
        {
            this.dblOrginalSupply = this.iiUpdate.dblAmount;

            //Fill Controls with Part Properties          
            this.labRequest.Text = Request.GetNameByNumner(this.cnConnection, this.iiUpdate.intRequest);
            this.labStuff.Text = this.iiUpdate.strEquipStorecode;

            this.tbAmount.Text = this.iiUpdate.dblAmount.ToString();
            this.tbPrice.Text = this.iiUpdate.dblPrice.ToString();
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.btmOK.Enabled = false;

            double dblSumSupplyLoc = double.Parse(this.tbAmount.Text.Trim()) - this.dblOrginalSupply;
            this.iiUpdate.dblAmount = InvoiceItem.GetNewSupply(this.cnConnection, this.iiUpdate.strEquipStorecode, dblSumSupplyLoc);
            this.iiUpdate.dblPrice = double.Parse(this.tbPrice.Text.Trim());

            this.iiUpdate.Update(this.cnConnection);

            InvoiceItems frmInvoiceItems = (InvoiceItems)this.Owner;
            frmInvoiceItems.SearchInvoiceItems();
            this.Close();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetFarsiLanguageTextBoxes(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void SetNumbericCharsTextBoxes(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void SetEnableBtmOk(object sender, EventArgs e)
        {
            if (this.iiUpdate.strEquipStorecode.Length != 0 || this.tbAmount.Text.Trim().Length != 0 ||
                this.tbPrice.Text.Trim().Length != 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void ButRequest_Click(object sender, EventArgs e)
        {
            SelectRequest frmSelectRequest = new SelectRequest();
            frmSelectRequest.Owner = this;
            frmSelectRequest.cnConnection = this.cnConnection;
            frmSelectRequest.setSettings = this.setSettings;
            frmSelectRequest.usUser = this.usUser;
            frmSelectRequest.ShowDialog();
            this.iiUpdate.intRequest = SelectRequest.intRequestNumber;
            this.labRequest.Text = SelectRequest.strRequestName;

            SetEnableBtmOk(new object(), new EventArgs());
        }

        private void BtmStuff_Click(object sender, EventArgs e)
        {
            SelectStuff frmSelectStuff = new SelectStuff();
            frmSelectStuff.Owner = this;
            frmSelectStuff.cnConnection = this.cnConnection;
            frmSelectStuff.setSettings = this.setSettings;
            frmSelectStuff.usUser = this.usUser;
            frmSelectStuff.ShowDialog();

            if (SelectStuff.strStuffStoreCode != "")
            {
                this.iiUpdate.strEquipStorecode = SelectStuff.strStuffStoreCode;
                this.labStuff.Text = SelectStuff.strStuffName;
            }

            SetEnableBtmOk(new object(), new EventArgs());
        }
    }
}
