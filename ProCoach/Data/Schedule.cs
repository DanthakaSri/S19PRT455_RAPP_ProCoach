using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCoach.Data
{
    public class Schedule
    {
        public int Id { get; set; }
        public int TeamId { get; set; }

        public int CoachId { get; set; }
        public DateTime Date { get; set; }

        public int Time { get; set; }
    }
}
