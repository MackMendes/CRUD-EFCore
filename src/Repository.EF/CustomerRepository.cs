using CRUD.EFCore.Domain.Core;
using CRUD.EFCore.Domain.Model;
using CRUD.EFCore.Repository.EF.ContextEF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUD.EFCore.Repository.EF
{
    public sealed class CustomerRepository : ICustomerRepository
    {
        private readonly CRUDEFContext context;

        public CustomerRepository(CRUDEFContext context)
        {
            this.context = context;
        }

        public void Add(Customer customer)
        {
            customer.CustomerId = Guid.NewGuid();

            this.context.Customers.Add(customer);
            this.context.SaveChanges();
        }

        public Customer GetById(Guid id)
        {
            return this.context.Customers.Find(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return this.context.Customers.ToList();
        }

        public void Update(Customer customer)
        {
            this.context.Entry(customer).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Remove(Customer customer)
        {
            this.context.Remove(customer);
            this.context.SaveChanges();
        }
    }
}
