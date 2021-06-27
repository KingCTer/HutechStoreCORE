﻿using HutechStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HutechStore.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);

            builder.Property(x => x.LastName).IsRequired().HasMaxLength(200);

            builder.Property(x => x.Dob).IsRequired();
        }
    }
}
