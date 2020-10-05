using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HomeInventory.Models;

namespace HomeInventory.Data
{
    public class HomeInventoryContext : DbContext
    {
        public HomeInventoryContext (DbContextOptions<HomeInventoryContext> options)
            : base(options)
        {
        }

        public DbSet<HomeInventory.Models.Item> Item { get; set; }

        public DbSet<HomeInventory.Models.Room> Room { get; set; }

        public DbSet<HomeInventory.Models.Category> Category { get; set; }
    }
}
