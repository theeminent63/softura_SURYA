using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AdoMVC.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "Please Enter the Name")]
        public string CustomerName { get; set; }
        [Required]
        public string EmailID { get; set; }
        [Required]
        [StringLength(maximumLength: 10)]
        public string MobileNo { get; set; }
    }
}