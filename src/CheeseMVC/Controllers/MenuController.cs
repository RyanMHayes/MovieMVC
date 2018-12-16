using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Data;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class MenuController : Controller
    {
        private readonly CheeseDbContext context;

        public MenuController(MenuController dbContext)
        {
            context = dbContext;
        }


        public IActionResult Index()
        {
            IList<Menu> menus = context.Menus.ToList();

            return View();
        }
    }
}