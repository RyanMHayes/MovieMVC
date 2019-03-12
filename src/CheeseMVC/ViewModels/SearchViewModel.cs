using MovieMVC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.ViewModels
{
    public class SearchViewModel : BaseViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<MovieGenre> Genres { get; set; }
        public List<Movie> StreamingServices { get; set; }

        public Movie Movie { get; set; }

        public MovieGenre Genre { get; set; }

        [Display(Name = "Streaming Service")]
        public MovieStreamingService StreamingService { get; set; }

        // The search value
        [Display(Name = "Keyword:")]
        public string SearchTerm { get; set; } = "";

    }
}
