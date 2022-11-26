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
    public class SupplierEntitiyConfiguration : IEntityTypeConfiguration<SupplierEntitiy>
    {
        public void Configure(EntityTypeBuilder<SupplierEntitiy> builder)
        {
            builder.ToTable("Suppliers").HasKey(h => h.SupplierId);
            builder.Property(p => p.CompanyName).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Address1).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Address2).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Phone).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Notes).IsRequired();

            builder.HasOne(h => h.Customer)
                .WithMany(w => w.Suppliers)
                .HasForeignKey(h => h.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
