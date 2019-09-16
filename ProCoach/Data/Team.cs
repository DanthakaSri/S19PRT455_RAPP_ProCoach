using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProCoach.Data
{
    public class Team
    {
        public int id { get; set; }

        [StringLength(10, MinimumLength = 3)]
        [Required]
        public  string  team_name  { get; set; }


        [Display(Name = "email")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string email { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string club { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string sport { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string  coaches { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string competition { get; set; }

       

        

    }
}
