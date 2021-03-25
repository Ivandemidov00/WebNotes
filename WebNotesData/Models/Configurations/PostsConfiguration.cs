using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebNotesData.Models.Configurations
{
    class PostsConfiguration : IEntityTypeConfiguration<posts>
    {
        public void Configure(EntityTypeBuilder<posts> builder) 
        {
            builder.ToTable("posts").HasKey(prop => prop.id);
            builder.Property(prop => prop.post).HasMaxLength(500);
        }

    }
}
