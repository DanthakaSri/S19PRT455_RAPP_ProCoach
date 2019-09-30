using System.ComponentModel.DataAnnotations;

namespace ProCoach.Models
{
    public class PracticeSession
    {
        [Display(Name = "PS")]
        public int Id { get; set; }

        
        public int Team_id { get; set; }

        public int Coach_id { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        [Required]

        public string Address { get; set; }

    }
}
