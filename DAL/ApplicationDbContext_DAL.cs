using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace DAL
{
    public class ApplicationDbContext_DAL : DbContext
    {
        public ApplicationDbContext_DAL(DbContextOptions options)
            : base(options)
        {
        }

       
        //public DbSet<Club> Club { get; set; }
        //public DbSet<Coach> Coach { get; set; }
        //public DbSet<Player> Player { get; set; }
        //public DbSet<PracticeSession> PracticeSession { get; set; }
        //public DbSet<Schedule> Schedule { get; set; }

        //public DbSet<ProCoach.Data.practice_session> Practice_Session { get; set; }





    }

}