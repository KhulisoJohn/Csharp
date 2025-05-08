using Microsoft.EntityFrameworkCore;
using EfRelationship.Models;

namespace EfRelationship.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
