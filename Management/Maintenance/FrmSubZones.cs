using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Models;


namespace Baran.Ferroalloy.Management.Maintenance
{
    public partial class FrmSubZones : Form
    {
        public string zoneName;

        public FrmSubZones()
        {
            InitializeComponent();
        }

        private void FrmSubZones_Load(object sender, EventArgs e)
        {
            this.dgvListSubZone.AutoGenerateColumns = false;
            ListRefresh();
        }

        public void ListRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var zones = db.Zone.GetEntity(t => t.nvcName == zoneName);
                this.dgvListSubZone.DataSource = db.SubZone.ListSubZones(zones.intNumber);
            }
        }

        private void TxtSearchSubZone_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var zones = db.Zone.GetEntity(t => t.nvcName == zoneName);
                this.dgvListSubZone.DataSource = db.SubZone.ListSubZones(zones.intNumber,txtSearchSubZone.Text);
            }
        }

        private void BtmRegister_Click(object sender, EventArgs e)
        {
            if (txtNameSubZone.Text == "")
            {
                RtlMessageBox.Show("لطفا نام زیرشاخه را وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string subZoneName = txtNameSubZone.Text;
                using (UnitOfWork db = new UnitOfWork())
                {
                    var zones = db.Zone.GetEntity(t => t.nvcName == zoneName);
                    var subZones = db.SubZone.GetEntity(t => t.nvcName == subZoneName);
                    if (subZones != null)
                    {
                        RtlMessageBox.Show("این زیرشاخه قبلا ثبت شده است", "خطا", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        var maxNumber = db.SubZone.GetAll().Max(t => t.intNumber);
                        tabSubZones tabSubZones = new tabSubZones()
                        {
                            bitSelect = false,
                            intNumber = maxNumber + 1,
                            nvcName = subZoneName,
                            intZone = zones.intNumber
                        };
                        db.SubZone.Insert(tabSubZones);
                        db.Save();
                        RtlMessageBox.Show("ثبت با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ListRefresh();
                        txtNameSubZone.Text = "";
                        txtEditSubZone.Text = "";
                    }

                }
            }
        }

        private void BtmEdit_Click(object sender, EventArgs e)
        {
            if (txtEditSubZone.Text == "")
            {
                RtlMessageBox.Show("لطفا نام زیرشاخه را از لیست مقابل انتخاب کنید", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var zones = db.Zone.GetEntity(t => t.nvcName == zoneName);
                    string subZoneName = txtEditSubZone.Text;
                    if (dgvListSubZone.CurrentRow != null)
                    {
                        int subZoneId = int.Parse(dgvListSubZone.CurrentRow.Cells[0].Value.ToString());
                        var subZones = db.SubZone.GetEntity(t => t.intID == subZoneId);
                        if (subZones != null)
                        {
                            subZones.intID = subZoneId;
                            subZones.bitSelect = subZones.bitSelect;
                            subZones.intNumber = subZones.intNumber;
                            subZones.nvcName = subZoneName;
                            subZones.intZone = zones.intNumber;

                            db.SubZone.Update(subZones);
                            db.Save();
                            RtlMessageBox.Show("ویرایش با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ListRefresh();
                            txtEditSubZone.Text = "";
                            txtNameSubZone.Text = "";

                        }
                    }
                }
            }
        }

        private void DgvListSubZone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListSubZone.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListSubZone.CurrentRow;
                this.txtEditSubZone.Text = dgvRow.Cells[1].Value.ToString();
            }
        }

        private void BtmDelete_Click(object sender, EventArgs e)
        {
            if (dgvListSubZone.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListSubZone.CurrentRow;
                int subZoneId = Convert.ToInt32(dgvRow.Cells[0].Value.ToString());
                string subZoneName = dgvRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف {subZoneName} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var subZones = db.SubZone.GetEntity(t => t.intID == subZoneId);
                        db.SubZone.Delete(subZones);
                        db.Save();
                        ListRefresh();
                        txtEditSubZone.Text = "";
                        txtNameSubZone.Text = "";
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک زیرشاخه را از لیست انتخاب کنید", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
