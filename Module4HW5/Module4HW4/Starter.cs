using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module4HW4.DataAccess;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.Json;

namespace Module4HW4
{
    public class Starter
    {
        public void Run()
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var dbOptionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var connectionString = configuration.GetConnectionString("Module4HW5");
            dbOptionsBuilder.UseSqlServer(connectionString, i => i.CommandTimeout(20));

            var applicationContext = new ApplicationContext(dbOptionsBuilder.Options);
            applicationContext.Database.Migrate();
            applicationContext.SaveChanges();
        }
    }
}