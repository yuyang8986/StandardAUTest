using System.Reflection;
using Microsoft.EntityFrameworkCore;
using StandardsAUTest.Domain.Entities;

namespace StandardsAUTest.Infrastructure.Persistance
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}