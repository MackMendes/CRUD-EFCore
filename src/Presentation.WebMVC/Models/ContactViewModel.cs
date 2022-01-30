namespace CRUD.EFCore.Presentation.WebMVC.Models
{
    public class ContactViewModel
    {
        public int ContactId { get; set; }

        public string ContactType { get; set; }

        public string Content { get; set; }

        public int CustomerId { get; set; }
    }
}
