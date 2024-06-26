﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).HasMaxLength(25);
            builder.Property(x => x.LastName).HasMaxLength(25);
            builder.Property(x => x.Email).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(50).IsRequired();

            builder.HasData(
                new User()
                {
                    Id = new Guid("84A011DB-4484-4140-AD1D-2E879668418D"),
                    FirstName = "Admin",
                    LastName = "Principal",
                    Email = "admin@admin.com",
                    Password = "admin123"
                }
                );
        }
    }
}
