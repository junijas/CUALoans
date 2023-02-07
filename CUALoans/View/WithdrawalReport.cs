using CUALoans.Controller;
using CUALoans.Model;
using CUALoans.Report;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class WithdrawalReport : Form
    {
        private readonly CUALoansData data = new CUALoansData();

        public WithdrawalReport()
        {
            InitializeComponent();
            AppController.LoadMembersCombo(cboMembers);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cboMembers_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void cboMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cboMembers.SelectedValue);
            var mineno = data.Members.FirstOrDefault(c => c.Id == id)?.MineNo;
            txtMine.Text = mineno;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cboMembers.SelectedValue);
            var mineno = data.Members.FirstOrDefault(c => c.Id == id)?.MineNo;
            txtMine.Text = mineno;
            try
            {
                var rpt = new MemberWithdrawal();

                rpt.SetParameterValue("@Member", id);
                rpt.SetParameterValue("@fromdate", dtFrom.Text);
                rpt.SetParameterValue("@todate", dtTo.Text);
                // rpt.SetParameterValue("@Todate", dtTo.Text);
                // contRptViewer.Zoom(75);
                withRptViewer.ReportSource = rpt;
            }
            catch (Exception)
            {
                MessageBox.Show($@"{"Failed to generate report please try later"}");
            }

        }

        private void btnTWith_Click(object sender, EventArgs e)
        {
            try
            {
                var rpt = new AllWithdrawal();
                rpt.SetParameterValue("@fromdate", dtFrom.Text);
                rpt.SetParameterValue("@todate", dtTo.Text);
                // contRptViewer.Zoom(75);
                withRptViewer.ReportSource = rpt;
            }
            catch (Exception)
            {
                MessageBox.Show($@"{"Failed to generate report please try later"}");
            }

        }
    }
}
