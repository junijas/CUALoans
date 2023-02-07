using CUALoans.Controller;
using CUALoans.Model;
using System;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class Loans : Form
    {
        private readonly CUALoansData data = new CUALoansData();

        public Loans()
        {
            InitializeComponent();
            dgvLoans.AutoGenerateColumns = false;
        }

        private void BtnAddJob_Click(object sender, EventArgs e)
        {
            var loanform = new AddLoan(this);
            //new AddJobBook().ShowDialog();
            loanform.ShowDialog();
        }

        private void JobBook_Load(object sender, EventArgs e)
        {
            dgvLoans.DataSource = AppController.LoanRequests();
            lbUsers.Text = Dashboard.GetUser;
        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dgvLoans.DataSource = AppController.SearchLoans(txtSearch.Text);
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void dgvLoans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvLoans.CurrentRow != null)
            {
                var id = (int)dgvLoans.CurrentRow.Cells["LId"].Value;
                //   var member = (int)dgvLoans.CurrentRow.Cells["mid"].Value;
                //var datasource = data.Loans.Where(x => x.Id == id).ToList();


                var columnedit = dgvLoans.Columns["job_edit"];
                var columndel = dgvLoans.Columns["job_del"];

                if (columnedit != null && e.ColumnIndex == columnedit.Index)
                {
                    // btnSaveCat.Text = "Update";
                    var loan = new AddLoan(this);

                    loan.txtId.Text = id.ToString();
                    loan.txtAmount.Text = dgvLoans.CurrentRow?.Cells["amount"].Value.ToString();
                    loan.txtDesc.Text = dgvLoans.CurrentRow?.Cells["purpose"].Value.ToString();
                    loan.txtDept.Text = dgvLoans.CurrentRow?.Cells["dept"].Value.ToString();
                    loan.txtG1.Text = dgvLoans.CurrentRow?.Cells["gua1"].Value.ToString();
                    loan.txtG2.Text = dgvLoans.CurrentRow?.Cells["gua2"].Value.ToString();
                    loan.txtM1.Text = dgvLoans.CurrentRow?.Cells["mine1"].Value.ToString();
                    loan.txtInterest.Text = dgvLoans.CurrentRow?.Cells["interest"].Value.ToString();
                    loan.txtPay.Text = dgvLoans.CurrentRow?.Cells["apay"].Value.ToString();
                    loan.txtM2.Text = dgvLoans.CurrentRow?.Cells["mine2"].Value.ToString();
                    loan.txtMine.Text = dgvLoans.CurrentRow?.Cells["mine"].Value.ToString();
                    loan.txtPeriod.Text = dgvLoans.CurrentRow?.Cells["period"].Value.ToString();
                    loan.cboLMembers.Text = dgvLoans.CurrentRow?.Cells["member"].Value.ToString();
                    //  loan.cboLMembers.DataBindings.Add("Text", datasource, "Members.Name");
                    loan.cboLStatus.FindString(dgvLoans.CurrentRow.Cells["status"].Value.ToString());

                    loan.ShowDialog();

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
                            AppController.RemoveLoan(id);
                            dgvLoans.DataSource = AppController.LoanRequests();
                        }
                    }
                }
            }

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = "Search ...";
        }
    }
}