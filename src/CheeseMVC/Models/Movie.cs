using System.Collections.Generic;

// MODEL ***

namespace MovieMVC.Models
{
    public class Movie
    {
        public string Title { get; set; }
        // public string Description { get; set; }
        public int ID { get; set; }

        public MovieGenre Genre { get; set; }    
        public int GenreID { get; set; }

        public MovieStreamingService StreamingService { get; set; }
        public int StreamingServiceID { get; set; }

        public IList<MovieFilter> MovieFilters { get; set; }


    }
}
