using System;
using System.Collections.Generic;

namespace CRUD.EFCore.Domain.Model
{
    public sealed class Customer
    {
        public Guid CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public IList<Contact> Contacts { get; set; }
    }
}
