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

        public IEnumerable<MovieFilter> MovieFilters { get; set; }

    }
}
