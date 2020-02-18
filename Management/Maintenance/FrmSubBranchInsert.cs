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
    public partial class FrmSubBranchInsert : Form
    {
        public string branchName;

        public FrmSubBranchInsert()
        {
            InitializeComponent();
        }

        private void FrmSubBranchInsert_Load(object sender, EventArgs e)
        {
            this.dgvListSubBranch.AutoGenerateColumns = false;

            ListRefresh();
        }

        public void ListRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var branch = db.Branch.GetEntity(t => t.nvcName == branchName);
                this.dgvListSubBranch.DataSource = db.SubBranch.ListSubBranches(branch.intNumber);
            }
        }

        private void TxtSearchSubBranch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var branch = db.Branch.GetEntity(t => t.nvcName == branchName);
                this.dgvListSubBranch.DataSource = db.SubBranch.ListSubBranches(branch.intNumber, txtSearchSubBranch.Text);
            }
        }

        private void BtmRegister_Click(object sender, EventArgs e)
        {
            if (txtRegisterSubBranch.Text == "")
            {
                RtlMessageBox.Show("لطفا نام زیرشاخه را وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string subBranchName = txtRegisterSubBranch.Text;
                using (UnitOfWork db = new UnitOfWork())
                {
                    var branch = db.Branch.GetEntity(t => t.nvcName == branchName);
                    var subBranch = db.SubBranch.GetEntity(t => t.nvcName == subBranchName);
                    if (subBranch != null)
                    {
                        RtlMessageBox.Show("این نام کالا قبلا ثبت شده است", "خطا", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else
                    {
                        var maxNumber = db.SubBranch.GetAll().Max(t => t.intNumber);
                        tabSubBranch tabSubBranch = new tabSubBranch()
                        {
                            bitSelect = false,
                            intNumber = maxNumber + 1,
                            nvcName = subBranchName,
                            intBranch = branch.intNumber
                        };
                        db.SubBranch.Insert(tabSubBranch);
                        db.Save();
                        RtlMessageBox.Show("ثبت با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ListRefresh();
                        txtRegisterSubBranch.Text = "";
                        txtEditSubBranch.Text = "";
                    }

                }
            }
        }

        private void BtmEdit_Click(object sender, EventArgs e)
        {
            if (txtEditSubBranch.Text == "")
            {
                RtlMessageBox.Show("لطفا نام زیرشاخه را از لیست مقابل انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var branch = db.Branch.GetEntity(t => t.nvcName == branchName);
                    string subBranchName = txtEditSubBranch.Text;
                    if (dgvListSubBranch.CurrentRow != null)
                    {
                        int subBranchId = int.Parse(dgvListSubBranch.CurrentRow.Cells[0].Value.ToString());
                        var subBranch = db.SubBranch.GetEntity(t => t.intID == subBranchId);
                        if (subBranch != null)
                        {
                            subBranch.intID = subBranchId;
                            subBranch.bitSelect = subBranch.bitSelect;
                            subBranch.intNumber = subBranch.intNumber;
                            subBranch.nvcName = subBranchName;
                            subBranch.intBranch = branch.intNumber;

                            db.Branch.Update(branch);
                            db.Save();
                            RtlMessageBox.Show("ویرایش با موفقیت انجام شد", "ثبت", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ListRefresh();
                            txtRegisterSubBranch.Text = "";
                            txtEditSubBranch.Text = "";

                        }
                    }
                }
            }
        }

        private void DgvListSubBranch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgvListSubBranch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListSubBranch.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListSubBranch.CurrentRow;
                this.txtEditSubBranch.Text = dgvRow.Cells[1].Value.ToString();
            }
        }

        private void BtmDelete_Click(object sender, EventArgs e)
        {
            if (dgvListSubBranch.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvListSubBranch.CurrentRow;
                int subBranchId = Convert.ToInt32(dgvRow.Cells[0].Value.ToString());
                string subBranchName = dgvRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف {subBranchName} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var subBranch = db.SubBranch.GetEntity(t => t.intID == subBranchId);
                        db.SubBranch.Delete(subBranch);
                        db.Save();
                        ListRefresh();
                        txtRegisterSubBranch.Text = "";
                        txtEditSubBranch.Text = "";
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
