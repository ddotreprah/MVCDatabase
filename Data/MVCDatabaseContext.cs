using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCDatabase.Data
{
    public class MVCDatabaseContext : DbContext
    {
        public MVCDatabaseContext(DbContextOptions<MVCDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }

    }
}
