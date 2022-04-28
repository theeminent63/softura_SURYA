using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewEF.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int ProductID { get; set; }
        public string ProdName { get; set; }
        public DateTime ManfDate { get; set; }
    }
}
