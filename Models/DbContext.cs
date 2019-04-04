using Microsoft.EntityFrameworkCore;

namespace Lab_11_Professor.Models
{
    public class ProfessorDbContext : DbContext
    {
        public ProfessorDbContext (DbContextOptions<ProfessorDbContext> options)
            : base(options)
        {
        }

        public DbSet<Lab_11_Professor.Models.Professor> Professor { get; set; }
    }
}