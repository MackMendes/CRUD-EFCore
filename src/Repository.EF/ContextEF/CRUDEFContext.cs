using CRUD.EFCore.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace CRUD.EFCore.Repository.EF.ContextEF
{
    public class CRUDEFContext : DbContext
    {
        public CRUDEFContext(DbContextOptions<CRUDEFContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
            .HasOne(p => p.Customer)
            .WithMany(b => b.Contacts);
        }
    }
}
