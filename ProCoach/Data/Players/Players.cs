using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCoach.Data
{
    public class Player
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string DOB { get; set; }

        public string email { get; set; }
        public int Mobileno { get; set; }
        public int EmergencyContact { get; set; }



        public string Clubname { get; set; }
        public string Sports { get; set; }
        public string Team { get; set; }

    }
}
