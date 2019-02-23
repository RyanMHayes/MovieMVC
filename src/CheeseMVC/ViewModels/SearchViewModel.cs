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
        // The search results
        public List<Movie> Movies { get; set; }

        //public List<MovieGenre> Genres { get; set; }

        //public List<Movie> StreamingServices { get; set; }


        //public BrowseType Filter { get; set; }

        //public IEnumerable<MovieFilter> Fields { get; set; }

        // The column to search, defaults to all
        //????????public BrowseType Filter { get; set; } = BrowseType.All;

        // The search value
        [Display(Name = "Keyword:")]
        public string SearchTerm { get; set; } = "";

    }
}
