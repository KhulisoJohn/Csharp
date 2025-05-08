using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfRelationship.Models
{
    public class UserProfile
    {
         public required int UserProfileId { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }

    // One-to-One: UserProfile belongs to one Student
    public required int StudentId { get; set; }
    public  required Student Student { get; set; }
    }
}