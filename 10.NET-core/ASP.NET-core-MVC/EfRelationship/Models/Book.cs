using System;

namespace EfRelationship.Models
{
    public class Book
    {
        public  int BookId { get; set; }
        public   required string Title { get; set; }
        public string? Genre { get; set; }

        // Foreign key
        public  int AuthorId { get; set; }

        // Navigation property
        public  Author? Author { get; set; }
    }
}
