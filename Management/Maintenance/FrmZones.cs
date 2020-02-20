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

namespace Baran.Ferroalloy.Management
{
    public partial class FrmZones : Form
    {
        public FrmZones()
        {
            InitializeComponent();
        }

        private void FrmZones_Load(object sender, EventArgs e)
        {
            this.dgvListZones.AutoGenerateColumns = false;
            ListRefresh();
        }

        public void ListRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.dgvListZones.DataSource = db.Zone.ListZones();
            }
        }

        private void TxtSearchZone_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.dgvListZones.DataSource = db.Zone.ListZones(txtSearchZone.Text);
            }
        }

        private void BtmRegister_Click(object sender, EventArgs e)
        {
            if (txtNameZone.Text == "")
            {
                RtlMessageBox.Show("لطفا نام بخش را وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nameZone = txtNameZone.Text;
                using (UnitOfWork db = new UnitOfWork())
                {
                    var zones = db.Zone.GetEntity(t => t.nvcName == nameZone);
                    if (zones != null)
                    {
                        RtlMessageBox.Show("این نام بخش قبلا ثبت شده است", "خطا", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        var maxNumber = db.Zone.GetAll().Max(t => t.intNumber);
                        tabZones tabZones = new tabZones()
                        {
                            bitSelect = false,
                            intNumber = maxNumber + 1,
                            nvcName = nameZone
                        };
                        db.Zone.Insert(tabZones);
                        db.Save();
                        RtlMessageBox.Show("ثبت با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ListRefresh();
                        txtNameZone.Text = "";
                        txtEditZone.Text = "";
                    }

                }
            }
        }

        private void BtmEdit_Click(object sender, EventArgs e)
        {
            if (txtEditZone.Text == "")
            {
                RtlMessageBox.Show("لطفا نام بخش را از لیست مقابل انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string nameZone = txtEditZone.Text;
                    if (dgvListZones.CurrentRow != null)
                    {
                        int zoneId = int.Parse(dgvListZones.CurrentRow.Cells[0].Value.ToString());
                        var zones = db.Zone.GetEntity(t => t.intID == zoneId);
                        if (zones != null)
                        {
                            zones.intID = zoneId;
                            zones.bitSelect = zones.bitSelect;
                            zones.intNumber = zones.intNumber;
                            zones.nvcName = nameZone;

                            db.Zone.Update(zones);
                            db.Save();
                            RtlMessageBox.Show("ویرایش با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ListRefresh();
                            txtNameZone.Text = "";
                            txtEditZone.Text = "";
                        }
                    }
                }
            }
        }

        private void DgvListZones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListZones.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListZones.CurrentRow;
                this.txtEditZone.Text = dgvRow.Cells[1].Value.ToString();
            }
        }

        private void BtmDelete_Click(object sender, EventArgs e)
        {
            if (dgvListZones.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListZones.CurrentRow;
                int zoneId = Convert.ToInt32(dgvRow.Cells[0].Value.ToString());
                string zoneName = dgvRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف انبار {zoneName} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var zones = db.Zone.GetEntity(t => t.intID == zoneId);
                        db.Zone.Delete(zones);
                        db.Save();
                        ListRefresh();
                        txtEditZone.Text = "";
                        txtNameZone.Text = "";
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک بخش را از لیست انتخاب کنید", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
