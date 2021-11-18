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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(e => e.EmployeeId);
            builder.Property(e => e.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(50).IsRequired();
            builder.Property(e => e.HiredDate).IsRequired().HasColumnType("date");
            builder.Property(e => e.OfficeId).IsRequired();
            builder.Property(e => e.TitleId).IsRequired();

            builder.HasOne(e => e.Title)
                .WithMany(t => t.Employees)
                .HasForeignKey(f => f.TitleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Office)
                .WithMany(o => o.Employees)
                .HasForeignKey(f => f.OfficeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Employee { EmployeeId = 1, DateOfBirth = new DateTime(1995, 05, 25), FirstName = "Igor", LastName = "Gorohov", HiredDate = new DateTime(2015, 07, 05), OfficeId = 1, TitleId = 3 },
                new Employee { EmployeeId = 2, DateOfBirth = new DateTime(1997, 01, 09), FirstName = "Ivan", LastName = "Gorohov", HiredDate = new DateTime(2015, 07, 05), OfficeId = 1, TitleId = 3 },
                new Employee { EmployeeId = 3, DateOfBirth = new DateTime(1980, 10, 13), FirstName = "Aleksandr", LastName = "Yakubovskiy", HiredDate = new DateTime(2016, 03, 20), OfficeId = 1, TitleId = 2 },
                new Employee { EmployeeId = 4, DateOfBirth = new DateTime(1988, 09, 08), FirstName = "Ekaterina", LastName = "Ponomarenko", HiredDate = new DateTime(2018, 08, 10), OfficeId = 1, TitleId = 1 },
                new Employee { EmployeeId = 5, DateOfBirth = new DateTime(1991, 07, 30), FirstName = "Maria", LastName = "Belova", HiredDate = new DateTime(2018, 10, 14), OfficeId = 1, TitleId = 2 });
        }
    }
}
