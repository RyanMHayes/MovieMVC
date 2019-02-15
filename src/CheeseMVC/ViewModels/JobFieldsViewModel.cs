using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieMVC.Models;

namespace MovieMVC.ViewModels
{
    public class JobFieldsViewModel : BaseViewModel
    {
        // The current column
        public BrowseType Filter { get; set; }

        // All fields in the given column
        public IEnumerable<MovieFilter> Fields { get; set; }

    }
}
