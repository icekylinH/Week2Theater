using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Theater.Models;

namespace Theater.Data
{
    public class DbInitializer
    {
        public static void Initialize(MovieContext context)
        {
            context.Database.EnsureCreated();

            // Look for any movies.
            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }

            var categories = new Category[]
{
            new Category{CategoryName="Chemistry",Code=1050},
};
            foreach (Category c in categories)
            {
                context.Categories.Add(c);
            }
            context.SaveChanges();

            var movies = new Movie[]
            {
            new Movie{Name="Carson",ReleaseDate=DateTime.Parse("2005-09-01"),CategoryID=1},
            };
            foreach (Movie m in movies)
            {
                context.Movies.Add(m);
            }
            context.SaveChanges();



        }
    }
}
