using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.Models
{
    public class MovieGenre
    {
        public int ID { get; set; }
        public string Genre { get; set; }

        //public Movie Movie { get; set; }
        //public int MovieID { get; set; }


        //public IList<Movie> Movies { get; set; }

        public List<MovieFilter> MovieFilters { get; set; }



        // public IList<Cheese> Cheeses { get; set; }





        //public int ID { get; set; }
        //public string Name { get; set; }
        //public IList<Movie> Cheeses { get; set; }


        // everything below has not been asked of me to do yet, but it's in the video

        // public string Description { get; set; }
        // public int CategoryID { get; set; }

        // public CheeseCategory Category { get; set; } (REALLY IFFY ON WHY I PUT THIS ONE HERE)
        // public IList<CheeseCategory> Categories { get; set; }


    }
}
