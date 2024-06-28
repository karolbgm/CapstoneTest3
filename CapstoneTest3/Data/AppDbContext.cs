using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CapstoneTest3.Models;

namespace CapstoneTest3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<CapstoneTest3.Models.Customer> Customers { get; set; } = default!;
        public DbSet<CapstoneTest3.Models.Employee> Employees { get; set; } = default!;
        public DbSet<CapstoneTest3.Models.Item> Items { get; set; } = default!;
        public DbSet<CapstoneTest3.Models.Order> Orders { get; set; } = default!;
        public DbSet<CapstoneTest3.Models.Orderline> Orderlines { get; set; } = default!;
    }
}
