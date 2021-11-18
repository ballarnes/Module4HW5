using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Module4HW4.DataAccess.Entities;

namespace Module4HW4.DataAccess.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasKey(c => c.ClientId);
            builder.Property(c => c.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(c => c.LastName).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Age).IsRequired();

            builder.HasData(
                new Client { ClientId = 1, FirstName = "Tatyana", LastName = "Kovaleva", Age = 30, Email = "t.kovalyova@gmail.com" },
                new Client { ClientId = 2, FirstName = "Gleb", LastName = "Ivanov", Age = 37, Email = "glebbb30@yahoo.com" },
                new Client { ClientId = 3, FirstName = "Timur", LastName = "Isaev", Age = 28, Email = "timisaev29@gmail.com" },
                new Client { ClientId = 4, FirstName = "Lev", LastName = "Novikov", Age = 41, Email = "lion29481@meta.ua" },
                new Client { ClientId = 5, FirstName = "Timofey", LastName = "Kryukov", Age = 25, Email = "timofey.kryukovv1@outlook.com" });
        }
    }
}