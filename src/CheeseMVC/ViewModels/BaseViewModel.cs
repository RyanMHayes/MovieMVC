using MovieMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.ViewModels
{
    public class BaseViewModel
    {
        public List<BrowseType> Filters { get; set; }

        // View title
        public string Title { get; set; } = "";


        public BaseViewModel()
        {
            // Populate the list of all columns

            Filters = new List<BrowseType>();

            foreach (BrowseType enumVal in Enum.GetValues(typeof(BrowseType)))
            {
                Filters.Add(enumVal);
            }


        }



    }
}
