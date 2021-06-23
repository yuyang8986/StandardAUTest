using System.Collections.Generic;
using System.Threading.Tasks;
using StandardsAUTest.Domain.Entities;
using StandardsAUTest.Domain.Entities.Dtos;

namespace StandardsAUTest.Domain.Interfaces
{
    public interface ICustomerRepo
    {
        Task<IEnumerable<Domain.Entities.Customer>> GetAllCustomers();

        Task<int> CreateCustomer(Domain.Entities.Customer customer);
    }
}