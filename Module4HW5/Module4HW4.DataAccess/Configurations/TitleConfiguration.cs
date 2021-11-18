using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Module4HW4.DataAccess.Entities;

namespace Module4HW4.DataAccess.Configurations
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(t => t.TitleId);
            builder.Property(t => t.Name).IsRequired().HasMaxLength(50);

            builder.HasData(
                new Title() { TitleId = 1, Name = "Junior" },
                new Title() { TitleId = 2, Name = "Middle" },
                new Title() { TitleId = 3, Name = "Senior" });
        }
    }
}
