using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCoach.Data
{
    public class Players
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string DOB { get; set; }

        public string Email { get; set; }
        public int Mobile_Number { get; set; }
        public int Emergency_Contact { get; set; }



        public string Club_Name { get; set; }
        public string Sports { get; set; }
        public string Team { get; set; }

    }
}
