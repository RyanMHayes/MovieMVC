using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.ViewModels
{
    public class AddStreamingServiceViewModel
    {
        [Required(ErrorMessage = "You must include the name of the streaming service you'd like to add.")]
        [Display(Name = "Streaming Service")]
        public string Name { get; set; }
    }
}
