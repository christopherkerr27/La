using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Lab23.Models;

namespace Lab23.Data
{
    public class DbInitializer
    {
        public static void Initialize(MoviesContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Movies.Any())
            {
                context.Movies.Add(new Movie() { Title = "The Old Guard", Genre = "Action", RunTime = 125 });
                context.Movies.Add(new Movie() { Title = "The Rental", Genre = "Horror", RunTime = 89 });
                context.Movies.Add(new Movie() { Title = "The Platform", Genre = "Action", RunTime = 94 });
                context.Movies.Add(new Movie() { Title = "Extraction", Genre = "Action", RunTime = 117 });
                context.Movies.Add(new Movie() { Title = "The Gentlemen", Genre = "Action", RunTime = 113 });
                context.Movies.Add(new Movie() { Title = "The King Of Staten Island", Genre = "Comedy", RunTime = 138 });
                context.Movies.Add(new Movie() { Title = "Joker", Genre = "Action", RunTime = 122 });
                context.Movies.Add(new Movie() { Title = "Parasite", Genre = "Comedy", RunTime = 132 });
                context.Movies.Add(new Movie() { Title = "The Hunt", Genre = "Action", RunTime = 115 });
                context.Movies.Add(new Movie() { Title = "Vivarium", Genre = "Action", RunTime = 99 });
                context.Movies.Add(new Movie() { Title = "Fantasy Island", Genre = "Action", RunTime = 109 });
                context.SaveChanges();
            }
        }
    }
}
