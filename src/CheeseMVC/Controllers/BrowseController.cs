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
        private MovieDbContext context;

        public BrowseController(MovieDbContext dbContext)
        {
            context = dbContext;
        }


        public IActionResult Index()
        {
            BrowseTypeViewModel browseTypeViewModel = new BrowseTypeViewModel();
            browseTypeViewModel.Title = "Browse by: ";

            return View(browseTypeViewModel);

            //JobFieldsViewModel jobFieldsViewModel = new JobFieldsViewModel();
            //jobFieldsViewModel.Title = "View Job Fields";

            //return View(jobFieldsViewModel);
        }


        public IActionResult Listings(BrowseType filter)
        {
            if (filter.Equals(BrowseType.Genre))
            {
                SearchMovieViewModel movieViewModel = new SearchMovieViewModel();



                movieViewModel.Movies = context.Movies.ToList();
                movieViewModel.Title = "All movies by"; //*********
                return View(/*"Movies",*/ movieViewModel);

            }

            else
            {
                


                return View();

            }



        }

    }

}



            /* switch (filter)
            {
                case BrowseType.StreamingService:
                    movies = MovieMVC.Data.Models.StreamingService.ToList().Cast<MovieFilter>();
                    break;

                case JobFieldType.Location:
                    fields = jobData.Locations.ToList().Cast<JobField>();
                    break;



                case JobFieldType.CoreCompetency:
                    fields = jobData.CoreCompetencies.ToList().Cast<JobField>();
                    break;
                case JobFieldType.PositionType:
                default:
                    fields = jobData.PositionTypes.ToList().Cast<JobField>();
                    break;
            }

            jobFieldsViewModel.Fields = fields;
            jobFieldsViewModel.Title = "All " + filter + " Values";
            jobFieldsViewModel.Column = column;

            return View(jobFieldsViewModel);
        }


        }

    }
}

    */