using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfRelationship.Models
{
    public class Author
    {
         public int AuthorId { get; set; }
    public string? Name { get; set; }
    public string? Bio { get; set; }

    // One-to-Many: An Author can write many Books
    public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}