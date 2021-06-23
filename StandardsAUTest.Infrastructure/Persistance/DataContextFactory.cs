using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace StandardsAUTest.Infrastructure.Persistance
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/../StandardAUTest/appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<DataContext>();
            var connection = configuration.GetConnectionString("Db");
            builder.UseSqlServer(connection, option =>
            {
            });
            return new DataContext(builder.Options);
        }
    }
}