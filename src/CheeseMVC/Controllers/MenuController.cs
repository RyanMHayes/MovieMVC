using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieMVC.Data;
using MovieMVC.Models;
using MovieMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Tools.DotNet;
/*
 * 
 * 
namespace MovieMVC.Controllers
{
    public class MenuController : Controller
    {
        private readonly MovieDbContext context;

        public MenuController(MovieDbContext dbContext)
        {
            context = dbContext;
        }


        public IActionResult Index()
        {
            List<Menu> menus = context.Menus.ToList(); //I had it as an IList, but I changed it to a List.  Which way?

            return View(menus);
        }


        // GET /Menu/Add
        public IActionResult Add()
        {
            AddMenuViewModel addMenuViewModel = new AddMenuViewModel();
            return View(addMenuViewModel);
        }


        [HttpPost]
        public IActionResult Add(AddMenuViewModel addMenuViewModel)
        {
            if (ModelState.IsValid)
            {
               
                // Add the new menu to my existing menus
                Menu newMenu = new Menu
                {
                    Name = addMenuViewModel.Name

                };

                context.Menus.Add(newMenu);
                context.SaveChanges();

                return Redirect("/Menu");   //What I had: return Redirect("/Menu/ViewMenu/" + newMenu.ID); [I changed it to the video's line]
            }

            return View(addMenuViewModel);

        }


        public IActionResult ViewMenu (int id)
        {
            List<CheeseMenu> items = context
                .CheeseMenus
                .Include(item => item.Cheese)
                .Where(cm => cm.MenuID == id)       // I wrote down CheeseMenu.  The video has cm
                .ToList();

            Menu menu = context.Menus.Single(m => m.ID == id);

            ViewMenuViewModel viewModel = new ViewMenuViewModel
            {
                Menu = menu,
                Items = items
            };

            return View(viewModel);
        }


        public IActionResult AddItem (int id)
        {
            Menu menu = context.Menus.Single(m => m.ID == id); //Check this method.  Do I need more?
            List<Movie> cheeses = context.Cheeses.ToList();
            return View(new AddMenuItemViewModel(menu, cheeses));

        }


        [HttpPost]
        public IActionResult AddItem(AddMenuItemViewModel addMenuItemViewModel)
        {
            if (ModelState.IsValid)
            {
                var cheeseID = addMenuItemViewModel.CheeseID;
                var menuID = addMenuItemViewModel.MenuID;

                IList<CheeseMenu> existingItems = context.CheeseMenus
                    .Where(cm => cm.CheeseID == cheeseID)
                    .Where(cm => cm.MenuID == menuID).ToList();

                if (existingItems.Count == 0)
                {
                    CheeseMenu menuItem = new CheeseMenu
                    {
                        Cheese = context.Cheeses.Single(c => c.ID == cheeseID),
                    };

                    context.CheeseMenus.Add(menuItem);
                    context.SaveChanges();
                }

                return Redirect(string.Format("/Menu/ViewMenu/{0}", addMenuItemViewModel.Menu.ID)); 

            }

            return View(addMenuItemViewModel);

        }

    }


    
}

*/