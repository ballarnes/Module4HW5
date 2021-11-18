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
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(e => e.EmployeeProjectId);
            builder.Property(e => e.Rate).IsRequired();
            builder.Property(e => e.StartedDate).IsRequired();
            builder.Property(e => e.EmployeeId).IsRequired();
            builder.Property(e => e.ProjectId).IsRequired();

            builder.HasOne(e => e.Employee)
                .WithMany(p => p.EmployeeProject)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Project)
                .WithMany(p => p.EmployeeProject)
                .HasForeignKey(e => e.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
               new EmployeeProject() { EmployeeProjectId = 1, EmployeeId = 1, ProjectId = 1, Rate = 5000, StartedDate = new DateTime(2016, 05, 26) },
               new EmployeeProject() { EmployeeProjectId = 2, EmployeeId = 2, ProjectId = 1, Rate = 5000, StartedDate = new DateTime(2016, 05, 26) },
               new EmployeeProject() { EmployeeProjectId = 3, EmployeeId = 1, ProjectId = 2, Rate = 7000, StartedDate = new DateTime(2017, 09, 19) },
               new EmployeeProject() { EmployeeProjectId = 4, EmployeeId = 2, ProjectId = 2, Rate = 7000, StartedDate = new DateTime(2017, 09, 19) },
               new EmployeeProject() { EmployeeProjectId = 5, EmployeeId = 1, ProjectId = 3, Rate = 50000, StartedDate = new DateTime(2019, 04, 12) },
               new EmployeeProject() { EmployeeProjectId = 6, EmployeeId = 2, ProjectId = 3, Rate = 50000, StartedDate = new DateTime(2019, 04, 12) },
               new EmployeeProject() { EmployeeProjectId = 7, EmployeeId = 3, ProjectId = 3, Rate = 50000, StartedDate = new DateTime(2019, 04, 12) },
               new EmployeeProject() { EmployeeProjectId = 8, EmployeeId = 4, ProjectId = 3, Rate = 50000, StartedDate = new DateTime(2019, 04, 12) },
               new EmployeeProject() { EmployeeProjectId = 9, EmployeeId = 5, ProjectId = 3, Rate = 50000, StartedDate = new DateTime(2019, 04, 12) },
               new EmployeeProject() { EmployeeProjectId = 10, EmployeeId = 1, ProjectId = 4, Rate = 10000, StartedDate = new DateTime(2019, 10, 12) },
               new EmployeeProject() { EmployeeProjectId = 11, EmployeeId = 2, ProjectId = 5, Rate = 12000, StartedDate = new DateTime(2020, 01, 15) },
               new EmployeeProject() { EmployeeProjectId = 12, EmployeeId = 3, ProjectId = 6, Rate = 23000, StartedDate = new DateTime(2020, 05, 01) },
               new EmployeeProject() { EmployeeProjectId = 13, EmployeeId = 4, ProjectId = 6, Rate = 23000, StartedDate = new DateTime(2020, 05, 01) },
               new EmployeeProject() { EmployeeProjectId = 14, EmployeeId = 5, ProjectId = 6, Rate = 23000, StartedDate = new DateTime(2020, 05, 01) });
        }
    }
}
