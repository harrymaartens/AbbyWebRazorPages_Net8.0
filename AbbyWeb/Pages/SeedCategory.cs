using Abby.Models;
using Microsoft.EntityFrameworkCore;
using Abby.DataAccess.Data;

namespace Abby.Models
{
    public static class SeedCategory
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context == null || context.Category == null)
                {
                    throw new ArgumentNullException("Null ApplicationDbContext");
                }

                // Look for any movies.
                if (context.MenuItem.Any())
                {
                    return;   // DB has been seeded
                }

                #region snippet1
                context.Category.AddRange(
                    
                    new Category
                    {
                        Name = "Appetizer"
                    },
                #endregion

                    new Category
                    {
                        Name = "Entree"
                    },

                    new Category
                    {
                        Name = "Dessert"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}