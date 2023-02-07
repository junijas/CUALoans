using CUALoans.Controller;
using CUALoans.Model;
using CUALoans.Report;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class Reports : Form
    {
        private readonly CUALoansData data = new CUALoansData();

        public Reports()
        {
            InitializeComponent();
            AppController.LoadMembersCombo(cboMembers);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        { 
            try
            {
                var id = Convert.ToInt32(cboMembers.SelectedValue);
                var from = dtFrom.Text;
                var to = dtTo.Text;

                var rpt = new TransactionStatement();

                rpt.SetParameterValue("@Member", id);
                rpt.SetParameterValue("@fromdate", from);
                rpt.SetParameterValue("@todate", to);

                rpt.SetParameterValue("@MemberId", id, rpt.Subreports[0].Name);
                rpt.SetParameterValue("@fromdate", from, rpt.Subreports[0].Name.ToString());
                rpt.SetParameterValue("@todate", to, rpt.Subreports[0].Name.ToString());

                //rpt.SetParameterValue("@Member", id, rpt.Subreports[1].Name);
                //rpt.SetParameterValue("@fromdate", from, rpt.Subreports[1].Name.ToString());
                //rpt.SetParameterValue("@todate", to, rpt.Subreports[1].Name.ToString());

                // contRptViewer.Zoom(75);
                stRptViewer.ReportSource = rpt;

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
        }

       
        private void btnAll_Click(object sender, EventArgs e)
        {
            

            var member = data.Members.Where(x => x.Status == "Active").ToList().Select(v => v.Id);
            var from = dtFrom.Text;
            var to = dtTo.Text;

            var rpt = new AllTransactionStatement();

           // rpt.SetParameterValue("@Member", member);
            rpt.SetParameterValue("@fromdate", from);
            rpt.SetParameterValue("@todate", to);

           // rpt.SetParameterValue("@MemberId", member, rpt.Subreports[0].Name);
            rpt.SetParameterValue("@fromdate", from, rpt.Subreports[0].Name.ToString());
            rpt.SetParameterValue("@todate", to, rpt.Subreports[0].Name.ToString());

            
            stRptViewer.ReportSource = rpt;
            try
            {
                

            }
            catch (Exception)
            {
                MessageBox.Show($@"{"Failed to generate report please try later"}");
            }

        }
    }
}