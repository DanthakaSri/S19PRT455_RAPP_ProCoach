using System.ComponentModel.DataAnnotations;

namespace ProCoach.Models
{
    public class Player
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "FirstName")]
        [Required]

        public string FirstName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Required]
        public string Dob { get; set; }

        [Display(Name = "Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public int Mobile_Number { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Club Name")]
        [Required]
        public string Club_Name { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Team Name")]
        [Required]
        public string Team { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Game Type")]
        [Required]

        public string Game_Type { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        [Required]
        public string Address { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

    }
}
