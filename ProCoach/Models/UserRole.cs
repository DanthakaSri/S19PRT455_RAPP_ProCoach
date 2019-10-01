using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProCoach.Models
{
    public class UserRole
    {
        [Required][Key]
        public string RoleName { get; set; }
    }
}
