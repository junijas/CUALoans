namespace CUALoans.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contribution
    {
        public int Id { get; set; }

        public int? MemberId { get; set; }

        public decimal? Amount { get; set; }

        public decimal? TotalContributed { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [Column(TypeName = "text")]
        public string Other { get; set; }

        public int? UserId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [StringLength(15)]
        public string Status { get; set; }

        public virtual Member Member { get; set; }

        public virtual User User { get; set; }
    }
}
