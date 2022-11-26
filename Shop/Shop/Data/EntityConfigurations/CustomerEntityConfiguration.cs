using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shop.Data.Entities;

namespace Shop.Data.EntityConfigurations
{
    internal class CustomerEntityConfiguration : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.ToTable("Customers").HasKey(h => h.CustomerId);
            builder.Property(p => p.Name).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Address).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(255).IsRequired();
            builder.Property(p => p.Phone).HasMaxLength(255).IsRequired();
        }
    }
}
