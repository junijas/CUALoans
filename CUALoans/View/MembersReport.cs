using System;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class MembersReport : Form
    {
        public MembersReport()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void memRptViewer_Load(object sender, EventArgs e)
        {
            memRptViewer.Zoom(75);
            //   memRptViewer.
        }

        private void btnInActive_Click(object sender, EventArgs e)
        {

        }
    }
}
