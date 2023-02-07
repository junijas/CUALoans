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
    public partial class Interest : Form
    {
        public Interest()
        {
            InitializeComponent();
        }
        private static readonly CUALoansData Data = new CUALoansData();

        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                var rate = Convert.ToDecimal(txtRate.Text) / 100;
                var period = Convert.ToDecimal(dtEnd.Value.Subtract(dtStart.Value).Days / 30) ;
                //  lbEnd.Text = period.ToString();
                if (Data.Transactions != null)
                {
                    var recent = Data.Transactions.Where(x => x.Date >= dtStart.Value && x.Date <= dtEnd.Value && x.CurrentBalance > 0).AsEnumerable().OrderByDescending(x => x.Date).GroupBy(x => x.MemberId).
                        Select(x => x.First()).ToList();
                    if (recent.Count > 0)
                    {
                        foreach (var rec in recent)
                        {
                            rec.CreatedAt = DateTime.Now;
                            rec.Date = DateTime.Today.Date;
                            rec.Deductions = 0;
                            rec.MemberId = rec.MemberId;
                            rec.MonthlyContribution = 0;
                            rec.Soap = 0;
                            rec.XmasGoods = 0;
                            rec.TotalContributed = 0;
                            rec.Interest = (rec.CurrentBalance * rate * period) / 12;
                            rec.CurrentBalance += rec.Interest;
                            Data.Transactions.Add(rec);
                        }
                    }
                    Data.SaveChanges();
                    MessageBox.Show("Interest paid succesfully", "Interest Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No record found", "Interest Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Failed to generate interest, try again later");
            }
           

        }
    }
}
