using System.Collections.Generic;

// MODEL ***

namespace MovieMVC.Models
{
    public class Movie
    {
        public string Title { get; set; }
        // public string Description { get; set; }
        public int ID { get; set; }
        public string StreamingService { get; set; }
        public MovieGenre Genre { get; set; }
        public int GenreID { get; set; }


    }
}
