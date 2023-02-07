namespace CUALoans.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transaction
    {
        public int Id { get; set; }

        public int? MemberId { get; set; }

        public decimal? MonthlyContribution { get; set; }

        public decimal? TotalContributed { get; set; }

        public decimal? Interest { get; set; }

        public decimal? Deductions { get; set; }

        public decimal? Soap { get; set; }

        public decimal? XmasGoods { get; set; }

        public decimal? TotalWithdrew { get; set; }

        public decimal? CurrentBalance { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? UserId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public virtual Member Member { get; set; }

        public virtual User User { get; set; }
    }
}
