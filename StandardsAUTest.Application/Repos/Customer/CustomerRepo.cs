using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StandardsAUTest.Domain.Entities.Dtos;
using StandardsAUTest.Domain.Interfaces;
using StandardsAUTest.Infrastructure.Persistance;

namespace StandardsAUTest.Application.Repos.Customer
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly IDataContext _dataContext;

        public CustomerRepo(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Domain.Entities.Customer>> GetAllCustomers()
        {
            return await _dataContext.Customers.ToListAsync();
        }

        public async Task<Domain.Entities.Customer> CreateCustomer(Domain.Entities.Customer customer)
        {
            _dataContext.Customers.Add(customer);
            await _dataContext.SaveChangesAsync();
            return customer;
        }
    }
}