using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public class Printer
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Brand { get; set; }
    }


    public class EfBridgeContext : DbContext
    {
        public EfBridgeContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<Printer> printer { get; set; }

    }
}
