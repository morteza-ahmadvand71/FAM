using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Finance;
using Baran.Ferroalloy.Maintenance;
using Baran.Ferroalloy.Office;
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
    public partial class InvoiceItemsInsert : Form
    {
        public InvoiceItem iiInsert = new InvoiceItem();
        public Connection cnConnection;
        public FamSetting setSettings;
        public User usUser;

        public InvoiceItemsInsert()
        {
            InitializeComponent();
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.btmOK.Enabled = false;

            this.iiInsert.dblAmount = InvoiceItem.GetNewSupply(this.cnConnection,this.iiInsert.strEquipStorecode,double.Parse(this.tbAmount.Text.Trim()));
            this.iiInsert.dblPrice = double.Parse(this.tbPrice.Text.Trim());

            iiInsert.Insert(this.cnConnection);

            InvoiceItems frmInvoiceItems = (InvoiceItems)this.Owner;
            frmInvoiceItems.SearchInvoiceItems();
            this.Close();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButRequest_Click(object sender, EventArgs e)
        {
            SelectRequest frmSelectRequest = new SelectRequest();
            frmSelectRequest.Owner = this;
            frmSelectRequest.cnConnection = this.cnConnection;
            frmSelectRequest.setSettings = this.setSettings;
            frmSelectRequest.usUser = this.usUser;
            frmSelectRequest.ShowDialog();
            
            if(SelectRequest.intRequestNumber != 0)
            {
                this.iiInsert.intRequest = SelectRequest.intRequestNumber;
                this.labRequest.Text = SelectRequest.strRequestName;
            }
            
            SetEnableBtmOk();
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

        private void SetEnableBtmOk()
        {
            if (this.tbAmount.Text.Trim().Length != 0 && this.tbPrice.Text.Trim().Length != 0 && 
                this.iiInsert.intRequest != 0 && this.iiInsert.strEquipStorecode.Length != 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
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
                this.iiInsert.strEquipStorecode = SelectStuff.strStuffStoreCode;
                this.labStuff.Text = SelectStuff.strStuffName;
            }

            SetEnableBtmOk();
        }

        private void TbPrice_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbAmount_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }
    }
}
