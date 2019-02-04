using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.ViewModels
{
    public class AddGenreViewModel
    {
        [Required]
        [Display(Name = "Genre")]
        public string Name { get; set; }  //This was Name.  Fix this elsewhere in the View [Never mind]



    }
}
