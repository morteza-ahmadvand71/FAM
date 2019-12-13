using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Finance;
using Baran.Ferroalloy.Maintenance;
using Baran.Ferroalloy.Management.Finance;
using Baran.Ferroalloy.Office;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Management
{
    public partial class Invoices : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public FamSetting setSettings;
        public User usUser;
        public DataSet dsInvoices;
        public Invoice InvSearch;
        private Invoice InvUpdate;
        private bool bolEnableBtmSearchByInterface;
        private bool bolEnableBtmSearchByPermision;
        private bool bolEnableBtmDeleteByInterface;
        private bool bolEnableBtmDeleteByPermision;
        private bool bolEnableBtmInsertByInterface;
        private bool bolEnableBtmInsertByPermision;

        public Invoices()
        {
            InitializeComponent();

            this.InvSearch = new Invoice();

            bolIsRunning = true;
            this.bolEnableBtmSearchByInterface = false;
            this.bolEnableBtmSearchByPermision = false;
            this.bolEnableBtmDeleteByInterface = false;
            this.bolEnableBtmDeleteByPermision = false;
            this.bolEnableBtmInsertByInterface = true;
            this.bolEnableBtmInsertByPermision = false;
        }

        private void Vendors_Load(object sender, EventArgs e)
        {
            SetComponentsByPermisions();
        }

        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolFinanceEnabed)
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = true;
                this.bolEnableBtmInsertByPermision = true;
                this.dgvInvoices.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoices_CellMouseDoubleClick);
                this.dgvInvoices.Columns["bitSelect"].Visible = true;
            }
            else
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = false;
                this.bolEnableBtmInsertByPermision = false;
                this.dgvInvoices.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoices_CellMouseDoubleClick);
                this.dgvInvoices.Columns["bitSelect"].Visible = false;
            }

            SetEnableComponents();
        }

        private void SetEnableComponents()
        {
            this.btmSearch.Enabled = this.bolEnableBtmSearchByPermision & this.bolEnableBtmSearchByInterface;
            this.btmDelete.Enabled = this.bolEnableBtmDeleteByPermision & this.bolEnableBtmDeleteByInterface;
            this.btmInsert.Enabled = this.bolEnableBtmInsertByPermision & this.bolEnableBtmInsertByInterface;
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vendors_FormClosing(object sender, FormClosingEventArgs e)
        {
            bolIsRunning = false;

            Management frmManagement = (Management)this.MdiParent;
            frmManagement.menWindows.DropDownItems["menWindowsInvoices"].Dispose();

        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            this.btmSearch.Enabled = false;
            SearchInvoices();
            this.btmSearch.Enabled = true;
        }

        public void SearchInvoices()
        {
            this.InvSearch = new Invoice();
            DateTime dtFromLoc = new DateTime();
            DateTime dtToLoc = new DateTime();

            if(this.tbNumber.Text.Trim().Length != 0)
            {
                this.InvSearch.intNumber = int.Parse(this.tbNumber.Text.Trim());
            }
            if (this.tbInvoiceNumberofVendor.Text.Trim().Length != 0)
            {
                this.InvSearch.intInvoiceNumberofVendor = int.Parse(this.tbInvoiceNumberofVendor.Text.Trim());
            }
            if (this.cbDate.Checked)
            {
                dtFromLoc = this.dtpFrom.Value;
                dtToLoc = this.dtpTo.Value;
            }
            this.InvSearch.intVendorNumber = SelectVendor.intNumberSelectedVendor;

            this.dsInvoices = Invoice.GetInvoices(this.cnConnection, this.InvSearch, dtFromLoc, dtToLoc);

            this.dgvInvoices.DataSource = this.dsInvoices;
            this.dgvInvoices.DataMember = "tabInvoices";

            for(int i=0;i< this.dgvInvoices.Rows.Count;i++)
            {
                this.dgvInvoices.Rows[i].Cells["nvcVendorName"].Value = Vendor.GetNameByNumber(this.cnConnection,
                    (int)this.dsInvoices.Tables["tabInvoices"].Rows[i]["intVendorNumber"]);

                this.dgvInvoices.Rows[i].Cells["nvcBuyerCoIDByName"].Value =
                    Employee.GetNameByCoID(this.cnConnection, this.dsInvoices.Tables["tabInvoices"].Rows[i]["nvcBuyerCoID"].ToString());

                InvoiceItem iiSearchLoc = new InvoiceItem();
                iiSearchLoc.intInvoiceNumber = (int)this.dsInvoices.Tables["tabInvoices"].Rows[i]["intNumber"];
                DataSet dsInvoiceItemsLoc = InvoiceItem.GetInvoiceItems(this.cnConnection, iiSearchLoc);
                double dobTotalCostLoc = 0;
                for (int j=0;j<dsInvoiceItemsLoc.Tables["tabInvoiceItems"].Rows.Count;j++)
                {
                    dobTotalCostLoc += (double)dsInvoiceItemsLoc.Tables["tabInvoiceItems"].Rows[j]["floAmount"] *
                        (double)dsInvoiceItemsLoc.Tables["tabInvoiceItems"].Rows[j]["floPrice"];
                }
                this.dgvInvoices.Rows[i].Cells["floTotalCost"].Value = dobTotalCostLoc.ToString();
            }
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            Int16 intSelectedInvoices = 0;
            foreach (DataRow drVendor in this.dsInvoices.Tables["tabInvoices"].Rows)
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
                    this.btmDelete.Enabled = false;
                    Invoice.DeleteVendors(this.cnConnection, this.dsInvoices);
                    SearchInvoices();
                    this.btmDelete.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(".هیچ فاکتوری انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void dgvInvoices_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.InvUpdate = new Invoice();

            InvoiceUpdate frmInvoiceUpdate = new InvoiceUpdate();
            frmInvoiceUpdate.Owner = this;
            frmInvoiceUpdate.invUpdate = this.InvUpdate;
            frmInvoiceUpdate.cnConnection = this.cnConnection;
            frmInvoiceUpdate.setSettings = this.setSettings;
            frmInvoiceUpdate.usUser = this.usUser;

            this.InvUpdate.intID = (int)this.dsInvoices.Tables["tabInvoices"].Rows[e.RowIndex]["intID"];
            this.InvUpdate.intNumber = (int)this.dsInvoices.Tables["tabInvoices"].Rows[e.RowIndex]["intNumber"];
            this.InvUpdate.intInvoiceNumberofVendor = (int)this.dsInvoices.Tables["tabInvoices"].Rows[e.RowIndex]["intInvoiceNumberofVendor"];
            this.InvUpdate.intVendorNumber = (int)this.dsInvoices.Tables["tabInvoices"].Rows[e.RowIndex]["intVendorNumber"];
            this.InvUpdate.strBuyerCoID = this.dsInvoices.Tables["tabInvoices"].Rows[e.RowIndex]["nvcBuyerCoID"].ToString();
            this.InvUpdate.dtDate = (DateTime)this.dsInvoices.Tables["tabInvoices"].Rows[e.RowIndex]["datDate"];
         
            frmInvoiceUpdate.ShowDialog();
        }

        private void btmInsert_Click(object sender, EventArgs e)
        {
            this.btmInsert.Enabled = false;
            InvoiceInsert frmInvoiceInsert = new InvoiceInsert();
            frmInvoiceInsert.Owner = this;
            frmInvoiceInsert.cnConnection = this.cnConnection;
            frmInvoiceInsert.setSettings = this.setSettings;
            frmInvoiceInsert.usUser = this.usUser;
            frmInvoiceInsert.ShowDialog();
            this.btmInsert.Enabled = true;
        }

        private void BtmInsertInvoiceItems_Click(object sender, EventArgs e)
        {
            if (this.dgvInvoices.SelectedRows.Count != 0)
            {
                this.btmInvoiceItems.Enabled = false;
                InvoiceItems frmInvoiceItems = new InvoiceItems();
                frmInvoiceItems.iiSearch.intInvoiceNumber = (int)this.dgvInvoices.SelectedRows[0].Cells["intNumber"].Value;
                frmInvoiceItems.invInvoice.intNumber = (int)this.dgvInvoices.SelectedRows[0].Cells["intNumber"].Value;
                frmInvoiceItems.invInvoice.intVendorNumber = (int)this.dgvInvoices.SelectedRows[0].Cells["intVendorNumber"].Value;
                frmInvoiceItems.invInvoice.dtDate = (DateTime)this.dgvInvoices.SelectedRows[0].Cells["datDate"].Value;

                frmInvoiceItems.cnConnection = this.cnConnection;
                frmInvoiceItems.Owner = this;
                frmInvoiceItems.usUser = this.usUser;
                frmInvoiceItems.setSettings = this.setSettings;
                frmInvoiceItems.ShowDialog();
                this.btmInvoiceItems.Enabled = true;
            }
        }

        private void ButVendor_Click(object sender, EventArgs e)
        {
            SelectVendor frmSelectVendor = new SelectVendor();
            frmSelectVendor.Owner = this;
            frmSelectVendor.cnConnection = this.cnConnection;
            frmSelectVendor.setSettings = this.setSettings;
            frmSelectVendor.usUser = this.usUser;
            frmSelectVendor.ShowDialog();
           
            this.labVendor.Text = SelectVendor.strNameSelectedVendor;

            SetEnableBtmSearch();
        }

        private void CbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbDate.Checked)
            {
                this.dtpFrom.Enabled = true;
                this.labFromDate.Enabled = true;
                this.dtpTo.Enabled = true;
                this.labToDate.Enabled = true;
            }
            else
            {
                this.dtpFrom.Enabled = false;
                this.labFromDate.Enabled = false;
                this.dtpTo.Enabled = false;
                this.labToDate.Enabled = false;
            }

            SetEnableBtmSearch();
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

        private void SetEnableBtmSearch()
        {
            if (this.tbNumber.Text.Trim().Length != 0 || this.tbInvoiceNumberofVendor.Text.Trim().Length != 0 ||
                this.cbDate.Checked || SelectVendor.intNumberSelectedVendor != 0)
            {
                this.bolEnableBtmSearchByInterface = true;
            }
            else
            {
                this.bolEnableBtmSearchByInterface = false;
            }

            SetEnableComponents();
        }

        private void dgvInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvInvoices.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgvInvoices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.bolEnableBtmDeleteByInterface = false;

            for (int i = 0; i < this.dgvInvoices.Rows.Count; i++)
            {
                if ((bool)this.dgvInvoices.Rows[i].Cells["bitSelect"].Value)
                {
                    this.bolEnableBtmDeleteByInterface = true;
                }
            }

            SetEnableComponents();
        }

        private void DgvInvoices_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex == -1)
            {
                string strInvoiceImagePathPathLoc =
                String.Format(@"{0}\{1}.jpg", this.setSettings.strInvoiceImagesPath, (int)this.dgvInvoices.SelectedRows[0].Cells["intNumber"].Value);

                this.btmInvoiceItems.Enabled = true;
                if (File.Exists(strInvoiceImagePathPathLoc))
                {
                    this.btmInvoiceImage.Enabled = true;
                }
            }
            else
            {
                this.btmInvoiceItems.Enabled = false;
                this.btmInvoiceImage.Enabled = false;
            }
        }

        private void TbNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void TbInvoiceNumberofVendor_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void DgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvInvoices.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void DgvEmployees_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.bolEnableBtmDeleteByInterface = false;

            for (int i = 0; i < this.dgvInvoices.Rows.Count; i++)
            {
                if ((bool)this.dgvInvoices.Rows[i].Cells["bitSelect"].Value)
                {
                    this.bolEnableBtmDeleteByInterface = true;
                }
            }

            SetEnableComponents();
        }

        private void DgvInvoices_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgvInvoices.Rows.Count; i++)
            {
                this.dgvInvoices.Rows[i].Cells["nvcVendorName"].Value = Vendor.GetNameByNumber(this.cnConnection,
                    (int)this.dsInvoices.Tables["tabInvoices"].Rows[i]["intVendorNumber"]);

                this.dgvInvoices.Rows[i].Cells["nvcBuyerCoIDByName"].Value =
                    Employee.GetNameByCoID(this.cnConnection, this.dsInvoices.Tables["tabInvoices"].Rows[i]["nvcBuyerCoID"].ToString());
            }
        }

        private void BtmInvoiceImage_Click(object sender, EventArgs e)
        {
            string strInvoiceImagePathPathLoc = 
                String.Format(@"{0}\{1}.jpg",this.setSettings.strInvoiceImagesPath,(int)this.dgvInvoices.SelectedRows[0].Cells["intNumber"].Value);
           
            if (File.Exists(strInvoiceImagePathPathLoc))
            {
                this.btmInvoiceImage.Enabled = false;
                InvoiceImage frmFactor = new InvoiceImage();
                frmFactor.Owner = this;
                frmFactor.strInvoiceImagePath = strInvoiceImagePathPathLoc;
                frmFactor.ShowDialog();
                this.btmInvoiceImage.Enabled = true;
            }
        }
    }
}
