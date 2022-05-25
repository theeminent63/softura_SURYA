using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CMSProj.Models
{
    public class AddDoctor
    {
        [Key]
        public int DoctorID { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Doctor's FName")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Doctor's LName")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Missing Value")]
        public string Sex { get; set; }
        [Required]
        [Display(Name = "Missing Value")]
        public string Specialization { get; set; }
        [Required]
        [Display(Name = "Missing Value")]
        public string VisitingHours { get; set; }
    }
}
