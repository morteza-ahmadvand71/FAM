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
    public partial class FrmBranchInsert : Form
    {
        public string name;

        public FrmBranchInsert()
        {
            InitializeComponent();
        }

        private void FrmBranchInsert_Load(object sender, EventArgs e)
        {
            this.dgvListBranch.AutoGenerateColumns = false;

            ListRefresh();
        }

        public void ListRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var nameEntity = db.Name.GetEntity(t => t.nvcName == name);
                this.dgvListBranch.DataSource = db.Branch.ListBranches(nameEntity.intNumber);
            }
        }

        private void TxtSearchBranch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var nameEntity = db.Name.GetEntity(t => t.nvcName == name);
                this.dgvListBranch.DataSource = db.Branch.ListBranches(nameEntity.intNumber, txtSearchBranch.Text);
            }
        }

        private void BtmRegister_Click(object sender, EventArgs e)
        {
            if (txtRegisterBranch.Text == "")
            {
                RtlMessageBox.Show("لطفا نام شاخه را وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nameBranch = txtRegisterBranch.Text;
                using (UnitOfWork db = new UnitOfWork())
                {
                    var nameEntity = db.Name.GetEntity(t => t.nvcName == name);
                    var branch = db.Branch.GetEntity(t => t.nvcName == nameBranch);
                    if (branch != null)
                    {
                        RtlMessageBox.Show("این نام کالا قبلا ثبت شده است", "خطا", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        var maxNumber = db.Branch.GetAll().Max(t => t.intNumber);
                        tabBranch tabBranch = new tabBranch()
                        {
                            bitSelect = false,
                            intNumber = maxNumber + 1,
                            nvcName = nameBranch,
                            intName = nameEntity.intNumber
                        };
                        db.Branch.Insert(tabBranch);
                        db.Save();
                        RtlMessageBox.Show("ثبت با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ListRefresh();
                        txtRegisterBranch.Text = "";
                        txtEditBranch.Text = "";
                    }

                }
            }
        }

        private void BtmEdit_Click(object sender, EventArgs e)
        {
            if (txtEditBranch.Text == "")
            {
                RtlMessageBox.Show("لطفا نام شاخه را از لیست مقابل انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var nameEntity = db.Name.GetEntity(t => t.nvcName == name);
                    string nameBranch = txtEditBranch.Text;
                    if (dgvListBranch.CurrentRow != null)
                    {
                        int nameId = int.Parse(dgvListBranch.CurrentRow.Cells[0].Value.ToString());
                        var branch = db.Branch.GetEntity(t => t.intID == nameId);
                        if (branch != null)
                        {
                            branch.intID = nameId;
                            branch.bitSelect = branch.bitSelect;
                            branch.intNumber = branch.intNumber;
                            branch.nvcName = nameBranch;
                            branch.intName = nameEntity.intNumber;

                            db.Branch.Update(branch);
                            db.Save();
                            RtlMessageBox.Show("ویرایش با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ListRefresh();
                            txtRegisterBranch.Text = "";
                            txtEditBranch.Text = "";
                            
                        }
                    }
                }
            }
        }

        private void DgvListBranch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvListBranch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListBranch.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListBranch.CurrentRow;
                this.txtEditBranch.Text = dgvRow.Cells[1].Value.ToString();
            }
        }

        private void BtmDelete_Click(object sender, EventArgs e)
        {
            if (dgvListBranch.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListBranch.CurrentRow;
                int branchId = Convert.ToInt32(dgvRow.Cells[0].Value.ToString());
                string nameBranch = dgvRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف {nameBranch} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var branch = db.Branch.GetEntity(t => t.intID == branchId);
                        db.Branch.Delete(branch);
                        db.Save();
                        ListRefresh();
                        txtRegisterBranch.Text = "";
                        txtEditBranch.Text = "";
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک شاخه را از لیست انتخاب کنید", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
    }
}
