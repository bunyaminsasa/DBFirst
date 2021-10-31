using Microsoft.AspNetCore.Mvc;
using SimpleHouse.Common;
using SimpleHouse.Models;
using SimpleHouse.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleHouse.Controllers
{
    public class MenuController : Controller
    {
        DBSimpleHouseContext db = new DBSimpleHouseContext();

        [Route("/menulerimiz")]
        public IActionResult Index()
        {
          
            BrandVM brandVM = new BrandVM { Brands = db.Brands.ToList() };
            ViewBag.menu = "menulerimiz";
            return View(brandVM);
        }

        [HttpPost]
        public IActionResult Insert(BrandVM _model)
        {
            
            db.Brands.Add(_model.Brand);
            db.SaveChanges();
            TempData["sonuc"] = "Marka eklendi";
            return RedirectToAction("Index");
        }

        [Route("/menu/{name}")]
        public IActionResult Detail(string name)
        {
            
            Product p = db.Products.ToList().Where(w => Tools.UrlConverter(w.Name) == name).FirstOrDefault() ?? null;
            if (p != null) return View(p);
            else return Redirect("/");
        }

    }
}
