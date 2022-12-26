using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WS.Data.EF
{
    public class WSDbContextFactory : IDesignTimeDbContextFactory<WSDbContext>
    {
        public WSDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("WSDatabase");    
            var optionsBuilder = new DbContextOptionsBuilder<WSDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new WSDbContext(optionsBuilder.Options);
        }
    }
}
