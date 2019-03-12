using MovieMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// VIEWMODEL ***

namespace MovieMVC.ViewModels
{
    public class AddMovieViewModel
    {
        [Required(ErrorMessage = "You must include a movie title")]
        [Display(Name = "Movie Title")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Streaming Service")]
        public int StreamingServiceID { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public int GenreID { get; set; }

        public List<SelectListItem> Genres { get; set; }
        public List<SelectListItem> StreamingServices { get; set; }



        public AddMovieViewModel(IEnumerable<MovieGenre> genres, IEnumerable<MovieStreamingService> streamingServices)
        {

            Genres = new List<SelectListItem>();
            StreamingServices = new List<SelectListItem>();


            foreach (MovieGenre genre in genres)

                Genres.Add(new SelectListItem
                {
                    Value = genre.ID.ToString(),
                    Text = genre.Genre.ToString()
                });


            foreach (MovieStreamingService streamingService in streamingServices)

                StreamingServices.Add(new SelectListItem
                {
                    Value = streamingService.ID.ToString(),
                    Text = streamingService.StreamingService.ToString()

                });

        }


        public AddMovieViewModel()
        { }
    }
}


