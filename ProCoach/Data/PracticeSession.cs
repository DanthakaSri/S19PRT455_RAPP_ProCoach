using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProCoach.Data
{
    public class PracticeSession
    {
        public int Id { get; set; }

        
        public int Team_id { get; set; }

        public int Coach_id { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        [Required]

        public string Address { get; set; }

    }
}
