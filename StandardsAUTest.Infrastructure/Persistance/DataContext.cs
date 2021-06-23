using Microsoft.EntityFrameworkCore;
using StandardsAUTest.Domain.Entities;

namespace StandardsAUTest.Infrastructure.Persistance
{
    public class DataContext : DbContext, IDataContext
    {
        public DataContext(DbContextOptions options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}