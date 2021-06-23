using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StandardsAUTest.Domain.Entities;
using StandardsAUTest.Domain.Entities.Dtos;
using StandardsAUTest.Domain.Entities.ViewModels;
using StandardsAUTest.Domain.Interfaces;

namespace StandardsAUTest.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;

        public CustomerService(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public async Task<IEnumerable<CustomerDto>> GetAllCustomers()
        {
            var customers = await _customerRepo.GetAllCustomers();

            return customers.Select(c => new CustomerDto
            {
                Age = c.Age,
                DateOfBirth = c.DateOfBirth,
                Name = c.Name,
                PostCode = c.PostCode,
                State = c.State,
                MonthlyExpensesTotal = c.MonthlyExpensesTotal,
                Occupation = c.Occupation,
                SumOfValue = c.SumOfValue,
                Id = c.CustomerId
            }).ToList();
        }

        public async Task<int> CreateCustomer(CreateCustomerViewModel createCustomerViewModel)
        {
            var customer = new Customer
            {
                DateOfBirth = createCustomerViewModel.DateOfBirth,
                Age = createCustomerViewModel.Age,
                State = createCustomerViewModel.State,
                Occupation = createCustomerViewModel.Occupation,
                Name = createCustomerViewModel.Name,
                MonthlyExpensesTotal = createCustomerViewModel.MonthlyExpensesTotal,
                SumOfValue = createCustomerViewModel.SumOfValue,
                PostCode = createCustomerViewModel.PostCode
            };

            await _customerRepo.CreateCustomer(customer);
            return customer.CustomerId;
        }
    }
}