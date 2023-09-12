using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Entities;

namespace WebApplication1.Data
{
    public class UniversityDataContext:DbContext
    {
        public UniversityDataContext(DbContextOptions<UniversityDataContext> options) : base(options)
        { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set;}
    }
}
