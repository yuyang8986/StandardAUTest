using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using StandardsAUTest.Domain.Entities;
using StandardsAUTest.Domain.Entities.Dtos;
using StandardsAUTest.Domain.Entities.ViewModels;
using StandardsAUTest.Domain.Interfaces;

namespace StandardAUTest.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;
        private readonly ICustomerService _customerService;

        public CustomersController(ILogger<CustomersController> logger, ICustomerService customerService)
        {
            _logger = logger;
            _customerService = customerService;
        }

        /// <summary>
        /// Get All Customers
        /// </summary>
        /// <returns>List of CustomerDto</returns>
        [ProducesResponseType(typeof(IEnumerable<CustomerDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> Get()
        {
            var result = await _customerService.GetAllCustomers();
            return Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateCustomerViewModel createCustomerViewModel)
        {
            var result = await _customerService.CreateCustomer(createCustomerViewModel);
            _logger.LogInformation($"Created Customer: {result}");
            return Created($"/customers/{result}", null);
        }
    }
}