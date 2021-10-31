using Microsoft.AspNetCore.Mvc;
using SimpleHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleHouse.Controllers
{
    public class AboutController : Controller
    {
        [Route("/hakkimizda")]
        public IActionResult Index()
        {
            DBSimpleHouseContext db = new DBSimpleHouseContext();
            ViewBag.menu = "hakkimizda";
            return View(db.Abouts.OrderBy(o => o.DisplayIndex).ToList());
        }
    }
}
