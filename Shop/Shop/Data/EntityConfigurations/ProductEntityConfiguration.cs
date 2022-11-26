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
    public class ProductEntityConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.ToTable("Products").HasKey(h => h.ProductId);
            builder.Property(p => p.ProductName).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Description).IsRequired();

            builder.HasOne(h => h.Supplier)
                .WithMany(w => w.Products)
                .HasForeignKey(h => h.SupplierId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(h => h.Category)
                .WithMany(w => w.Products)
                .HasForeignKey(h => h.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
