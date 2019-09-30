using System;

namespace ProCoach.Models
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
