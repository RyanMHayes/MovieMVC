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
            //BrowseTypeViewModel browseTypeViewModel = new BrowseTypeViewModel();
            //browseTypeViewModel.Title = "Browse by: ";

            //return View(browseTypeViewModel);


            IList<MovieFilter> filters = context.Filters.ToList();

            return View(filters);


        }


        public IActionResult FilterBy(BrowseType filter)
        {
            SearchMovieViewModel movieViewModel = new SearchMovieViewModel();

            IEnumerable<MovieFilter> fields;

            //************Maybe stop trying to use the Techjobs method.
            //Maybe try to access these things just through Dbcontext

            //****Really, stop.  Try using LINQ to access the necessary data.


            //switch (filter)
            //{
            //    case BrowseType.Genre:
            //        fields = context.Genres.Include(context => context.Genre).ToList().Cast<MovieFilter>();
            //        break;
            //    case BrowseType.StreamingService:
            //        fields = context.StreamingServices.ToList().Cast<MovieFilter>();
            //        break;

            //}

            //movieViewModel.Fields = context.Genres.ToList().Cast<MovieFilter>();
            movieViewModel.Fields = context.Genres.Include(context => context.Genre).ToList().Cast<MovieFilter>();
            movieViewModel.Title = "Movies filtered by" + filter;
            movieViewModel.Filter = filter;

            return View(movieViewModel);

            /*

            if (filter.Equals(BrowseType.Genre))
            {
                //fields = context.Genres.ToList().Cast<MovieFilter>();

                IList<MovieFilter> fields = context.Genres.Include(context => context.Genre).ToList();

            }

            else
            {
                fields = context.StreamingServices.ToList().Cast<MovieFilter>();

            }

            //movieViewModel.Fields = fields;
            movieViewModel.Title = "Movies filtered by" + filter;
            movieViewModel.Filter = filter;

            return View(movieViewModel);

            */

        }

        public IActionResult MovieListings(BrowseType filter)
        {
            if (filter.Equals(BrowseType.Genre))
            {

                SearchMovieViewModel movieViewModel = new SearchMovieViewModel();
                movieViewModel.Genres = context.Genres.ToList();
                movieViewModel.Title = "Choose a " + filter; //*********
                return View(movieViewModel);

            }

            else
            {

                return View();

            }

        }


       

    }

}


                //movieViewModel.Movies = context.Movies.ToList();
                //movieViewModel.Title = "All movies by"; //*********
                //return View(/*"Movies",*/ movieViewModel);
