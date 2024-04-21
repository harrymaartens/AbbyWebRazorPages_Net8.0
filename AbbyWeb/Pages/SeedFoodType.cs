using Abby.Models;
using Microsoft.EntityFrameworkCore;
using Abby.DataAccess.Data;

namespace Abby.Models
{
    public static class SeedFoodType
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context == null || context.FoodType == null)
                {
                    throw new ArgumentNullException("Null ApplicationDbContext");
                }

                // Look for any movies.
                if (context.FoodType.Any())
                {
                    return;   // DB has been seeded
                }

                #region snippet1
                context.FoodType.AddRange(

                    new FoodType
                    {
                        Name = "Veg"
                    },
                #endregion

                    new FoodType
                    {
                        Name = "Non Veg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}