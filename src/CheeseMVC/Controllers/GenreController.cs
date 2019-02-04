using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieMVC.Models;
using MovieMVC.ViewModels;

namespace MovieMVC.Controllers
{
    public class GenreController : Controller
    {
        private readonly MovieDbContext context;

        public GenreController(MovieDbContext dbContext)
        {
            context = dbContext;
        }


        public IActionResult Index()
        {
            List<MovieGenre> MovieGenres = context.Genres.ToList();
            return View(MovieGenres);
        }


        public IActionResult Add()
        {
            AddGenreViewModel addGenreViewModel = new AddGenreViewModel();
            return View(addGenreViewModel);
        }


        [HttpPost]
        public IActionResult Add(AddGenreViewModel addGenreViewModel)
        {
            if (ModelState.IsValid)
            {
                // Add the new genre to my existing genres
                MovieGenre newGenre = new MovieGenre
                {
                    Genre = addGenreViewModel.Name
                };

                context.Genres.Add(newGenre);
                context.SaveChanges();

                return Redirect("/Movie"); //******needs to redirect to add entry page
            }

            return View(addGenreViewModel);
        }
    }
}