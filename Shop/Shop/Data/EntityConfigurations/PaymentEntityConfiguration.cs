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
    public class PaymentEntityConfiguration : IEntityTypeConfiguration<PaymentEntity>
    {
        public void Configure(EntityTypeBuilder<PaymentEntity> builder)
        {
            builder.ToTable("Payment").HasKey(h => h.PaymentId);
            builder.Property(h => h.PaymentType).IsRequired();
            builder.Property(h => h.Allowed).IsRequired();
        }
    }
}
