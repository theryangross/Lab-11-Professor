using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Lab_11_Professor.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProfessorDbContext(serviceProvider.GetRequiredService<DbContextOptions<ProfessorDbContext>>()))
            {
                // Look for any blogs.
                if (context.Professor.Any())
                {
                    return; // DB has been seeded
                }
                
                context.Professor.AddRange(
                    new Professor
                    {
                        FirstName = "Mickey",
                        LastName = "Mouse"
                    },
                    new Professor
                    {
                        FirstName = "Minnie",
                        LastName = "Mouse"
                    },
                    new Professor
                    {
                        FirstName = "Donald",
                        LastName = "Duck"
                    }
                );
                
                context.SaveChanges();
            }
        }

    }

}