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
            List<Movie> allMovies = context.Movies.ToList();
            string searchTerm = searchViewModel.SearchTerm;
          
            List<Movie> moviesBySearch = context.Movies
                .Include(m => m.Genre)
                .Include(m => m.StreamingService)
                .Where(m => m.Title.ToString().ToLower().Contains(searchTerm.ToLower()))
                .ToList();

            searchViewModel.Movies = moviesBySearch;
            searchViewModel.Title = "Results for " + searchTerm;

            return View("Index", searchViewModel); 
            
        }
    }
}