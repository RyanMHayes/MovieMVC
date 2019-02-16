using System;
using MovieMVC.Controllers;
using MovieMVC.Models;
using Microsoft.EntityFrameworkCore;

// DATA ***

namespace MovieMVC.Data
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieGenre> Genres { get; set; }
        public DbSet<MovieStreamingService> StreamingServices { get; set; }
        public DbSet<MovieFilter> MovieFilters { get; set; } 

        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()    //Was MovieFilter
                .HasKey(c => new { c.GenreID, c.StreamingServiceID });
        }

        public static implicit operator MovieDbContext(BrowseController v) //Was MenuController.  Should it be browse, or something else?
        {
            throw new NotImplementedException();
        }


    }
}
