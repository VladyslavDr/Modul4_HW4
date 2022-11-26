using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Entities;

namespace Shop.Data.EntityConfigurations
{
    public class OrderEntityConfiguration : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.ToTable("Orders").HasKey(h => h.OrderId);
            builder.Property(p => p.OrderDate).HasMaxLength(7).IsRequired();

            builder.HasOne(h => h.Shipper)
                .WithMany(w => w.Orders)
                .HasForeignKey(h => h.ShipperId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(h => h.Payment)
                .WithMany(w => w.Orders)
                .HasForeignKey(h => h.PaymentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(h => h.Customer)
                .WithMany(w => w.Orders)
                .HasForeignKey(h => h.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
