using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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
    }
}