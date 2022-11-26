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
    public class OrderDetailEntityConfiguration : IEntityTypeConfiguration<OrderDetailEntity>
    {
        public void Configure(EntityTypeBuilder<OrderDetailEntity> builder)
        {
            builder.ToTable("OrderDetails").HasKey(h => h.OrderDetailId);
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.Discount).IsRequired();

            builder.HasOne(h => h.Product)
                .WithMany(w => w.OrderDetails)
                .HasForeignKey(h => h.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(h => h.Order)
                .WithMany(w => w.OrderDetails)
                .HasForeignKey(h => h.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
