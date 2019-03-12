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
    public class StreamingServiceController : Controller
    {
        private readonly MovieDbContext context;

        public StreamingServiceController(MovieDbContext dbContext)
        {
            context = dbContext;
        }


        public IActionResult Index()
        {
            List<MovieStreamingService> MovieStreamingServices = context.StreamingServices.ToList();
            return View(MovieStreamingServices);
        }


        public IActionResult Add()
        {
            AddStreamingServiceViewModel addStreamingServiceViewModel = new AddStreamingServiceViewModel();
            return View(addStreamingServiceViewModel);
        }


        [HttpPost]
        public IActionResult Add(AddStreamingServiceViewModel addStreamingServiceViewModel)
        {
            if (ModelState.IsValid)
            {
                
                MovieStreamingService newStreamingService = new MovieStreamingService
                {
                    StreamingService = addStreamingServiceViewModel.Name
                };

                context.StreamingServices.Add(newStreamingService);
                context.SaveChanges();

                return Redirect("/Movie/Add"); 
            }

            return View(addStreamingServiceViewModel);
        }
    }
}