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
    public partial class InvoiceUpdate : Form
    {
        public Invoice invUpdate;
        public Connection cnConnection;
        public FamSetting setSettings;
        public User usUser;

        public InvoiceUpdate()
        {
            InitializeComponent();

            this.invUpdate = new Invoice();
        }

        private void InvoiceUpdate_Load(object sender, EventArgs e)
        {
            //Fill Controls with Part Properties
            this.tbNumber.Text = this.invUpdate.intNumber.ToString();
            this.tbInvoiceNumberofVendor.Text = this.invUpdate.intInvoiceNumberofVendor.ToString();
            this.dtpDate.Value = this.invUpdate.dtDate;
            this.labVendor.Text = Vendor.GetNameByNumber(this.cnConnection,this.invUpdate.intVendorNumber);
            this.labEmployee.Text = Employee.GetNameByCoID(this.cnConnection,this.invUpdate.strBuyerCoID);
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            if(this.invUpdate.intNumber != int.Parse(this.tbNumber.Text.Trim()))
            {
                InvoiceItem iiSearchLoc = new InvoiceItem();
                InvoiceItem iiUpdateLoc = new InvoiceItem();

                iiSearchLoc.intInvoiceNumber = this.invUpdate.intNumber;
                DataSet dsInvoiceItemsLoc = InvoiceItem.GetInvoiceItems(this.cnConnection, iiSearchLoc);
                for(int i=0;i<dsInvoiceItemsLoc.Tables["tabInvoiceItems"].Rows.Count;i++)
                {
                    iiUpdateLoc.intID = (int)dsInvoiceItemsLoc.Tables["tabInvoiceItems"].Rows[i]["intID"];
                    iiUpdateLoc.intInvoiceNumber = int.Parse(this.tbNumber.Text.Trim());
                    iiUpdateLoc.intRequest = (int)dsInvoiceItemsLoc.Tables["tabInvoiceItems"].Rows[i]["intRequestNumber"];
                    iiUpdateLoc.strEquipStorecode = dsInvoiceItemsLoc.Tables["tabInvoiceItems"].Rows[i]["nvcStoreCode"].ToString();
                    iiUpdateLoc.dblAmount = (double)dsInvoiceItemsLoc.Tables["tabInvoiceItems"].Rows[i]["floAmount"];
                    iiUpdateLoc.dblPrice = (double)dsInvoiceItemsLoc.Tables["tabInvoiceItems"].Rows[i]["floPrice"];
                    iiUpdateLoc.Update(this.cnConnection);
                }
            }
            //this.invUpdate.strBuyerCoID = SelectEmployee.strCoID;
            //this.invUpdate.intVendorNumber = SelectVendor.intNumberSelectedVendor;
            this.invUpdate.intNumber = int.Parse(this.tbNumber.Text.Trim());
            this.invUpdate.intInvoiceNumberofVendor = int.Parse(this.tbInvoiceNumberofVendor.Text.Trim());
            this.invUpdate.dtDate = this.dtpDate.Value;
            this.invUpdate.Update(this.cnConnection);

            Invoices frmInvoices = (Invoices)this.Owner;
            frmInvoices.SearchInvoices();
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

        private void SetEnableBtmUpdate()
        {
            if ( this.invUpdate.intVendorNumber != 0 && this.invUpdate.strBuyerCoID.Length != 0
                 && this.tbNumber.Text.Trim().Length != 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void ButEmployee_Click(object sender, EventArgs e)
        {
            SelectEmployee frmSelectEmployee = new SelectEmployee();
            frmSelectEmployee.Owner = this;
            frmSelectEmployee.setSettings = this.setSettings;
            frmSelectEmployee.usUser = this.usUser;
            frmSelectEmployee.cnConnection = this.cnConnection;
            frmSelectEmployee.ShowDialog();

            if (SelectEmployee.strCoID != "")
            {
                this.invUpdate.strBuyerCoID = SelectEmployee.strCoID;
                this.labEmployee.Text = SelectEmployee.strEmployeeName;
            }

            SetEnableBtmUpdate();
        }

        private void ButVendor_Click(object sender, EventArgs e)
        {
            SelectVendor frmSelectVendor = new SelectVendor();
            frmSelectVendor.Owner = this;
            frmSelectVendor.setSettings = this.setSettings;
            frmSelectVendor.usUser = this.usUser;
            frmSelectVendor.cnConnection = this.cnConnection;
            frmSelectVendor.ShowDialog();

            if(SelectVendor.intNumberSelectedVendor != 0)
            {
                this.invUpdate.intVendorNumber = SelectVendor.intNumberSelectedVendor;
                this.labVendor.Text = SelectVendor.strNameSelectedVendor;
            }
            
            SetEnableBtmUpdate();
        }

        private void TbNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmUpdate();
        }

        private void TbInvoiceNumberofVendor_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmUpdate();
        }

        private void DtpDate_ValueChanged(object sender, EventArgs e)
        {
            SetEnableBtmUpdate();
        }
    }
}
