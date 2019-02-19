using MovieMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.ViewModels
{
    public class BrowseTypeViewModel : BaseViewModel
    {
        public BrowseType Filter { get; set; }

        public List<MovieFilter> MovieFilters { get; set; } //Was an IEnumerable, now a List

        public MovieGenre Genre { get; set; }
        public MovieStreamingService StreamingService { get; set; }

        public List<MovieGenre> Genres { get; set;}
        public List<MovieStreamingService> StreamingServices { get; set; }

        public List<Movie> Movies { get; set; }

    }

}
