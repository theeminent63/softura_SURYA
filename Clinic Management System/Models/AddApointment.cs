using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CMSProj.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CMSProj.Models
{
    public class AddApointment
    {
        [Key]
        [ForeignKey("PatientID")]
        public int PatientID { get; set; }
        [Required]
        [Display(Name = "Missing Value")]
        public string Sepcialization { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Doctor's FName")]
        public string Doctor { get; set; }
        [Required]
        [Display(Name = "Missing Value")]
        public string VisitDate { get; set; }
        [Required]
        [Display(Name = "Missing Value")]
        public string AppointmentTime { get; set; }
    }
}
