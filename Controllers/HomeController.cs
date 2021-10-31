using Microsoft.AspNetCore.Mvc;
using SimpleHouse.Models;
using SimpleHouse.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleHouse.Controllers
{
    public class HomeController : Controller
    {
        DBSimpleHouseContext db = new DBSimpleHouseContext();
        [Route("/")]
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Products = db.Products.ToList(),
                Categories = db.Categories.ToList()

            };
            ViewBag.menu = "anasayfa";
            return View(homeVM);
        }
    }
}
