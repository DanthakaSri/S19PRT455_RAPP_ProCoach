using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProCoach.Data;
using ProCoach.Models;

namespace ProCoach.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Team> Team { get; set; }
        public DbSet<Club> Club { get; set; }
        public DbSet<Coach> Coach { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<PracticeSession> PracticeSession { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<ProCoach.Models.UserRole> UserRole { get; set; }


    }
}