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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Management
{
    public partial class InvoiceItems : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public FamSetting setSettings;
        public User usUser;
        public Invoice invInvoice;
        public DataSet dsInvoiceItems;
        public InvoiceItem iiSearch;
        private InvoiceItem iiUpdate;
        private bool bolEnableBtmDeleteByInterface;
        private bool bolEnableBtmDeleteByPermision;
        private bool bolEnableBtmInsertByInterface;
        private bool bolEnableBtmInsertByPermision;
        private double dobTotalCost;

        public InvoiceItems()
        {
            InitializeComponent();

            this.bolEnableBtmDeleteByInterface = false;
            this.bolEnableBtmDeleteByPermision = false;
            this.bolEnableBtmInsertByInterface = true;
            this.bolEnableBtmInsertByPermision = false;
            this.iiSearch = new InvoiceItem();
            this.invInvoice = new Invoice();
            this.iiUpdate = new InvoiceItem();
            this.dobTotalCost = 0;
        }

        private void InvoiceItems_Load(object sender, EventArgs e)
        {
            SetComponentsByPermisions();

            this.labInvoiceNumber.Text = this.invInvoice.intNumber.ToString();
            this.labInvoiceDate.Text = this.invInvoice.dtDate.ToString("D");
            this.labVendor.Text = Vendor.GetNameByNumber(this.cnConnection,this.invInvoice.intVendorNumber);

            SearchInvoiceItems();
        }

        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolFinanceEnabed)
            {
                this.bolEnableBtmDeleteByPermision = true;
                this.bolEnableBtmInsertByPermision = true;
                this.dgvInvoiceItems.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoices_CellMouseDoubleClick);
                this.dgvInvoiceItems.Columns["bitSelect"].Visible = true;
            }
            else
            {
                this.bolEnableBtmDeleteByPermision = false;
                this.bolEnableBtmInsertByPermision = false;
                this.dgvInvoiceItems.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoices_CellMouseDoubleClick);
                this.dgvInvoiceItems.Columns["bitSelect"].Visible = false;
            }

            SetEnableComponents();
        }

        private void SetEnableComponents()
        {
            this.btmDelete.Enabled = this.bolEnableBtmDeleteByPermision & this.bolEnableBtmDeleteByInterface;
            this.btmInsert.Enabled = this.bolEnableBtmInsertByPermision & this.bolEnableBtmInsertByInterface;
        }

       

        private void InvoiceItems_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        public void SearchInvoiceItems()
        {
            this.dsInvoiceItems = InvoiceItem.GetInvoiceItems(this.cnConnection, this.iiSearch);

            this.dgvInvoiceItems.DataSource = this.dsInvoiceItems;
            this.dgvInvoiceItems.DataMember = "tabInvoiceItems";

            for (int i = 0; i < this.dsInvoiceItems.Tables["tabInvoiceItems"].Rows.Count; i++)
            {
                if ((int)this.dsInvoiceItems.Tables["tabInvoiceItems"].Rows[i]["intRequestNumber"] == -1)
                {
                    this.dgvInvoiceItems.Rows[i].Cells["intRequestNumberAsName"].Value = "بدون درخواست";
                }
                else
                {
                    this.dgvInvoiceItems.Rows[i].Cells["intRequestNumberAsName"].Value =
                   this.dsInvoiceItems.Tables["tabInvoiceItems"].Rows[i]["intRequestNumber"];
                }

                this.dgvInvoiceItems.Rows[i].Cells["nvcStoreCodeAsName"].Value =
                   StoreCode.GetMaterialTypeFromStoreCode(this.cnConnection, this.dsInvoiceItems.Tables["tabInvoiceItems"].Rows[i]["nvcStoreCode"].ToString());

                this.dobTotalCost += (double)this.dsInvoiceItems.Tables["tabInvoiceItems"].Rows[i]["floAmount"] *
                    (double)this.dsInvoiceItems.Tables["tabInvoiceItems"].Rows[i]["floPrice"];

                this.dgvInvoiceItems.Rows[i].Cells["floTotalCost"].Value =
                    (double)this.dsInvoiceItems.Tables["tabInvoiceItems"].Rows[i]["floAmount"] *
                    (double)this.dsInvoiceItems.Tables["tabInvoiceItems"].Rows[i]["floPrice"];
            }

            this.labTotalCost.Text = String.Format("{0:n0}",this.dobTotalCost);
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            Int16 intSelectedInvoices = 0;
            foreach (DataRow drVendor in this.dsInvoiceItems.Tables["tabInvoices"].Rows)
            {
                if ((Boolean)drVendor["bitSelect"])
                {
                    ++intSelectedInvoices;
                }
            }

            if (intSelectedInvoices > 0)
            {
                DialogResult dialogResult = MessageBox.Show("آیا می خواهید " + intSelectedInvoices.ToString() + " فاکتور را حذف کنید؟", "حذف", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Invoice.DeleteVendors(this.cnConnection, this.dsInvoiceItems);
                    SearchInvoiceItems();
                }
            }
            else
            {
                MessageBox.Show(".هیچ فاکتوری انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void dgvInvoices_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {   
            InvoiceItemsUpdate frmInvoiceUpdate = new InvoiceItemsUpdate();

            frmInvoiceUpdate.Owner = this;
            frmInvoiceUpdate.iiUpdate = this.iiUpdate;
            frmInvoiceUpdate.cnConnection = this.cnConnection;
            frmInvoiceUpdate.setSettings = this.setSettings;
            frmInvoiceUpdate.usUser = this.usUser;

            this.iiUpdate.intID = (int)this.dsInvoiceItems.Tables["tabInvoiceItems"].Rows[e.RowIndex]["intID"];
            this.iiUpdate.intInvoiceNumber = (int)this.dsInvoiceItems.Tables["tabInvoiceItems"].Rows[e.RowIndex]["intInvoiceNumber"];
            this.iiUpdate.strEquipStorecode = this.dsInvoiceItems.Tables["tabInvoiceItems"].Rows[e.RowIndex]["nvcStoreCode"].ToString();
            this.iiUpdate.intRequest = (int)this.dsInvoiceItems.Tables["tabInvoiceItems"].Rows[e.RowIndex]["intRequestNumber"];
            this.iiUpdate.dblAmount = (double)this.dsInvoiceItems.Tables["tabInvoiceItems"].Rows[e.RowIndex]["floAmount"];
            this.iiUpdate.dblPrice = (double)this.dsInvoiceItems.Tables["tabInvoiceItems"].Rows[e.RowIndex]["floPrice"];
         
            frmInvoiceUpdate.ShowDialog();
        }

        private void btmInsert_Click(object sender, EventArgs e)
        {
            InvoiceItemsInsert frmInvoiceItemsInsert = new InvoiceItemsInsert();
            frmInvoiceItemsInsert.Owner = this;
            frmInvoiceItemsInsert.cnConnection = this.cnConnection;
            frmInvoiceItemsInsert.ShowDialog();
        }

        private void BtmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtmInsert_Click(object sender, EventArgs e)
        {
            this.btmInsert.Enabled = false;
            InvoiceItemsInsert frmInvoiceItemsInsert = new InvoiceItemsInsert();
            frmInvoiceItemsInsert.Owner = this;
            frmInvoiceItemsInsert.cnConnection = this.cnConnection;
            frmInvoiceItemsInsert.setSettings = this.setSettings;
            frmInvoiceItemsInsert.usUser = this.usUser;
            frmInvoiceItemsInsert.iiInsert.intInvoiceNumber = this.invInvoice.intNumber;
            frmInvoiceItemsInsert.ShowDialog();
            this.btmInsert.Enabled = true;
        }

        private void BtmDelete_Click(object sender, EventArgs e)
        {
            Int16 intSelectedInvoiceItems = 0;
            foreach (DataRow drInvoiceItems in this.dsInvoiceItems.Tables["tabInvoiceItems"].Rows)
            {
                if ((Boolean)drInvoiceItems["bitSelect"])
                {
                    ++intSelectedInvoiceItems;
                }
            }

            if (intSelectedInvoiceItems > 0)
            {
                DialogResult dialogResult = MessageBox.Show("آیا می خواهید " + intSelectedInvoiceItems.ToString() + " آیتم را حذف کنید؟", "حذف", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.btmDelete.Enabled = false;
                    Invoice.DeleteVendors(this.cnConnection, this.dsInvoiceItems);
                    SearchInvoiceItems();
                    this.btmDelete.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(".هیچ آیتم انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvInvoiceItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgvInvoices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.bolEnableBtmDeleteByInterface = false;

            for (int i = 0; i < this.dgvInvoiceItems.Rows.Count; i++)
            {
                if ((bool)this.dgvInvoiceItems.Rows[i].Cells["bitSelect"].Value)
                {
                    this.bolEnableBtmDeleteByInterface = true;
                }
            }

            SetEnableComponents();
        }
    }
}
