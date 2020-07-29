using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Lab23.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab23.Data
{
    public class MoviesContext :DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movie { get; set; }
        public object Movies { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie")
                .Property(X500DistinguishedName => x.Genre)
                .HasMaxLength(50)
                .IsRequired();
        }
        
    }
}
