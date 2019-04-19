using Microsoft.EntityFrameworkCore;

namespace Lab_11_Professor.Models
{
    public class ProfessorDbContext : DbContext
    {
        public ProfessorDbContext (DbContextOptions<ProfessorDbContext> options)
            : base(options)
        {
        }

        public DbSet<Professor> Professor { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}