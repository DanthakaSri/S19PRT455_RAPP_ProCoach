using System.ComponentModel.DataAnnotations;

namespace ProCoach.Models
{
    public class Club
    {

        public int ID { get; set; }

        [StringLength(10, MinimumLength = 3)]
        [Required]
        public string Sport { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        [Required]
        public string Address { get; set; }


        [StringLength(10, MinimumLength = 10)]
        [Display(Name = "Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string Phone { get; set; }


        [StringLength(10, MinimumLength = 10)]
        [Display(Name = "Website")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Website { get; set; }
    }
}

    
