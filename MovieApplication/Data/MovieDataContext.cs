using Microsoft.EntityFrameworkCore;
using MovieApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApplication.Data
{
    public class MovieDataContext : DbContext
    {
        public MovieDataContext(DbContextOptions<MovieDataContext> options)
            : base(options)
        {

        }

        public MovieDataContext() { }
        public DbSet<Movie> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasKey(m => new { m.Id });

            modelBuilder.Entity<Movie>().Property(m => m.Title).HasColumnName("Title");
            modelBuilder.Entity<Movie>().Property(m => m.Genre).HasColumnName("Genre");
        }
    }
}
