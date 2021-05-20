using Misa.Core.Entities;
using Misa.Core.Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace Misa.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        public int Delete(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetByid(Guid customerId)
        {
            throw new NotImplementedException();
        }

        public int Insert(Customer customer)
        {
            throw new NotImplementedException();
        }

        public int Update(Guid customerId, Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
