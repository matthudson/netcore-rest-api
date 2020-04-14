using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreRestApi.Auth.Dtos;
using NetCoreRestApi.Data;
using NetCoreRestApi.Data.Models;

namespace NetCoreRestApi.Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerRegistrationsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly ILogger<CustomerRegistrationsController> _logger;

        public CustomerRegistrationsController(DataContext context, ILogger<CustomerRegistrationsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // POST: api/CustomerRegistrations
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<int> PostCustomerRegistration(CustomerRegistrationDto customerRegistrationDto)
        {
            try
            {
                var customerRegistration =
                    new CustomerRegistration {
                        Forename = customerRegistrationDto.Forename,
                        Surname = customerRegistrationDto.Surname,
                        PolicyReferenceNumber = customerRegistrationDto.PolicyReferenceNumber,
                        Email = customerRegistrationDto.Email,
                        DateOfBirth = customerRegistrationDto.DateOfBirth
                    };

                _context.CustomerRegistrations.Add(customerRegistration);
                await _context.SaveChangesAsync();

                var customer =
                    new Customer {
                        Forename = customerRegistration.Forename,
                        Surname = customerRegistration.Surname,
                        Email = customerRegistration.Email,
                        DateOfBirth = customerRegistration.DateOfBirth,
                        CustomerRegistration = customerRegistration,
                        Policies = new List<Policy> { new Policy { ReferenceNumber = customerRegistration.PolicyReferenceNumber } }
                    };

                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();

                return customerRegistration.CustomerRegistrationId; // todo: online reference
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error occurred whilst registering the customer");
                throw;
            }
        }
    }
}
