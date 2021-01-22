using FulfillmentApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FulfillmentApi.Data
{
    public class FulfillmentDbContext : DbContext
    {
        public DbSet<OrderItem> OrderItems { get; set; }

        public FulfillmentDbContext(DbContextOptions<FulfillmentDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Fulfillment");
            modelBuilder.Entity<OrderItem>(o =>
            {
                o.ToTable("tblOrderItem");
                o.HasKey(o => o.OrderItemId);
                o.Property(o => o.OrderItemId).ValueGeneratedOnAdd();

                o.HasData(
                    new OrderItem(1, 1, 1, "shipped"),
                    new OrderItem(2, 2, 1, "shipped"),
                    new OrderItem(3, 2, 2, "pending"),
                    new OrderItem(4, 2, 2, "pending"),
                    new OrderItem(5, 3, 4, "canceled"));
            });

        }
    }
}