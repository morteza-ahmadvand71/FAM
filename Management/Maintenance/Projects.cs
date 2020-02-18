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
    public partial class Projects : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        public DataSet dsProjects;
        private Project proSearch;
        private Project proUpdate;
        private Category[] caCategories;
        private bool bolEnableBtmSearchByInterface;
        private bool bolEnableBtmSearchByPermision;
        private bool bolEnableBtmDeleteByInterface;
        private bool bolEnableBtmDeleteByPermision;
        private bool bolEnableBtmInsertByInterface;
        private bool bolEnableBtmInsertByPermision;

        public Projects()
        {
            InitializeComponent();

            this.proSearch = new Project();
            this.proUpdate = new Project();

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

            //Fill cbCategory ComboBox
            this.caCategories = Category.GetCategories(this.cnConnection);
            this.cbCategory.Items.Add("");
            foreach (Category ctCategory in this.caCategories)
            {
                this.cbCategory.Items.Add(ctCategory.strName);
            }
        }

        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolTechnicalEnabed)
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = true;
                this.bolEnableBtmInsertByPermision = true;
                this.dgvProjects.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProjects_CellMouseDoubleClick);
                this.dgvProjects.Columns["bitSelect"].Visible = true;
            }
            else
            {
                this.bolEnableBtmSearchByPermision = true;
                this.bolEnableBtmDeleteByPermision = false;
                this.bolEnableBtmInsertByPermision = false;
                this.dgvProjects.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProjects_CellMouseDoubleClick);
                this.dgvProjects.Columns["bitSelect"].Visible = false;
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

        private void Projects_FormClosing(object sender, FormClosingEventArgs e)
        {
            bolIsRunning = false;

            Management frmManagement = (Management)this.MdiParent;
            frmManagement.menWindows.DropDownItems["menWindowsProjects"].Dispose();
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            this.btmSearch.Enabled = false;
            SearchProjects();
            this.btmSearch.Enabled = true;
        }

        public void SearchProjects()
        {
            if(this.tbNumber.Text.Trim().Length != 0)
            {
                this.proSearch.intNumber = int.Parse(this.tbNumber.Text.Trim());
            }

            this.proSearch.strName = this.tbName.Text;
            this.proSearch.strTip = this.tbTip.Text;
            this.proSearch.intCategory = this.caCategories[this.cbCategory.SelectedIndex-1].intNumber;

            this.dsProjects = Project.GetProjects(this.cnConnection, this.proSearch);

            this.dgvProjects.DataSource = this.dsProjects;
            this.dgvProjects.DataMember = "tabProjects";

            for (int i=0;i< this.dgvProjects.Rows.Count;i++)
            {
                this.dgvProjects.Rows[i].Cells["intCategoryAsName"].Value = 
                    Category.GetNameByNumber(this.cnConnection, (int)this.dgvProjects.Rows[i].Cells["intCategory"].Value);
            }
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            Int16 intSelectedProjects = 0;
            foreach (DataRow drVendor in this.dsProjects.Tables["tabProjects"].Rows)
            {
                if ((Boolean)drVendor["bitSelect"])
                {
                    ++intSelectedProjects;
                }
            }

            if (intSelectedProjects > 0)
            {
                DialogResult dialogResult = MessageBox.Show("آیا می خواهید " + intSelectedProjects.ToString() + " پروژه را حذف کنید؟", "حذف", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.btmDelete.Enabled = false;
                    Project.DeleteProjects(this.cnConnection, this.dsProjects);
                    SearchProjects();
                    this.btmDelete.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(".هیچ پروژه‌ای انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void dgvProjects_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {   
            if(e.RowIndex != -1)
            {
                ProjectUpdate frmProjectUpdate = new ProjectUpdate();
                frmProjectUpdate.Owner = this;

                frmProjectUpdate.proUpdate = this.proUpdate;
                frmProjectUpdate.cnConnection = this.cnConnection;

                this.proUpdate.intID = (int)this.dgvProjects.Rows[e.RowIndex].Cells["intID"].Value;
                this.proUpdate.intNumber = (int)this.dgvProjects.Rows[e.RowIndex].Cells["intNumber"].Value;
                this.proUpdate.intCategory = (int)this.dgvProjects.Rows[e.RowIndex].Cells["intCategory"].Value;
                this.proUpdate.strName = this.dgvProjects.Rows[e.RowIndex].Cells["nvcName"].Value.ToString();
                this.proUpdate.strTip = this.dgvProjects.Rows[e.RowIndex].Cells["nvcTip"].Value.ToString();

                frmProjectUpdate.ShowDialog();
            }
           
        }

        private void btmInsert_Click(object sender, EventArgs e)
        {
            this.btmInsert.Enabled = false;
            ProjectInsert frmProjectInsert = new ProjectInsert();
            frmProjectInsert.Owner = this;
            frmProjectInsert.cnConnection = this.cnConnection;
            frmProjectInsert.ShowDialog();
            this.btmInsert.Enabled = true;
        }

        private void BtmSubProjects_Click(object sender, EventArgs e)
        {
            if (this.dgvProjects.SelectedRows.Count != 0)
            {
                this.btmSubprojects.Enabled = false;
                Subprojects frmSubprojects = new Subprojects();

                frmSubprojects.spSearch.intProjectNumber = (int)this.dgvProjects.SelectedRows[0].Cells["intNumber"].Value;
                frmSubprojects.proProject.intNumber = (int)this.dgvProjects.SelectedRows[0].Cells["intNumber"].Value;
                frmSubprojects.proProject.strName = this.dgvProjects.SelectedRows[0].Cells["nvcName"].Value.ToString();
                frmSubprojects.proProject.intCategory = Category.GetNumberByName(this.cnConnection, this.dgvProjects.SelectedRows[0].Cells["intCategory"].Value.ToString());
                frmSubprojects.proProject.strTip = this.dgvProjects.SelectedRows[0].Cells["nvcTip"].Value.ToString();

                frmSubprojects.cnConnection = this.cnConnection;
                frmSubprojects.usUser = this.usUser;
                frmSubprojects.ShowDialog();
                this.btmSubprojects.Enabled = true;
            }
        }

        private void SetEnableBtmSearch()
        {
            if (this.tbNumber.Text.Trim().Length != 0 || this.cbCategory.SelectedIndex >= 1 ||
                this.tbName.Text.Length != 0 || this.tbTip.Text.Length != 0)
            {
                this.bolEnableBtmSearchByInterface = true;
            }
            else
            {
                this.bolEnableBtmSearchByInterface = false;
            }

            SetEnableComponents();
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

        private void dgvProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvProjects.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgvProjects_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.bolEnableBtmDeleteByInterface = false;

            for (int i = 0; i < this.dgvProjects.Rows.Count; i++)
            {
                if ((bool)this.dgvProjects.Rows[i].Cells["bitSelect"].Value)
                {
                    this.bolEnableBtmDeleteByInterface = true;
                }
            }

            SetEnableComponents();
        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void TbNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void TbTip_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmSearch();
        }

        private void DgvProjects_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgvProjects.Rows.Count; i++)
            {
                this.dgvProjects.Rows[i].Cells["intCategoryAsName"].Value =
                    Category.GetNameByNumber(this.cnConnection, (int)this.dgvProjects.Rows[i].Cells["intCategory"].Value);
            }
        }

        private void DgvProjects_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex == -1)
            {
                this.btmSubprojects.Enabled = true;
            }
            else
            {
                this.btmSubprojects.Enabled = false;
            }
        }
    }
}
