using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfRelationship.Models
{
    public class Student
    {
         public int StudentId { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }

    // One-to-One: A Student has one UserProfile
    public required UserProfile UserProfile { get; set; }

    // Many-to-Many: A Student can enroll in many Courses
    public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}