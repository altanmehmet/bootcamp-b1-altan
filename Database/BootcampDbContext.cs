using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using net_core_bootcamp_b1_altan.Models;

namespace net_core_bootcamp_b1_altan.Database
{
    public class BootcampDbContext : DbContext
    {
        public BootcampDbContext(DbContextOptions<BootcampDbContext> options)
                : base(options)
        {

        }
        public DbSet<Book> Book { get; set; }

    }
}
