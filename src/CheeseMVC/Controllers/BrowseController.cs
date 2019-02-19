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

                movieViewModel.Title = "Movies filtered by" + filter;
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

                movieViewModel.Title = "Movies filtered by" + filter;
                movieViewModel.Filter = filter;

                return View(movieViewModel);
            }


        }

        public IActionResult MovieListings(string filter, int valueID)   //, int id)
        {
            if (filter.Equals("Genre"))
            {
                
                //List<Movie> movies = context.Genres.Include(movie => movie.Movies).Where(movie => movie.ID == id).ToList();

                BrowseTypeViewModel movieViewModel = new BrowseTypeViewModel();
                movieViewModel.Movies = context.Movies.Where(m => m.GenreID == valueID).ToList();
                movieViewModel.Title = "Movies filtered by " + filter; 
                return View(movieViewModel);

            }

            else
            {

                BrowseTypeViewModel movieViewModel = new BrowseTypeViewModel();
                movieViewModel.Movies = context.Movies.Where(m => m.StreamingServiceID == valueID).ToList();
                movieViewModel.Title = "Movies filtered by " + filter;
                return View(movieViewModel);

            }

        }


       

    }

}


                //movieViewModel.Movies = context.Movies.ToList();
                //movieViewModel.Title = "All movies by"; //*********
                //return View(/*"Movies",*/ movieViewModel);
