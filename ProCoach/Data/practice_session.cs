using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCoach.Data
{
    public class practice_session
    {

        public int id { get; set; }
        public int player_id  { get; set; }

        public int Coach_id { get; set; }

        public int team_id { get; set; }
        public int address { get; set; }
    }
}
