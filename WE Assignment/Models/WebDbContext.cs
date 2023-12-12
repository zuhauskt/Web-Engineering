using Microsoft.EntityFrameworkCore;

namespace WE_Assignment.Models
{
    public class WebDbContext:DbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> options) : base(options)
        {
       
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Enrolled> Enrollments { get; set; }
        public DbSet<Mark> Marks { get; set; }
    }
}
