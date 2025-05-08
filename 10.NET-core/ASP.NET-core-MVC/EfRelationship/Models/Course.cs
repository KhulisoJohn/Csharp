using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfRelationship.Models
{
    public class Course
    {
        
    public required int CourseId { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }

    // Many-to-Many: A Course can have many Students
    public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}