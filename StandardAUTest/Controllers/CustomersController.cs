using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using StandardsAUTest.Domain.Entities;
using StandardsAUTest.Domain.Entities.Dtos;
using StandardsAUTest.Domain.Interfaces;

namespace StandardAUTest.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ILogger<CustomersController> logger, ICustomerService customerService)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get All Customers
        /// </summary>
        /// <returns>List of CustomerDto</returns>
        [ProducesResponseType(typeof(IEnumerable<CustomerDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public Task<ActionResult<IEnumerable<CustomerDto>>> Get()
        {
        }
    }
}