using CUALoans.Report;
using System;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class AllTransactionsReport : Form
    {
        public AllTransactionsReport()
        {
            InitializeComponent();
        }

        

        private void btnPreview_Click(object sender, EventArgs e)
        {

            var rpt = new AllTransactions();

            // contRptViewer.Zoom(75);
           try
            {
                rpt.SetParameterValue("@fromdate", dtFrom.Text);
                rpt.SetParameterValue("@todate", dtTo.Text);
                altRptViewer.ReportSource = rpt;
                altRptViewer.Zoom(60);
            }
            catch (Exception)
            {
                MessageBox.Show($@"{"Failed to generate report please try later"}");
            }

          
        }

        private void altRptViewer_Load(object sender, EventArgs e)
        {
            altRptViewer.Zoom(60);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AllTransactionsReport_Load(object sender, EventArgs e)
        {
            dtFrom.Focus();
        }
    }
}
