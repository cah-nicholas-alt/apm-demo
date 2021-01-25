using EcommerceApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApi.Data
{
    public class EcommerceDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Ecommerce");

            var order = modelBuilder.Entity<Order>(o =>
            {
                o.ToTable("tblOrder");
                o.HasKey(o => o.OrderId);
                o.Property(o => o.OrderId).ValueGeneratedOnAdd();

                o.HasData(
                    new Order(1, 10.0m, .70m, 10.7m, "nick"),
                    new Order(2, 20.0m, 1.2m, 21.2m, "bob"),
                    new Order(3, 0.0m, .00m, 0.00m, "bob"));
            });

            modelBuilder.Entity<Product>(p =>
            {
                p.ToTable("tblProduct");
                p.HasKey(p => p.ProductId);
                p.Property(p => p.ProductId).ValueGeneratedOnAdd();

                p.HasData(
                    new Product(1, "Product A", 10),
                    new Product(2, "Product B", 5),
                    new Product(3, "Product C", 14),
                    new Product(4, "Product D", 76));
            });
        }
    }
}