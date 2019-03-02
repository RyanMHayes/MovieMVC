using MovieMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.ViewModels
{
    public class BrowseTypeViewModel : BaseViewModel
    {
        public BrowseType Filter { get; set; }

        public MovieGenre Genre { get; set; }

        [Display(Name = "Streaming Service")]
        public MovieStreamingService StreamingService { get; set; }
        
        public Movie Movie { get; set; } // I added this.  Maybe it will fix this.  Or maybe it will break it.

        public List<MovieGenre> Genres { get; set;}
        public List<MovieStreamingService> StreamingServices { get; set; }

        public List<Movie> Movies { get; set; }

    }

}
