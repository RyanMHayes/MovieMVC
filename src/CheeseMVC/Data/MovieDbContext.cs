﻿using System;
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
        // public DbSet<MovieFilter> MovieFilters { get; set; } 

        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
            .HasKey(c => c.ID);


            //modelBuilder.Entity<Movie>()    
            //.HasKey(c => new { c.GenreID, c.StreamingServiceID });



            modelBuilder.Entity<Movie>() //These were MovieFilter class [or movie and movies below]
                .HasOne(pt => pt.Genre)
                .WithMany(p => p.Movies) //These were MovieFilters
                .HasForeignKey(pt => pt.GenreID);

            modelBuilder.Entity<Movie>()
                .HasOne(pt => pt.StreamingService)
                .WithMany(t => t.Movies)
                .HasForeignKey(pt => pt.StreamingServiceID);




            /* OLD VERSION, THE ABOVE IS TRYING SOMETHING NEW

            modelBuilder.Entity<Movie>() //These were MovieFilter class [or movie and movies below]
                .HasOne(pt => pt.Genre)
                .WithMany(p => p.Movies) //These were MovieFilters
                .HasForeignKey(pt => pt.GenreID);

            modelBuilder.Entity<Movie>()
                .HasOne(pt => pt.StreamingService)
                .WithMany(t => t.Movies)
                .HasForeignKey(pt => pt.StreamingServiceID);

    */


        }

        public static implicit operator MovieDbContext(BrowseController v) //Was MenuController.  Should it be browse, or something else?
        {
            throw new NotImplementedException();
        }


    }
}
