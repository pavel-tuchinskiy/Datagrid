using Bogus;
using DataAccess.Data.Seed;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class GridDbContext : DbContext
    {
        public GridDbContext()
        {

        }
        public GridDbContext(DbContextOptions<GridDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrdersAndProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GridDbContext).Assembly);
        }
    }
}
