using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);
            builder.HasIndex(x => x.Email);

            builder.Property(x => x.FirstName).HasMaxLength(25);
            builder.Property(x => x.LastName).HasMaxLength(25);
            builder.Property(x => x.Email).HasMaxLength(256).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(50).IsRequired();

            builder.HasData(
                new User()
                {
                    Id = new Guid("84A011DB-4484-4140-AD1D-2E879668418D"),
                    FirstName = "Admin",
                    LastName = "Principal",
                    Email = "admin@admin.com",
                    Password = "admin123",
                    Profile = Domain.Enums.ProfileType.Admin,
                    DateCreated = DateTime.UtcNow,
                    IsActive = true,
                    IsDeleted = false
                });
        }
    }
}
