using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSProj.Models
{
    public class AddPatient
    {
        [Key]
        [ForeignKey("PatientID")]
        public int PatientID { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Patient FName")]
        public string PFirstName { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Patient LName")]
        public string PLastName { get; set; }
        [Required]
        [Display(Name = "Missing Value")]
        public string Sex { get; set; }
        [Required]
        [Display(Name = "Missing Value")]
        public int Age { get; set; }
        [Required]
        [Display(Name = "Missing Value")]
        public string DateOfBirth { get; set; }
    }
}
