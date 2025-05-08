using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfRelationship.Models
{
    public class Book
    {
         public required int BookId { get; set; }
    public required string Title { get; set; }
    public string? Genre { get; set; }

    // Many-to-One: A Book belongs to one Author
    public required int AuthorId { get; set; }
    public required Author Author { get; set; }
    }
}