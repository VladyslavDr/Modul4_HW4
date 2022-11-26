using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Entities;
using Shop.Data.EntityConfigurations;

namespace Shop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
            /*
            Database.EnsureDeleted();
            Database.EnsureCreated();
            */
        }

        public DbSet<CategoryEntity> Categories { get; set; } = null!;
        public DbSet<CustomerEntity> Customers { get; set; } = null!;
        public DbSet<OrderDetailEntity> OrderDetails { get; set; } = null!;
        public DbSet<OrderEntity> Orders { get; set; } = null!;
        public DbSet<PaymentEntity> Payments { get; set; } = null!;
        public DbSet<ProductEntity> Products { get; set; } = null!;
        public DbSet<ShipperEntity> Shippers { get; set; } = null!;
        public DbSet<SupplierEntitiy> Suppliers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ShipperEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierEntitiyConfiguration());
            modelBuilder.UseHiLo();
        }
    }
}
