using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfiguration
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CustomerName).HasMaxLength(100);
            builder.Property(x => x.CustomerEmail).HasMaxLength(256);
            builder.Property(x => x.TotalSalePrice).HasColumnType("decimal(10, 2)");

            builder.HasMany(x => x.SaleItems)
                .WithOne(x => x.Sale)
                .HasForeignKey(x => x.SaleId);
        }
    }
}
