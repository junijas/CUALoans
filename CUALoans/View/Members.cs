using CUALoans.Controller;
using CUALoans.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class Members : Form
    {
        private readonly CUALoansData data = new CUALoansData();

        public Members()
        {
            InitializeComponent();
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.ClearSelection();
        }

        private void BtnAddJob_Click(object sender, EventArgs e)
        {
            //var job = new AddJobBook(this);
            ////new AddJobBook().ShowDialog();
            //job.ShowDialog();
        }





        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //dgvJobBook.DataSource = AppController.SearchJobs(txtSearch.Text);
        }



        private bool ValidateControls()
        {
            timer1.Start();
            var valid = true;

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, @"Name is  required");
                txtName.Focus();
                valid = false;
            }

            else if (string.IsNullOrEmpty(txtMineNo.Text))
            {
                errorProvider1.SetError(txtMineNo, @"Mine number is required");
                txtMineNo.Focus();
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtDept.Text))
            {
                errorProvider1.SetError(txtDept, @"Department is required");
                txtDept.Focus();
                valid = false;
            }

            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, @"Phone is required");
                txtPhone.Focus();
                valid = false;
            }
            //else if (string.IsNullOrEmpty(txtAddress.Text))
            //{
            //    errorProvider1.SetError(txtAddress, @"Residential Address is required");
            //    txtAddress.Focus();
            //    valid = false;
            //}
            //else if (string.IsNullOrEmpty(txtBank.Text))
            //{
            //    errorProvider1.SetError(txtBank, @"Bank is required");
            //    txtBank.Focus();
            //    valid = false;
            //}
            //else if (string.IsNullOrEmpty(txtAccountNo.Text))
            //{
            //    errorProvider1.SetError(txtAccountNo, @"Account number is required");
            //    txtAccountNo.Focus();
            //    valid = false;
            //}
            else
            {
                errorProvider1.Clear();
            }

            return valid;
        }
        private void Clear()
        {
            txtName.Clear();
            txtMineNo.Clear();
            txtDept.Clear();
            txtBank.Clear();
            txtAccountNo.Clear();
            txtAddress.Clear();
            txtId.Clear();
            txtPhone.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                var user = Dashboard.GetUser;
                var id = data.Users.SingleOrDefault(a => a.username == user)?.user_id;
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    var add = new Model.Member
                    {
                        Name = txtName.Text,
                        MineNo = txtMineNo.Text,
                        Department = txtDept.Text,
                        Bank = txtBank.Text,
                        BankAccount = txtAccountNo.Text,
                        PhoneNumber = txtPhone.Text,
                        Address = txtAddress.Text,
                        Status = "Active",
                        UserId = id
                    };
                    if (AppController.AddMember(add))
                    {
                        MessageBox.Show(@"Records added successfully", @"Adding records", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        dgvMembers.DataSource = AppController.GetMembers();
                        Clear();
                    }
                }
                // Update Records
                else
                {
                    var edit = new Model.Member
                    {
                        Id = Convert.ToInt32(txtId.Text),
                        Name = txtName.Text,
                        MineNo = txtMineNo.Text,
                        Department = txtDept.Text,
                        Bank = txtBank.Text,
                        BankAccount = txtAccountNo.Text,
                        PhoneNumber = txtPhone.Text,
                        Address = txtAddress.Text,
                        Status = "Active",
                        UserId = id
                    };
                    //   LoadCombos();

                    if (AppController.UpdateMember(edit))
                    {
                        MessageBox.Show(@"Records updated successfully", @"Updating records", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        dgvMembers.DataSource = AppController.GetMembers();
                        Clear();
                    }
                }
            }

        }

        private void Members_Load(object sender, EventArgs e)
        {
            dgvMembers.DataSource = AppController.GetMembers();
            //lbUsers.Text = Dashboard.GetUser;


        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvMembers.CurrentRow != null)
            {
                var id = (int)dgvMembers.CurrentRow.Cells["MId"].Value;
                var datasource = data.Members.Where(x => x.Id == id).ToList();


                var columnedit = dgvMembers.Columns["job_edit"];
                var columndel = dgvMembers.Columns["job_del"];

                if (columnedit != null && e.ColumnIndex == columnedit.Index)
                {
                    // btnSaveCat.Text = "Update";

                    txtId.Text = id.ToString();
                    txtName.Text = dgvMembers.CurrentRow?.Cells["Name"].Value.ToString();
                    txtMineNo.Text = dgvMembers.CurrentRow?.Cells["mine"].Value.ToString();
                    txtDept.Text = dgvMembers.CurrentRow?.Cells["dept"].Value.ToString();
                    txtBank.Text = dgvMembers.CurrentRow?.Cells["bank"].Value.ToString();
                    txtAccountNo.Text = dgvMembers.CurrentRow?.Cells["account"].Value.ToString();
                    txtAddress.Text = dgvMembers.CurrentRow?.Cells["address"].Value.ToString();
                    txtPhone.Text = dgvMembers.CurrentRow?.Cells["phone"].Value.ToString();


                }
                else
                {
                    // Debug.Assert(columndel != null, "columndel != null");
                    if (e.ColumnIndex == columndel.Index)
                    {
                        if (string.IsNullOrEmpty(id.ToString())) return;

                        if (MessageBox.Show(@"Are you sure you want to delete record", @"Deleting record",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            AppController.RemoveMember(id);
                            dgvMembers.DataSource = AppController.GetMembers();
                        }
                    }
                }
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = "Search ...";
        }

        private void txtSearch_KeyUp_1(object sender, KeyEventArgs e)
        {
            dgvMembers.DataSource = AppController.SearchMembers(txtSearch.Text);
        }
    }
}