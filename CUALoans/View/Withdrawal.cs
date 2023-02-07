using CUALoans.Controller;
using CUALoans.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class Withdrawal : Form
    {
        private readonly CUALoansData data = new CUALoansData();

        public Withdrawal()
        {
            InitializeComponent();
            dgvWithdraw.AutoGenerateColumns = false;
            AppController.LoadMembersCombo(cboMembers);
        }

        private bool ValidateControls()
        {
            timer1.Start();
            var valid = true;

            if (string.IsNullOrEmpty(cboMembers.Text))
            {
                errorProvider1.SetError(cboMembers, @"Select member");
                cboMembers.Focus();
                valid = false;
            }

            //else if (string.IsNullOrEmpty(txtAmount.Text))
            //{
            //    errorProvider1.SetError(txtAmount, @"Amount is required");
            //    txtAmount.Focus();
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
            txtSoap.Clear();
            txtXmas.Clear();
            txtId.Clear();
            txtAmount.Clear();
            cboMembers.ResetText();
            txtTAmount.Clear();
            txtWith.Clear();
            txtOldAmt.Clear();
            txtMine.Clear();
            txtOldBal.Clear();
            txtBalance.Clear();
            txtOldWith.Clear();
            txtPrevBalance.Clear();
            txtOldSoap.Clear();
            txtOldXmas.Clear();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // try
            // {
            var mybal = Convert.ToDecimal(txtBalance.Text);
            if (mybal <= 0) return;
            if (ValidateControls())
            {
                var user = Dashboard.GetUser;
                var id = data.Users.SingleOrDefault(a => a.username == user)?.user_id;


                //Adding a new record
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    var add = new Model.Withdrawal
                    {
                        MemberId = Convert.ToInt32(cboMembers.SelectedValue?.ToString()),
                        Amount = Convert.ToDecimal(txtAmount.Text),
                        Balance = Convert.ToDecimal(txtBalance.Text),
                        Soap = Convert.ToDecimal(txtSoap.Text),
                        Xmas_Goods = Convert.ToDecimal(txtXmas.Text),
                        Date = dtDate.Value,
                        TotalContributed = Convert.ToDecimal(txtTAmount.Text),
                        TotalWithdrew = Convert.ToDecimal(txtWith.Text) + Convert.ToDecimal(txtAmount.Text)
                        + Convert.ToDecimal(txtSoap.Text) + Convert.ToDecimal(txtXmas.Text),
                        UserId = id
                    };

                    if (AppController.Withdraw(add))
                    {
                        MessageBox.Show(@"Records added successfully", @"Adding records", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        dgvWithdraw.DataSource = AppController.GetWitTransaction();
                        Clear();
                    }
                }
                // Update Records
                else
                {
                    var edit = new Model.Withdrawal
                    {
                        Id = Convert.ToInt32(txtId.Text),

                        MemberId = Convert.ToInt32(cboMembers.SelectedValue?.ToString()),
                        Amount = Convert.ToDecimal(txtAmount.Text),
                        Balance = Convert.ToDecimal(txtBalance.Text),
                        Date = dtDate.Value,
                        Soap = Convert.ToDecimal(txtSoap.Text),
                        Xmas_Goods = Convert.ToDecimal(txtXmas.Text),
                        TotalContributed = Convert.ToDecimal(txtTAmount.Text),
                        TotalWithdrew = Convert.ToDecimal(txtWith.Text) + Convert.ToDecimal(txtAmount.Text)
                        + Convert.ToDecimal(txtSoap.Text) + Convert.ToDecimal(txtXmas.Text),

                        UserId = id
                    };
                    //   LoadCombos();

                    if (AppController.UpdateWithdrawals(edit))
                    {
                        MessageBox.Show(@"Records updated successfully", @"Updating records", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        dgvWithdraw.DataSource = AppController.GetWitTransaction();
                        Clear();
                    }
                }
            }


            //	}
            //	catch (Exception ex)
            //   {

            //       MessageBox.Show(ex.Message);
            //   }

        }

        private void Withdrawal_Load(object sender, EventArgs e)
        {
            dgvWithdraw.DataSource = AppController.GetWitTransaction();
            cboMembers.Focus();
        }
        private void GetOldData()
        {
            try
            {
                var member = Convert.ToInt32(cboMembers.SelectedValue.ToString());

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    txtTAmount.Text = AppController.GetCurrentBalance(member).ToString();
                    //  txtPrevBalance.Text = AppController.GetBalance(member);
                    //   txtWith.Text = AppController.GetTotalWithdrew(member);

                }
            }
            catch (Exception)
            {
            }
           
        }


        private void Calculate()
        {
            try
            {
                var member = Convert.ToInt32(cboMembers.SelectedValue.ToString());

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    txtPrevBalance.Text = AppController.GetBalance(member);


                    if (string.IsNullOrEmpty(txtSoap.Text))
                    {
                        txtSoap.Text = 0.ToString();
                    }
                    if (string.IsNullOrEmpty(txtAmount.Text))
                    {
                        txtAmount.Text = 0.ToString();
                    }
                    if (string.IsNullOrEmpty(txtXmas.Text))
                    {
                        txtXmas.Text = 0.ToString();
                    }
                    var soap = Convert.ToDecimal(txtSoap.Text);
                    var amt = Convert.ToDecimal(txtAmount.Text);
                    var xmas = Convert.ToDecimal(txtXmas.Text);
                    var sumwith = amt + soap + xmas;
                    txtBalance.Text = (Convert.ToDecimal(txtPrevBalance.Text) - sumwith).ToString();
                }
                else
                {
                    //txtWith.Text = AppController.GetTotalWithdrew(member);
                    txtTAmount.Text = AppController.GetTotalContributed(member);
                    if (string.IsNullOrEmpty(txtSoap.Text))
                    {
                        txtSoap.Text = 0.ToString();
                    }
                    if (string.IsNullOrEmpty(txtAmount.Text))
                    {
                        txtAmount.Text = 0.ToString();
                    }
                    if (string.IsNullOrEmpty(txtXmas.Text))
                    {
                        txtXmas.Text = 0.ToString();
                    }
                    var soap = Convert.ToDecimal(txtSoap.Text);
                    var amt = Convert.ToDecimal(txtAmount.Text);
                    var xmas = Convert.ToDecimal(txtXmas.Text);
                    var sumwith = amt + soap + xmas;

                    var total = Convert.ToDecimal(txtTAmount.Text);
                    var oldbal = Convert.ToDecimal(txtOldBal.Text);
                    var oldsoap = Convert.ToDecimal(txtOldSoap.Text);
                    var oldxmas = Convert.ToDecimal(txtOldXmas.Text);
                    var oldamt = Convert.ToDecimal(txtOldAmt.Text);
                    var oldwith = Convert.ToDecimal(txtOldWith.Text);
                    //	var amount = Convert.ToDecimal(txtAmount.Text);

                    txtBalance.Text = ((oldbal + oldamt + oldsoap + oldxmas) - (sumwith)).ToString();
                    txtWith.Text = (oldwith - (oldamt + oldsoap + oldxmas)).ToString();
                }
            }
            catch (Exception)
            {
            }
        }

      
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Calculate();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.ClearUndo();
            //dgvWithdraw.DataSource = AppController.GetWitTransaction();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dgvWithdraw.DataSource = AppController.SearchWithdrawals(txtSearch.Text);
        }


        private void txtAmount_Leave(object sender, EventArgs e)
        {
           // Calculate();
        }

        private void txtSoap_Leave(object sender, EventArgs e)
        {
            //Calculate();
        }

        private void txtXmas_Leave(object sender, EventArgs e)
        {
           // Calculate();

        }

        private void btnSaveTran_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                var user = Dashboard.GetUser;
                var id = data.Users.SingleOrDefault(a => a.username == user)?.user_id;


                //Adding a new record
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    var add = new Model.Transaction
                    { 
                       // Soap = Convert.ToDecimal(txtSoap.Text),
                       // XmasGoods = Convert.ToDecimal(txtXmas.Text),
                        Date = dtDate.Value,
                        UserId = id
                    };
                    add.MemberId = Convert.ToInt32(cboMembers.SelectedValue?.ToString());
                    add.MonthlyContribution = 0;
                    add.Deductions = Convert.ToDecimal(txtAmount.Text);
                    add.Soap = Convert.ToDecimal(txtSoap.Text);
                    add.XmasGoods = Convert.ToDecimal(txtXmas.Text);
                    add.CurrentBalance = AppController.GetCurrentBalance(Convert.ToInt32(add.MemberId)) - (add.Deductions + add.Soap + add.XmasGoods);

                if (AppController.AddTransaction(add))
                        {
                            MessageBox.Show(@"Records added successfully", @"Adding records", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            dgvWithdraw.DataSource = AppController.GetWitTransaction();
                            Clear();
                        }

                    cboMembers.Focus();
                }
                // Update Records
                else
                {
                    var edit = new Model.Transaction
                    {
                        Id = Convert.ToInt32(txtId.Text),

                        Date = dtDate.Value,
                      //  Soap = Convert.ToDecimal(txtSoap.Text),
                       // XmasGoods = Convert.ToDecimal(txtXmas.Text),
                       

                        UserId = id
                    };
                    edit.MemberId = Convert.ToInt32(cboMembers.SelectedValue?.ToString());
                    edit.MonthlyContribution = 0;
                    edit.Deductions = Convert.ToDecimal(txtAmount.Text);
                    edit.Soap = Convert.ToDecimal(txtSoap.Text);
                    edit.XmasGoods = Convert.ToDecimal(txtXmas.Text);
                    edit.CurrentBalance = Convert.ToDecimal(txtTAmount.Text) - (edit.Deductions + edit.Soap + edit.XmasGoods);

           
                        if (AppController.UpdateTransaction(edit))
                        {
                            MessageBox.Show(@"Records updated successfully", @"Updating records", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            dgvWithdraw.DataSource = AppController.GetWitTransaction();
                            Clear();
                        }
                    
                    
                }
            }

        }

        private void cboMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetOldData();

                var member = Convert.ToInt32(cboMembers.SelectedValue);
                var mineno = data.Members.Where(c => c.Id == member).FirstOrDefault().MineNo;
                // var department = data.Members.Where(c => c.Id == member).FirstOrDefault().Department;
                txtMine.Text = mineno;
                txtSoap.Text = 0.ToString();
                txtXmas.Text = 0.ToString();
                txtAmount.Text = 0.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void dgvWithdraw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvWithdraw.CurrentRow != null)
            {
                var id = (int)dgvWithdraw.CurrentRow.Cells["WId"].Value;
                //  var datasource = data.Contributions.Where(x => x.Id == id).ToList();


                var columnedit = dgvWithdraw.Columns["job_edit"];
                var columndel = dgvWithdraw.Columns["job_del"];

                if (columnedit != null && e.ColumnIndex == columnedit.Index)
                {

                    txtId.Text = id.ToString();
                    var mid = (int)dgvWithdraw.CurrentRow?.Cells["MId"].Value;
                    cboMembers.Text = dgvWithdraw.CurrentRow?.Cells["member"].Value.ToString();
                    txtMine.Text = dgvWithdraw.CurrentRow?.Cells["mineno"].Value.ToString();
                    txtAmount.Text = dgvWithdraw.CurrentRow?.Cells["amt"].Value.ToString();
                    txtSoap.Text = dgvWithdraw.CurrentRow?.Cells["soap"].Value.ToString();
                    txtXmas.Text = dgvWithdraw.CurrentRow?.Cells["xmas"].Value.ToString();
                    dtDate.Text = dgvWithdraw.CurrentRow?.Cells["date"].Value.ToString();
                    var sum = Convert.ToDecimal(txtAmount.Text) + Convert.ToDecimal(txtSoap.Text) + Convert.ToDecimal(txtXmas.Text);
                    txtTAmount.Text = (AppController.GetCurrentBalance(mid) + sum).ToString();
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
                            AppController.RemoveTransaction(id);
                            dgvWithdraw.DataSource = AppController.GetWitTransaction();
                        }
                    }
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var bulk = new BulkDeleteWith(this);
            //new AddJobBook().ShowDialog();
            bulk.ShowDialog(); ;
        }
    }
}