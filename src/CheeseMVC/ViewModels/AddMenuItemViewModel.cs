using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        public int CheeseID { get; set; } //The instructions said to keep these lowercase.  What does the video have?
        public int MenuID { get; set; }

        public Menu Menu { get; set; }
        public List<SelectListItem> Cheeses { get; set; }



        public AddMenuItemViewModel(Menu menu, IEnumerable<Cheese> cheeses)
        {

            Cheeses = new List<SelectListItem>();


            foreach (var cheese in cheeses)
            {

                // <option value="0">Hard</option>
                Cheeses.Add(new SelectListItem
                {
                    Value = cheese.ID.ToString(),
                    Text = cheese.Name
                });
            }

            Menu = menu;

        }



        public AddMenuItemViewModel()
        {

        }

    }

}
