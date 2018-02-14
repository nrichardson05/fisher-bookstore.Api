using System;

namespace Fisher.Bookstore.Api.Models
{
    public class Author
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public DateTime PublishDate { get; set; }

        public string Publisher { get; set; }

        public string Name {get; set;}
    }
}