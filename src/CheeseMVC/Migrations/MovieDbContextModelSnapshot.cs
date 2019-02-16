﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MovieMVC.Data;
using System;

namespace MovieMVC.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    partial class MovieDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieMVC.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GenreID");

                    b.Property<int>("StreamingServiceID");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.HasIndex("GenreID");

                    b.HasIndex("StreamingServiceID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieMVC.Models.MovieFilter", b =>
                {
                    b.Property<int>("GenreID");

                    b.Property<int>("StreamingServiceID");

                    b.Property<int>("ID");

                    b.HasKey("GenreID", "StreamingServiceID");

                    b.HasIndex("ID");

                    b.HasIndex("StreamingServiceID");

                    b.ToTable("MovieFilters");
                });

            modelBuilder.Entity("MovieMVC.Models.MovieGenre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Genre");

                    b.HasKey("ID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("MovieMVC.Models.MovieStreamingService", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StreamingService");

                    b.HasKey("ID");

                    b.ToTable("StreamingServices");
                });

            modelBuilder.Entity("MovieMVC.Models.Movie", b =>
                {
                    b.HasOne("MovieMVC.Models.MovieGenre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade); //Was Cascade for all these.  I'm changing it to see what happens.

                    b.HasOne("MovieMVC.Models.MovieStreamingService", "StreamingService")
                        .WithMany()
                        .HasForeignKey("StreamingServiceID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MovieMVC.Models.MovieFilter", b =>
                {
                    b.HasOne("MovieMVC.Models.MovieGenre", "Genre")
                        .WithMany("MovieFilters")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MovieMVC.Models.Movie")
                        .WithMany("MovieFilters")
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MovieMVC.Models.MovieStreamingService", "StreamingService")
                        .WithMany("MovieFilters")
                        .HasForeignKey("StreamingServiceID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
