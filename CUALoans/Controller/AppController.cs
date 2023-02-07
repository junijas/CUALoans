using CUALoans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CUALoans.Controller
{
    class AppController
    {
        private static readonly CUALoansData data = new CUALoansData();

        #region Transactions
        public static bool AddTransaction(Transaction tr)
        {

            tr.CreatedAt = DateTime.Now;
            data.Transactions.Add(tr);
            data.SaveChanges();

            return true;
        }
        public static bool UpdateTransaction(Transaction tr)
        {
            var query = data.Transactions.Find(tr.Id);
            if (query != null)
            {
                query.MemberId = tr.MemberId;
                query.MonthlyContribution = tr.MonthlyContribution;
                query.Deductions = tr.Deductions;
                query.TotalContributed = tr.TotalContributed;
                query.TotalWithdrew = tr.TotalWithdrew;
                query.CurrentBalance = tr.CurrentBalance;
                query.Soap = tr.Soap;
                query.XmasGoods = tr.XmasGoods;
                query.Date = tr.Date;
                query.UpdatedAt = DateTime.Now;
            }
            data.SaveChanges();
            return true;
        }

        public static void RemoveTransaction(int id)
        {
            var query = data.Transactions.Find(id);
            if (query != null)
            {
                data.Transactions.Remove(query);

            }
            data.SaveChanges();
        }

        public static bool RemoveAllTransactions(int id, DateTime dt)
        {
            
            var query = data.Transactions.Where(x => x.MemberId == id && x.Date.Value >= dt.Date);
            data.Transactions.RemoveRange(query);
                //     data.Database.ExecuteSqlCommand("Delete from Transactions where ")
            data.SaveChanges();
            return true;
        }
       
        public static IEnumerable<dynamic> GetConTransaction()
        {
            try
            {
                var query = from c in data.Transactions
                    where c.MonthlyContribution != 0 && c.MonthlyContribution.ToString() != " "
                            select new
                            {
                                c.Id,
                                c.Member.Name,
                                c.Member.MineNo,
                                Amount = c.MonthlyContribution,
                                Total = c.CurrentBalance,
                                c.Date
                            };
                return query.OrderByDescending(a => a.Date).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Cannot Connect to Database Server, please check if the server is running");
            }
            return null;
        }

        public static IEnumerable<dynamic> GetWitTransaction()
        {
            try
            {
                var query = from c in data.Transactions
                            where c.MonthlyContribution == 0
                            select new
                            {
                                c.Id,
                                c.MemberId,
                                c.Member.Name,
                                c.Member.MineNo,
                                Balance = c.CurrentBalance,
                                c.Deductions, c.Soap, c.XmasGoods,
                                //  c.TotalWithdrew,
                                c.Date
                            };
                return query.OrderByDescending(a => a.Date).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Cannot Connect to Database Server, please check if the server is running");
            }
            return null;
        }

        public static decimal GetInitialBalance(int member)
        {
            var init = data.Transactions.SingleOrDefault(p => p.MemberId == member);
            if (init != null)
            {
                var initial = init.MonthlyContribution;
                return (decimal)initial;
            }
            return 0;
        }

        public static decimal GetCurrentBalance(int member)
        {
            var current = data.Transactions.OrderByDescending(x => x.Id).ToList()
                .FirstOrDefault(x => x.MemberId == member);

            if (current?.CurrentBalance != null) return (decimal)current.CurrentBalance;
            return GetInitialBalance(member);
        }
        public static decimal GetTotalContribition(int member, decimal mcon)
        {
            return GetCurrentBalance(member) + mcon;
        }

        #endregion Transactions

        #region Members
        public static IEnumerable<dynamic> SearchMembers(string search)
        {
            try
            {
                return data.Members.Where(a => a.Status.Equals("Active") && a.Name.Contains(search) ||
                   a.MineNo.Contains(search) || a.Department.Contains(search)).ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public static IEnumerable<Member> GetMembers()
        {
            try
            {
                return data.Members.Where(a => a.Status.Equals("Active")).OrderByDescending(x=>x.CreatedAt).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Cannot Connect to Database Server, please check if the server is running");
            }
            return null;
        }
        public static bool AddMember(Member mm)
        {
            try
            {
                mm.CreatedAt = DateTime.Now;
                data.Members.Add(mm);
                data.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;

        }

        public static bool UpdateMember(Member mm)
        {
            var query = data.Members.Find(mm.Id);
            if (query != null)
            {
                query.Name = mm.Name;
                query.MineNo = mm.MineNo;
                query.Department = mm.Department;
                query.Bank = mm.BankAccount;
                query.PhoneNumber = mm.PhoneNumber;
                query.Address = mm.Address;
                query.UpdatedAt = DateTime.Now;
            }

            data.SaveChanges();
            return true;
        }

        public static void RemoveMember(int id)
        {
            var query = data.Members.Find(id);
            if (query != null)
            {
                query.Status = "Resigned";
            }
            data.SaveChanges();
        }
        public static bool FindMineNo(string mine)
        {
            var exist = data.Members.Any(a => a.MineNo == mine);
            if (exist)
            {
                return true;
            }
            return false;
        }

        #endregion  Members

        #region Contributions
        public static IEnumerable<dynamic> SearchContributions(string search)
        {
            try
            {
                var query = from c in data.Transactions
                            where c.MonthlyContribution != 0 && (c.Member.Name.Contains(search)
                            || c.Member.MineNo.Contains(search))
                            select new
                            {
                                c.Id,
                                c.Member.Name,
                                c.Member.MineNo,
                                Amount = c.MonthlyContribution,
                                Total = c.CurrentBalance,
                                c.Date
                            };
                return query.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public static IEnumerable<dynamic> GetContributions()
        {
            try
            {
                var query = from c in data.Contributions
                            where c.Status == "Active"
                            select new
                            {
                                c.Id,
                                c.Member.Name,
                                c.Member.MineNo,
                                Amount = c.Amount,
                                Total = c.TotalContributed,
                                c.Date,
                                c.Other,
                            };
                return query.ToList().OrderByDescending(a => a.Date);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Cannot Connect to Database Server, please check if the server is running");
            }
            return null;
        }
        public static bool AddContribution(Contribution cont)
        {
            try
            {

                cont.CreatedAt = DateTime.Now;
                cont.Status = "Active";
                data.Contributions.Add(cont);
                data.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;

        }

        public static bool UpdateContribution(Contribution cont)
        {
            var query = data.Contributions.Find(cont.Id);
            if (query != null)
            {

                query.MemberId = cont.MemberId;
                query.Amount = cont.Amount;
                query.Other = cont.Other;
                query.TotalContributed = cont.TotalContributed;
                query.Date = cont.Date;
                query.UpdatedAt = DateTime.Now;
            }

            data.SaveChanges();
            return true;
        }

        public static void DeleteContribution(int id)
        {
            var query = data.Contributions.Find(id);
            if (query != null)
            {
                data.Contributions.Remove(query);
            }
            data.SaveChanges();
        }
        public static void LoadMembersCombo(ComboBox cb)
        {
            try
            {
                cb.DisplayMember = "Name";
                cb.ValueMember = "Id";
                cb.DataSource = (from mm in data.Members
                                 where mm.Status == "Active"
                                 select new { mm.Id, mm.Name }).Distinct().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void LoadYearsCombo(ComboBox cb)
        {
            try
            {
                cb.DisplayMember = "Year";
                // cb.ValueMember = "Id";
                cb.DataSource = (from mm in data.Contributions
                                 where mm.Status == "Active"
                                 select new { Year = mm.Date.Value.Year }).Distinct().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion Contributions

        #region Withdrawals
        public static IEnumerable<dynamic> SearchWithdrawals(string search)
        {
            try
            {
                var query = from c in data.Transactions
                            where c.MonthlyContribution == 0 && (c.Member.Name.Contains(search)
                            || c.Member.MineNo.Contains(search))

                            select new
                            {
                                c.Id,
                                c.MemberId,
                                c.Member.Name,
                                c.Member.MineNo,
                                Balance = c.CurrentBalance,
                                c.Deductions,
                                c.Soap,
                                c.XmasGoods,
                                c.Date
                            };

                return query.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public static IEnumerable<dynamic> GetWithdrawals()
        {
            try
            {
                var query = from c in data.Withdrawals
                            where c.Status == "Active"
                            select new
                            {
                                c.Id,
                                c.Member.Name,
                                c.Member.MineNo,
                                c.Amount,
                                Total = c.TotalContributed,
                                c.Date,
                                c.Status,
                                c.Soap,
                                c.Xmas_Goods,
                                c.Balance,
                                c.TotalWithdrew
                            };
                return query.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Cannot Connect to Database Server, please check if the server is running");
            }
            return null;
        }
        public static bool Withdraw(Withdrawal wi)
        {
            wi.CreatedAt = DateTime.Now;

            wi.Status = "Active";
            data.Withdrawals.Add(wi);
            data.SaveChanges();

            return true;
            //try
            //{


            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //return false;

        }

        public static bool UpdateWithdrawals(Withdrawal with)
        {
            var query = data.Withdrawals.Find(with.Id);
            if (query != null)
            {

                query.MemberId = with.MemberId;
                query.Amount = with.Amount;
                query.Soap = with.Soap;
                query.Xmas_Goods = with.Xmas_Goods;
                query.Balance = with.Balance;
                query.TotalContributed = with.TotalContributed;
                query.TotalWithdrew = with.TotalWithdrew;
                query.Date = with.Date;
                // query.Status = with.Status;
                query.UpdatedAt = DateTime.Now;
            }

            data.SaveChanges();
            return true;
        }

        public static void DeleteWithdrawals(int id)
        {
            var query = data.Withdrawals.Find(id);
            if (query != null)
            {
                data.Withdrawals.Remove(query);
            }
            data.SaveChanges();
        }
        public static string GetTotalContribution(int member, DateTime dt)
        {
            try
            {
                var total = data.Contributions.Where(z => z.MemberId == member && z.Date.Value.Month == dt.Month).Max(x => x.TotalContributed).Value;
                return total.ToString();
            }
            catch (Exception)
            {

            }
            return null;
        }
        public static string GetTotalContributed(int member)
        {
            try
            {
                var total = data.Contributions.Where(z => z.MemberId == member).Max(x => x.TotalContributed).Value;
                return total.ToString();
            }
            catch (Exception)
            {

            }
            return null;
        }

        public static string GetBalance(int member)
        {

            var exist = data.Withdrawals.Any(z => z.MemberId == member);
            if (exist)
            {
                var balance = data.Withdrawals.Where(v => v.MemberId == member).Min(w => w.Balance).Value.ToString();
                return balance;

            }
            else
            {
                return GetTotalContributed(member);
            }
        }
        public static string WithdrawalBalance(int member, decimal amount)
        {
            var exist = data.Withdrawals.Any(z => z.MemberId == member);
            if (exist)
            {
                var balance = data.Withdrawals.Where(v => v.MemberId == member).Min(w => w.Balance).Value;
                return (balance -= amount).ToString();

            }
            else
            {
                return GetTotalContributed(member);
            }
        }
        public static string GetTotalWithdrew(int member)
        {
            var exist = data.Withdrawals.Any(z => z.MemberId == member);
            if (exist)
            {
                var total = data.Withdrawals.Where(v => v.MemberId == member).Max(w => w.TotalWithdrew).Value.ToString();
                return total;
            }
            return 0.ToString();
        }

        #endregion Withdrawals

        #region Loans
        public static IEnumerable<dynamic> SearchLoans(string search)
        {
            try
            {
                var query = from c in data.Loans
                            where c.Member.Name.Contains(search)
                            || c.Member.MineNo.Contains(search)
                            select new
                            {
                                c.Id,
                                Member = c.Member.Id,
                                c.Member.Name,
                                c.Member.MineNo,
                                c.Member.Department,
                                c.Amount,
                                c.Date,
                                c.Purpose,
                                c.Guarantor1,
                                c.Guarantor2,
                                c.RepaymentPeriod,
                                c.Interest,
                                c.AmountPayable,
                                c.MineNo1,
                                c.MineNo2,
                                c.Status,
                            };
                return query.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public static IEnumerable<dynamic> LoanRequests()
        {
            try
            {
                var query = from c in data.Loans
                                // where c.Status == "Active"
                            select new
                            {
                                c.Id,
                                Member = c.Member.Id,
                                c.Member.Name,
                                c.Member.MineNo,
                                c.Member.Department,
                                c.Amount,
                                c.Date,
                                c.Purpose,
                                c.Guarantor1,
                                c.Guarantor2,
                                c.RepaymentPeriod,
                                c.Interest,
                                c.Rate,
                                c.AmountPayable,
                                c.MineNo1,
                                c.MineNo2,
                                c.Status,

                            };
                return query.OrderByDescending(a => a.Date).ToList();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Cannot Connect to Database Server, please check if the server is running");
            }
            return null;
        }
        public static bool RequestLoan(Loan loan)
        {
            try
            {

                loan.CreatedAt = DateTime.Now;
                //  loan.Status = "Active";
                data.Loans.Add(loan);
                data.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;

        }

        public static bool UpdateLoanRequest(Loan loan)
        {
            var query = data.Loans.Find(loan.Id);
            if (query != null)
            {

                query.MemberId = loan.MemberId;
                query.Amount = loan.Amount;
                query.Purpose = loan.Purpose;
                query.Rate = loan.Rate;
                query.Interest = loan.Interest;
                query.AmountPayable = loan.AmountPayable;
                query.RepaymentPeriod = loan.RepaymentPeriod;
                query.Guarantor1 = loan.Guarantor1;
                query.Guarantor2 = loan.Guarantor2;
                query.MineNo1 = loan.MineNo1;
                query.MineNo2 = loan.MineNo2;
                query.Amount = loan.Amount;
                query.UserId = loan.UserId;
                query.Status = loan.Status;
                query.UpdatedAt = DateTime.Now;

            }

            data.SaveChanges();
            return true;
        }

        public static void RemoveLoan(int id)
        {
            var query = data.Loans.Find(id);
            if (query != null)
            {
                data.Loans.Remove(query);

            }
            data.SaveChanges();
        }

        #endregion Loans

        #region Payments
        public static IEnumerable<dynamic> SearchPayments(string search)
        {
            try
            {
                var query = from c in data.Payments
                            where c.Status == "Active" && c.Member.Name.Contains(search)
                            || c.Member.MineNo.Contains(search)
                            select new
                            {
                                c.Id,
                                c.Member.Name,
                                c.Member.MineNo,
                                c.Balance,
                                c.Payment1,
                                c.TotalPaid,
                                c.Date,
                                Loan = c.Loan.AmountPayable,
                            };
                return query.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public static IEnumerable<dynamic> GetPayments()
        {
            try
            {
                var query = from c in data.Payments
                            where c.Status == "Active"
                            select new
                            {
                                c.Id,
                                c.Member.Name,
                                c.Member.MineNo,
                                c.Balance,
                                c.Payment1,
                                c.TotalPaid,
                                c.Date,
                                Loan = c.Loan.AmountPayable,
                            };
                return query.OrderByDescending(a => a.Date).Distinct().ToList();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Cannot Connect to Database Server, please check if the server is running");
            }
            return null;
        }
        public static bool PayLoan(Payment pay)
        {
            try
            {

                pay.CreatedAt = DateTime.Now;
                pay.Status = "Active";
                data.Payments.Add(pay);
                data.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;

        }

        public static bool UpdateLoanPayment(Payment pay)
        {
            var query = data.Payments.Find(pay.Id);
            if (query != null)
            {

                query.MemberId = pay.MemberId;
                query.TotalPaid = pay.TotalPaid;
                query.Payment1 = pay.Payment1;
                query.LoanId = pay.LoanId;
                query.Balance = pay.Balance;
                query.Date = pay.Date;
                // query.Status = pay.Status;
                query.Remarks = pay.Remarks;
                query.UpdatedAt = DateTime.Now; ;

            }

            data.SaveChanges();
            return true;
        }

        public static void DeletePayments(int id)
        {
            var query = data.Payments.Find(id);
            if (query != null)
            {
                data.Payments.Remove(query);
            }
            data.SaveChanges();
        }
        public static void CloseLoan (int id)
        {
            var query = data.Loans.Find(id);
            if (query!=null)
            {
                query.LoanState = "paid";
            }
            data.SaveChanges();
        }
        public static void LoadLoansCombo(int member, ComboBox cb)
        {
            try
            {
                cb.DisplayMember = "AmountPayable";
                cb.ValueMember = "Id";
                cb.DataSource = (from mm in data.Loans
                                 where mm.Status == "Approved" && mm.MemberId == member && 
                                 mm.LoanState=="inproc"
                                 select new { mm.Id, mm.AmountPayable }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string GetTotalPaid(int member)
        {
            var total = data.Payments.Where(z => z.MemberId == member).Max(x => x.TotalPaid).Value;
            return total.ToString();
        }

        #endregion  Payments
    }
}
