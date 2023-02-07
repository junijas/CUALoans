namespace CUALoans.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment
    {
        public int Id { get; set; }

        public int? MemberId { get; set; }

        public int? LoanId { get; set; }

        public decimal? Balance { get; set; }

        [Column("Payment")]
        public decimal? Payment1 { get; set; }

        public decimal? TotalPaid { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [StringLength(150)]
        public string Remarks { get; set; }

        public int? UserId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [StringLength(15)]
        public string Status { get; set; }

        public virtual Loan Loan { get; set; }

        public virtual Member Member { get; set; }

        public virtual User User { get; set; }
    }
}
