using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reusables.Data
{
    [Table("SalesOrderDetail", Schema = "Sales")]
    public partial class SalesOrderDetail
    {
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesOrderID { get; set; }

        [Column(Order = 1)]
        public int SalesOrderDetailID { get; set; }

        [StringLength(25)]
        public string CarrierTrackingNumber { get; set; }

        public short OrderQty { get; set; }

        public int ProductID { get; set; }

        public int SpecialOfferID { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal UnitPriceDiscount { get; set; }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal LineTotal { get; set; }

        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual SalesOrderHeader SalesOrderHeader { get; set; }
    }
}
