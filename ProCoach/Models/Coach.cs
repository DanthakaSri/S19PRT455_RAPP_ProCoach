using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProCoach.Models
{
    public class Coach
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Required]
        public  string Dob { get; set; }

        [StringLength(10, MinimumLength = 10)]
        [Display(Name = "Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string Mobile { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        [Required]
        public string Address { get; set; }

    }
}
