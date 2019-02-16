using Microsoft.AspNetCore.Mvc;
using MovieMVC.Models;
using System.Collections.Generic;
using MovieMVC.ViewModels;
using MovieMVC.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

// CONTROLLER ***

namespace MovieMVC.Controllers
{
    public class MovieController : Controller
    {
        private MovieDbContext context;

        public MovieController(MovieDbContext dbContext)
        {
            context = dbContext;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            // List<Cheese> cheeses = context.Cheeses.ToList(); --This is what we used before, but the instructions had us implement the line below instead
            IList<Movie> movies = context.Movies.Include(context => context.Genre).ToList();

            return View(movies);
        }


        public IActionResult Add()
        {
            AddMovieViewModel addMovieViewModel = new AddMovieViewModel(context.Genres.ToList(), context.StreamingServices.ToList());
            return View(addMovieViewModel);
        }


        [HttpPost]
        public IActionResult Add(AddMovieViewModel addMovieViewModel)
        {

            if (ModelState.IsValid)
            {
                MovieGenre newMovieGenre = context.Genres.SingleOrDefault(c => c.ID == addMovieViewModel.GenreID);
                MovieStreamingService newMovieStreamingService = context.StreamingServices.SingleOrDefault(c => c.ID == addMovieViewModel.StreamingServiceID);

                //*********Do I need the same for Streaming Service?


                // Add the new cheese to my existing cheeses
                Movie newMovie = new Movie
                {
                    Title = addMovieViewModel.Name,
                    StreamingService = newMovieStreamingService,
                    Genre = newMovieGenre
                };

                context.Movies.Add(newMovie);
                context.SaveChanges();

                return Redirect("/Movie");
            }

            return View(addMovieViewModel);
        }


        //public IActionResult Remove()
        //{
        //    ViewBag.title = "Remove Cheeses";
        //    ViewBag.cheeses = context.Cheeses.ToList();
        //    return View();
        //}


        //[HttpPost]
        //public IActionResult Remove(int[] cheeseIds)
        //{
        //    foreach (int cheeseId in cheeseIds)
        //    {
        //        Movie theCheese = context.Cheeses.Single(c => c.ID == cheeseId);
        //        context.Cheeses.Remove(theCheese);
        //    }

        //    context.SaveChanges();

        //    return Redirect("/");
       // }
    }
}
