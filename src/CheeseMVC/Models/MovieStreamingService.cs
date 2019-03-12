using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.Models
{
    public class MovieStreamingService 
    {
        public int ID { get; set; }

        [Display(Name = "Streaming Service")]
        public string StreamingService { get; set; }

        public List<Movie> Movies { get; set; }

       

    }
}
