using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieMVC.Data;
using MovieMVC.ViewModels;
using MovieMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieMVC.Controllers
{
    public class BrowseController : Controller
    {
        private readonly MovieDbContext context;

        public BrowseController(MovieDbContext dbContext)
        {
            context = dbContext;
        }


        public IActionResult Index()
        {
            BrowseTypeViewModel browseTypeViewModel = new BrowseTypeViewModel();
            browseTypeViewModel.Title = "Browse by: ";

            return View(browseTypeViewModel);


        }


        public IActionResult FilterBy(BrowseType filter)
        {
            
            if (filter == BrowseType.Genre)
            {
                List<MovieGenre> movieFilters = context.Genres.ToList();

                BrowseTypeViewModel movieViewModel = new BrowseTypeViewModel
                {
                    Genres = movieFilters


                };

                movieViewModel.Title = "Movies filtered by " + filter;
                movieViewModel.Filter = filter;

                return View(movieViewModel);
            }

            else 
            {
                List<MovieStreamingService> movieFilters = context.StreamingServices.ToList();

                BrowseTypeViewModel movieViewModel = new BrowseTypeViewModel
                {
                    StreamingServices = movieFilters,


                };

                movieViewModel.Title = "Choose a " + filter;
                movieViewModel.Filter = filter;

                return View(movieViewModel);
            }

        }


        public IActionResult MovieListings()   
        {

            string filter = HttpContext.Request.Query["filter"].ToString();  
            string value = HttpContext.Request.Query["value"].ToString();  

            List<Movie> moviesFilteredByGenre = context.Movies.
                Include(context => context.Genre).
                Include(context => context.StreamingService)
                .Where(m => m.Genre.Genre.ToString() == value)
                .ToList();

            List<Movie> moviesFilteredByStreamingService = context.Movies
                .Include(context => context.Genre)
                .Include(context => context.StreamingService)
                .Where(m => m.StreamingService.StreamingService.ToString() == value)
                .ToList();


            ViewBag.Title = "Movies filtered by " + value;

            if (filter == "Genre")
            {
                return View(moviesFilteredByGenre);
            }


            else
            {
                return View(moviesFilteredByStreamingService);
            }

        }       

    }

}


