using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fushion2.Models
{
    public partial class Customer
    {
        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(200)]
        public string Address { get; set; }
        [Required]
        [StringLength(13)]
        public string PhoneNo { get; set; }
        [Required]
        [StringLength(10)]
        public string PostalCode { get; set; }
        [Required]
        [StringLength(20)]
        public string Province { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }
    }
}
