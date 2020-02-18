using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
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
    public partial class TechnicalDocuments : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public User usUser;
        public DataSet dsTechnicalDocuments;
        private Category[] caCategories;
        private Zone[] zoZones;
        private TechnicalDocument tdSearch;
        private TechnicalDocument tdUpdate;


        public TechnicalDocuments()
        {
            InitializeComponent();
            bolIsRunning = true;
        }

        private void TechnicalDocuments_Load(object sender, EventArgs e)
        {
            SetComponentsByPermisions();

            //Fill cbCategory ComboBox
            this.caCategories = Category.GetCategories(this.cnConnection);
            this.cbCategory.Items.Add("");
            foreach (Category ctCategory in this.caCategories)
            {
                this.cbCategory.Items.Add(ctCategory.strName);
            }

            //Fill cbZone ComboBox
            this.zoZones = Zone.GetZones(this.cnConnection);
            this.cbZone.Items.Add("");
            foreach (Zone zoZone in this.zoZones)
            {
                this.cbZone.Items.Add(zoZone.strNamePty);
            }
        }

        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolTechnicalEnabed)
            {
                this.btmDelete.Enabled = true;
                this.btmInsert.Enabled = true;
                this.dgvTechnicalDocuments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTechnicalDocuments_CellMouseDoubleClick);
            }
            else
            {
                this.btmDelete.Enabled = false;
                this.btmInsert.Enabled = false;
                this.dgvTechnicalDocuments.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTechnicalDocuments_CellMouseDoubleClick);
            }
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TechnicalDocuments_FormClosing(object sender, FormClosingEventArgs e)
        {
            bolIsRunning = false;

            Management frmManagement = (Management)this.MdiParent;
            frmManagement.menWindows.DropDownItems["menWindowsTechnicalDocuments"].Dispose();
        }

        private void btmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            SearchTechnicalDocuments();
        }

        public void SearchTechnicalDocuments()
        {
            this.tdSearch = new TechnicalDocument();
            this.tdSearch.intCategory = Category.GetNumberByName(this.cnConnection,this.cbCategory.Text);
            this.tdSearch.strZonePty = Zone.GetZoneCode(this.cnConnection, this.cbZone.Text);
            this.tdSearch.strCodePty = this.tbCode.Text;
            this.tdSearch.strCoDesignerPty =this.tbCoDesigner.Text;
            this.tdSearch.strPersonDesignerPty = this.tbDesignerName.Text;
            this.tdSearch.strRevisionNumberPty = this.tbRevisionNumber.Text;
            this.dsTechnicalDocuments = TechnicalDocument.GetTechnicalDocuments(this.cnConnection, this.tdSearch);

            foreach (DataRow drTechnicalDocument in this.dsTechnicalDocuments.Tables["tabTechnicalDocuments"].Rows)
            {
                drTechnicalDocument["intCategory"] = Category.GetNameByNumber(this.cnConnection, (int)drTechnicalDocument["intCategory"]);
                drTechnicalDocument["nvcZone"] = Zone.GetZoneName(this.cnConnection, drTechnicalDocument["nvcZone"].ToString());
            }

            this.dgvTechnicalDocuments.DataSource = this.dsTechnicalDocuments;
            this.dgvTechnicalDocuments.DataMember = "tabTechnicalDocuments";
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            Int16 intSelectedTechnicalDocuments = 0;
            foreach (DataRow drTechnicalDocument in this.dsTechnicalDocuments.Tables["tabTechnicalDocuments"].Rows)
            {
                if ((Boolean)drTechnicalDocument["bitSelect"])
                {
                    ++intSelectedTechnicalDocuments;
                }
            }

            if (intSelectedTechnicalDocuments > 0)
            {
                DialogResult dialogResult = MessageBox.Show("آیا می خواهید " + intSelectedTechnicalDocuments.ToString() + " قطعه را حذف کنید؟", "حذف", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TechnicalDocument.DeleteTechnicalDocuments(this.cnConnection, this.dsTechnicalDocuments);
                    SearchTechnicalDocuments();
                }
            }
            else
            {
                MessageBox.Show(".هیچ قطعه ای انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            }
        }

        private void dgvTechnicalDocuments_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TechnicalDocumentUpdate frmTechnicalDocumentUpdate = new TechnicalDocumentUpdate();
            frmTechnicalDocumentUpdate.Owner = this;
            this.tdUpdate = new TechnicalDocument();
            frmTechnicalDocumentUpdate.tdTechnicalDocument = this.tdUpdate;
            frmTechnicalDocumentUpdate.cnConnection = this.cnConnection;

            this.tdUpdate.intIDPty = (Int16)this.dsTechnicalDocuments.Tables["tabTechnicalDocuments"].Rows[e.RowIndex]["intID"];
            this.tdUpdate.intCategory = (int)this.dsTechnicalDocuments.Tables["tabTechnicalDocuments"].Rows[e.RowIndex]["intCategory"];
            this.tdUpdate.strZonePty = this.dsTechnicalDocuments.Tables["tabTechnicalDocuments"].Rows[e.RowIndex]["nvcZone"].ToString();
            this.tdUpdate.strCodePty = this.dsTechnicalDocuments.Tables["tabTechnicalDocuments"].Rows[e.RowIndex]["nvcCode"].ToString();
            this.tdUpdate.strCoDesignerPty = this.dsTechnicalDocuments.Tables["tabTechnicalDocuments"].Rows[e.RowIndex]["nvcCoDesigner"].ToString();
            this.tdUpdate.strPersonDesignerPty = this.dsTechnicalDocuments.Tables["tabTechnicalDocuments"].Rows[e.RowIndex]["nvcPersonDesigner"].ToString();
            this.tdUpdate.strRevisionNumberPty = this.dsTechnicalDocuments.Tables["tabTechnicalDocuments"].Rows[e.RowIndex]["nvcRevisionNumber"].ToString();
            this.tdUpdate.strTipPty = this.dsTechnicalDocuments.Tables["tabTechnicalDocuments"].Rows[e.RowIndex]["nvcTip"].ToString();

            frmTechnicalDocumentUpdate.ShowDialog();
        }

        private void btmInsert_Click(object sender, EventArgs e)
        {
            TechnicalDocumentInsert frmTechnicalDocumentInsert = new TechnicalDocumentInsert();
            frmTechnicalDocumentInsert.Owner = this;
            frmTechnicalDocumentInsert.cnConnection = this.cnConnection;
            frmTechnicalDocumentInsert.ShowDialog();
        }

    }
}
