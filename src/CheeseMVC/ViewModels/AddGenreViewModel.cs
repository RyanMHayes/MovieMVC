using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.ViewModels
{
    public class AddGenreViewModel
    {
        [Required(ErrorMessage = "You must include the name of the genre you'd like to add.")]
        [Display(Name = "Genre")]
        public string Name { get; set; }  



    }
}
