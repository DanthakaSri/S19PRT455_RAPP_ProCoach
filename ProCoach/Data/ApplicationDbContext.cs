using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProCoach.Data;

namespace ProCoach.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProCoach.Data.Team> Team { get; set; }
        public DbSet<ProCoach.Data.Club> Club { get; set; }
        public DbSet<ProCoach.Data.Coach> Coach { get; set; }
        public DbSet<ProCoach.Data.Player> Player { get; set; }
        public DbSet<ProCoach.Data.PracticeSession> PracticeSession { get; set; }
        public DbSet<ProCoach.Data.Schedule> Schedule { get; set; }

        //public DbSet<ProCoach.Data.practice_session> Practice_Session { get; set; }





    }
}