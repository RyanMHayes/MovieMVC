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

        public IActionResult MovieListings()   //, string filter, int valueID, 
        {


            //List<Movie> movies = context.Genres.Include(movie => movie.Movies).Where(movie => movie.ID == id).ToList();

            

            List<Movie> filteredMovies = new List<Movie>();
            string filter = HttpContext.Request.Query["filter"].ToString();  //*********Working!
            string value = HttpContext.Request.Query["value"].ToString();  //*********Working!
            List<Movie> allMovies = context.Movies.ToList();



            //BrowseTypeViewModel movieViewModel = new BrowseTypeViewModel();


            //MovieGenre genreFilter = context.Genres.Include****************come back to here
            //Make a LINQ for for value of DRAMA or whatever genre


            //string value = "Genre";
            //string x = System.Web.HttpUtility.ParseQueryString(queryString).Get("filter");

            List<Movie> filteredMovies2 = context.Movies.Where(m => m.Genre.Genre.ToString() == value).ToList();

            if (filter == "Genre")
            {
                //foreach (Movie movie in allMovies)
                //{
                    //if (movie.Genre.ToString() == value) 
                    //{ 

                        //filteredMovies.Add(movie);

                    //}

                //}

            }
            //BrowseTypeViewModel movieViewModel = new BrowseTypeViewModel();
            //movieViewModel.Movies = context.Movies.Where(m => m.GenreID == valueID).ToList();
            //movieViewModel.Movies = context.Movies.Include(m => m.StreamingServiceID)
            //movieViewModel.Movies = context.Movies.Where(m => m.GenreID == m.Genre.ID).ToList();  //Where value of selected genre == m.GenreID or m.Genre.ID


            BrowseTypeViewModel movieViewModel = new BrowseTypeViewModel
            {
                Movies = filteredMovies2,
                //StreamingServices = context.StreamingServices.ToList(),
                //Genres = context.Genres.ToList(),
            };


            ViewBag.Title = "Movies filtered by " + value;
            //movieViewModel.Movies = filteredMovies;
            
            //movieViewModel.Genres = context.Genres.ToList();
            //movieViewModel.StreamingService = 
            return View(filteredMovies2);

            //}

            //else
            //{
            //
            //    BrowseTypeViewModel movieViewModel = new BrowseTypeViewModel();
            //    movieViewModel.Movies = context.Movies.Where(m => m.StreamingServiceID == valueID).ToList();
            //    movieViewModel.Title = "Movies filtered by " + filter;
            //    return View(movieViewModel);

            //}

        }


       

    }

}


                //movieViewModel.Movies = context.Movies.ToList();
                //movieViewModel.Title = "All movies by"; //*********
                //return View(/*"Movies",*/ movieViewModel);
