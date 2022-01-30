using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRUD.EFCore.Presentation.WebMVC.Models
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        {
            this.Contacts = new List<ContactViewModel>();
        }

        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public IList<ContactViewModel> Contacts { get; set; }
    }
}
