using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CUALoans.Model
{
    public partial class CUALoansData : DbContext
    {
        public CUALoansData()
            : base("name=CuaLoansData")
        {
        }

        public virtual DbSet<Contribution> Contributions { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Withdrawal> Withdrawals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contribution>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Contribution>()
                .Property(e => e.TotalContributed)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Contribution>()
                .Property(e => e.Other)
                .IsUnicode(false);

            modelBuilder.Entity<Contribution>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.ItemName)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Loan>()
                .Property(e => e.Purpose)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.Interest)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Loan>()
                .Property(e => e.AmountPayable)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Loan>()
                .Property(e => e.Guarantor1)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.MineNo1)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.Guarantor2)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.MineNo2)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
               .Property(e => e.LoanState)
               .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.MineNo)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Department)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Bank)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.BankAccount)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Balance)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Payment1)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Payment>()
                .Property(e => e.TotalPaid)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.MonthlyContribution)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.TotalContributed)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Deductions)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Soap)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.XmasGoods)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.TotalWithdrew)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.CurrentBalance)
                .HasPrecision(10, 2);

            modelBuilder.Entity<User>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.salt)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Contributions)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Loans)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Members)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Payments)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Transactions)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Withdrawals)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Withdrawal>()
                .Property(e => e.TotalContributed)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Withdrawal>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Withdrawal>()
                .Property(e => e.Soap)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Withdrawal>()
                .Property(e => e.Xmas_Goods)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Withdrawal>()
                .Property(e => e.TotalWithdrew)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Withdrawal>()
                .Property(e => e.Balance)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Withdrawal>()
                .Property(e => e.Status)
                .IsUnicode(false);
        }
    }
}
