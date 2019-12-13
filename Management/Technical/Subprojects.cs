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
    public partial class Subprojects : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSetings;
        public Project proProject;
        public DataSet dsSubprojects;
        public Subproject spSearch;
        private Subproject spUpdate;

        public Subprojects()
        {
            InitializeComponent();
            //bolIsRunning = true;

            this.proProject = new Project();
            this.spSearch = new Subproject();
            this.spUpdate = new Subproject();
        }

        private void Subprojects_Load(object sender, EventArgs e)
        {
            SetComponentsByPermisions();

            this.labProjectNumber.Text = this.proProject.intNumber.ToString();
            this.labName.Text = this.proProject.strName;
            this.labCategory.Text = Category.GetNameByNumber(this.cnConnection,this.proProject.intCategory);
            this.labTip.Text = this.proProject.strTip;

            SearchSubprojects();
        }

        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolTechnicalEnabed)
            {
                this.btmDelete.Enabled = true;
                this.btmInsert.Enabled = true;
                this.dgvSubprojects.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSubprojects_CellMouseDoubleClick);
                this.dgvSubprojects.Columns["bitSelect"].Visible = true;
            }
            else
            {
                this.btmDelete.Enabled = false;
                this.btmInsert.Enabled = false;
                this.dgvSubprojects.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSubprojects_CellMouseDoubleClick);
                this.dgvSubprojects.Columns["bitSelect"].Visible = false;
            }
        }

        private void Subprojects_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        public void SearchSubprojects()
        {
            this.dsSubprojects = Subproject.GetSubprojects(this.cnConnection, this.spSearch);

            this.dgvSubprojects.DataSource = this.dsSubprojects;
            this.dgvSubprojects.DataMember = "tabSubprojects";

            for (int i = 0; i < this.dgvSubprojects.Rows.Count; i++)
            {
                this.dgvSubprojects.Rows[i].Cells["intCategoryAsName"].Value =
                    Category.GetNameByNumber(this.cnConnection, (int)this.dgvSubprojects.Rows[i].Cells["intCategory"].Value);
            }
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
            Int16 intSelectedSubprojects = 0;
            foreach (DataRow drVendor in this.dsSubprojects.Tables["tabSubprojects"].Rows)
            {
                if ((Boolean)drVendor["bitSelect"])
                {
                    ++intSelectedSubprojects;
                }
            }

            if (intSelectedSubprojects > 0)
            {
                DialogResult dialogResult = MessageBox.Show("آیا می خواهید " + intSelectedSubprojects.ToString() + " زیرپروژه‌ها را حذف کنید؟", "حذف", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Subproject.DeleteSubprojects(this.cnConnection, this.dsSubprojects);
                    SearchSubprojects();
                }
            }
            else
            {
                MessageBox.Show(".هیچ زیرپروژه‌ای انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void dgvSubprojects_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {   
            if(e.RowIndex != -1)
            {
                SubprojectUpdate frmSubprojectUpdate = new SubprojectUpdate();

                frmSubprojectUpdate.Owner = this;
                frmSubprojectUpdate.spUpdate = this.spUpdate;
                frmSubprojectUpdate.cnConnection = this.cnConnection;

                this.spUpdate.intID = (int)this.dgvSubprojects.Rows[e.RowIndex].Cells["intID"].Value;
                this.spUpdate.intProjectNumber = (int)this.dgvSubprojects.Rows[e.RowIndex].Cells["intProjectNumber"].Value;
                this.spUpdate.intCategory = (int)this.dgvSubprojects.Rows[e.RowIndex].Cells["intCategory"].Value;
                this.spUpdate.strName = this.dgvSubprojects.Rows[e.RowIndex].Cells["nvcName"].Value.ToString();
                this.spUpdate.dtStart = (DateTime)this.dgvSubprojects.Rows[e.RowIndex].Cells["datStart"].Value;
                this.spUpdate.intDuration = (int)this.dgvSubprojects.Rows[e.RowIndex].Cells["intDuration"].Value;
                this.spUpdate.intProgress = (int)this.dgvSubprojects.Rows[e.RowIndex].Cells["intProgress"].Value;
                this.spUpdate.strTip = this.dgvSubprojects.Rows[e.RowIndex].Cells["nvcTip"].Value.ToString();

                frmSubprojectUpdate.ShowDialog();
            }
        }

        private void btmInsert_Click(object sender, EventArgs e)
        {
            SubprojectInsert frmSubprojectInsert = new SubprojectInsert();
            frmSubprojectInsert.Owner = this;
            frmSubprojectInsert.cnConnection = this.cnConnection;
            frmSubprojectInsert.spInsert.intProjectNumber = this.proProject.intNumber;
            frmSubprojectInsert.ShowDialog();
        }

        private void BtmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvSubprojects_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgvSubprojects.Rows.Count; i++)
            {
                this.dgvSubprojects.Rows[i].Cells["intCategoryAsName"].Value =
                    Category.GetNameByNumber(this.cnConnection, (int)this.dgvSubprojects.Rows[i].Cells["intCategory"].Value);
            }
        }
        private void dgvSubprojects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvSubprojects.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
        private void dgvSubprojects_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.btmDelete.Enabled = false;

            for (int i = 0; i < this.dgvSubprojects.Rows.Count; i++)
            {
                if ((bool)this.dgvSubprojects.Rows[i].Cells["bitSelect"].Value)
                {
                    this.btmDelete.Enabled = true;
                }
            }
        }
    }
}
