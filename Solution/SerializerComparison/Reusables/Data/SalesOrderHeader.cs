using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reusables.Data
{
    [Table("SalesOrderHeader", Schema = "Sales")]
    public partial class SalesOrderHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesOrderHeader()
        {
            SalesOrderDetails = new List<SalesOrderDetail>();
        }

        [Key]
        public int SalesOrderID { get; set; }

        public byte RevisionNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DueDate { get; set; }

        public DateTime? ShipDate { get; set; }

        public byte Status { get; set; }

        public bool OnlineOrderFlag { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Required]
        [StringLength(25)]
        public string SalesOrderNumber { get; set; }

        [StringLength(25)]
        public string PurchaseOrderNumber { get; set; }

        [StringLength(15)]
        public string AccountNumber { get; set; }

        public int CustomerID { get; set; }

        public int? SalesPersonID { get; set; }

        public int? TerritoryID { get; set; }

        public int BillToAddressID { get; set; }

        public int ShipToAddressID { get; set; }

        public int ShipMethodID { get; set; }

        public int? CreditCardID { get; set; }

        [StringLength(15)]
        public string CreditCardApprovalCode { get; set; }

        public int? CurrencyRateID { get; set; }

        [Column(TypeName = "money")]
        public decimal SubTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal TaxAmt { get; set; }

        [Column(TypeName = "money")]
        public decimal Freight { get; set; }

        [Column(TypeName = "money")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal TotalDue { get; set; }

        [StringLength(128)]
        public string Comment { get; set; }

        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}
