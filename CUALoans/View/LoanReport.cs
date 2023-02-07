using CUALoans.Controller;
using CUALoans.Model;
using CUALoans.Report;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class LoanReport : Form
    {
        private readonly CUALoansData data = new CUALoansData();

        public LoanReport()
        {
            InitializeComponent();
            AppController.LoadMembersCombo(cboMembers);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cboMembers.SelectedValue);
            var mineno = data.Members.FirstOrDefault(c => c.Id == id)?.MineNo;
            txtMine.Text = mineno;
            try
            {
                var rpt = new MemberLoans();

                rpt.SetParameterValue("@MemberId", id);
                // rpt.SetParameterValue("@Todate", dtTo.Text);
                // contRptViewer.Zoom(75);
                loanRptViewer.ReportSource = rpt;
            }
            catch (Exception)
            {
                MessageBox.Show($@"{"Failed to generate report please try later"}");
            }


          
        }

        private void loanRptViewer_Load(object sender, EventArgs e)
        {
            loanRptViewer.Zoom(2);
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

       

        private void btnAllLoans_Click(object sender, EventArgs e)
        {
            try
            {
                var rpt = new AllLoans();

                rpt.SetParameterValue("@fromdate", dtFrom.Text);
                rpt.SetParameterValue("@todate", dtTo.Text);
                // contRptViewer.Zoom(75);
                loanRptViewer.ReportSource = rpt;
            }
            catch (Exception)
            {
                MessageBox.Show($@"{"Failed to generate report please try later"}");
            }
        }
    }
}
