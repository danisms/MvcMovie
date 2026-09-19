using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = "R"
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = "PG-16"
                }

                ,

                new Movie
                {
                    Title = "Scorpion",
                    ReleaseDate = DateTime.Parse("2014-09-22"),
                    Genre = "Action",
                    Price = 49.99M,
                    Rating = "TV-14"
                }

                ,

                new Movie
                {
                    Title = "Prison Brake",
                    ReleaseDate = DateTime.Parse("2005-08-29"),
                    Genre = "Action",
                    Price = 10.99M,
                    Rating = "TV-14"
                }

                ,

                new Movie
                {
                    Title = "Limitless - Episode",
                    ReleaseDate = DateTime.Parse("2011-03-18"),
                    Genre = "Scifi",
                    Price = 00.00M,
                    Rating = "PG-13"
                }

                ,

                new Movie
                {
                    Title = "Flash",
                    ReleaseDate = DateTime.Parse("2023-06-16"),
                    Genre = "Scifi",
                    Price = 11.99M,
                    Rating = "PG-13"
                }
            );
            context.SaveChanges();
        }
    }
}