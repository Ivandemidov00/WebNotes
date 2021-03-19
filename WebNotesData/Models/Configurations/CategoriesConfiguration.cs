using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebNotesData.Models.Configurations
{
    class CategoriesConfiguration : IEntityTypeConfiguration<categories>
    {
        public void Configure(EntityTypeBuilder<categories> builder)
        {
            builder.ToTable("categories").HasKey(prop => prop.id);
            builder.Property(prop => prop.name).HasMaxLength(50);
        }
    }
}
