using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ProCoach.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public int TeamId { get; set; }

        public int CoachId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

    }
}
