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
    public partial class FrmEquipName : Form
    {
        public string categoryName;

        public FrmEquipName()
        {
            InitializeComponent();
        }

        private void FrmEquipName_Load(object sender, EventArgs e)
        {
            this.dgvListEquipName.AutoGenerateColumns = false;

            ListRefresh();
        }

        public void ListRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var categories = db.Categories.GetEntity(t => t.nvcName == categoryName);
                this.dgvListEquipName.DataSource = db.EquipName.ListEquipNames(categories.intNumber);
            }
        }

        private void TxtSearchEquipName_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var categories = db.Categories.GetEntity(t => t.nvcName == categoryName);
                this.dgvListEquipName.DataSource = db.EquipName.ListEquipNames(categories.intNumber, txtSearchEquipName.Text);
            }
        }

        private void BtmRegister_Click(object sender, EventArgs e)
        {
            if (txtEquipName.Text == "")
            {
                RtlMessageBox.Show("لطفا نام تجهیز را وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string equipName = txtEquipName.Text;
                using (UnitOfWork db = new UnitOfWork())
                {
                    var categories = db.Categories.GetEntity(t => t.nvcName == categoryName);
                    var equipNameEntity = db.EquipName.GetEntity(t => t.nvcName == equipName);
                    if (equipNameEntity != null)
                    {
                        RtlMessageBox.Show("این نام تجهیز قبلا ثبت شده است", "خطا", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        var maxNumber = db.EquipName.GetAll().Max(t => t.intNumber);
                        tabEquipName tabEquipName = new tabEquipName()
                        {
                            bitSelect = false,
                            intNumber = maxNumber + 1,
                            nvcName = equipName,
                            intCategory = categories.intNumber
                        };
                        db.EquipName.Insert(tabEquipName);
                        db.Save();
                        RtlMessageBox.Show("ثبت با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ListRefresh();
                        txtEditEquipName.Text = "";
                        txtEquipName.Text = "";
                    }

                }
            }
        }

        private void BtmEdit_Click(object sender, EventArgs e)
        {
            if (txtEditEquipName.Text == "")
            {
                RtlMessageBox.Show("لطفا نام تجهیز را از لیست مقابل انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var categories = db.Categories.GetEntity(t => t.nvcName == categoryName);
                    string equipName = txtEditEquipName.Text;
                    if (dgvListEquipName.CurrentRow != null)
                    {
                        int equipNameId = int.Parse(dgvListEquipName.CurrentRow.Cells[0].Value.ToString());
                        var equipNameEntity = db.EquipName.GetEntity(t => t.intID == equipNameId);
                        if (equipNameEntity != null)
                        {
                            equipNameEntity.intID = equipNameId;
                            equipNameEntity.bitSelect = equipNameEntity.bitSelect;
                            equipNameEntity.intNumber = equipNameEntity.intNumber;
                            equipNameEntity.nvcName = equipName;
                            equipNameEntity.intCategory = categories.intNumber;

                            db.EquipName.Update(equipNameEntity);
                            db.Save();
                            RtlMessageBox.Show("ویرایش با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ListRefresh();
                            txtEditEquipName.Text = "";
                            txtEquipName.Text = "";
                        }
                    }
                }
            }
        }

        private void DgvListEquipName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListEquipName.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListEquipName.CurrentRow;
                this.txtEditEquipName.Text = dgvRow.Cells[1].Value.ToString();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListEquipName.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListEquipName.CurrentRow;
                int equipNameId = Convert.ToInt32(dgvRow.Cells[0].Value.ToString());
                string equipName = dgvRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف {equipName} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var equipNameEntity = db.EquipName.GetEntity(t => t.intID == equipNameId);
                        db.EquipName.Delete(equipNameEntity);
                        db.Save();
                        ListRefresh();
                        txtEquipName.Text = "";
                        txtEditEquipName.Text = "";
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک نام تجهیز را از لیست انتخاب کنید", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
