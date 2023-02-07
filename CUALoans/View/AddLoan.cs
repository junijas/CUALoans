using CUALoans.Controller;
using CUALoans.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class AddLoan : Form
    {
        private readonly Loans loan;
        private readonly CUALoansData data = new CUALoansData();

        //public AddJobBook(JobBook jobs)
        //{
        //    InitializeComponent();
        //    _job = jobs;
        //    ChangeDateBackground();
        //    cbDept.Focus();
        //}

        public AddLoan(Loans loans)
        {
            InitializeComponent();
            ChangeDateBackground();
            AppController.LoadMembersCombo(cboLMembers);
            loan = loans;

        }

        private void ChangeDateBackground()
        {
            dtDate.BackColor = Color.FromArgb(10, 32, 80);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
            //  new Loans().dgvJobBook.DataSource = AppController.GetJobBook();
        }

        private bool ValidateControls()
        {
            timer1.Start();
            var valid = true;

            if (string.IsNullOrEmpty(cboLMembers.Text))
            {
                errorProvider1.SetError(cboLMembers, @"Select member");
                cboLMembers.Focus();
                valid = false;
            }

            else if (string.IsNullOrEmpty(txtInterest.Text))
            {
                errorProvider1.SetError(txtInterest, @"Amount is required");
                txtInterest.Focus();
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtPay.Text))
            {
                errorProvider1.SetError(txtPay, @"Payment period is required");
                txtPay.Focus();
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtG1.Text))
            {
                errorProvider1.SetError(txtG1, @"Guarantor 1  is required");
                txtG1.Focus();
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtG2.Text))
            {
                errorProvider1.SetError(txtG2, @"Guarantor 2 is required");
                txtG2.Focus();
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtM1.Text))
            {
                errorProvider1.SetError(txtM1, @"Guarantor's mine number is required");
                txtM1.Focus();
                valid = false;
            }
            else if (string.IsNullOrEmpty(txtM2.Text))
            {
                errorProvider1.SetError(txtM2, @"Guarantor's mine number is required");
                txtM2.Focus();
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
            cboLStatus.ResetText();
            txtMonth.Clear();
            txtPay.Clear();
            txtId.Clear();
            txtInterest.Clear();
            cboLMembers.ResetText();
            txtDept.Clear();
            txtDesc.Clear();
            txtM1.Clear();
            txtM2.Clear();
            txtG1.Clear();
            txtG2.Clear();
            txtMine.Clear();
            txtAmount.Clear();
            txtPeriod.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateControls())
                {
                    var user = Dashboard.GetUser;
                    var id = data.Users.SingleOrDefault(a => a.username == user)?.user_id;


                    //Adding a new record
                    if (string.IsNullOrEmpty(txtId.Text))
                    {
                        var add = new Model.Loan
                        {
                            MemberId = Convert.ToInt32(cboLMembers.SelectedValue?.ToString()),
                            Amount = Convert.ToDecimal(txtAmount.Text),
                            Purpose = txtDesc.Text,
                            RepaymentPeriod = Convert.ToInt32(txtPeriod.Text),
                            Rate = Convert.ToDecimal(txtRate.Text),
                            Interest = Convert.ToDecimal(txtInterest.Text),
                            AmountPayable = Convert.ToDecimal(txtPay.Text),
                            Guarantor1 = txtG1.Text,
                            Guarantor2 = txtG2.Text,
                            MineNo1 = txtM1.Text,
                            MineNo2 = txtM2.Text,
                            Date = dtDate.Value,
                            Status = cboLStatus.Text,
                            LoanState="inproc",
                            UserId = id
                        };

                        if (AppController.RequestLoan(add))
                        {
                            MessageBox.Show(@"Records added successfully", @"Adding records", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            loan.dgvLoans.DataSource = AppController.LoanRequests();
                            Clear();
                        }
                    }
                    // Update Records
                    else
                    {
                        var edit = new Model.Loan
                        {
                            Id = Convert.ToInt32(txtId.Text),
                            MemberId = Convert.ToInt32(cboLMembers.SelectedValue?.ToString()),
                            Amount = Convert.ToDecimal(txtAmount.Text),
                            Purpose = txtDesc.Text,
                            RepaymentPeriod = Convert.ToInt32(txtPeriod.Text),
                            Interest = Convert.ToDecimal(txtInterest.Text),
                            AmountPayable = Convert.ToDecimal(txtPay.Text),
                            Guarantor1 = txtG1.Text,
                            Guarantor2 = txtG2.Text,
                            MineNo1 = txtM1.Text,
                            MineNo2 = txtM2.Text,
                            Date = dtDate.Value,
                            Status = cboLStatus.Text,

                            UserId = id
                        };
                        //   LoadCombos();

                        if (AppController.UpdateLoanRequest(edit))
                        {
                            MessageBox.Show(@"Records updated successfully", @"Updating records", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            loan.dgvLoans.DataSource = AppController.LoanRequests();
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



        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);




        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            errorProvider1.Clear();
        }

        private void AddLoan_Load(object sender, EventArgs e)
        {

        }

        private void AddLoan_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void CalculateInterest()
        {
            if (string.IsNullOrEmpty(txtAmount.Text) || string.IsNullOrEmpty(txtPeriod.Text)) return;

            var period = Convert.ToDecimal(txtPeriod.Text) / 12;

           
                var principal = Convert.ToDecimal(txtAmount.Text);
                var rate = Convert.ToDecimal(txtRate.Text)/100; 
                var interest = principal * rate * period;
                txtInterest.Text = Math.Round(interest, 2).ToString();
                txtPay.Text = Math.Round((interest + principal), 2).ToString();
                var mpay = (Convert.ToDecimal(txtPay.Text) / Convert.ToInt32(txtPeriod.Text));
                txtMonth.Text = Math.Round(mpay, 2).ToString();


        }


        private void cboLMembers_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateInterest();
            }
            catch (Exception)
            {

            }

        }

        private void txtPeriod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateInterest();
            }
            catch (Exception)
            {

            }
        }

        private void txtMine_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void cboLMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var member = Convert.ToInt32(cboLMembers.SelectedValue);
                var mineno = data.Members.Where(c => c.Id == member).FirstOrDefault()?.MineNo;
                var department = data.Members.Where(c => c.Id == member).FirstOrDefault()?.Department;
                txtMine.Text = mineno;
                txtDept.Text = department;
            }
            catch (Exception)
            {
            }

        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateInterest();
            }
            catch (Exception)
            {

            }
        }
    }
}