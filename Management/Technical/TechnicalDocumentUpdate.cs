using Baran.Ferroalloy.Automation.SqlDataBase;
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
    public partial class TechnicalDocumentUpdate : Form
    {
        public TechnicalDocument tdTechnicalDocument = new TechnicalDocument();
        public Connection cnConnection;
        private Category[] caCategories;

        public TechnicalDocumentUpdate()
        {
            InitializeComponent();
        }

        private void TechnicalDocumentUpdate_Load(object sender, EventArgs e)
        {
            //Fill cbCategory ComboBox
            this.caCategories = Category.GetCategories(this.cnConnection);
            this.cbCategory.Items.Add("");
            foreach (Category ctCategory in this.caCategories)
            {
                this.cbCategory.Items.Add(ctCategory.strName);
            }

            //Fill cbZone ComboBox
            Zone[] zoZones = Zone.GetZones(this.cnConnection);
            this.cbZone.Items.Clear();
            this.cbZone.Items.Add("");
            foreach (Zone zoZone in zoZones)
            {
                this.cbZone.Items.Add(zoZone.strNamePty);
            }

            this.cbCategory.Text = Category.GetNameByNumber(this.cnConnection,this.tdTechnicalDocument.intCategory);
            this.cbZone.Text = tdTechnicalDocument.strZonePty;
            this.tbCode.Text = tdTechnicalDocument.strCodePty;
            this.tbCoDesigner.Text = tdTechnicalDocument.strCoDesignerPty;
            this.tbPersonDesigner.Text = tdTechnicalDocument.strPersonDesignerPty;
            this.tbRevisionNumber.Text = tdTechnicalDocument.strRevisionNumberPty;
            this.tbTip.Text = tdTechnicalDocument.strTipPty;
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            tdTechnicalDocument.intCategory = Category.GetNumberByName(this.cnConnection,this.cbCategory.Text);
            tdTechnicalDocument.strZonePty = Zone.GetZoneCode(this.cnConnection,this.cbZone.Text);
            tdTechnicalDocument.strCodePty = this.tbCode.Text;
            tdTechnicalDocument.strCoDesignerPty = this.tbCoDesigner.Text;
            tdTechnicalDocument.strPersonDesignerPty = this.tbPersonDesigner.Text;
            tdTechnicalDocument.strRevisionNumberPty = this.tbRevisionNumber.Text;
            tdTechnicalDocument.strTipPty = this.tbTip.Text;
            tdTechnicalDocument.Update(this.cnConnection);

            TechnicalDocuments frmTechnicalDocuments = (TechnicalDocuments)this.Owner;
            frmTechnicalDocuments.SearchTechnicalDocuments();
            this.Close();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
