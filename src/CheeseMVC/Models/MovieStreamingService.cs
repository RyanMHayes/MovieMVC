﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.Models
{
    public class MovieStreamingService //: MovieFilter  *****Not sure if this is right.  Hiding inheritance of MovieFilter class
    {
        //no additional members yet.  See MovieFilter.cs

        public int ID { get; set; }
        public string StreamingService { get; set; }

        //public Movie Movie { get; set; }
        //public int MovieID { get; set; }

        //public IList<Movie> Movies { get; set; }

        public List<MovieFilter> MovieFilters { get; set; }

    }
}