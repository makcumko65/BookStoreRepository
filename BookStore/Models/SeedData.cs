using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BookStoreContext>>()))
            {

                if (context.Book.Any())
                {
                    return;
                }

                context.Book.AddRange(
                    new Book
                    {
                        Name = "Lord Of The Rings",
                        Author = "J.R.R. Tolkien",
                        Genre = "Adventure",
                        Price = 10,
                        Year = 1975
                    },

                    new Book
                    {
                        Name = "The Shining",
                        Author = "Stephen King",
                        Genre = "Horror",
                        Price = 6,
                        Year = 1988
                    },

                    new Book
                    {
                        Name = "Fahrenheit 451",
                        Author = "Ray Bradbury",
                        Year = 1968,
                        Genre = "Dystopian",
                        Price = 3
                    },

                    new Book
                    {
                        Name = "The Dark Tower",
                        Author = "Stephen King",
                        Genre = "Adventure",
                        Price = 11,
                        Year = 1999
                    }
                );
                context.SaveChanges();
            }
        }
    }
}