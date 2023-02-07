using CUALoans.Controller;
using CUALoans.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class Contribution : Form
    {
        private const int initial = 0;
        private readonly CUALoansData data = new CUALoansData();

        public Contribution()
        {
            InitializeComponent();
            dgvContribute.AutoGenerateColumns = false;
            AppController.LoadMembersCombo(cboMembers);
        }

        private void dgvContribute_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvContribute.CurrentRow != null)
            {
                var id = (int)dgvContribute.CurrentRow.Cells["CId"].Value;
                var datasource = data.Contributions.Where(x => x.Id == id).ToList();


                var columnedit = dgvContribute.Columns["job_edit"];
                var columndel = dgvContribute.Columns["job_del"];

                if (columnedit != null && e.ColumnIndex == columnedit.Index)
                {
                    // btnSaveCat.Text = "Update";

                    txtId.Text = id.ToString();
                    cboMembers.Text = dgvContribute.CurrentRow?.Cells["member"].Value.ToString();
                    txtAmount.Text = dgvContribute.CurrentRow?.Cells["amount"].Value.ToString();
                    txtPrevCont.Text = dgvContribute.CurrentRow?.Cells["amount"].Value.ToString();
                    txtMine.Text = dgvContribute.CurrentRow?.Cells["mine"].Value.ToString();
                    txtCurrentBal.Text = dgvContribute.CurrentRow?.Cells["total"].Value.ToString();
                    //  txtCurrentBal.Text = 
                    //  txtUTotal.Text = dgvContribute.CurrentRow?.Cells["amount"].Value.ToString();
                    dtDate.Text = dgvContribute.CurrentRow?.Cells["date"].Value.ToString();
                    //  txtDetails.Text = dgvContribute.CurrentRow?.Cells["details"].Value.ToString();
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
                            dgvContribute.DataSource = AppController.GetConTransaction();
                        }
                    }
                }
            }
        }

        private void Contribution_Load(object sender, EventArgs e)
        {
            dgvContribute.DataSource = AppController.GetConTransaction();
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
            txtPrevCont.Clear();
            txtUTotal.Clear(); txtMine.Clear();
            txtId.Clear();
            txtAmount.Clear();
            txtCurrentBal.Clear();
            cboMembers.ResetText();
            txtTotal.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateControls())
                {
                    var user = Dashboard.GetUser;
                    var id = data.Users.SingleOrDefault(a => a.username == user)?.user_id;

                    GetTotal();

                    //Adding a new record
                    if (string.IsNullOrEmpty(txtId.Text))
                    {
                        var add = new Model.Contribution
                        {
                            MemberId = Convert.ToInt32(cboMembers.SelectedValue?.ToString()),
                            Amount = Convert.ToDecimal(txtAmount.Text),
                            Date = dtDate.Value,
                            TotalContributed = Convert.ToDecimal(txtAmount.Text) +
                          Convert.ToDecimal(txtTotal.Text),

                            UserId = id
                        };

                        if (AppController.AddContribution(add))
                        {
                            MessageBox.Show(@"Records added successfully", @"Adding records", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            dgvContribute.DataSource = AppController.GetConTransaction();
                            cboMembers.Focus();
                            Clear();
                        }
                    }
                    // Update Records
                    else
                    {
                        var edit = new Model.Contribution
                        {
                            Id = Convert.ToInt32(txtId.Text),
                            MemberId = Convert.ToInt32(cboMembers.SelectedValue?.ToString()),
                            Amount = Convert.ToDecimal(txtAmount.Text),
                           // Other = txtDetails.Text,
                            Date = dtDate.Value,
                            TotalContributed = Convert.ToDecimal(txtAmount.Text) +
                          Convert.ToDecimal(txtTotal.Text),


                            UserId = id
                        };
                        //   LoadCombos();

                        if (AppController.UpdateContribution(edit))
                        {
                            MessageBox.Show(@"Records updated successfully", @"Updating records", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            dgvContribute.DataSource = AppController.GetConTransaction();
                            Clear();
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
          
        }

        private void CboMembers_SelectedValueChanged(object sender, EventArgs e)
        {


        }
        private void GetTotal()
        {
            try
            {
                var member = Convert.ToInt32(cboMembers.SelectedValue?.ToString());
                var check = data.Contributions.Where(y => y.Status == "Active").Any(z => z.MemberId == member);

                if (check)
                {
                    var total = data.Contributions.Where(x => x.MemberId == member)
                       .Max(y => y.TotalContributed).Value.ToString();
                    if (string.IsNullOrEmpty(txtId.Text))
                    {
                        txtTotal.Text = total;
                    }
                    else
                    {
                        var diff = Convert.ToDecimal(total) - Convert.ToDecimal(txtUTotal.Text);
                        txtTotal.Text = diff.ToString();
                    }

                }
                else
                {
                    txtTotal.Text = 0.ToString();
                }
            }
            catch (Exception)
            {

            }
        }
        private void cboMembers_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dgvContribute.DataSource = AppController.SearchContributions(txtSearch.Text);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = "Search ...";
        }
        private void cboMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                var mm = Convert.ToInt32(cboMembers.SelectedValue);
                var mineno = data.Members.FirstOrDefault(c => c.Id == mm)?.MineNo;
                // var department = data.Members.Where(c => c.Id == member).FirstOrDefault().Department;
                txtCurrentBal.Text = AppController.GetCurrentBalance(mm).ToString();
                txtMine.Text = mineno;
            }
            catch (Exception)
            {
                // ignored
            }
        }
        private void btnSaveTran_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {
                var user = Dashboard.GetUser;
                var id = data.Users.SingleOrDefault(a => a.username == user)?.user_id;

              //  GetTotal();

                //Adding a new record
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    var add = new Model.Transaction
                    {
                        MemberId = Convert.ToInt32(cboMembers.SelectedValue?.ToString()),
                        MonthlyContribution = Convert.ToDecimal(txtAmount.Text),
                        Date = dtDate.Value,
                        CurrentBalance = Convert.ToDecimal(txtCurrentBal.Text),
                        Deductions = 0,
                        XmasGoods = 0,
                        Soap=0,

                      //  TotalContributed = Convert.ToDecimal(txtAmount.Text) +
                      //Convert.ToDecimal(txtTotal.Text),

                        UserId = id
                    };
                 

                    if (AppController.AddTransaction(add))
                    {
                        MessageBox.Show(@"Records added successfully", @"Adding records", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        dgvContribute.DataSource = AppController.GetConTransaction();
                        Clear();
                        cboMembers.Focus();
                    }
                }
                // Update Records
                else
                {
                    var edit = new Model.Transaction
                    {
                        Id = Convert.ToInt32(txtId.Text),
                        MemberId = Convert.ToInt32(cboMembers.SelectedValue?.ToString()),
                        MonthlyContribution = Convert.ToDecimal(txtAmount.Text),
                        Date = dtDate.Value,
                        //CurrentBalance = Convert.ToDecimal(txtCurrentBal.Text),
                        UserId = id,
                        Deductions = 0,
                        XmasGoods = 0,
                        Soap = 0,
                    };
                    edit.CurrentBalance = Convert.ToDecimal(txtCurrentBal.Text) - Convert.ToDecimal(txtPrevCont.Text);
                    //   LoadCombos();

                    if (AppController.UpdateTransaction(edit))
                    {
                        MessageBox.Show(@"Records updated successfully", @"Updating records", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        dgvContribute.DataSource = AppController.GetConTransaction();
                        Clear();
                    }
                }
            }
        }

        private void GetBalance()
        {
            try
            {
                if (string.IsNullOrEmpty(txtAmount.Text))
                {
                    txtCurrentBal.Text = AppController.GetCurrentBalance(Convert.ToInt32(cboMembers.SelectedValue)).ToString();
                }
                else
                {
                    var itemid = Convert.ToInt32(cboMembers.SelectedValue);
                    txtCurrentBal.Text = AppController.GetTotalContribition(itemid, Convert.ToDecimal(txtAmount.Text)).ToString();
                }

            }
            catch (Exception)
            {
            }
        }
        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
           
           GetBalance();
        }
        private void btnInterest_Click(object sender, EventArgs e)
        {
            new Interest().ShowDialog();
        }

        private void dtDate_ValueChanged(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var bulk = new BulkDeleteCont(this);
            //new AddJobBook().ShowDialog();
            bulk.ShowDialog();
        }
    }
}