using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fushion2.Models
{
    public partial class Category
    {
        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }
        [Key]
        [Column("CategoryID")]
        public int CategoryId { get; set; }
    }
}
