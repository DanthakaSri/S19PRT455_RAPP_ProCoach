using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.DAL
{
    public class EfBookContext: DbContext

    {
        public EfBookContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
    }
}
