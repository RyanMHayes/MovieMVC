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

        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        { }
    }
}
