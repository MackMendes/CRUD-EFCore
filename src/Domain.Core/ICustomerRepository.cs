using CRUD.EFCore.Domain.Model;
using System;
using System.Collections.Generic;

namespace CRUD.EFCore.Domain.Core
{
    public interface ICustomerRepository
    {
        public void Add(Customer customer);

        public Customer GetById(Guid id);

        public IEnumerable<Customer> GetAll();

        public void Update(Customer customer);

        public void Remove(Customer customer);
    }
}
