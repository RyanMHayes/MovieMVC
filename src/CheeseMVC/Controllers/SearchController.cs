using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieMVC.Data;
using MovieMVC.Models;
using MovieMVC.ViewModels;

namespace MovieMVC.Controllers
{
    public class SearchController : Controller
    {
        private readonly MovieDbContext context;

        public SearchController(MovieDbContext dbContext)
        {
            context = dbContext;
        }


        public IActionResult Index()
        {
            SearchViewModel searchViewModel = new SearchViewModel();
            searchViewModel.Title = "Search by Title";
            return View(searchViewModel);
        }


        public IActionResult Results(SearchViewModel searchViewModel)
        {
            //List<Movie> x = context.Movies.Where(m => m in searchViewModel.SearchTerm); //Make an empty list.  Then cycle through it.  
                                                                                        //If movie.lower() == searchViewModel.SearchTerm.lower(), [Contains method]
                                                                                        //add the movie to the list.

            //If it doesn't work, do the LINQ like with Browse.
            //List<Movie> moviesBySearch = new List<Movie>();
            List<Movie> allMovies = context.Movies.ToList();
            string searchTerm = searchViewModel.SearchTerm;

            //if (searchViewModel.SearchTerm != "")
            //{
                //return View(); //Used to be "Index"
                //*******Need some kind of error message
            //}



            //if (searchViewModel.SearchTerm.Equals(""))
            //List<Movie> moviesBySearch = new List<Movie>();
            List<Movie> moviesBySearch = context.Movies
                .Include(m => m.Genre)
                .Include(m => m.StreamingService)
                .Where(m => m.Title.ToString().ToLower().Contains(searchTerm.ToLower()))
                .ToList();

            searchViewModel.Movies = moviesBySearch;
            searchViewModel.Title = "Results for " + searchTerm;

            return View("Index", searchViewModel); //Was going to have it all on results page--wasn't working.
            
        }




    }
}