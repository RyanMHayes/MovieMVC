using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// MODEL ***

namespace MovieMVC.Models
{
    public class Movie
    {
        public string Title { get; set; }
        // public string Description { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        //private static readonly int nextId = 1; //??????

        //[ForeignKey("GenreID")]
        public MovieGenre Genre { get; set; }    
        public int GenreID { get; set; }

        //[ForeignKey("StreamingServiceID")]
        [Display(Name = "Streaming Service")]
        public MovieStreamingService StreamingService { get; set; }
        public int StreamingServiceID { get; set; }

        //public IList<MovieFilter> MovieFilters { get; set; }
        //public List<MovieGenre> Genres { get; set; }


    }
}
