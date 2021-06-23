using System.Collections.Generic;
using System.Threading.Tasks;
using StandardsAUTest.Domain.Entities.Dtos;
using StandardsAUTest.Domain.Entities.ViewModels;
using StandardsAUTest.Domain.Interfaces;

namespace StandardsAUTest.Application.Services
{
    public class CustomerService : ICustomerService
    {
        public CustomerService()
        {
        }

        public Task<IEnumerable<CustomerDto>> GetAllCustomers()
        {
            throw new System.NotImplementedException();
        }

        public Task<CustomerDto> CreateCustomer(CreateCustomerViewModel createCustomerViewModel)
        {
            throw new System.NotImplementedException();
        }
    }
}