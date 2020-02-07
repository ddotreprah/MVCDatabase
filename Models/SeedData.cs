using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCDatabase.Data;
using System;
using System.Linq;

namespace MVCDatabase.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCDatabaseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCDatabaseContext>>()))
            {
                // Look for any movies.
                if (context.Item.Any())
                {
                    return;   // DB has been seeded
                }

                context.Item.AddRange(
                    new Item
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Quantity = 3,
                        Price = 7.99M
                    },

                    new Item
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Quantity = 1,
                        Price = 8.99M
                    },

                    new Item
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Quantity = 2,
                        Price = 9.99M
                    },

                    new Item
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Quantity = 5,
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}