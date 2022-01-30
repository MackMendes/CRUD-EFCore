using System;

namespace CRUD.EFCore.Domain.Model
{
    public sealed class Contact
    {
        public int ContactId { get; set; }

        public string ContactType { get; set; }

        public string Content { get; set; }

        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
