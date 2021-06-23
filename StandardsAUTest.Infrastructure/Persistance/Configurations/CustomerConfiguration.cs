using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StandardsAUTest.Domain.Entities;
using StandardsAUTest.Domain.Types;

namespace StandardsAUTest.Infrastructure.Persistance.Configurations
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            var seeding = new Customer
            {
                Age = 30,
                MonthlyExpensesTotal = 100,
                Occupation = Occupation.Author,
                Name = "Test",
                DateOfBirth = DateTime.Parse("2020-01-01"),
                PostCode = "2000",
                State = "NSW",
                SumOfValue = 1000
            };

            builder.HasData(seeding);
        }
    }
}