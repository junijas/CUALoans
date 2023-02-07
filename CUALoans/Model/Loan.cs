namespace CUALoans.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Loan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Loan()
        {
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }

        public int? MemberId { get; set; }

        public decimal? Amount { get; set; }

        [Column(TypeName = "text")]
        public string Purpose { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? RepaymentPeriod { get; set; }

        public decimal? Rate { get; set; }
        public decimal? Interest { get; set; }

        public decimal? AmountPayable { get; set; }

        [StringLength(150)]
        public string Guarantor1 { get; set; }

        [StringLength(10)]
        public string MineNo1 { get; set; }

        [StringLength(50)]
        public string Guarantor2 { get; set; }

        [StringLength(50)]
        public string MineNo2 { get; set; }

        public int? UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreatedAt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? UpdatedAt { get; set; }

        [StringLength(15)]
        public string Status { get; set; }


        [StringLength(15)]
        public string LoanState { get; set; }

        public virtual Member Member { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
