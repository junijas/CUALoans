using CUALoans.Controller;
using CUALoans.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class Payment : Form
    {
        private readonly CUALoansData data = new CUALoansData();

        public Payment()
        {
            InitializeComponent();
            dgvPayments.AutoGenerateColumns = false;
            AppController.LoadMembersCombo(cboMembers);
        }


        private bool ValidateControls()
        {
            timer1.Start();
            var valid = true;

            if (string.IsNullOrEmpty(cboMembers.Text))
            {
                errorProvider1.SetError(cboMembers, @"Select a member");
                cboMembers.Focus();
                valid = false;
            }

            else if (string.IsNullOrEmpty(cboLoans.Text))
            {
                errorProvider1.SetError(cboLoans, @"Choose the loan ");
                cboLoans.Focus();
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtAmount.Text))
            {
                errorProvider1.SetError(txtAmount, @"Amount is required");
                txtAmount.Focus();
                valid = false;
            }
            else
            {
                errorProvider1.Clear();
            }

            return valid;
        }

        private void Clear()
        {
            cboLoans.ResetText(); txtMine.Clear();
            txtBalance.Clear();
            txtOldBal.Clear();
            txtId.Clear();
            //txtOldBalance.Clear();
            txtAmount.Clear();
            cboMembers.ResetText();
            dtDate.ResetText();
            txtPaid.Clear();
            txtOldAmt.Clear();
            txtOldPaid.Clear();
        }

        private void CalculateBalance()
        {
            try
            {
                var member = Convert.ToInt32(cboMembers.SelectedValue);
                var amount = Convert.ToDecimal(txtAmount.Text);
                var loanid = Convert.ToInt32(cboLoans.SelectedValue);
                var exist = data.Payments.Any(z => z.LoanId == loanid);


                if (string.IsNullOrEmpty(txtId.Text))
                {
                    if (exist)
                    {
                        var balance = data.Payments.Where(v => v.MemberId == member && v.LoanId ==loanid ).Min(w => w.Balance).Value;
                        //   txtOldBalance.Text = balance.ToString();
                        txtBalance.Text = (balance - amount).ToString();
                    }
                    else
                    {
                        var loan = Convert.ToDecimal(cboLoans.Text);
                        txtBalance.Text = (loan - amount).ToString();
                    }
                }
                else
                {
                    var loan = Convert.ToDecimal(cboLoans.Text);
                    var oldbal = Convert.ToDecimal(txtOldBal.Text);
                    var oldamt = Convert.ToDecimal(txtOldAmt.Text);

                    txtBalance.Text = (oldbal + oldamt - amount).ToString();

                }

            }
            catch (Exception)
            {

            }

        }
        private void CalculateTotal()
        {
            try
            {
                var member = Convert.ToInt32(cboMembers.SelectedValue);
                var amount = Convert.ToDecimal(txtAmount.Text);
                var loanid = Convert.ToInt32(cboLoans.SelectedValue);

                var exist = data.Payments.Any(z => z.MemberId == member && z.LoanId==loanid);
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    if (exist)
                    {
                        var total = data.Payments.Where(z => z.MemberId == member).
                            Max(x => x.TotalPaid).Value;
                        txtPaid.Text = (total + amount).ToString();
                    }
                    else
                    {
                        txtPaid.Text = amount.ToString();
                    }
                }
                else
                {
                    var oldp = Convert.ToDecimal(txtOldPaid.Text);
                    var oldamt = Convert.ToDecimal(txtOldAmt.Text);
                    txtPaid.Text = (oldp - oldamt + amount).ToString();
                    //var count = data.Payments.Where(z => z.MemberId == member).Count();
                    //var total = data.Payments.Where(z => z.MemberId == member).
                    //    Sum(u=>u.Payment1).Value;
                    //if (count > 1)
                    //{
                    //    txtPaid.Text = total.ToString();
                    //}
                    //else
                    //{
                    //    txtPaid.Text = txtAmount.Text;

                    //}

                }
            }
            catch (Exception)
            {

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateControls())
                {
                    var user = Dashboard.GetUser;
                    var id = data.Users.SingleOrDefault(a => a.username == user)?.user_id;
                    var balance = Convert.ToDecimal(txtBalance.Text);
                    var loanid = Convert.ToInt32(cboLoans.SelectedValue?.ToString());
                    //Adding a new record
                    if (string.IsNullOrEmpty(txtId.Text))
                    {
                        var add = new Model.Payment
                        {
                            MemberId = Convert.ToInt32(cboMembers.SelectedValue?.ToString()),
                            LoanId = loanid,
                            Payment1 = Convert.ToDecimal(txtAmount.Text),
                            Balance = balance,
                            Date = dtDate.Value,
                            Remarks = txtRemarks.Text,
                            TotalPaid = Convert.ToDecimal(txtPaid.Text),
                            UserId = id,
                            
                        };

                        if (AppController.PayLoan(add))
                        {
                            MessageBox.Show(@"Records added successfully", @"Adding records", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            if (balance == 0)
                            {
                                AppController.CloseLoan(loanid);
                            }
                            

                            dgvPayments.DataSource = AppController.GetPayments();
                            cboMembers.Focus();
                            Clear();
                            
                        }
                    }
                    // Update Records
                    else
                    {
                        LoadCombo();
                        var edit = new Model.Payment
                        {
                            Id = Convert.ToInt32(txtId.Text),

                            MemberId = Convert.ToInt32(cboMembers.SelectedValue?.ToString()),
                            LoanId = Convert.ToInt32(cboLoans.SelectedValue?.ToString()),
                            Payment1 = Convert.ToDecimal(txtAmount.Text),
                            Balance = Convert.ToDecimal(txtBalance.Text),
                            Date = dtDate.Value,
                            Remarks = txtRemarks.Text,
                            TotalPaid = Convert.ToDecimal(txtPaid.Text),
                            UserId = id
                        };
                        if (AppController.UpdateLoanPayment(edit))
                        {
                            MessageBox.Show(@"Records updated successfully", @"Updating records", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            dgvPayments.DataSource = AppController.GetPayments();
                            Clear();
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }

        }
        private void LoadCombo()
        {
            var member = Convert.ToInt32(cboMembers.SelectedValue);
            AppController.LoadLoansCombo(member, cboLoans);
        }
        private void cboMembers_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void dgvPayments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvPayments.CurrentRow != null)
            {
                var id = (int)dgvPayments.CurrentRow.Cells["PId"].Value;
                var datasource = data.Contributions.Where(x => x.Id == id).ToList();


                var columnedit = dgvPayments.Columns["job_edit"];
                var columndel = dgvPayments.Columns["job_del"];

                if (columnedit != null && e.ColumnIndex == columnedit.Index)
                {
                    // btnSaveCat.Text = "Update";

                    txtId.Text = id.ToString();
                    cboMembers.Text = dgvPayments.CurrentRow?.Cells["member"].Value.ToString();
                    cboLoans.Text = dgvPayments.CurrentRow?.Cells["loan"].Value.ToString();
                    txtAmount.Text = dgvPayments.CurrentRow?.Cells["pay"].Value.ToString();
                    txtOldAmt.Text = dgvPayments.CurrentRow?.Cells["pay"].Value.ToString();
                    txtPaid.Text = dgvPayments.CurrentRow?.Cells["total"].Value.ToString();
                    txtOldPaid.Text = dgvPayments.CurrentRow?.Cells["total"].Value.ToString();
                    txtBalance.Text = dgvPayments.CurrentRow?.Cells["balance"].Value.ToString();
                    txtOldBal.Text = dgvPayments.CurrentRow?.Cells["balance"].Value.ToString();
                    dtDate.Text = dgvPayments.CurrentRow?.Cells["date"].Value.ToString();
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
                            AppController.DeletePayments(id);
                            dgvPayments.DataSource = AppController.GetPayments();
                        }
                    }
                }
            }

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateBalance();
            CalculateTotal();


        }

        private void Payment_Load(object sender, EventArgs e)
        {
            dgvPayments.DataSource = AppController.GetPayments();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = "Search ...";
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dgvPayments.DataSource = AppController.SearchPayments(txtSearch.Text);
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadCombo();
                var member = Convert.ToInt32(cboMembers.SelectedValue);
                var mineno = data.Members.Where(c => c.Id == member).FirstOrDefault().MineNo;
                txtMine.Text = mineno;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cboLoans_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                var member = Convert.ToInt32(cboMembers.SelectedValue);
                var loanid = Convert.ToInt32(cboLoans.SelectedValue);
                

                var period = data.Loans.Where(c => c.MemberId == member && c.Id==loanid).FirstOrDefault()?.RepaymentPeriod;
                var total = data.Loans.Where(c => c.MemberId == member && c.Id == loanid).FirstOrDefault()?.AmountPayable;
                var mpay = total / period;
                var mpayde = Math.Round(Convert.ToDecimal(mpay), 2);
                txtAmount.Text = mpayde.ToString();
               // CalculateBalance();
            }
            catch (Exception)
            {
            }

        }
    }
}