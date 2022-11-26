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
    public class ShipperEntityConfiguration : IEntityTypeConfiguration<ShipperEntity>
    {
        public void Configure(EntityTypeBuilder<ShipperEntity> builder)
        {
            builder.ToTable("Shippers").HasKey(h => h.ShipperId);
            builder.Property(p => p.CompanyName).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Phone).HasMaxLength(255).IsRequired();
        }
    }
}
