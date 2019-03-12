using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// MODEL ***

namespace MovieMVC.Models
{
    public class Movie
    {
        public string Title { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public MovieGenre Genre { get; set; }    
        public int GenreID { get; set; }

        [Display(Name = "Streaming Service")]
        public MovieStreamingService StreamingService { get; set; }
        public int StreamingServiceID { get; set; }

    }
}
