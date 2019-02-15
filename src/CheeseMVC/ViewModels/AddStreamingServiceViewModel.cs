using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieMVC.ViewModels
{
    public class AddStreamingServiceViewModel
    {
        [Required]
        [Display(Name = "Streaming Service")]
        public string Name { get; set; }
    }
}
