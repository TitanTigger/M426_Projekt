using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M426_Projekt_Core.Models.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace M426_Projekt_Core.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ToDoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ToDoContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return; // DB has been seeded
                }

                context.SaveChanges();
            }
        }
    }
}
