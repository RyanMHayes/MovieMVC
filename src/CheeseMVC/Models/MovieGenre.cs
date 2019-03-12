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

        public List<Movie> Movies { get; set; }

    }
}
