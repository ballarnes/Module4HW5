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
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(o => o.OfficeId);
            builder.Property(o => o.Title).IsRequired().HasMaxLength(100);
            builder.Property(o => o.Location).IsRequired().HasMaxLength(100);

            builder.HasData(
                new Office() { OfficeId = 1, Title = "Main Office", Location = "Kyiv" });
        }
    }
}
