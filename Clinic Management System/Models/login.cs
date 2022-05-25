using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CMSProj.Models
{
    public class login
    {
            [Key]
        [Required]
        [Display(Name = "Invalid UserName")]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Invalid Password")]
        public string Password { get; set; }
        
    }
}
