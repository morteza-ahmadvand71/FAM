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
    public partial class InvoiceInsert : Form
    {
        public Invoice invInsert = new Invoice();
        public Connection cnConnection;
        public FamSetting setSettings;
        public User usUser;

        public InvoiceInsert()
        {
            InitializeComponent();
        }

        private void InvoiceInsert_Load(object sender, EventArgs e)
        {
          
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.btmOK.Enabled = false;
            if(this.tbInvoiceNumberofVendor.Text.Trim() != "")
            {
                this.invInsert.intInvoiceNumberofVendor = int.Parse(this.tbInvoiceNumberofVendor.Text);
            }
            this.invInsert.dtDate = this.dtpDate.Value;

            invInsert.Insert(this.cnConnection);

            Invoices frmInvoices = (Invoices)this.Owner;
            frmInvoices.SearchInvoices();
            this.Close();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButVendor_Click(object sender, EventArgs e)
        {
            SelectVendor frmSelectVendor = new SelectVendor();
            frmSelectVendor.Owner = this;
            frmSelectVendor.cnConnection = this.cnConnection;
            frmSelectVendor.setSettings = this.setSettings;
            frmSelectVendor.usUser = this.usUser;
            frmSelectVendor.ShowDialog();
            if(SelectVendor.intNumberSelectedVendor != 0)
            {
                this.invInsert.intVendorNumber = SelectVendor.intNumberSelectedVendor;
                this.labVendor.Text = SelectVendor.strNameSelectedVendor;
            }
            
            SetEnableBtmInsert();
        }

        private void ButEmployee_Click(object sender, EventArgs e)
        {
            SelectEmployee frmSelectEmployee = new SelectEmployee();
            frmSelectEmployee.Owner = this;
            frmSelectEmployee.cnConnection = this.cnConnection;
            frmSelectEmployee.setSettings = this.setSettings;
            frmSelectEmployee.usUser = this.usUser;
            frmSelectEmployee.ShowDialog();
            if (SelectEmployee.strCoID != "")
            {
                this.invInsert.strBuyerCoID = SelectEmployee.strCoID;
                this.labEmployee.Text = SelectEmployee.strEmployeeName;
            }
            
            SetEnableBtmInsert();
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

        private void SetEnableBtmInsert()
        {
            if (this.invInsert.intVendorNumber != 0 && this.invInsert.strBuyerCoID.Length != 0)
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
            SetEnableBtmInsert();
        }

        private void TbInvoiceNumberofVendor_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmInsert();
        }
    }
}
