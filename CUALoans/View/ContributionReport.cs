using CUALoans.Controller;
using CUALoans.Model;
using CUALoans.Report;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class ContributionReport : Form
    {
        private readonly CUALoansData data = new CUALoansData();

        public ContributionReport()
        {
            InitializeComponent();
            AppController.LoadMembersCombo(cboMembers);
            contRptViewer.Zoom(75);

            //  AppController.LoadYearsCombo(cboYear);
        }

        private void cboMembers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            

        }

        private void ContributionReport_Load(object sender, EventArgs e)
        {
           // contRptViewer.Zoom(75);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void contRptViewer_Load(object sender, EventArgs e)
        {
            //contRptViewer.Zoom(50);
        }

        private void cboYear_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cboMembers.SelectedValue);

            var rpt = new MemberContributions();
           
            // contRptViewer.Zoom(75);
            contRptViewer.ReportSource = rpt;
            try
            {
                rpt.SetParameterValue("@Member", id);
                rpt.SetParameterValue("@fromdate", dtFrom.Text);
                rpt.SetParameterValue("@todate", dtTo.Text);
            }
            catch (Exception)
            {
                MessageBox.Show($@"{"Failed to generate report please try later"}");
            }

        }

        private void cboMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cboMembers.SelectedValue);
            var mineno = data.Members.FirstOrDefault(c => c.Id == id)?.MineNo;
            txtMine.Text = mineno;
            //try
            //{
            //    var rpt = new MemberContributions();

            //    rpt.SetParameterValue("@MemberId", id);
             
            //    contRptViewer.ReportSource = rpt;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show($@"{"Failed to generate report please try later"}");
            //}
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {
                var rpt = new AllContributions();
                rpt.SetParameterValue("@fromdate", dtFrom.Text);
                rpt.SetParameterValue("@todate", dtTo.Text);
                // contRptViewer.Zoom(75);
                contRptViewer.ReportSource = rpt;
            }
            catch (Exception)
            {
                MessageBox.Show($@"{"Failed to generate report please try later"}");
            }
        }
    }
}
