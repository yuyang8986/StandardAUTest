using System.Collections.Generic;
using System.Threading.Tasks;
using StandardsAUTest.Domain.Entities.Dtos;
using StandardsAUTest.Domain.Entities.ViewModels;

namespace StandardsAUTest.Domain.Interfaces
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDto>> GetAllCustomers();

        Task<CustomerDto> CreateCustomer(CreateCustomerViewModel createCustomerViewModel);
    }
}