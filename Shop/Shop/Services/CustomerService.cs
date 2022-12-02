using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Shop.Data.Entities;
using Shop.Repositories;
using Shop.Models;

namespace Shop.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _customerRepository;
        private readonly ILogger<CustomerService> _loggerService; // почитать

        public CustomerService(CustomerRepository customerRepository, ILogger<CustomerService> loggerService)
        {
            _customerRepository = customerRepository;
            _loggerService = loggerService;
        }

        public int AddCustomer(string name, string address, string email, string phone)
        {
            var id = _customerRepository.AddCustomer(name, address, email, phone);
            _loggerService.LogInformation($"Created customer Name: {name}, Address: {address}, Email: {email}, Phone: {phone}");

            return id;
        }

        public void DeleteCustomer(int id)
        {
            CustomerEntity? customer = _customerRepository.GetCustomer(id);

            if (customer == null)
            {
                _loggerService.LogInformation($"Not founded customer with Id = {id}");
                throw new NullReferenceException();
            }

            _customerRepository.DeleteCustomer(customer);
            _loggerService.LogInformation($"Delete сustomer with Id = {customer.CustomerId}");
        }

        public Customer GetCustomer(int id)
        {
            var customer = _customerRepository.GetCustomer(id);

            if (customer == null)
            {
                _loggerService.LogInformation($"Not founded customer with Id = {id}");
                return null!; // почитать
            }

            return new Customer()
            {
                CustomerId = customer.CustomerId,
                Name = customer.Name,
                Address = customer.Address,
                Email = customer.Email,
                Phone = customer.Phone
            };
        }
    }
}
