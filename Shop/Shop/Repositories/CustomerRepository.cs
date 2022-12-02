using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Data.Entities;
using Shop.Models;

namespace Shop.Repositories
{
    public class CustomerRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CustomerRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddCustomer(string name, string address, string email, string phone)
        {
            var customer = new CustomerEntity()
            {
                Name = name,
                Address = address,
                Email = email,
                Phone = phone
            };

            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();

            return customer.CustomerId;
        }

        public CustomerEntity? GetCustomer(int id)
        {
            return _dbContext.Customers.FirstOrDefault(f => f.CustomerId == id);
        }

        public void DeleteCustomer(CustomerEntity customer)
        {
            _dbContext.Customers.Remove(customer);
            _dbContext.SaveChanges();
        }
    }
}
