using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fushion2.Models
{
    public partial class Order
    {
        [Key]
        public int OrderNo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime OrderDate { get; set; }
        public int OrderQuantity { get; set; }
        [Column("CustomerID")]
        public int CustomerId { get; set; }
    }
}
