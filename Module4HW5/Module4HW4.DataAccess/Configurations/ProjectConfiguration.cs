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
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.ProjectId);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Budget).IsRequired();
            builder.Property(p => p.StartedDate).IsRequired();
            builder.Property(p => p.ClientId).IsRequired();

            builder.HasOne(p => p.Client)
                .WithMany(c => c.Projects)
                .HasForeignKey(p => p.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Project() { ProjectId = 1, Name = "Finui Infotech", Budget = 5000, ClientId = 1, StartedDate = new DateTime(2016, 05, 26) },
                new Project() { ProjectId = 2, Name = "Mobigradles", Budget = 7000, ClientId = 2, StartedDate = new DateTime(2017, 09, 19) },
                new Project() { ProjectId = 3, Name = "Metacafe", Budget = 50000, ClientId = 2, StartedDate = new DateTime(2019, 04, 12) },
                new Project() { ProjectId = 4, Name = "Binary Bit", Budget = 10000, ClientId = 3, StartedDate = new DateTime(2019, 10, 12) },
                new Project() { ProjectId = 5, Name = "Hexagon Entertainment", Budget = 12000, ClientId = 4, StartedDate = new DateTime(2020, 01, 15) },
                new Project() { ProjectId = 6, Name = "TWS System", Budget = 23000, ClientId = 5, StartedDate = new DateTime(2020, 05, 01) });
        }
    }
}
