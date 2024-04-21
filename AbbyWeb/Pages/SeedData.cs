using Abby.Models;
using Microsoft.EntityFrameworkCore;
using Abby.DataAccess.Data;

namespace Abby.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context == null || context.MenuItem == null)
                {
                    throw new ArgumentNullException("Null ApplicationDbContext");
                }

                // Look for any movies.
                if (context.MenuItem.Any())
                {
                    return;   // DB has been seeded
                }

                #region snippet1
                context.MenuItem.AddRange(
                    
                    //Appetizer

                    new MenuItem
                    {
                        Name = "Bhel",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque efficitur in mauris sed posuere. Donec eu purus tellus. Fusce sapien nibh, gravida non diam eu, ultrices tempus massa. Sed sed sem ac sem pharetra malesuada in nec risus. Etiam ut accumsan quam, vel aliquam eros. In hac habitasse platea dictumst. Donec scelerisque aliquam luctus. Donec scelerisque, diam eget tristique condimentum, neque urna aliquet risus, in luctus lacus lorem eget dui.</p>",
                        Image = "\\images\\menuItems\\fe3afd71-ea8c-4e9f-b7c4-a7a64bbb37dc.jpg",
                        Price = 9.99,
                        FoodTypeId = 1,
                        CategoryId = 1
                    },
                #endregion

                    new MenuItem
                    {
                        Name = "Chicken Roll",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque efficitur in mauris sed posuere. Donec eu purus tellus. Fusce sapien nibh, gravida non diam eu, ultrices tempus massa. Sed sed sem ac sem pharetra malesuada in nec risus. Etiam ut accumsan quam, vel aliquam eros. In hac habitasse platea dictumst. Donec scelerisque aliquam luctus. Donec scelerisque, diam eget tristique condimentum, neque urna aliquet risus, in luctus lacus lorem eget dui.</p>",
                        Image = "\\images\\menuItems\\110e9553-b7b7-4c34-a265-d12776a3323e.jpg",
                        Price = 7.49,
                        FoodTypeId = 2,
                        CategoryId = 1
                    },

                    new MenuItem
                    {
                        Name = "Pani Puri",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque efficitur in mauris sed posuere. Donec eu purus tellus. Fusce sapien nibh, gravida non diam eu, ultrices tempus massa. Sed sed sem ac sem pharetra malesuada in nec risus. Etiam ut accumsan quam, vel aliquam eros. In hac habitasse platea dictumst. Donec scelerisque aliquam luctus. Donec scelerisque, diam eget tristique condimentum, neque urna aliquet risus, in luctus lacus lorem eget dui.</p>",
                        Image = "\\images\\menuItems\\caa5d16c-c283-4c5d-bbad-9c17b768a5a6.jpg",
                        Price = 6.29,
                        FoodTypeId = 1,
                        CategoryId = 1
                    },

                    new MenuItem
                    {
                        Name = "Samosa",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque efficitur in mauris sed posuere. Donec eu purus tellus. Fusce sapien nibh, gravida non diam eu, ultrices tempus massa. Sed sed sem ac sem pharetra malesuada in nec risus. Etiam ut accumsan quam, vel aliquam eros. In hac habitasse platea dictumst. Donec scelerisque aliquam luctus. Donec scelerisque, diam eget tristique condimentum, neque urna aliquet risus, in luctus lacus lorem eget dui.</p>",
                        Image = "\\images\\menuItems\\ef029498-6237-49b9-9e61-6da78e175f84.jpg",
                        Price = 8.95,
                        FoodTypeId = 1,
                        CategoryId = 1
                    },

                    // Entree

                    new MenuItem
                    {
                        Name = "Chicken Kabab",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque efficitur in mauris sed posuere. Donec eu purus tellus. Fusce sapien nibh, gravida non diam eu, ultrices tempus massa. Sed sed sem ac sem pharetra malesuada in nec risus. Etiam ut accumsan quam, vel aliquam eros. In hac habitasse platea dictumst. Donec scelerisque aliquam luctus. Donec scelerisque, diam eget tristique condimentum, neque urna aliquet risus, in luctus lacus lorem eget dui.</p>",
                        Image = "\\images\\menuItems\\a41d8f37-d77a-4302-bd77-8761e56ff817.jpg",
                        Price = 15.19,
                        FoodTypeId = 2,
                        CategoryId = 2
                    },

                    new MenuItem
                    {
                        Name = "Chicken Tikka",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque efficitur in mauris sed posuere. Donec eu purus tellus. Fusce sapien nibh, gravida non diam eu, ultrices tempus massa. Sed sed sem ac sem pharetra malesuada in nec risus. Etiam ut accumsan quam, vel aliquam eros. In hac habitasse platea dictumst. Donec scelerisque aliquam luctus. Donec scelerisque, diam eget tristique condimentum, neque urna aliquet risus, in luctus lacus lorem eget dui.</p>",
                        Image = "\\images\\menuItems\\6f4c1dee-3040-49c5-98a6-c33fd425b5b9.jpg",
                        Price = 13.89,
                        FoodTypeId = 2,
                        CategoryId = 2
                    },

                    new MenuItem
                    {
                        Name = "Malai Kofta",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque efficitur in mauris sed posuere. Donec eu purus tellus. Fusce sapien nibh, gravida non diam eu, ultrices tempus massa. Sed sed sem ac sem pharetra malesuada in nec risus. Etiam ut accumsan quam, vel aliquam eros. In hac habitasse platea dictumst. Donec scelerisque aliquam luctus. Donec scelerisque, diam eget tristique condimentum, neque urna aliquet risus, in luctus lacus lorem eget dui.</p>",
                        Image = "\\images\\menuItems\\26bf6487-a088-47a1-a60e-d3f5e8450966.jpg",
                        Price = 12.99,
                        FoodTypeId = 1,
                        CategoryId = 2
                    },

                    new MenuItem
                    {
                        Name = "Paneer Tikka",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque efficitur in mauris sed posuere. Donec eu purus tellus. Fusce sapien nibh, gravida non diam eu, ultrices tempus massa. Sed sed sem ac sem pharetra malesuada in nec risus. Etiam ut accumsan quam, vel aliquam eros. In hac habitasse platea dictumst. Donec scelerisque aliquam luctus. Donec scelerisque, diam eget tristique condimentum, neque urna aliquet risus, in luctus lacus lorem eget dui.</p>",
                        Image = "\\images\\menuItems\\1888bdf0-2c00-4271-88da-be53cb51aca7.jpg",
                        Price = 11.95,
                        FoodTypeId = 1,
                        CategoryId = 2
                    },

                    // Dessert

                    new MenuItem
                    {
                        Name = "Buttermilk",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque efficitur in mauris sed posuere. Donec eu purus tellus. Fusce sapien nibh, gravida non diam eu, ultrices tempus massa. Sed sed sem ac sem pharetra malesuada in nec risus. Etiam ut accumsan quam, vel aliquam eros. In hac habitasse platea dictumst. Donec scelerisque aliquam luctus. Donec scelerisque, diam eget tristique condimentum, neque urna aliquet risus, in luctus lacus lorem eget dui.</p>",
                        Image = "\\images\\menuItems\\9c6e7c4d-09e8-44ce-91e9-a9947594080d.jpg",
                        Price = 4.45,
                        FoodTypeId = 1,
                        CategoryId = 3
                    }, 
                    
                    new MenuItem
                    {
                        Name = "Mango Lassi",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque efficitur in mauris sed posuere. Donec eu purus tellus. Fusce sapien nibh, gravida non diam eu, ultrices tempus massa. Sed sed sem ac sem pharetra malesuada in nec risus. Etiam ut accumsan quam, vel aliquam eros. In hac habitasse platea dictumst. Donec scelerisque aliquam luctus. Donec scelerisque, diam eget tristique condimentum, neque urna aliquet risus, in luctus lacus lorem eget dui.</p>",
                        Image = "\\images\\menuItems\\b6ac5875-1b57-421d-b305-4f8139098a6b.jpg",
                        Price = 5.95,
                        FoodTypeId = 1,
                        CategoryId = 3
                    }, 
                    
                    new MenuItem
                    {
                        Name = "Rasmalai",
                        Description = "<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque efficitur in mauris sed posuere. Donec eu purus tellus. Fusce sapien nibh, gravida non diam eu, ultrices tempus massa. Sed sed sem ac sem pharetra malesuada in nec risus. Etiam ut accumsan quam, vel aliquam eros. In hac habitasse platea dictumst. Donec scelerisque aliquam luctus. Donec scelerisque, diam eget tristique condimentum, neque urna aliquet risus, in luctus lacus lorem eget dui.</p>",
                        Image = "\\images\\menuItems\\ebf1562b-0a38-47cd-85c2-0b42ca175fe9.jpg",
                        Price = 4.99,
                        FoodTypeId = 1,
                        CategoryId = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}