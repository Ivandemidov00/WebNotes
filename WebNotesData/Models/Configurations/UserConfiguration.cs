using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebNotesData.Models.Configurations
{
    class UserConfiguration : IEntityTypeConfiguration<user>
    {
        public void Configure(EntityTypeBuilder<user> builder) 
        {
            builder.ToTable("user").HasKey(prop => prop.id);
            builder.Property(prop => prop.name).HasMaxLength(30);            
        }

    }
}
