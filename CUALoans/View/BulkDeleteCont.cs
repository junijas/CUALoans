using CrystalDecisions.CrystalReports.ViewerObjectModel;
using CUALoans.Controller;
using CUALoans.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUALoans.View
{
    public partial class BulkDeleteCont : Form
    {
        private readonly CUALoansData data = new CUALoansData();
        private readonly Contribution conts;

       
        public BulkDeleteCont(Contribution cont)
        {
            InitializeComponent();
            conts = cont;
        }
        private static readonly CUALoansData Data = new CUALoansData();

        private void btnPay_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(cboMember.SelectedValue);
            if (AppController.RemoveAllTransactions(id,dtStart.Value.Date))
            {
                MessageBox.Show(@"Records deleted successfully");
                conts.dgvContribute.DataSource = AppController.GetConTransaction();
                this.Close();
            }
        }
        private void cboMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(cboMember.SelectedValue);
                var mineno = data.Members.FirstOrDefault(c => c.Id == id)?.MineNo;
                txtMine.Text = mineno;
            }
            catch (Exception exception)
            {
               
            }
           
        }

        private void BulkDelete_Load(object sender, EventArgs e)
        {
            AppController.LoadMembersCombo(cboMember);

        }
    }
}
