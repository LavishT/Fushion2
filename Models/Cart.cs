using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fushion2.Models
{
    public partial class Cart
    {
        [Key]
        [StringLength(100)]
        public string CartId { get; set; }
        [Required]
        [StringLength(10)]
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
