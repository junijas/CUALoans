using CUALoans.Controller;
using CUALoans.Model;
using CUALoans.Report;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class PaymentReport : Form
    {
        private readonly CUALoansData data = new CUALoansData();

        public PaymentReport()
        {
            InitializeComponent();
            payRptViewer.Zoom(73);
            AppController.LoadMembersCombo(cboMembers);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void payRptViewer_Load(object sender, EventArgs e)
        {

        }

        private void cboMembers_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                var rpt = new TotalPayments();

                rpt.SetParameterValue("@fromdate", dtFrom.Text);
                rpt.SetParameterValue("@todate", dtTo.Text);
                // contRptViewer.Zoom(75);
                payRptViewer.ReportSource = rpt;
            }
            catch (Exception)
            {
                MessageBox.Show($@"{"Failed to generate report please try later"}");
            }
        }

        private void cboMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cboMembers.SelectedValue);
            var mineno = data.Members.Where(c => c.Id == id).FirstOrDefault()?.MineNo;
            txtMine.Text = mineno;
            try
            {
                var rpt = new MemberPayments();

                rpt.SetParameterValue("@MemberId", id);
                // rpt.SetParameterValue("@Todate", dtTo.Text);
                // contRptViewer.Zoom(75);
                payRptViewer.ReportSource = rpt;
            }
            catch (Exception)
            {
                MessageBox.Show($@"{"Failed to generate report please try later"}");
            }
        }
    }
}
